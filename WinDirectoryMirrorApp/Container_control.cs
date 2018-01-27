using System.Collections.Generic;
using System.Windows.Forms;
using DM;
using DM.Enums;

namespace WinDirectoryMirrorApp
{
    public partial class Container_control : UserControl
    {
        #region delegates and events declaration

        public delegate void UpdateDelegate(DmHolder dmHolder);
        public event UpdateDelegate UpdateEvent;
        public delegate void DeleteDelegate(long identifier);
        public event DeleteDelegate DeleteEvent;
        public delegate void StartDelegate(string name, bool mirrorMode, int buildOption, long identifier, bool trackChanged);
        public event StartDelegate StartEvent;
        public delegate void StopDelegate(long identifier);
        public event StopDelegate StopEvent;
        public delegate void OptionsDelegate(long identifier, DisplayEventOption option, bool value);
        public event OptionsDelegate OptionsEvent;

        #endregion

        const int _margin = 1; // spacing between the dm controls
        int _height = 148; // the height of your dm control
        const int _width = 626;
        private int _currentIndex = -1;

        public Container_control()
        {
            InitializeComponent();
        }

        public void Bind(List<DmHolder> list)
        {
            Refresh();
            if (list.Count > 0)
            {
                if (Controls.Count > 0)
                {
                    int n = Controls.Count-1;
                    for (int i = n; i > -1; i--)
                    {
                        Controls[i].Dispose();
                    }
                    Refresh();
                }
                _height += _margin;
                Height = (_height * list.Count) + _margin;
                for (int i = 0; i < list.Count; i++)
                {
                    DirectoryMirror_Control dmc = new DirectoryMirror_Control();
                    dmc.Index = i;
                    dmc.DmName = list[i].Name;
                    dmc.Identifier = list[i].Identifier;
                    dmc.SourceDirectory = list[i].SourcePath;
                    dmc.MirrorDirectory = list[i].MirrorPath;
                    dmc.Buffer = list[i].Buffer;
                    dmc.Timer = list[i].Timer;
                    dmc.IsRunning = list[i].IsRunning;
                    dmc.UpdateEvent += dmuc_UpdateEvent;
                    dmc.DeleteEvent += dmuc_DeleteEvent;
                    dmc.StartEvent += dmuc_StartEvent;
                    dmc.StopEvent += dmuc_StopEvent;
                    //dmc.OptionsEvent += dmuc_OptionsEvent;
                    Controls.Add(dmc);
                    Controls[i].Left = 2;
                    Controls[i].Top = (_height * i) + _margin;                    
                    Controls[i].Anchor = AnchorStyles.Right | AnchorStyles.Left;
                    Controls[i].Width = _width;
                }
            }
        }

        public void SetStart()
        {
            for(int i = 0; i < Controls.Count; i++)
            {
                var dmc = (DirectoryMirror_Control) Controls[i];
                if(dmc.Index == _currentIndex)
                {
                    dmc.SetStart();
                    return;
                }
            }
        }

        void dmuc_StopEvent(long identifier)
        {
            StopEvent(identifier);
        }

        void dmuc_StartEvent(string name, bool mirrorMode, int buildOption, long identifier, int index, bool trackChanged)
        {
            _currentIndex = index;
            StartEvent(name, mirrorMode, buildOption, identifier, trackChanged);
        }

        void dmuc_DeleteEvent(long identifier)
        {
            DeleteEvent(identifier);
        }

        void dmuc_UpdateEvent(DmHolder dmHolder)
        {
            UpdateEvent(dmHolder);
        }

        void dmuc_OptionsEvent(long identifier, DisplayEventOption option, bool value)
        {
            OptionsEvent(identifier, option, value);
        }

        private void Container_control_Resize(object sender, System.EventArgs e)
        {
            Refresh();
        }

    }
}
