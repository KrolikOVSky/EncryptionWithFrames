using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionWithFrames
{
    public partial class WindowOfEncryption : System.Windows.Forms.Form
    {
        public WindowOfEncryption()
        {
            InitializeComponent();
        }

        public String GetText() { return EnterTextSpace.Text; }

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
