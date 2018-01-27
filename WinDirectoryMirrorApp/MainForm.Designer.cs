namespace WinDirectoryMirrorApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sourceGrid = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.file = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lnkClearSource = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.mirrorGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Event = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.info = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lnkClearMirror = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.addNew_button = new System.Windows.Forms.Button();
            this.panelA = new System.Windows.Forms.Panel();
            this.mirrorErrorChk = new System.Windows.Forms.CheckBox();
            this.sourceErrorChk = new System.Windows.Forms.CheckBox();
            this.mirrorActivityChk = new System.Windows.Forms.CheckBox();
            this.sourceActivityChk = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorGrid)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(648, 383);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(640, 357);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Configuraciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 357);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actividad";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sourceGrid);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.mirrorGrid);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Size = new System.Drawing.Size(634, 351);
            this.splitContainer1.SplitterDistance = 178;
            this.splitContainer1.TabIndex = 0;
            // 
            // sourceGrid
            // 
            this.sourceGrid.AllowUserToAddRows = false;
            this.sourceGrid.AllowUserToDeleteRows = false;
            this.sourceGrid.AllowUserToOrderColumns = true;
            this.sourceGrid.AllowUserToResizeRows = false;
            this.sourceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sourceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.time,
            this.eventType,
            this.file});
            this.sourceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceGrid.Location = new System.Drawing.Point(0, 24);
            this.sourceGrid.Name = "sourceGrid";
            this.sourceGrid.ShowCellErrors = false;
            this.sourceGrid.ShowCellToolTips = false;
            this.sourceGrid.ShowEditingIcon = false;
            this.sourceGrid.ShowRowErrors = false;
            this.sourceGrid.Size = new System.Drawing.Size(634, 154);
            this.sourceGrid.TabIndex = 1;
            // 
            // name
            // 
            this.name.HeaderText = "Instancia";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 120;
            // 
            // time
            // 
            this.time.HeaderText = "Hora";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Width = 80;
            // 
            // eventType
            // 
            this.eventType.HeaderText = "Evento";
            this.eventType.Name = "eventType";
            this.eventType.ReadOnly = true;
            this.eventType.Width = 120;
            // 
            // file
            // 
            this.file.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.file.FillWeight = 300F;
            this.file.HeaderText = "Archivo/Directorio";
            this.file.Name = "file";
            this.file.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lnkClearSource);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 24);
            this.panel2.TabIndex = 0;
            // 
            // lnkClearSource
            // 
            this.lnkClearSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearSource.AutoSize = true;
            this.lnkClearSource.Location = new System.Drawing.Point(594, 5);
            this.lnkClearSource.Name = "lnkClearSource";
            this.lnkClearSource.Size = new System.Drawing.Size(40, 13);
            this.lnkClearSource.TabIndex = 1;
            this.lnkClearSource.TabStop = true;
            this.lnkClearSource.Text = "Limpiar";
            this.lnkClearSource.Click += new System.EventHandler(this.lnkClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carpeta principal";
            // 
            // mirrorGrid
            // 
            this.mirrorGrid.AllowUserToAddRows = false;
            this.mirrorGrid.AllowUserToDeleteRows = false;
            this.mirrorGrid.AllowUserToOrderColumns = true;
            this.mirrorGrid.AllowUserToResizeRows = false;
            this.mirrorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mirrorGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Event,
            this.info});
            this.mirrorGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mirrorGrid.Location = new System.Drawing.Point(0, 24);
            this.mirrorGrid.Name = "mirrorGrid";
            this.mirrorGrid.ReadOnly = true;
            this.mirrorGrid.ShowCellErrors = false;
            this.mirrorGrid.ShowCellToolTips = false;
            this.mirrorGrid.ShowEditingIcon = false;
            this.mirrorGrid.ShowRowErrors = false;
            this.mirrorGrid.Size = new System.Drawing.Size(634, 145);
            this.mirrorGrid.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Instancia";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Hora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // Event
            // 
            this.Event.HeaderText = "Evento";
            this.Event.Name = "Event";
            this.Event.ReadOnly = true;
            this.Event.Width = 120;
            // 
            // info
            // 
            this.info.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.info.HeaderText = "Infornación";
            this.info.Name = "info";
            this.info.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lnkClearMirror);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(634, 24);
            this.panel3.TabIndex = 0;
            // 
            // lnkClearMirror
            // 
            this.lnkClearMirror.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClearMirror.AutoSize = true;
            this.lnkClearMirror.Location = new System.Drawing.Point(594, 5);
            this.lnkClearMirror.Name = "lnkClearMirror";
            this.lnkClearMirror.Size = new System.Drawing.Size(40, 13);
            this.lnkClearMirror.TabIndex = 2;
            this.lnkClearMirror.TabStop = true;
            this.lnkClearMirror.Text = "Limpiar";
            this.lnkClearMirror.Click += new System.EventHandler(this.lnkClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Carpeta espejo";
            // 
            // save_button
            // 
            this.save_button.Enabled = false;
            this.save_button.Location = new System.Drawing.Point(124, 9);
            this.save_button.Margin = new System.Windows.Forms.Padding(0);
            this.save_button.Name = "save_button";
            this.save_button.Padding = new System.Windows.Forms.Padding(1);
            this.save_button.Size = new System.Drawing.Size(84, 30);
            this.save_button.TabIndex = 3;
            this.save_button.Tag = "Save";
            this.save_button.Text = "Guardar tarea";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // addNew_button
            // 
            this.addNew_button.Location = new System.Drawing.Point(24, 9);
            this.addNew_button.Margin = new System.Windows.Forms.Padding(0);
            this.addNew_button.Name = "addNew_button";
            this.addNew_button.Padding = new System.Windows.Forms.Padding(1);
            this.addNew_button.Size = new System.Drawing.Size(91, 30);
            this.addNew_button.TabIndex = 2;
            this.addNew_button.Tag = "Add";
            this.addNew_button.Text = "Nueva tarea";
            this.addNew_button.UseVisualStyleBackColor = true;
            this.addNew_button.Click += new System.EventHandler(this.addNew_button_Click);
            // 
            // panelA
            // 
            this.panelA.Controls.Add(this.mirrorErrorChk);
            this.panelA.Controls.Add(this.sourceErrorChk);
            this.panelA.Controls.Add(this.mirrorActivityChk);
            this.panelA.Controls.Add(this.sourceActivityChk);
            this.panelA.Controls.Add(this.save_button);
            this.panelA.Controls.Add(this.addNew_button);
            this.panelA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelA.Location = new System.Drawing.Point(0, 0);
            this.panelA.MinimumSize = new System.Drawing.Size(672, 46);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(672, 46);
            this.panelA.TabIndex = 4;
            // 
            // mirrorErrorChk
            // 
            this.mirrorErrorChk.AutoSize = true;
            this.mirrorErrorChk.Checked = true;
            this.mirrorErrorChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mirrorErrorChk.Location = new System.Drawing.Point(407, 26);
            this.mirrorErrorChk.Name = "mirrorErrorChk";
            this.mirrorErrorChk.Size = new System.Drawing.Size(150, 17);
            this.mirrorErrorChk.TabIndex = 37;
            this.mirrorErrorChk.Text = "Ver errores carpeta espejo";
            this.mirrorErrorChk.UseVisualStyleBackColor = true;
            // 
            // sourceErrorChk
            // 
            this.sourceErrorChk.AutoSize = true;
            this.sourceErrorChk.Checked = true;
            this.sourceErrorChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sourceErrorChk.Location = new System.Drawing.Point(238, 26);
            this.sourceErrorChk.Name = "sourceErrorChk";
            this.sourceErrorChk.Size = new System.Drawing.Size(149, 17);
            this.sourceErrorChk.TabIndex = 36;
            this.sourceErrorChk.Text = "Ver errores carpeta fuente";
            this.sourceErrorChk.UseVisualStyleBackColor = true;
            // 
            // mirrorActivityChk
            // 
            this.mirrorActivityChk.AutoSize = true;
            this.mirrorActivityChk.Checked = true;
            this.mirrorActivityChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mirrorActivityChk.Location = new System.Drawing.Point(407, 6);
            this.mirrorActivityChk.Name = "mirrorActivityChk";
            this.mirrorActivityChk.Size = new System.Drawing.Size(161, 17);
            this.mirrorActivityChk.TabIndex = 35;
            this.mirrorActivityChk.Text = "Ver actividad carpeta espejo";
            this.mirrorActivityChk.UseVisualStyleBackColor = true;
            // 
            // sourceActivityChk
            // 
            this.sourceActivityChk.AutoSize = true;
            this.sourceActivityChk.Checked = true;
            this.sourceActivityChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sourceActivityChk.Location = new System.Drawing.Point(238, 6);
            this.sourceActivityChk.Name = "sourceActivityChk";
            this.sourceActivityChk.Size = new System.Drawing.Size(160, 17);
            this.sourceActivityChk.TabIndex = 34;
            this.sourceActivityChk.Text = "Ver actividad carpeta fuente";
            this.sourceActivityChk.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Sincronizador en ejecución";
            this.notifyIcon.BalloonTipTitle = "Sincronizador";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sincronizador";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 442);
            this.Controls.Add(this.panelA);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(688, 400);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sincronizador de Archivos";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sourceGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mirrorGrid)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panelA.ResumeLayout(false);
            this.panelA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.Button addNew_button;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView sourceGrid;
        private System.Windows.Forms.DataGridView mirrorGrid;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.LinkLabel lnkClearSource;
        private System.Windows.Forms.LinkLabel lnkClearMirror;
        private System.Windows.Forms.CheckBox mirrorErrorChk;
        private System.Windows.Forms.CheckBox sourceErrorChk;
        private System.Windows.Forms.CheckBox mirrorActivityChk;
        private System.Windows.Forms.CheckBox sourceActivityChk;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn file;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Event;
        private System.Windows.Forms.DataGridViewTextBoxColumn info;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

