using System;
using System.Drawing;
using System.Windows.Forms;
using DM;
using DM.Enums;

namespace WinDirectoryMirrorApp
{
    public partial class DirectoryMirror_Control : UserControl
    {
        #region public properties

        public string DmName
        {
            get { return DMname_label.Text; }
            set { DMname_label.Text = value; }
        }
        public string SourceDirectory
        {
            get { return source_value.Text; }
            set { source_value.Text = value; }
        }
        public string MirrorDirectory
        {
            get { return mirror_value.Text; }
            set { mirror_value.Text = value; }
        }
        public int Buffer
        {
            get { return Convert.ToInt32(buffer_value.Text); }
            set { buffer_value.Text = value.ToString(); }
        }
        public double Timer
        {
            get { return Convert.ToDouble(timer_value.Text); }
            set { timer_value.Text = value.ToString(); }
        }
        public bool IsRunning
        {
            set { setState(value); }
        }
        public long Identifier { get; set; }
        public int Index { get; set; }

        #endregion

        #region delegates and events declaration

        public delegate void UpdateDelegate(DmHolder dmHolder);
        public event UpdateDelegate UpdateEvent;
        public delegate void DeleteDelegate(long identifier);
        public event DeleteDelegate DeleteEvent;
        public delegate void StartDelegate(string name, bool mirrorMode, int rebuildOption, long identifier, int index, bool trackChanged);
        public event StartDelegate StartEvent;
        public delegate void StopDelegate(long identifier);
        public event StopDelegate StopEvent;
        public delegate void OptionsDelegate(long identifier, DisplayEventOption option, bool value);
        public event OptionsDelegate OptionsEvent;

        #endregion

        public DirectoryMirror_Control()
        {
            InitializeComponent();
        }

        private void setState(bool v)
        {
            if (v) SetStart();
            else setStopped();
        }

        public void SetStart()
        {
            edit_button.Enabled = false;
            delete_button.Enabled = false;
            currentState_label.Text = "Sincronizando";
            currentState_label.ForeColor = Color.Green;
            BackColor = Color.White;
            mirrorMode_radiobutton.Enabled = false;
            infoMode_radiobutton.Enabled = false;
        }

        private void setStopped()
        {
            edit_button.Enabled = true;
            delete_button.Enabled = true;
            currentState_label.Text = "Detenido";
            currentState_label.ForeColor = Color.Red;
            BackColor = Color.Gainsboro;
            mirrorMode_radiobutton.Enabled = true;
            infoMode_radiobutton.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            switch (b.Tag.ToString())
            {
                case "Power":
                    if (currentState_label.Text != "Sincronizando")
                    {
                        if (mirrorMode_radiobutton.Checked)
                        {
                            RebuildForm rebuildForm = new RebuildForm();
                            rebuildForm.ShowDialog(this);
                            if (rebuildForm.DialogResult == DialogResult.OK)
                            {
                                StartEvent(DmName, mirrorMode_radiobutton.Checked, rebuildForm.RebuildOption, Identifier, Index, trackChangedChk.Checked);                               
                            }
                        }
                        else
                        {
                            StartEvent(DmName, mirrorMode_radiobutton.Checked, -1, Identifier, Index, trackChangedChk.Checked);
                        }
                        //setStart();
                    }
                    else
                    {
                        setStopped();
                        StopEvent(Identifier);
                    }
                    break;
                case "Edit":
                    EditForm editForm = new EditForm();
                    editForm.Text = "Edit";
                    editForm.DmName = DmName;
                    editForm.SourceDirectory = SourceDirectory;
                    editForm.MirrorDirectory = MirrorDirectory;
                    editForm.Timer = Timer;
                    editForm.Buffer = Buffer;
                    editForm.ShowDialog(this);
                    if (editForm.DialogResult == DialogResult.OK)
                    {
                        DmHolder dmh = new DmHolder();
                        dmh.Name = editForm.DmName;
                        dmh.SourcePath = editForm.SourceDirectory;
                        dmh.MirrorPath = editForm.MirrorDirectory;
                        dmh.Buffer = editForm.Buffer;
                        dmh.Timer = editForm.Timer;
                        dmh.Identifier = Identifier;
                        UpdateEvent(dmh);
                    }

                    break;
                case "Delete":
                    DeleteEvent(Identifier);
                    break;
                default:
                    break;
            }

        }

        #region options click events

        //private void sourceActivityChk_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, EventOption.SourceEvent, sourceActivityChk.Checked);
        //}

        //private void sourceErrorChk_CheckedChanged(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, EventOption.SourceError, sourceErrorChk.Checked);
        //}

        //private void mirrorActivityChk_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, EventOption.MirrorAction, mirrorActivityChk.Checked);
        //}

        //private void mirrorErrorChk_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, EventOption.MirrorError, mirrorErrorChk.Checked);
        //}

        //private void trackChangedChk_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, DisplayEventOption.TrackChanged, trackChangedChk.Checked);
        //}

        //private void mirrorMode_radiobutton_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, DisplayEventOption.MirrorMode, mirrorMode_radiobutton.Checked);
        //}

        //private void infoMode_radiobutton_Click(object sender, EventArgs e)
        //{
        //    OptionsEvent(Identifier, DisplayEventOption.InfoMode, infoMode_radiobutton.Checked);
        //}

        #endregion

    }
}
