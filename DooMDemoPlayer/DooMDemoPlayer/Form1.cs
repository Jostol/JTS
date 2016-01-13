using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DooMDemoPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_browse_executable_Click(object sender, EventArgs e)
        {
            // Open File Browser - Choose DooM Port.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Executable Files|*.exe";
            openFileDialog1.Title = "Select a DooM Port";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set port textbox to display doom port path
                textbox_port_path.Text  = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void button_browse_pwads_Click(object sender, EventArgs e)
        {
            // Open File
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "PWAD Files|*.wad";
            openFileDialog1.Title = "Select a PWAD";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set pwad textbox to display added pwads
                textbox_pwads.Text += openFileDialog1.InitialDirectory + openFileDialog1.FileName + " ";
            }
        }

        private void button_play_Click(object sender, EventArgs e)
        {
            //Open command prompt, execute commands in commands textbox. /C carries out command
            System.Diagnostics.Process.Start("CMD.exe", "/C " + textbox_commands.Text);
        }

        private void button_select_demo_Click(object sender, EventArgs e)
        {
            // Open File Browser - Choose Demo file
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Demo Files|*.lmp|Demo Files (any)|*.*";
            openFileDialog1.Title = "Select a DooM Demo";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Set demo textbox to display demo path
                textbox_demo_path.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program © 2016 Jostol  \n" +
                            "For DevilutioN \n" +
                            "-------------  \n" +
                            "Icon © 2010 Exhumed \n" +
                            "Part of Mega Games Pack 37 Icons   \n" +
                            "http://www.softicons.com/game-icons/mega-games-pack-37-icons-by-exhumed/doom-collectors-edition-1-icon    \n" +
                            "Released under CC Attribution-Noncommercial-No Derivate 3.0    \n" +
                            "License http://creativecommons.org/licenses/by-nc-nd/3.0/legalcode");
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            try {
                textbox_commands.Text = textbox_port_path.Text + " -iwad " + listBox1.SelectedItem.ToString() + " -file " + textbox_pwads.Text + " -playdemo " + textbox_demo_path.Text;
            } catch { }
        }
    }
}
