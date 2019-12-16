using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EncryptionWithFrames
{
    public partial class WindowOfDecryption : Form
    {
        public WindowOfDecryption()
        {
            InitializeComponent();
        }

        public String GetText() { return textBox1.Text; }


        private void OK_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
