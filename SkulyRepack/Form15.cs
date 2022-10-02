using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;   // For DLL importing
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SkulyRepack
{
    public partial class Form15 : Form
    {
        private const int SW_RESTORE = 9;
        private const int SW_MINIMIZE = 6;


        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mysqladmin = new Process();

            mysqladmin.StartInfo.FileName = @"MySQL\bin\mysqladmin.exe";
            mysqladmin.StartInfo.Arguments = "-u root --password=root shutdown";

            mysqladmin.StartInfo.UseShellExecute = true;
            mysqladmin.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            mysqladmin.Start();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var procauthkillstring = "authserver";
            var procauthkill2 = Process.GetProcessesByName(procauthkillstring);

            if ((procauthkill2.Length != 0))
            {
                foreach (var proc2 in procauthkill2)
                {
                    proc2.Kill();
                }
            }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var procworldstring = "worldserver";
            var procworld = Process.GetProcessesByName(procworldstring);

            if ((procworld.Length != 0))
            {
                foreach (var proc in procworld)
                {
                    SetForegroundWindow(proc.MainWindowHandle);
                    SendKeys.Send("server shutdown 5");
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(10000);
                }
            }


            var procauthkillstring = "authserver";
            var procauthkill2 = Process.GetProcessesByName(procauthkillstring);

            if ((procauthkill2.Length != 0))
            {
                foreach (var proc2 in procauthkill2)
                {
                    proc2.Kill();
                }
            }


            var mysqladmin = new Process();

            mysqladmin.StartInfo.FileName = @"MySQL\bin\mysqladmin.exe";
            mysqladmin.StartInfo.Arguments = "-u root --password=root shutdown";

            mysqladmin.StartInfo.UseShellExecute = true;
            mysqladmin.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            mysqladmin.Start();

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var procworldstring = "worldserver";
            var procworld = Process.GetProcessesByName(procworldstring);

            if ((procworld.Length != 0))
            {
                foreach (var proc in procworld)
                {
                    SetForegroundWindow(proc.MainWindowHandle);
                    SendKeys.Send("server shutdown 5");
                    SendKeys.Send("{ENTER}");
                    Thread.Sleep(3000);
                }
            }
            this.Close();
        }
    }
}
