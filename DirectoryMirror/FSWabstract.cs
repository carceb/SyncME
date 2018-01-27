using System;
using System.IO;

namespace DM
{
    // This class is based on the FileSystemWatcher class
    public abstract class FSWabstract : FileSystemWatcher
    {
        // Delegates and events to send messages about FileSystemWatcher events
        public delegate void SourceEventDelegate(SourceEventArgs fswEventArgs);
        public event SourceEventDelegate SourceEvent;
        public delegate void SourceErrorDelegate(SourceEventArgs fswEventArgs);
        public event SourceErrorDelegate SourceError;

        public string FriendlyName { get; set; }

        protected FSWabstract()
        {
            // Changed, Created and Deleted event handlers have common parameters "object"
            // and "FileSystemEventArgs" so we'll use the same delegate for those 3
            Changed += FSWcontract_IoActivity;
            Created += FSWcontract_IoActivity;
            Deleted += FSWcontract_IoActivity;
            Renamed += FSWcontract_Renamed;
            Error += FSWcontract_Error;
        }

        /// <summary>
        /// Enable or disable tracking of "Changed" event.
        /// </summary>
        /// <param name="value"></param>
        public void TrackChangedEvent(bool value)
        {
            if (value) Changed += FSWcontract_IoActivity;
            else Changed -= FSWcontract_IoActivity;
        }

        /// <summary>
        /// Tracks FilsSystemWatcher Errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSWcontract_Error(object sender, ErrorEventArgs e)
        {
            SourceEventArgs fswe = new SourceEventArgs();
            fswe.FSWname = this.FriendlyName;
            fswe.TimeStamp = DateTime.Now;
            fswe.Path = e.GetException().Message;
            fswe.EventType = "Error";
            SourceError(fswe);
        }

        /// <summary>
        /// Tracks FilsSystemWatcher "Renamed" events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSWcontract_Renamed(object sender, RenamedEventArgs e)
        {
            SourceEventArgs fswe = new SourceEventArgs();
            fswe.FSWname = this.FriendlyName;
            fswe.TimeStamp = DateTime.Now;
            fswe.OldPath = e.OldFullPath;
            fswe.Path = e.FullPath;
            fswe.EventType = e.ChangeType.ToString();
            SourceEvent(fswe);
        }

        /// <summary>
        /// Tracks FilsSystemWatcher "Changed", Created" and "Deleted" events
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FSWcontract_IoActivity(object sender, FileSystemEventArgs e)
        {
            SourceEventArgs fswe = new SourceEventArgs();
            fswe.FSWname = this.FriendlyName;
            fswe.TimeStamp = DateTime.Now;
            fswe.Path = e.FullPath;
            fswe.EventType = e.ChangeType.ToString();
            SourceEvent(fswe);
        }
    }
}
