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

        public String getText() { return EnterTextSpace.Text; }

        private void OK_btn_Click(object sender, EventArgs e)
        {
            string str = "";
            //if (comboBox1.Items[4].Equals(2)) EnterTextSpace.Text = "OK";
            for (int i = 0; i <= 5; i++) str += String.Format("{0} \r\n",Convert.ToString(comboBox1.Items[i]));
            //Close();
            EnterTextSpace.Text = str;
        }

        private void Cancle_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
