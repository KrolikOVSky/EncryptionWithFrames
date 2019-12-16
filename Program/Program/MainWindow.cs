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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowOfEncryption form2 = new WindowOfEncryption();
            form2.Text = this.Text;
            form2.ShowDialog();
            string text = form2.GetText();
            if (text.Equals(""))
            {
                Space_for_code.Text = "No symbols was found";
            }
            else
            {
                Space_for_code.Text = EncryptCode.Program.Code(EncryptCode.Program.CodeInArray(text));
                Space_for_key.Text = EncryptCode.Program.Key(EncryptCode.Program.CodeInArray(text));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WindowOfDecryption form3 = new WindowOfDecryption();
            form3.Text = "Decrypt";
            form3.ShowDialog();
            string text = form3.GetText();
            if (text.Equals(""))
            {
                Space_for_code.Text = "No symbols was found";
            }
            else
            {
                Space_for_code.Text = EncryptCode.Program.Code(EncryptCode.Program.CodeInArray(text));
                Space_for_key.Text = EncryptCode.Program.Key(EncryptCode.Program.CodeInArray(text));
            }
        }

    }
}
