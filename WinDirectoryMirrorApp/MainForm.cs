using System;
using System.Drawing;
using System.Windows.Forms;
using DM;
using DM.Enums;

namespace WinDirectoryMirrorApp
{
    public partial class MainForm : Form
    {
        private Controler _ctrl;
        private Container_control _container;

        public MainForm()
        {
            InitializeComponent();
            _ctrl = new Controler();
            _ctrl.SourceEvent += SourceEvent;
            _ctrl.SourceError += SourceError;
            _ctrl.MirrorEvent += MirrorEvent;
            _ctrl.MirrorError += MirrorError;
            SetUp();
            sourceGrid.Rows.Add();
            mirrorGrid.Rows.Add();
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            DateTime buildDate = new DateTime(2000, 1, 1).AddDays(version.Build).AddSeconds(version.Revision * 2);
            string displayableVersion = $"{version} ({buildDate})";
            this.Text = "Sincronizador de Archivos [Versión: " + displayableVersion + "]";
        }

        private void SetUp()
        {
            _container = new Container_control();
            _container.UpdateEvent += UpdateEvent;
            _container.DeleteEvent += DeleteEvent;
            _container.StartEvent += StartEvent;
            _container.StopEvent += StopEvent;
            _container.Bind(_ctrl.DirectoryMirrorList);
            tabControl1.TabPages[0].Controls.Add(_container);
            tabControl1.TabPages[0].Controls[0].Top = 0;
            tabControl1.TabPages[0].Controls[0].Width = 636;
            tabControl1.TabPages[0].Controls[0].Anchor = AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left;
        }

        #region info events from DM and FSW displayed in the grids

        private void MirrorEvent(MirrorEventArgs args)
        {
            if(mirrorActivityChk.Checked)
                _ctrl_MirrorEvent(args);
        }

        private void MirrorError(MirrorEventArgs args)
        {
            if(mirrorErrorChk.Checked)
                _ctrl_MirrorError(args);
        }

        private void SourceEvent(SourceEventArgs args)
        {
            if(sourceActivityChk.Checked)
                _ctrl_SourceEvent(args);
        }

        private void SourceError(SourceEventArgs args)
        {
            if(sourceErrorChk.Checked)
                _ctrl_SourceEvent(args);
        }

        delegate void SetMirrorEventCallback(MirrorEventArgs mirrorEventArgs);
        private void _ctrl_MirrorEvent(MirrorEventArgs mirrorEventArgs)
        {
            var row = (DataGridViewRow)mirrorGrid.Rows[0].Clone();
            row.Cells[0].Value = mirrorEventArgs.FSWname;
            row.Cells[1].Value = mirrorEventArgs.TimeStamp.ToLongTimeString();
            row.Cells[2].Value = mirrorEventArgs.Action;
            row.Cells[3].Value = mirrorEventArgs.Info;
            if (mirrorGrid.InvokeRequired)
            {
                SetMirrorEventCallback d = _ctrl_MirrorEvent;
                Invoke(d, new object[] { mirrorEventArgs });
            }
            else
            {
                mirrorGrid.Rows.Insert(0, row);
            }
        }

        delegate void SetMirrorErrorCallback(MirrorEventArgs mirrorEventArgs);
        private void _ctrl_MirrorError(MirrorEventArgs mirrorEventArgs)
        {
           var row = (DataGridViewRow)mirrorGrid.Rows[0].Clone();
            row.Cells[0].Value = mirrorEventArgs.FSWname;
            row.Cells[1].Value = mirrorEventArgs.TimeStamp.ToLongTimeString();
            row.Cells[2].Value = mirrorEventArgs.Action;
            row.Cells[3].Value = mirrorEventArgs.Info;
            row.Cells[0].Style.ForeColor = Color.Red;
            row.Cells[1].Style.ForeColor = Color.Red;
            row.Cells[2].Style.ForeColor = Color.Red;
            row.Cells[3].Style.ForeColor = Color.Red;
            if (mirrorGrid.InvokeRequired)
            {
                SetMirrorErrorCallback d = _ctrl_MirrorError;
                Invoke(d, new object[] { mirrorEventArgs });
            }
            else
            {
                mirrorGrid.Rows.Insert(0, row);
            }
        }

        delegate void SetSourceEventCallback(SourceEventArgs sourceEventArg);
        private void _ctrl_SourceEvent(SourceEventArgs sourceEventArgs)
        {
            var row = (DataGridViewRow)sourceGrid.Rows[0].Clone();
            row.Cells[0].Value = sourceEventArgs.FSWname;
            row.Cells[1].Value = sourceEventArgs.TimeStamp.ToLongTimeString();
            row.Cells[2].Value = sourceEventArgs.EventType;
            row.Cells[3].Value = sourceEventArgs.Path;
            if (sourceGrid.InvokeRequired)
            {
                SetSourceEventCallback d = _ctrl_SourceEvent;
                Invoke(d, new object[] { sourceEventArgs });
            }
            else
            {
                sourceGrid.Rows.Insert(0, row);
            }
        }

        delegate void SetSourceErrorCallback(SourceEventArgs sourceEventArg);
        private void _ctrl_SourceError(SourceEventArgs sourceEventArgs)
        {
            var row = (DataGridViewRow)sourceGrid.Rows[0].Clone();
            row.Cells[0].Value = sourceEventArgs.FSWname;
            row.Cells[1].Value = sourceEventArgs.TimeStamp.ToLongTimeString();
            row.Cells[2].Value = sourceEventArgs.EventType;
            row.Cells[3].Value = sourceEventArgs.Path;
            row.Cells[0].Style.ForeColor = Color.Red;
            row.Cells[1].Style.ForeColor = Color.Red;
            row.Cells[2].Style.ForeColor = Color.Red;
            row.Cells[3].Style.ForeColor = Color.Red;
            if (sourceGrid.InvokeRequired)
            {
                SetSourceErrorCallback d = _ctrl_SourceError;
                Invoke(d, new object[] { sourceEventArgs });
            }
            else
            {
                sourceGrid.Rows.Insert(0, row);
            }
        }

        private void lnkClear_Click(object sender, EventArgs e)
        {
            LinkLabel lnk = (LinkLabel) sender;
            if (lnk.Name == "lnkClearSource")
            {
                sourceGrid.Rows.Clear();
                sourceGrid.Rows.Add();
            }
            else
            {
                mirrorGrid.Rows.Clear();
                mirrorGrid.Rows.Add();
            }
        }

        #endregion

        #region action events from directoryMirror_controls

        private void StopEvent(long identifier)
        {
            _ctrl.KillDM(identifier);
        }

        private void StartEvent(string oName, bool mirrorMode, int buildOption, long identifier, bool trackChanged)
        {
            var result = _ctrl.StartDM(oName, mirrorMode, sourceActivityChk.Checked, sourceErrorChk.Checked, mirrorActivityChk.Checked, mirrorErrorChk.Checked, buildOption, identifier, trackChanged);
            if(result != "ok")
            {
                MessageBox.Show(result, "Start error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _container.SetStart();
            }
        }

        private void DeleteEvent(long identifier)
        {
            _ctrl.Delete(identifier);
            _container.Bind(_ctrl.DirectoryMirrorList);
            save_button.Enabled = true;
        }

        private void UpdateEvent(DmHolder dmHolder)
        {
            _ctrl.Update(dmHolder);
            _container.Bind(_ctrl.DirectoryMirrorList);
            save_button.Enabled = true;
        }

        #endregion

        private void addNew_button_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm();
            editForm.Text = "Nueva tarea de sincronización";
            editForm.DmName = "Nueva tarea";
            editForm.SourceDirectory = "";
            editForm.MirrorDirectory = "";
            editForm.Timer = 2500;
            editForm.Buffer = 16;
            editForm.ShowDialog(this);
            if (editForm.DialogResult == DialogResult.OK)
            {
                DmHolder dmc = new DmHolder();
                dmc.Identifier = DateTime.Now.Ticks;
                dmc.Name = editForm.DmName;
                dmc.SourcePath = editForm.SourceDirectory;
                dmc.MirrorPath = editForm.MirrorDirectory;
                dmc.Timer = editForm.Timer;
                dmc.Buffer = editForm.Buffer;
                _ctrl.Update(dmc);
                _container.Bind(_ctrl.DirectoryMirrorList);
                save_button.Enabled = true;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            _ctrl.Save();
            save_button.Enabled = false;
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon.Visible = true;
                notifyIcon.ShowBalloonTip(1000);
            }
        }
    }
}
