using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinDirectoryMirrorApp
{
    public partial class EditForm : Form
    {
        #region public properties

        public string DmName
        {
            get { return name_value.Text; }
            set { name_value.Text = value; }
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
            get { return Convert.ToInt32(buffer_value.SelectedValue); }
            set { buffer_value.SelectedIndex = buffer_value.FindString(value.ToString()); }
        }
        public double Timer
        {
            get { return Convert.ToDouble(timer_value.Value); }
            set { timer_value.Value = Convert.ToDecimal(value); }
        }
        public DateTime TimeStamp { get; set; }

        #endregion

        public EditForm()
        {
            InitializeComponent();
            TimeStamp = DateTime.Now;
            setBuffer_values();
        }

        public EditForm(DateTime timestamp)
        {
            InitializeComponent();
            TimeStamp = timestamp;
            setBuffer_values();
        }

        private void setBuffer_values()
        {
            List<ComboBoxItem> list = new List<ComboBoxItem>();
            ComboBoxItem s = new ComboBoxItem();
            s.Text = "4";
            s.Numeric = 4;
            list.Add(s);
            s = new ComboBoxItem();
            s.Text = "8";
            s.Numeric = 8;
            list.Add(s);
            s = new ComboBoxItem();
            s.Text = "16";
            s.Numeric = 16;
            list.Add(s);
            s = new ComboBoxItem();
            s.Text = "32";
            s.Numeric = 32;
            list.Add(s);
            s = new ComboBoxItem();
            s.Text = "64";
            s.Numeric = 64;
            list.Add(s);

            buffer_value.ValueMember = "Numeric";
            buffer_value.ValueMember = "Text";
            buffer_value.DataSource = list;

        }

        private void EditForm_Validating(object sender, CancelEventArgs e)
        {
            validateForm();
        }

        private bool validateForm()
        {
            if (String.IsNullOrEmpty(name_value.Text))
            {
                errorProvider1.SetError(name_value, "Requerido");
                return false;
            }
            if (String.IsNullOrEmpty(source_value.Text))
            {
                errorProvider1.SetError(name_value, "Requerido");
                return false;
            }
            if (String.IsNullOrEmpty(mirror_value.Text))
            {
                errorProvider1.SetError(mirror_value, "Requerido");
                return false;
            }
            if (source_value.Text.StartsWith(mirror_value.Text, System.StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.SetError(source_value, "El directorio principal no puede estar localizado en el directorio espejo.");
                return false;
            }
            if (mirror_value.Text.StartsWith(source_value.Text, System.StringComparison.OrdinalIgnoreCase))
            {
                errorProvider1.SetError(mirror_value, "El directorio espejo no puede estar localizado en el directorio principal.");
                return false;
            }
            return true;
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            if (validateForm() == false) DialogResult = DialogResult.None;
        }

        private void source_button_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                {
                    source_value.Text = fbd.SelectedPath;
                }
            }
        }

        private void mirror_button_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                {
                    mirror_value.Text = fbd.SelectedPath;
                }
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Numeric { get; set; }
    }
}
