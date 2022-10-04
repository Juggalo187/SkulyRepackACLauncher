using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkulyRepack
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var lines = File.ReadAllLines(@"configs\modules\AutoBalance.conf");

            for (int index = 0; index < lines.Length; index++)
            {
                string line = lines[index];
                if (line.Contains("AutoBalance.enable="))
                {
                    lines[index] = "AutoBalance.enable=1";
                }
            }

            File.WriteAllLines(@"configs\modules\AutoBalance.conf", lines);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var lines = File.ReadAllLines(@"configs\modules\AutoBalance.conf");

            for (int index = 0; index < lines.Length; index++)
            {
                string line = lines[index];
                if (line.Contains("AutoBalance.enable="))
                {
                    lines[index] = "AutoBalance.enable=0";
                }
            }

            File.WriteAllLines(@"configs\modules\AutoBalance.conf", lines);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"configs\modules\Solocraft.conf");

            for (int index = 0; index < lines.Length; index++)
            {
                string line = lines[index];
                if (line.Contains("Solocraft.Enable ="))
                {
                    lines[index] = "Solocraft.Enable = 1";
                }
            }

            File.WriteAllLines(@"configs\modules\Solocraft.conf", lines);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines(@"configs\modules\Solocraft.conf");

            for (int index = 0; index < lines.Length; index++)
            {
                string line = lines[index];
                if (line.Contains("Solocraft.Enable ="))
                {
                    lines[index] = "Solocraft.Enable = 1";
                }
            }

            File.WriteAllLines(@"configs\modules\Solocraft.conf", lines);
        }

        private void button13_Click(object sender, EventArgs e)
        {

                //Process.Start("worldserver.conf");

            var worldconf = new Process();
            worldconf.StartInfo.FileName = @"worldserver.conf";
            worldconf.StartInfo.UseShellExecute = true;
            worldconf.Start();
        }
    }
}
