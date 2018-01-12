using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace PUBG_MapChooser
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public string steamloc = "";
        public string pubgmaploc = "";
        public string[] pubgmaplist = { };
        private void Main_Load(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = @"Select your Steamapps Install folder where PUBG is installed (usually it's C:\Program Files\Steam\steamapps)";
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    steamloc = fbd.SelectedPath;
                    Console.WriteLine(steamloc);
                    if (steamloc == string.Empty)
                    {
                        MessageBox.Show("Steam wasen't selected!", "Error!");
                        Application.Exit();
                    }
                    if (Directory.Exists(steamloc + "\\common"))
                    {
                        if (Directory.Exists(steamloc + "\\common\\PUBG"))
                        {
                            if (Directory.Exists(steamloc + "\\common\\PUBG\\TslGame\\Content\\Paks"))
                            {
                                pubgmaploc = steamloc + "\\common\\PUBG\\TslGame\\Content\\Paks";
                                Console.WriteLine(pubgmaploc);
                            }
                        }
                        else
                        {
                            MessageBox.Show("PUBG not installed!", "Error!");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Steam Corrupt!", "Error!");
                        Application.Exit();
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
            
        }
        private void CheckChange()
        {
            if (!(erangelMapCheck.Checked && miramarMapCheck.Checked))
            {
                MessageBox.Show("By disabling both maps, PUBG will refuse to join any servers and won't watch any replays", "Caution!", MessageBoxButtons.OK);
            }
        }
        private void setMaps_Click(object sender, EventArgs e)
        {
            pubgmaplist = Directory.GetFiles(pubgmaploc);
            if (erangelMapCheck.Checked)
            {
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_erangel"))
                    {
                        if (file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak.disabled", ".pak");
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
            if (!erangelMapCheck.Checked)
            {
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_erangel"))
                    {
                        if (!file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak", ".pak.disabled");
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
            if (miramarMapCheck.Checked)
            {
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_desert"))
                    {
                        if (file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak.disabled", ".pak");
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
            if (!miramarMapCheck.Checked)
            {
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_desert"))
                    {
                        if (!file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak", ".pak.disabled");
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
        }
    }
}
