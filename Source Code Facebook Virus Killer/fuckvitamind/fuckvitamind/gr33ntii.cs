/**
Facebook Virus auto spam ???? Oh shit I created this nigga to remove it xd
Source by Gr33ntii hello world
**/
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using IWshRuntimeLibrary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Diagnostics;
using System.IO;

namespace fuckvitamind
{
    public partial class gr33ntii : Form
    {
        private object directory;

        public gr33ntii()
        {
            InitializeComponent();
        }

        private void gr33ntii_Load(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("worker"))
            {
                process.Kill();
            }
            {
                object direction = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref direction) + @"\Google Chrome.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "Google Chrome";
                shortcut.WorkingDirectory = @"C:\Program Files (x86)\Google\Chrome\Application";
                shortcut.TargetPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                shortcut.Save();
            }

            {
                //"C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Google Chrome.lnk"
                WshShell shell = new WshShell();
                string shortcutAddress = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Internet Explorer\\Quick Launch\\User Pinned\\TaskBar\\Google Chrome.lnk";
                IWshShortcut x = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                x.Description = "Google Chrome";
                x.WorkingDirectory = @"C:\Program Files (x86)\Google\Chrome\Application";
                x.TargetPath = @"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe";
                x.Save();
            }


            ed1th0st();
            Gr33ntii();

        }

        private void Gr33ntii()
        {
            if (System.IO.File.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\" + Environment.UserName + "\\worker.exe"))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\" + Environment.UserName); //biết được folder lạ thì cứ xóa thẳng cổ nó là xong -.- sao lắm người cứ thích code dài vậy ta
                try
                {
                    di.Delete(true);
                }

                catch (System.IO.IOException e)

                {

                }
                //Pr0c3ssH3lp3r.Pr0c3ssH3lp3r ph = new Pr0c3ssH3lp3r.Pr0c3ssH3lp3r();
                //ph.KillThisProcess("worker", "pcname\machinename", 12);
            }
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                  ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (rk.GetValue("Google Updater", null) == null)
            {
                MessageBox.Show("Máy của bạn không bị nhiễm Virus\nNhưng vẫn sẽ giúp đỡ bạn một phần nào đó",
                    "Thông báo");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Virus sẽ được xóa ngay bây giờ",
                "Thông báo");
                rk.DeleteValue("Google Updater"); //sure vcl là thằng này :))) Chrome chưa bao giờ có cái gì gọi là :Google Updater:
            }
        }

        private void ed1th0st()
        {
            string texttowrite = "\n127.0.0.1         oheloke.yezav.bid plugin.oheloke.yezav.bid yezav.bid plugin.divay.ikaci.bid divay.ikaci.bid ikaci.bid plugin.udadedi.ikaci.bid udadedi.ikaci.bid";
            string text = System.IO.File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"), Encoding.UTF8);
            if (!text.Contains(texttowrite))
            {
                using (StreamWriter w = System.IO.File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
                {
                    w.WriteLine(texttowrite);
                }
            }
        }
    }
}