using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptionWithFrames
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
            //Application.Run(new Form2());
            //Console.WriteLine(EncryptCode.Program.Run("alex2"));

            //EncryptCode.Program.MainProg();
        }
    }
}
