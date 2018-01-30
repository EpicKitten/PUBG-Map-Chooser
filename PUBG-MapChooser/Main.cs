using System;
using System.Diagnostics;
using System.IO;
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
            foreach (var process in Process.GetProcesses())
            {
                if (process.ProcessName == "TslGame")
                {
                    MessageBox.Show("PUBG is running!" + Environment.NewLine + "PUBG does not allow file renames while running." + Environment.NewLine + "Please click ok, close PUBG, and reopen this application", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            if (Properties.Settings.Default.steam_location == "" || Properties.Settings.Default.pubg_map_location == "")
            {
                steamappsSelect();
            }
            pubgmaploc = Properties.Settings.Default.pubg_map_location;
            map_check_UI_update();

        }
        private void map_check_UI_update()
        {
            pubgmaplist = Directory.GetFiles(pubgmaploc);
            foreach (string file in pubgmaplist)
            {
                if (file.Contains("TslGame-WindowsNoEditor_erangel"))
                {
                    if (file.Contains(".pak"))
                    {
                       erangelMapCheck.Checked = true;
                    }
                    if (file.Contains(".pak.disabled"))
                    {
                        erangelMapCheck.Checked = false;
                    }
                }
                if (file.Contains("TslGame-WindowsNoEditor_desert"))
                {
                    if (file.Contains(".pak"))
                    {
                        miramarMapCheck.Checked = true;
                    }
                    if (file.Contains(".pak.disabled"))
                    {
                        miramarMapCheck.Checked = false;
                    }
                }
            }
        }
        private void steamappsSelect()
        {
              MessageBox.Show("Please select the \"steamapps\" folder in the next window", "Select \"steamapps\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
              while (true)
              {
                  Properties.Settings.Default.steam_location = folderSelect();
                  if (Properties.Settings.Default.steam_location.Contains("steamapps"))
                  {
                    if (Directory.Exists(Properties.Settings.Default.steam_location + "\\common"))
                    {
                        if (Directory.Exists(Properties.Settings.Default.steam_location + "\\common\\PUBG"))
                        {
                            if (Directory.Exists(Properties.Settings.Default.steam_location + "\\common\\PUBG\\TslGame\\Content\\Paks"))
                            {
                                steamloc = Properties.Settings.Default.steam_location;
                                pubgmaploc = steamloc + "\\common\\PUBG\\TslGame\\Content\\Paks";
                                Properties.Settings.Default.pubg_map_location = pubgmaploc;
                                Properties.Settings.Default.Save();
                                break;
                            }
                            else
                            {
                                MessageBox.Show("We couldn't find the map files in PUBG!" + Environment.NewLine + "Please verify PUBG in Steam by Right-clicking on PUBG, clicking Properties, clicking the Local Files tab, and then clicking Verify Integrity of Game Files... ", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            DialogResult result = MessageBox.Show("We couldn't find PUBG in steamapps!" + Environment.NewLine + "Please select the \"steamapps\" folder containing PUBG in the next window", "Select \"steamapps\"", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                            if (result == DialogResult.Cancel)
                            {
                                Environment.Exit(0);
                            }
                        }
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("We couldn't find the \"common\" folder in steamapps!" + Environment.NewLine + "Please select the \"steamapps\" folder in the next window", "Select \"steamapps\"", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                        if (result == DialogResult.Cancel)
                        {
                            Environment.Exit(0);
                        }
                    }
                  }
                  else
                  {
                     DialogResult result = MessageBox.Show("Steamapps wasn't selected!" + Environment.NewLine + "Please select the \"steamapps\" folder in the next window", "Select \"steamapps\"", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                     if (result == DialogResult.Cancel)
                     {
                         Environment.Exit(0);
                     }
                  }
              }
        }

        private string folderSelect()
        {
            using (var fbd = new FolderBrowserDialog())
            {
                fbd.Description = @"Select your Steamapps Install folder (usually it's C:\Program Files\Steam\steamapps)";
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Console.WriteLine(fbd.SelectedPath);
                    return fbd.SelectedPath;
                }
                return "";
            }
        }
        private void togglemap_erangel(bool toggle)
        {
            pubgmaplist = Directory.GetFiles(pubgmaploc);
            if (toggle)
            {
                Console.WriteLine("Enabling Erangel...");
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_erangel"))
                    {
                        if (file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak.disabled", ".pak");//enables the files
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Disabling Erangel...");
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_erangel"))
                    {
                        if (!file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak", ".pak.disabled");//disables the files
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
        }
        private void togglemap_miramar(bool toggle)
        {
            pubgmaplist = Directory.GetFiles(pubgmaploc);
            if (toggle)
            {
                Console.WriteLine("Enabling Miramar...");
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_desert"))
                    {
                        if (file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak.disabled", ".pak");//enables the files
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Disabling Miramar...");
                foreach (string file in pubgmaplist)
                {
                    if (file.Contains("TslGame-WindowsNoEditor_desert"))
                    {
                        if (!file.Contains(".pak.disabled"))
                        {
                            string oldname = file;
                            string newname = file.Replace(".pak", ".pak.disabled");//disables the files
                            File.Move(oldname, newname);
                        }
                    }
                }
            }
        }
        private void setMaps_Click(object sender, EventArgs e)
        {
            Console.WriteLine(pubgmaploc);
            pubgmaplist = Directory.GetFiles(pubgmaploc);
            Console.WriteLine("--------- Current List -----------");
            foreach (var item in pubgmaplist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------------------------");
            if (!erangelMapCheck.Checked && !miramarMapCheck.Checked)
            {
                DialogResult bothunchecked = MessageBox.Show("By disabling both maps, PUBG will refuse to join any servers and won't watch any replays" + Environment.NewLine + "Are you sure you want to continue?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (bothunchecked == DialogResult.Yes)
                {
                    togglemap_erangel(erangelMapCheck.Checked);
                    togglemap_miramar(miramarMapCheck.Checked);
                }
            }
            togglemap_erangel(erangelMapCheck.Checked);
            togglemap_miramar(miramarMapCheck.Checked);
            map_check_UI_update();
        }
        private void resetSettings_Click(object sender, EventArgs e)
        {
            DialogResult settingsreset =  MessageBox.Show("This will reset the saved Steam location!" + Environment.NewLine + "Are you sure you want to continue?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (settingsreset == DialogResult.Yes)
            {
                 Properties.Settings.Default.steam_location = "";
                 Properties.Settings.Default.pubg_map_location = "";
                 Properties.Settings.Default.Save();
                 MessageBox.Show("Saved Steam location cleared!", "Settings cleared!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 steamappsSelect();
            }
            map_check_UI_update();
        }
    }
}
