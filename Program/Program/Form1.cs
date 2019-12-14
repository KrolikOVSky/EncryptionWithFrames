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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
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
            Form2 form2 = new Form2();
            form2.Text = this.Text;
            form2.ShowDialog();

            //textBox1.Text = Convert.ToString(EncryptCode.Program.Run("as"));
            text = form2.getText();
            if (text.Equals(""))
            {
                textBox1.Text = "No symbols was found";
            }
            //else textBox1.Text = text;
            else textBox1.Text = Convert.ToString(EncryptCode.Program.Run(text));
        }
    }
}
