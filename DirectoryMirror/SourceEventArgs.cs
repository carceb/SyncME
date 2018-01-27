using System;

namespace DM
{
    /// <summary>
    /// Entity used by the DirectoryMirror to keep track about the FileSystemWatcher
    /// events and the paths involded, then later used to update the mirror directory.
    /// </summary>
    /// 
    public class SourceEventArgs
    {
        public string FSWname { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool IsDirectory  { get; set; }
        public string Path { get; set; } // also used for error message from the Error event
        public string OldPath { get; set; } //used only by the onRenamed event
        public string EventType { get; set; } // Changed, Created, Deleted, Renamed, Error
    }
}
