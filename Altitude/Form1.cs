using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Altitude
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InformationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void BuildToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Build ID: 1.0");
        }

        private void WhyTheFuckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This was made because I'm a lazy fuck. \nDiscord: Orochimaru#1337");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string url = "https://amap.alttd.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void AMeadow_Click(object sender, EventArgs e)
        {
            string url = "https://mmap.alttd.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void ASummit_Click(object sender, EventArgs e)
        {
            string url = "https://smap.alttd.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void AValley_Click(object sender, EventArgs e)
        {
            string url = "https://vmap.alttd.com/";
            System.Diagnostics.Process.Start(url);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            label1.Font = new System.Drawing.Font(label1.Font.Name, 24F);
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AVote6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AVote3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AVote2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AVoteButton_Click(object sender, EventArgs e)
        {
            if (aVote1.Checked)
            {
                string url = "https://minecraftservers.org/vote/284208";
                System.Diagnostics.Process.Start(url);
            }
            if (aVote2.Checked)
            {
                string url = "https://topminecraftservers.org/vote/4906";
                System.Diagnostics.Process.Start(url);
            }
            if (aVote3.Checked)
            {
                string url = "https://minecraft-server-list.com/server/298238/vote/";
                System.Diagnostics.Process.Start(url);
            }
            if (aVote4.Checked)
            {
                string url = "https://minecraft-server.net/vote/Altitude/";
                System.Diagnostics.Process.Start(url);
            }
            if (aVote5.Checked)
            {
                string url = "https://www.planetminecraft.com/server/alttd/vote/";
                System.Diagnostics.Process.Start(url);
            }
            if (aVote6.Checked)
            {
                string url = "https://minecraft-mp.com/server/98955/vote/";
                System.Diagnostics.Process.Start(url);
            }
        }

        private void ToolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void aFuckingUselessIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
}
