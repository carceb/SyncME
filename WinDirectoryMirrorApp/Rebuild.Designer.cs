namespace WinDirectoryMirrorApp
{
    partial class RebuildForm
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
            this.HardRb = new System.Windows.Forms.RadioButton();
            this.SoftRb = new System.Windows.Forms.RadioButton();
            this.OkButton = new System.Windows.Forms.Button();
            this.RbGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRb = new System.Windows.Forms.RadioButton();
            this.RbGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HardRb
            // 
            this.HardRb.AutoSize = true;
            this.HardRb.Checked = true;
            this.HardRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HardRb.Location = new System.Drawing.Point(43, 30);
            this.HardRb.Name = "HardRb";
            this.HardRb.Size = new System.Drawing.Size(157, 19);
            this.HardRb.TabIndex = 0;
            this.HardRb.TabStop = true;
            this.HardRb.Tag = "0";
            this.HardRb.Text = "Inicio / reinicio completo";
            this.HardRb.UseVisualStyleBackColor = true;
            this.HardRb.Click += new System.EventHandler(this.Rb_Click);
            // 
            // SoftRb
            // 
            this.SoftRb.AutoSize = true;
            this.SoftRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoftRb.Location = new System.Drawing.Point(43, 91);
            this.SoftRb.Name = "SoftRb";
            this.SoftRb.Size = new System.Drawing.Size(173, 19);
            this.SoftRb.TabIndex = 1;
            this.SoftRb.Tag = "1";
            this.SoftRb.Text = "Inicio / reinicio comparativo";
            this.SoftRb.UseVisualStyleBackColor = true;
            this.SoftRb.Click += new System.EventHandler(this.Rb_Click);
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OkButton.Location = new System.Drawing.Point(154, 284);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(57, 23);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Aceptar";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // RbGroupBox
            // 
            this.RbGroupBox.Controls.Add(this.label3);
            this.RbGroupBox.Controls.Add(this.label2);
            this.RbGroupBox.Controls.Add(this.label1);
            this.RbGroupBox.Controls.Add(this.DeleteRb);
            this.RbGroupBox.Controls.Add(this.HardRb);
            this.RbGroupBox.Controls.Add(this.SoftRb);
            this.RbGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbGroupBox.Location = new System.Drawing.Point(44, 12);
            this.RbGroupBox.Name = "RbGroupBox";
            this.RbGroupBox.Size = new System.Drawing.Size(276, 266);
            this.RbGroupBox.TabIndex = 4;
            this.RbGroupBox.TabStop = false;
            this.RbGroupBox.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(57, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 67);
            this.label3.TabIndex = 5;
            this.label3.Text = "(¡CUIDADO! Elimina todos los archivos y carpetas en el directorio principal y en " +
    "el directorio espejo)";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "(Revisa los cambios en el directorio principal y los actualiza en el espejo)";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "(Inicia una tarea de sincronización desde cero)";
            // 
            // DeleteRb
            // 
            this.DeleteRb.AutoSize = true;
            this.DeleteRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRb.Location = new System.Drawing.Point(43, 174);
            this.DeleteRb.Name = "DeleteRb";
            this.DeleteRb.Size = new System.Drawing.Size(86, 19);
            this.DeleteRb.TabIndex = 2;
            this.DeleteRb.Tag = "2";
            this.DeleteRb.Text = "Borrar todo";
            this.DeleteRb.UseVisualStyleBackColor = true;
            this.DeleteRb.Click += new System.EventHandler(this.Rb_Click);
            // 
            // RebuildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 319);
            this.Controls.Add(this.RbGroupBox);
            this.Controls.Add(this.OkButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RebuildForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sincronización";
            this.RbGroupBox.ResumeLayout(false);
            this.RbGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton HardRb;
        private System.Windows.Forms.RadioButton SoftRb;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox RbGroupBox;
        private System.Windows.Forms.RadioButton DeleteRb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}