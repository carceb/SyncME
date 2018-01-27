using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM
{
    public class MirrorEventArgs
    {
        public string FSWname { get; set; }
        public string Action { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Info { get; set; }
    }
}
