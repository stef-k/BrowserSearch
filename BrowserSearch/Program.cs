using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BrowserSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            string url = "https://google.com?q=";
            string content = Clipboard.GetText();

            if (content != "")
            {
                System.Diagnostics.Process.Start(url + content);
            }

        }
    }
}
