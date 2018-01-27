namespace WinDirectoryMirrorApp
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.mirror_label = new System.Windows.Forms.Label();
            this.source_label = new System.Windows.Forms.Label();
            this.mirror_button = new System.Windows.Forms.Button();
            this.source_button = new System.Windows.Forms.Button();
            this.mirror_value = new System.Windows.Forms.TextBox();
            this.source_value = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.name_value = new System.Windows.Forms.TextBox();
            this.timer_value = new System.Windows.Forms.NumericUpDown();
            this.buffer_value = new System.Windows.Forms.ComboBox();
            this.timer_label = new System.Windows.Forms.Label();
            this.buffer_label = new System.Windows.Forms.Label();
            this.ok_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.sourceDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.timer_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // mirror_label
            // 
            this.mirror_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mirror_label.AutoSize = true;
            this.mirror_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mirror_label.Location = new System.Drawing.Point(11, 108);
            this.mirror_label.Name = "mirror_label";
            this.mirror_label.Size = new System.Drawing.Size(39, 13);
            this.mirror_label.TabIndex = 4;
            this.mirror_label.Text = "Espejo";
            // 
            // source_label
            // 
            this.source_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.source_label.AutoSize = true;
            this.source_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_label.Location = new System.Drawing.Point(11, 80);
            this.source_label.Name = "source_label";
            this.source_label.Size = new System.Drawing.Size(47, 13);
            this.source_label.TabIndex = 3;
            this.source_label.Text = "Principal";
            // 
            // mirror_button
            // 
            this.mirror_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mirror_button.BackColor = System.Drawing.SystemColors.Control;
            this.mirror_button.Image = global::WinDirectoryMirrorApp.Properties.Resources.folder;
            this.mirror_button.Location = new System.Drawing.Point(57, 101);
            this.mirror_button.Margin = new System.Windows.Forms.Padding(0);
            this.mirror_button.Name = "mirror_button";
            this.mirror_button.Padding = new System.Windows.Forms.Padding(1);
            this.mirror_button.Size = new System.Drawing.Size(30, 30);
            this.mirror_button.TabIndex = 16;
            this.mirror_button.UseVisualStyleBackColor = false;
            this.mirror_button.Click += new System.EventHandler(this.mirror_button_Click);
            // 
            // source_button
            // 
            this.source_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.source_button.BackColor = System.Drawing.SystemColors.Control;
            this.source_button.Image = global::WinDirectoryMirrorApp.Properties.Resources.folder;
            this.source_button.Location = new System.Drawing.Point(57, 71);
            this.source_button.Margin = new System.Windows.Forms.Padding(0);
            this.source_button.Name = "source_button";
            this.source_button.Padding = new System.Windows.Forms.Padding(1);
            this.source_button.Size = new System.Drawing.Size(30, 30);
            this.source_button.TabIndex = 15;
            this.source_button.UseVisualStyleBackColor = false;
            this.source_button.Click += new System.EventHandler(this.source_button_Click);
            // 
            // mirror_value
            // 
            this.mirror_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mirror_value.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mirror_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mirror_value.Location = new System.Drawing.Point(90, 106);
            this.mirror_value.Name = "mirror_value";
            this.mirror_value.Size = new System.Drawing.Size(564, 20);
            this.mirror_value.TabIndex = 18;
            // 
            // source_value
            // 
            this.source_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.source_value.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.source_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.source_value.Location = new System.Drawing.Point(90, 76);
            this.source_value.Name = "source_value";
            this.source_value.Size = new System.Drawing.Size(564, 20);
            this.source_value.TabIndex = 17;
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(12, 52);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(76, 13);
            this.name_label.TabIndex = 19;
            this.name_label.Text = "Nombre param";
            // 
            // name_value
            // 
            this.name_value.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name_value.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_value.Location = new System.Drawing.Point(90, 46);
            this.name_value.MaxLength = 100;
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(564, 20);
            this.name_value.TabIndex = 20;
            // 
            // timer_value
            // 
            this.timer_value.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.timer_value.Location = new System.Drawing.Point(208, 14);
            this.timer_value.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.timer_value.Name = "timer_value";
            this.timer_value.Size = new System.Drawing.Size(72, 20);
            this.timer_value.TabIndex = 21;
            this.timer_value.Value = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            // 
            // buffer_value
            // 
            this.buffer_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.buffer_value.FormattingEnabled = true;
            this.buffer_value.Location = new System.Drawing.Point(377, 12);
            this.buffer_value.Name = "buffer_value";
            this.buffer_value.Size = new System.Drawing.Size(60, 21);
            this.buffer_value.TabIndex = 22;
            // 
            // timer_label
            // 
            this.timer_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timer_label.AutoSize = true;
            this.timer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(90, 17);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(102, 13);
            this.timer_label.TabIndex = 23;
            this.timer_label.Text = "Timer (milisegundos)";
            // 
            // buffer_label
            // 
            this.buffer_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buffer_label.AutoSize = true;
            this.buffer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buffer_label.Location = new System.Drawing.Point(311, 16);
            this.buffer_label.Name = "buffer_label";
            this.buffer_label.Size = new System.Drawing.Size(58, 13);
            this.buffer_label.TabIndex = 24;
            this.buffer_label.Text = "Buffer (KB)";
            // 
            // ok_button
            // 
            this.ok_button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ok_button.Image = ((System.Drawing.Image)(resources.GetObject("ok_button.Image")));
            this.ok_button.Location = new System.Drawing.Point(12, 11);
            this.ok_button.Margin = new System.Windows.Forms.Padding(0);
            this.ok_button.Name = "ok_button";
            this.ok_button.Padding = new System.Windows.Forms.Padding(1);
            this.ok_button.Size = new System.Drawing.Size(30, 30);
            this.ok_button.TabIndex = 25;
            this.ok_button.Tag = "Save";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_button.Image = ((System.Drawing.Image)(resources.GetObject("cancel_button.Image")));
            this.cancel_button.Location = new System.Drawing.Point(44, 11);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(0);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Padding = new System.Windows.Forms.Padding(1);
            this.cancel_button.Size = new System.Drawing.Size(30, 30);
            this.cancel_button.TabIndex = 26;
            this.cancel_button.Tag = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 137);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.buffer_label);
            this.Controls.Add(this.timer_label);
            this.Controls.Add(this.buffer_value);
            this.Controls.Add(this.timer_value);
            this.Controls.Add(this.name_value);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.mirror_value);
            this.Controls.Add(this.source_value);
            this.Controls.Add(this.mirror_button);
            this.Controls.Add(this.source_button);
            this.Controls.Add(this.mirror_label);
            this.Controls.Add(this.source_label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(690, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(690, 176);
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.EditForm_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.timer_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mirror_label;
        private System.Windows.Forms.Label source_label;
        private System.Windows.Forms.Button mirror_button;
        private System.Windows.Forms.TextBox mirror_value;
        private System.Windows.Forms.TextBox source_value;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_value;
        private System.Windows.Forms.NumericUpDown timer_value;
        private System.Windows.Forms.ComboBox buffer_value;
        private System.Windows.Forms.Label timer_label;
        private System.Windows.Forms.Label buffer_label;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.FolderBrowserDialog sourceDialog;
        internal System.Windows.Forms.Button source_button;
    }
}