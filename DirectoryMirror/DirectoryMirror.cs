using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using DM.StaticMethods;

namespace DM
{
    // directoryMirror
    // An implementation of the FileSystemWatcher class
    // by Luc Archambault, stereo3d@gmail.com, February 2005

    /// <summary>
    /// This class watches for IO activity in a "source" 
    /// directory to keep an exact copy of that directory
    /// in a specified "mirror" directory. Through the 
    /// "infoMessageEvent" it sends back messages about IO
    /// activity and encountered exceptions.
    /// </summary>


    // This class is based on the FileSystemWatcher class
    public class DirectoryMirror : FSWabstract
    {
        string _mirDir = ""; // Path of the mirror directory
        List<SourceEventArgs> _IOlist; // List to keep track of changes in the source diretory
        double _time;
        Timer _timer;
        bool _mirrorMode;

        public string SourceDirectory
        {
            get { return this.Path; }
            set { this.Path = value; }
        }

        public string MirrorDirectory
        {
            get { return _mirDir; }
            set { _mirDir = value; }
        }

        public double Milliseconds
        {
            get { return _time; }
            set { _time = value; }
        }
        public bool MirrorMode
        {
            get { return _mirrorMode; }
            set { _mirrorMode = value; }
        }

        //Delegates and events to send messages about Exceptions
        public delegate void MirrorActionDelegate(MirrorEventArgs info);
        public event MirrorActionDelegate DMinfoEvent;
        public delegate void MirrorErrorDelegate(MirrorEventArgs info);
        public event MirrorErrorDelegate DMerrorEvent;

        public DirectoryMirror()
        {
        }

        public DirectoryMirror(string name, string srcDir, string mirDir)
        {
            this.FriendlyName = name;
            _IOlist = new List<SourceEventArgs>();
            // Set up the path to the source directory
            SourceDirectory = srcDir;
            // Set up the path to the mirror directory
            MirrorDirectory = mirDir;
            //Start();
        }

        public void Start()
        {
            if (!string.IsNullOrEmpty(SourceDirectory) &&
                !string.IsNullOrEmpty(MirrorDirectory))
            {
                // Set up the different properties
                // Monitor all files and directories
                Filter = "";
                // Listen for changes in the name of files and directories
                // and changes in size
                NotifyFilter = (NotifyFilters.FileName |
                    NotifyFilters.DirectoryName | NotifyFilters.LastWrite);
                IncludeSubdirectories = true;
                EnableRaisingEvents = true;


                if (_mirrorMode)
                {
                    SourceEvent += DirectoryMirror_FSWevent;
                    SourceError += DirectoryMirror_FSWerror;
                    _timer = new Timer();
                    _timer.Elapsed += timer_Elapsed;
                    _timer.Interval = _time;
                    _timer.AutoReset = false;
                    _IOlist = new List<SourceEventArgs>();
                }
            }
        }

        void DirectoryMirror_FSWerror(SourceEventArgs fswEventArgs)
        {
            _timer.Start();
        }

        void DirectoryMirror_FSWevent(SourceEventArgs fswEventArgs)
        {
            _timer.Start();
            _IOlist.Add(fswEventArgs);
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            MirrorEventArgs args = new MirrorEventArgs();
            args.FSWname = this.FriendlyName;
            args.TimeStamp = DateTime.Now;
            args.Info = "Timer elapsed";
            DMinfoEvent(args);
            if (_IOlist.Count > 0)
            {
                List<SourceEventArgs> list = new List<SourceEventArgs>();
                lock (_IOlist)
                {
                    list.AddRange(_IOlist);
                    _IOlist.Clear();
                }

                updateMirror(list);
            }
        }

        private void updateMirror(List<SourceEventArgs> list)
        {
            MirrorEventArgs args = new MirrorEventArgs();
            args.FSWname = this.FriendlyName;
            args.TimeStamp = DateTime.Now;
            args.Action = "Comienzo de la actualización en el espejo";
            args.Info = list.Count.ToString() + " evento(s) para procesar";
            DMinfoEvent(args);

            string destination;
            List<SourceEventArgs> listF = new List<SourceEventArgs>();

            try
            {
                //--- Created ---//
                listF = list.Where(x => x.EventType == "Created").ToList();
                for (int i = 0; i < listF.Count; i++)
                {
                    destination = listF[i].Path.Replace(SourceDirectory, MirrorDirectory);
                    if (Directory.Exists(listF[i].Path))
                    {
                        Directory.CreateDirectory(destination);
                        IOmethods.CopyDirectoryRecursively(listF[i].Path, destination);
                        list.Remove(listF[i]);
                        // Remove all "Created" and "Changed" events of child folders and files from the master list
                        list = list.Where(s => (s.EventType == "Created" || s.EventType == "Changed") && s.Path.Contains(listF[i].Path) == false).ToList();
                        // Update the sublist of "Created events"
                        listF = list.Where(x => x.EventType == "Created").ToList();
                        i -= 1;
                        args = new MirrorEventArgs();
                        args.FSWname = this.FriendlyName;
                        args.Action = "Create";
                        args.TimeStamp = DateTime.Now;
                        args.Info = destination;
                        DMinfoEvent(args);

                    }
                    else
                    {
                        File.Copy(listF[i].Path, destination, true);
                        // Remove all "Changed" events for this file from the master list
                        list = list.Where(s => (s.EventType != "Changed" && s.Path != listF[i].Path)).ToList();
                        // Update the sublist of "Created events"
                        listF = list.Where(x => x.EventType == "Created").ToList();
                        i -= 1;
                        args = new MirrorEventArgs();
                        args.FSWname = this.FriendlyName;
                        args.Action = "Create";
                        args.TimeStamp = DateTime.Now;
                        args.Info = destination;
                        DMinfoEvent(args);
                    }
                }
            }
            catch (Exception x)
            {
                args = new MirrorEventArgs();
                args.FSWname = this.FriendlyName;
                args.TimeStamp = DateTime.Now;
                args.Action = "Error";
                args.Info = x.Message;
                DMerrorEvent(args);
            }
            try
            {
                //--- Changed ---//
                listF = list.Where(z => z.EventType == "Changed").ToList();
                listF = RemoveDuplicates(listF);
                foreach (SourceEventArgs f in listF)
                {
                    if (File.Exists(f.Path))
                    {
                        destination = f.Path.Replace(SourceDirectory, MirrorDirectory);
                        File.Copy(f.Path, destination, true);
                        args = new MirrorEventArgs();
                        args.FSWname = this.FriendlyName;
                        args.Action = "Copy";
                        args.TimeStamp = DateTime.Now;
                        args.Info = destination;
                        DMinfoEvent(args);
                    }

                }
            }
            catch (Exception x)
            {
                args = new MirrorEventArgs();
                args.FSWname = this.FriendlyName;
                args.TimeStamp = DateTime.Now;
                args.Action = "Error";
                args.Info = x.Message;
                DMerrorEvent(args);
            }
            try
            {
                //--- Renamed ---//
                listF = list.Where(x => x.EventType == "Renamed").ToList();
                foreach (SourceEventArgs f in listF)
                {
                    destination = f.Path.Replace(SourceDirectory, MirrorDirectory);
                    if (System.IO.Directory.Exists(f.OldPath.Replace(SourceDirectory, MirrorDirectory)))
                    {
                        string oldFPath = f.OldPath.Replace(SourceDirectory, MirrorDirectory);
                        string newFPath = f.Path.Replace(SourceDirectory, MirrorDirectory);
                        System.IO.Directory.Move(oldFPath, newFPath);
                    }
                    else
                    {
                        string oldFPath = f.OldPath.Replace(SourceDirectory, MirrorDirectory);
                        string newFPath = f.Path.Replace(SourceDirectory, MirrorDirectory);
                        System.IO.File.Move(oldFPath, newFPath);
                    }
                    args = new MirrorEventArgs();
                    args.FSWname = this.FriendlyName;
                    args.Action = "Rename";
                    args.TimeStamp = DateTime.Now;
                    args.Info = destination;
                    DMinfoEvent(args);
                }
            }
            catch (Exception x)
            {
                args = new MirrorEventArgs();
                args.FSWname = this.FriendlyName;
                args.TimeStamp = DateTime.Now;
                args.Action = "Error";
                args.Info = x.Message;
                DMerrorEvent(args);
            }
            try
            {
                //--- Deleted ---//
                listF = list.Where(x => x.EventType == "Deleted").ToList();
                foreach (SourceEventArgs f in listF)
                {
                    destination = f.Path.Replace(SourceDirectory, MirrorDirectory);
                    if (Directory.Exists(destination))
                    {
                        Directory.Delete(destination, true);
                    }
                    else
                    {
                        File.Delete(destination);
                    }
                    args = new MirrorEventArgs();
                    args.FSWname = this.FriendlyName;
                    args.Action = "Delete";
                    args.TimeStamp = DateTime.Now;
                    args.Info = destination;
                    DMinfoEvent(args);
                }
            }
            catch (Exception x)
            {
                args = new MirrorEventArgs();
                args.FSWname = this.FriendlyName;
                args.TimeStamp = DateTime.Now;
                args.Action = "Error";
                args.Info = x.Message;
                DMerrorEvent(args);
            }
            args = new MirrorEventArgs();
            args.FSWname = this.FriendlyName;
            args.TimeStamp = DateTime.Now;
            args.Action = "Fin de la actualización en el espejo";
            DMinfoEvent(args);
        }

        private List<SourceEventArgs> RemoveDuplicates(List<SourceEventArgs> list)
        {
            list = list.OrderBy(z => z.FSWname).OrderBy(z => z.Path).ToList();
            List<SourceEventArgs> newList = new List<SourceEventArgs>();
            SourceEventArgs last1 = new SourceEventArgs();
            last1.Path = "+";
            last1.FSWname = "";
            foreach (SourceEventArgs fswa in list)
            {
                if (fswa.FSWname != last1.FSWname || fswa.Path != last1.Path)
                {
                    newList.Add(fswa);
                    last1 = fswa;
                }
            }
            return newList;
        }

    }
}
