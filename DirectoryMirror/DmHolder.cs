using System;

namespace DM
{
    /// <summary>
    /// Entity used by the controler to keep track of the
    /// of the DirectoryMirror objects configured by the user
    /// </summary>
    public class DmHolder
    {
        private DirectoryMirror _DM;

        public int Index { get; set; }
        public string Name { get; set; }
        public string SourcePath { get; set; }
        public string MirrorPath { get; set; }
        public string Info { get; set; }
        public bool MirrorMode { get; set; }
        public long Identifier { get; set; }
        public int Buffer { get; set; }
        public double Timer { get; set; }
        public DirectoryMirror DM
        { 
            get { return _DM ;}
            set { _DM = value; }
        }
        public bool IsRunning 
        {
            get { return _DM != null;}
        }
    }
}
