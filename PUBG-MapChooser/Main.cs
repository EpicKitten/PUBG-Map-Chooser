using Microsoft.Win32;
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
        public string pubgmaploc = "";
        public string[] pubgmaplist = { };

        private void Main_Load(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcesses())//For each process in the process list...
            {
                if (process.ProcessName == "TslGame")//..is the process called TslGame? (Pubg)
                {
                    MessageBox.Show("PUBG is running!" + Environment.NewLine + "PUBG does not allow file renames while running." + Environment.NewLine + "Please click ok, close PUBG, and reopen this application", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(0);
                }
            }
            PUBG_Locations();

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

        private void PUBG_Locations()
        {
            if (Properties.Settings.Default.pubg_map_location == "" || !Properties.Settings.Default.pubg_map_location.Contains("PUBG"))
            {
                try
                {
                    using (RegistryKey regkey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Uninstall\\Steam App 578080"))
                    {
                        if (regkey != null)
                        {
                            string pubgregloc = (string)regkey.GetValue("InstallLocation");
                            if (pubgregloc != null && pubgregloc.Contains("PUBG"))
                            {
                                Console.WriteLine("PUBG location from registry: " + pubgregloc);
                                Console.WriteLine("Saving location to Properties...");
                                Properties.Settings.Default.pubg_location = pubgregloc;
                                Properties.Settings.Default.pubg_map_location = Properties.Settings.Default.pubg_location + "\\TslGame\\Content\\Paks";
                                Properties.Settings.Default.Save();
                                Console.WriteLine("Saved location to Properties!");
                                pubgmaploc = Properties.Settings.Default.pubg_map_location;
                            }
                            if (pubgregloc == null)
                            {
                                pubgSelect();
                            }
                        }
                        if (regkey == null)
                        {
                            pubgSelect();
                        }
                    }
                }
                catch (Exception ex)
                {
                    pubgSelect();
                }
            }
        }

        private void pubgSelect()
        {
            MessageBox.Show("PUBG location could not be found in the registry!"+Environment.NewLine+"Please select the \"PUBG\" folder in the next window", "Select \"PUBG\"", MessageBoxButtons.OK, MessageBoxIcon.Information);
            while (true)
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    fbd.Description = @"Select your Steamapps Install folder (usually it's C:\Program Files\Steam\steamapps)";
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Console.WriteLine("\""+fbd.SelectedPath + "\" was selected!");
                        if (Directory.Exists(fbd.SelectedPath + "\\common\\PUBG\\TslGame\\Content\\Paks"))
                        {
                            Properties.Settings.Default.pubg_location = fbd.SelectedPath;
                            pubgmaploc = Properties.Settings.Default.pubg_location + "\\TslGame\\Content\\Paks";
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
                }
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
            DialogResult settingsreset =  MessageBox.Show("This will reset the saved PUBG location!" + Environment.NewLine + "Are you sure you want to continue?", "Caution!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (settingsreset == DialogResult.Yes)
            {
                 Properties.Settings.Default.pubg_location = "";
                 Properties.Settings.Default.pubg_map_location = "";
                 Properties.Settings.Default.Save();
                 MessageBox.Show("Saved PUBG location cleared!", "Settings cleared!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PUBG_Locations();
            }
            map_check_UI_update();
        }
    }
}
