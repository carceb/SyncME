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
    public partial class RebuildForm : Form
    {
        private int _selected = 0;
        public int RebuildOption
        {
            get { return _selected;  }
            set { setRadioButton(value);}
        }

        public RebuildForm()
        {
            InitializeComponent();
        }

        private void Rb_Click(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
            object o = rb.Tag;
            _selected = Convert.ToInt32(o);
        }

        private void setRadioButton(int v)
        {
            foreach(RadioButton rb in RbGroupBox.Controls)
            {
                if(v == (int)rb.Tag)
                {
                    rb.Checked = true;
                    return;
                }
            }
        }

    }
}
