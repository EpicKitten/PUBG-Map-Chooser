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
            Properties.Settings.Default.steam_location = "";
            Properties.Settings.Default.pubg_map_location = "";
            Properties.Settings.Default.Save();
            if (Properties.Settings.Default.steam_location == string.Empty)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = @"Select your Steamapps Install folder where PUBG is installed (usually it's C:\Program Files\Steam\steamapps)";
                    DialogResult result = fbd.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        Console.WriteLine(fbd.SelectedPath);
                        if (fbd.SelectedPath == string.Empty)
                        {
                            MessageBox.Show("Steam wasen't selected!", "Error!");
                            Application.Exit();
                        }
                        if (Directory.Exists(fbd.SelectedPath + "\\common"))
                        {
                            if (Directory.Exists(fbd.SelectedPath + "\\common\\PUBG"))
                            {
                                if (Directory.Exists(fbd.SelectedPath + "\\common\\PUBG\\TslGame\\Content\\Paks"))
                                {
                                    pubgmaploc = steamloc + "\\common\\PUBG\\TslGame\\Content\\Paks";
                                    steamloc = fbd.SelectedPath;
                                    Properties.Settings.Default.steam_location = steamloc;
                                    Properties.Settings.Default.pubg_map_location = steamloc + pubgmaploc;
                                    Properties.Settings.Default.Save();
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
            steamloc = Properties.Settings.Default.steam_location;
            pubgmaploc = Properties.Settings.Default.pubg_map_location;
            Console.WriteLine(steamloc);
            Console.WriteLine(pubgmaploc);
        }
        private void CheckChange()
        {
            if (!(erangelMapCheck.Checked && miramarMapCheck.Checked))
            {
                MessageBox.Show("By disabling both maps, PUBG will refuse to join any servers and won't watch any replays", "Caution!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void resetSettings_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.steam_location = "";
            Properties.Settings.Default.pubg_map_location = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("Settings Cleared!", "Closing app!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Application.Exit();
        }
    }
}
