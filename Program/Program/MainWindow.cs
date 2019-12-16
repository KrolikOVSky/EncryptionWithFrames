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
            String text = null;
            WindowOfEncryption form2 = new WindowOfEncryption();
            form2.Text = this.Text;
            form2.ShowDialog();

            //textBox1.Text = Convert.ToString(EncryptCode.Program.Run("as"));
            text = form2.getText();
            if (text.Equals(""))
            {
                Space_for_code.Text = "No symbols was found";
            }
            else
            {
                Space_for_code.Text = EncryptCode.Program.Code(EncryptCode.Program.CodeInArray(text));
                Space_for_key.Text = EncryptCode.Program.Key(EncryptCode.Program.CodeInArray(text));
                //textBox1.Text = EncryptCode.Program.Run
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String text = null;
            Form3 form3 = new Form3();
            form3.Text = "Decrypt";
            form3.ShowDialog();

            //textBox1.Text = Convert.ToString(EncryptCode.Program.Run("as"));
            text = form3.getText();
            if (text.Equals(""))
            {
                Space_for_code.Text = "No symbols was found";
            }
            else
            {
                Space_for_code.Text = EncryptCode.Program.Code(EncryptCode.Program.CodeInArray(text));
                Space_for_key.Text = EncryptCode.Program.Key(EncryptCode.Program.CodeInArray(text));
                //textBox1.Text = EncryptCode.Program.Run
            }
            //else textBox1.Text = Convert.ToString(EncryptCode.Program.Run(text));

        }

    }
}
