namespace WinDirectoryMirrorApp
{
    partial class DirectoryMirror_Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryMirror_Control));
            this.DMname_label = new System.Windows.Forms.Label();
            this.source_label = new System.Windows.Forms.Label();
            this.mirror_label = new System.Windows.Forms.Label();
            this.source_value = new System.Windows.Forms.TextBox();
            this.mirror_value = new System.Windows.Forms.TextBox();
            this.buffer_label = new System.Windows.Forms.Label();
            this.timer_label = new System.Windows.Forms.Label();
            this.currentState_label = new System.Windows.Forms.Label();
            this.timer_value = new System.Windows.Forms.Label();
            this.buffer_value = new System.Windows.Forms.Label();
            this.mirrorMode_radiobutton = new System.Windows.Forms.RadioButton();
            this.trackChangedChk = new System.Windows.Forms.CheckBox();
            this.infoMode_radiobutton = new System.Windows.Forms.RadioButton();
            this.delete_button = new System.Windows.Forms.Button();
            this.edit_button = new System.Windows.Forms.Button();
            this.start_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DMname_label
            // 
            this.DMname_label.AutoSize = true;
            this.DMname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DMname_label.Location = new System.Drawing.Point(15, 9);
            this.DMname_label.Name = "DMname_label";
            this.DMname_label.Size = new System.Drawing.Size(114, 17);
            this.DMname_label.TabIndex = 0;
            this.DMname_label.Text = "DMname_label";
            // 
            // source_label
            // 
            this.source_label.AutoSize = true;
            this.source_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_label.Location = new System.Drawing.Point(15, 41);
            this.source_label.Name = "source_label";
            this.source_label.Size = new System.Drawing.Size(47, 13);
            this.source_label.TabIndex = 0;
            this.source_label.Text = "Principal";
            // 
            // mirror_label
            // 
            this.mirror_label.AutoSize = true;
            this.mirror_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mirror_label.Location = new System.Drawing.Point(16, 67);
            this.mirror_label.Name = "mirror_label";
            this.mirror_label.Size = new System.Drawing.Size(39, 13);
            this.mirror_label.TabIndex = 0;
            this.mirror_label.Text = "Espejo";
            // 
            // source_value
            // 
            this.source_value.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.source_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_value.Location = new System.Drawing.Point(89, 38);
            this.source_value.Name = "source_value";
            this.source_value.ReadOnly = true;
            this.source_value.Size = new System.Drawing.Size(513, 20);
            this.source_value.TabIndex = 0;
            this.source_value.TabStop = false;
            // 
            // mirror_value
            // 
            this.mirror_value.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mirror_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mirror_value.Location = new System.Drawing.Point(89, 65);
            this.mirror_value.Name = "mirror_value";
            this.mirror_value.ReadOnly = true;
            this.mirror_value.Size = new System.Drawing.Size(513, 20);
            this.mirror_value.TabIndex = 0;
            this.mirror_value.TabStop = false;
            // 
            // buffer_label
            // 
            this.buffer_label.AutoSize = true;
            this.buffer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buffer_label.Location = new System.Drawing.Point(512, 12);
            this.buffer_label.Name = "buffer_label";
            this.buffer_label.Size = new System.Drawing.Size(70, 13);
            this.buffer_label.TabIndex = 0;
            this.buffer_label.Text = "Buffer (KB) :  ";
            // 
            // timer_label
            // 
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(386, 12);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(64, 13);
            this.timer_label.TabIndex = 0;
            this.timer_label.Text = "Timer (ms) : ";
            // 
            // currentState_label
            // 
            this.currentState_label.AutoSize = true;
            this.currentState_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentState_label.ForeColor = System.Drawing.Color.Red;
            this.currentState_label.Location = new System.Drawing.Point(320, 12);
            this.currentState_label.Name = "currentState_label";
            this.currentState_label.Size = new System.Drawing.Size(50, 13);
            this.currentState_label.TabIndex = 0;
            this.currentState_label.Text = "Detenido";
            // 
            // timer_value
            // 
            this.timer_value.AutoSize = true;
            this.timer_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_value.Location = new System.Drawing.Point(455, 12);
            this.timer_value.Name = "timer_value";
            this.timer_value.Size = new System.Drawing.Size(35, 13);
            this.timer_value.TabIndex = 0;
            this.timer_value.Text = "2000";
            this.timer_value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buffer_value
            // 
            this.buffer_value.AutoSize = true;
            this.buffer_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buffer_value.Location = new System.Drawing.Point(583, 12);
            this.buffer_value.Name = "buffer_value";
            this.buffer_value.Size = new System.Drawing.Size(21, 13);
            this.buffer_value.TabIndex = 0;
            this.buffer_value.Text = "16";
            this.buffer_value.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mirrorMode_radiobutton
            // 
            this.mirrorMode_radiobutton.AutoSize = true;
            this.mirrorMode_radiobutton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mirrorMode_radiobutton.Checked = true;
            this.mirrorMode_radiobutton.Location = new System.Drawing.Point(89, 94);
            this.mirrorMode_radiobutton.Name = "mirrorMode_radiobutton";
            this.mirrorMode_radiobutton.Size = new System.Drawing.Size(84, 17);
            this.mirrorMode_radiobutton.TabIndex = 30;
            this.mirrorMode_radiobutton.TabStop = true;
            this.mirrorMode_radiobutton.Text = "ModoEspejo";
            this.mirrorMode_radiobutton.UseVisualStyleBackColor = true;
            // 
            // trackChangedChk
            // 
            this.trackChangedChk.AutoSize = true;
            this.trackChangedChk.Checked = true;
            this.trackChangedChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trackChangedChk.Location = new System.Drawing.Point(95, 118);
            this.trackChangedChk.Name = "trackChangedChk";
            this.trackChangedChk.Size = new System.Drawing.Size(117, 17);
            this.trackChangedChk.TabIndex = 34;
            this.trackChangedChk.Text = "Monitor de eventos";
            this.trackChangedChk.UseVisualStyleBackColor = true;
            // 
            // infoMode_radiobutton
            // 
            this.infoMode_radiobutton.AutoSize = true;
            this.infoMode_radiobutton.Location = new System.Drawing.Point(182, 94);
            this.infoMode_radiobutton.Name = "infoMode_radiobutton";
            this.infoMode_radiobutton.Size = new System.Drawing.Size(107, 17);
            this.infoMode_radiobutton.TabIndex = 35;
            this.infoMode_radiobutton.TabStop = true;
            this.infoMode_radiobutton.Text = "ModoInformacion";
            this.infoMode_radiobutton.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            this.delete_button.Image = ((System.Drawing.Image)(resources.GetObject("delete_button.Image")));
            this.delete_button.Location = new System.Drawing.Point(255, 4);
            this.delete_button.Margin = new System.Windows.Forms.Padding(0);
            this.delete_button.Name = "delete_button";
            this.delete_button.Padding = new System.Windows.Forms.Padding(1);
            this.delete_button.Size = new System.Drawing.Size(30, 30);
            this.delete_button.TabIndex = 0;
            this.delete_button.TabStop = false;
            this.delete_button.Tag = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.button_Click);
            // 
            // edit_button
            // 
            this.edit_button.Image = global::WinDirectoryMirrorApp.Properties.Resources.config;
            this.edit_button.Location = new System.Drawing.Point(222, 4);
            this.edit_button.Margin = new System.Windows.Forms.Padding(0);
            this.edit_button.Name = "edit_button";
            this.edit_button.Padding = new System.Windows.Forms.Padding(1);
            this.edit_button.Size = new System.Drawing.Size(30, 30);
            this.edit_button.TabIndex = 0;
            this.edit_button.TabStop = false;
            this.edit_button.Tag = "Edit";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.button_Click);
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.Color.Gainsboro;
            this.start_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.start_button.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start_button.Image = global::WinDirectoryMirrorApp.Properties.Resources.power;
            this.start_button.Location = new System.Drawing.Point(288, 4);
            this.start_button.Margin = new System.Windows.Forms.Padding(1);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(30, 30);
            this.start_button.TabIndex = 0;
            this.start_button.TabStop = false;
            this.start_button.Tag = "Power";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.button_Click);
            // 
            // DirectoryMirror_Control
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.infoMode_radiobutton);
            this.Controls.Add(this.trackChangedChk);
            this.Controls.Add(this.mirrorMode_radiobutton);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.buffer_value);
            this.Controls.Add(this.timer_value);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.currentState_label);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.buffer_label);
            this.Controls.Add(this.mirror_value);
            this.Controls.Add(this.source_value);
            this.Controls.Add(this.mirror_label);
            this.Controls.Add(this.source_label);
            this.Controls.Add(this.DMname_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 3, 5, 3);
            this.Name = "DirectoryMirror_Control";
            this.Padding = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Size = new System.Drawing.Size(610, 138);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DMname_label;
        private System.Windows.Forms.Label source_label;
        private System.Windows.Forms.Label mirror_label;
        private System.Windows.Forms.TextBox source_value;
        private System.Windows.Forms.TextBox mirror_value;
        private System.Windows.Forms.Label buffer_label;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label currentState_label;
        private System.Windows.Forms.Label timer_value;
        private System.Windows.Forms.Label buffer_value;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.RadioButton mirrorMode_radiobutton;
        private System.Windows.Forms.CheckBox trackChangedChk;
        private System.Windows.Forms.RadioButton infoMode_radiobutton;
    }
}
