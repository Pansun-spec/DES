using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FileLock
{
    static class Program
    {
        /// <summary>
        /// main enter
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
