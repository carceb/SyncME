using System;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using DM.StaticMethods;
using DM.Enums;

namespace DM
{
    public class Controler
    {
        List<DmHolder> _list;

        public Controler()
        {
            _list = XMLmethods.readDMlist();
        }

        public List<DmHolder> DirectoryMirrorList
        {
            get { return _list; }
        }

        // Delegate and event to bubble up FSW events messages 
        public delegate void SourceEventDelegate(SourceEventArgs fswEventArgs);
        public event SourceEventDelegate SourceEvent;
        // Delegate and event to bubble up FSW error messages
        public delegate void SourceErrorDelegate(SourceEventArgs fswEventArgs);
        public event SourceErrorDelegate SourceError;
        // Delegate and event to bubble up DM messages
        public delegate void MirrorEventDelegate(MirrorEventArgs info);
        public event MirrorEventDelegate MirrorEvent;
        // Delegate and event to bubble up DM error messages
        public delegate void MirrorErrorDelegate(MirrorEventArgs info);
        public event MirrorErrorDelegate MirrorError;

        public void CreateNewDM(string name, string source, string mirror)
        {
            hardMirrorRebuild(source, mirror);
            DirectoryMirror dm = new DirectoryMirror(_list[0].Name, _list[0].SourcePath, _list[0].MirrorPath);
        }

        public string StartDM(string name, bool mirrorMode, bool showFSWevents, bool showFSWErrors, bool showDMevents, bool showDMerrors, int rebuildOption, long identifier, bool trackChanged)
        {
            DmHolder dmHolder = _list.Find(d => d.Identifier == identifier);
            if (dmHolder != null)
            {
                if (!IOmethods.DirectoryExists(dmHolder.SourcePath)) return "La carpeta principal no existe";
                if (!dmHolder.IsRunning)
                {
                    if (mirrorMode)
                    {
                        if (!IOmethods.DirectoryExists(dmHolder.MirrorPath)) return "La carpeta espejo no existe";
                        if (rebuildOption == 0) hardMirrorRebuild(dmHolder.SourcePath, dmHolder.MirrorPath);
                        else if (rebuildOption == 1) softMirrorRebuild(dmHolder.SourcePath, dmHolder.MirrorPath);
                        else deleteSourceAndMirror(dmHolder.SourcePath, dmHolder.MirrorPath);
                    }
                    dmHolder.DM = new DirectoryMirror
                                      {
                                          FriendlyName = dmHolder.Name,
                                          SourceDirectory = dmHolder.SourcePath,
                                          MirrorDirectory = dmHolder.MirrorPath,
                                          InternalBufferSize = dmHolder.Buffer,
                                          Milliseconds = dmHolder.Timer,
                                          MirrorMode = mirrorMode
                                      };
                    if (showFSWevents)
                    {
                        dmHolder.DM.SourceEvent += new FSWabstract.SourceEventDelegate(SourceEvent);
                    }
                    if(showFSWErrors)
                    {
                        dmHolder.DM.SourceError += new FSWabstract.SourceErrorDelegate(SourceError);
                    }
                    if (showDMevents)
                    {
                        dmHolder.DM.DMinfoEvent += new DirectoryMirror.MirrorActionDelegate(MirrorEvent);
                    }
                    if (showDMerrors)
                        dmHolder.DM.DMerrorEvent += new DirectoryMirror.MirrorErrorDelegate(MirrorError);
                    } 
                    dmHolder.DM.Start();
                    dmHolder.DM.TrackChangedEvent(trackChanged);
                    return "ok";
            }
            return "No pudo comenzar";
        }

        public bool KillDM(long identifier)
        {
            DmHolder dmHolder = _list.Find(d => d.Identifier == identifier);
            if (dmHolder != null)
            {
                if (dmHolder.IsRunning)
                {
                    dmHolder.DM.Dispose();
                    dmHolder.DM = null;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(long identifier)
        {
            try
            {
                DmHolder dmHolder = _list.Find(d => d.Identifier == identifier);
                if (dmHolder != null)
                {
                    _list.Remove(dmHolder);
                    _list.Sort((x, y) => y.Identifier.CompareTo(x.Identifier));
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(DmHolder dh)
        {
            try
            {
                DmHolder dmHolder = _list.Find(d => d.Identifier == dh.Identifier);
                if (dmHolder != null)
                {
                    dmHolder.Name = dh.Name;
                    dmHolder.SourcePath = dh.SourcePath;
                    dmHolder.MirrorPath = dh.MirrorPath;
                    dmHolder.Buffer = dh.Buffer;
                    dmHolder.Timer = dh.Timer;
                }
                else
                {
                    _list.Add(dh);
                    _list.Sort((x, y) => y.Identifier.CompareTo(x.Identifier));
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void Save()
        {
            XMLmethods.writeDMlist(_list);
        }

        #region rebuild mirror

        ///<summary>
        /// Delete the mirror directory and recreates it and copies 
        /// all the content from the source directory to it.
        ///</summary>
        /// <param name="source"></param>
        /// <param name="mirror"></param>
        private static void hardMirrorRebuild(string source, string mirror)
        {
            IOmethods.DeleteAll(mirror);
            //Directory.CreateDirectory(mirror);
            IOmethods.CopyDirectoryRecursively(source, mirror);
        }

        ///<summary>
        /// Compares The directory structure from the source and the mirror,
        /// and the files (file name and size comparison) and then makes the
        /// the nessecessary changes so that the mirror is identical to the source
        ///</summary>
        /// <param name="source"></param>
        /// <param name="mirror"></param>
        private static void softMirrorRebuild(string source, string mirror)
        {
            IOmethods.MirrorUpdate(source, mirror);
        }

        /// <summary>
        /// Deletes all the contents of the source and mirror folders
        /// </summary>
        /// <param name="source"></param>
        /// <param name="mirror"></param>
        private static void deleteSourceAndMirror(string source, string mirror)
        {
            IOmethods.DeleteAll(source);
            IOmethods.DeleteAll(mirror);
            Thread.Sleep(1000);            
        }

        #endregion

    }
}
