using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace m3u8wmsAuthSignUpdater
{
    public partial class Form1 : Form
    {
        string OldPlayList = "Set path to m3u8 playlist!";      
        string DefaultPath = "Set url to html source! ";
        string strExpireTime;
        string httpDownload = Path.GetTempPath() + "\\httpDownload";
        string strAuthsignPath; 
        string AppDirectorySettings = AppDomain.CurrentDomain.BaseDirectory + "\\Settings.ini";
        string[] Settingslines = new string[3];
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
            settingsCheck();
            tmrFadeIn.Start();
        }
        void settingsCheck()
        {
            if (File.Exists(AppDirectorySettings))
            {
                Settingslines = File.ReadAllLines(AppDirectorySettings);
                DefaultPath = Settingslines[0];
                OldPlayList = Settingslines[1];
                strExpireTime = Settingslines[2];
            }
            else if (!File.Exists(AppDirectorySettings))
            {
                Settingslines[0] = DefaultPath;
                Settingslines[1] = OldPlayList;
                Settingslines[2] = "Data not available!";
                File.WriteAllLines(AppDirectorySettings, Settingslines);
            }
            lblGuide66Path.Text = DefaultPath;
            lblm3u8Path.Text = OldPlayList;
        }
        
        
        void downloadFile()
        {
            using (WebClient client = new WebClient()) 
            {
                client.DownloadFile(DefaultPath, httpDownload);
            }
            DateTime currentTime = DateTime.Now;
            DateTime xMinutesLater = currentTime.AddMinutes(360);
            strExpireTime = string.Format("{0}", xMinutesLater);
            Settingslines[2] = strExpireTime;
            File.WriteAllLines(AppDirectorySettings, Settingslines);
        }
        void kodiForceClose()
        {
            foreach (var process in Process.GetProcessesByName("Kodi"))
            {
                process.Kill();
            }
        }
        void openKodi()
        {
            string KodiLocation;
            string KodiStartx86 = @"C:\Program Files (x86)\Kodi\kodi.exe";
            string KodiStart = @"C:\Program Files\Kodi\kodi.exe";
            if (File.Exists(KodiStartx86))
            {
                KodiLocation = KodiStartx86;
            }
            else 
            {
                KodiLocation = KodiStart;
            }
            ProcessStartInfo kodiopen = new ProcessStartInfo(KodiLocation);
            Process.Start(kodiopen);
        }
        void getAuthSign()
        {
            string httpContent = File.ReadAllText(httpDownload);
            var result = Regex.Match(httpContent, "wmsAuthSign=(.*)");
            string strResult = result.ToString();
            //strResult = strResult.Remove(strResult.Length - 3);////TESTING
            strAuthsignPath = strResult;
        }
        void getOldAuthSign()
        {
            string Replacement = strAuthsignPath;
            string FromOldPlaylist = File.ReadAllText(OldPlayList);
            var regOldPlayList = Regex.Match(FromOldPlaylist, "wmsAuthSign=(.*)");
            string strOldAuthSign = regOldPlayList.ToString();
            var Replaced = Regex.Replace(FromOldPlaylist, strOldAuthSign, Replacement);
            File.WriteAllText(OldPlayList, Replaced);
        }
        void cleanUp()
        {
            File.Delete(httpDownload);
        }
        private void btnSetHtml_Click(object sender, EventArgs e)
        {
            txtNewPath.Visible = !txtNewPath.Visible;
            lblGuide66Path.Visible = !lblGuide66Path.Visible;
            btnSetPath.Enabled = !btnSetPath.Enabled;
        }
        private void btnSetPath_Click(object sender, EventArgs e)
        {   
            lblGuide66Path.Text = txtNewPath.Text;
            DefaultPath = txtNewPath.Text;
            Settingslines[0] = DefaultPath;
            File.WriteAllLines(AppDirectorySettings, Settingslines);
            txtNewPath.Visible = !txtNewPath.Visible;
            lblGuide66Path.Visible = !lblGuide66Path.Visible;
            btnSetPath.Enabled = !btnSetPath.Enabled;
            lblStatusInfo.Text = "html source is set....";
            lblStatusInfo.Refresh();
            Thread.Sleep(2000);
            lblStatusInfo.Text = "";
        }
        private void btnChangePathm3u8_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}",
                DefaultExt = "m3u8",
                Filter = "m3u8 files (*.m3u8)|*.m3u8|All Files (*.*)|*.*",
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblm3u8Path.Text = openFileDialog1.FileName;
                OldPlayList = lblm3u8Path.Text;
                btnSetm3u8.Enabled = !btnSetm3u8.Enabled;
            }
        }
        private void btnSetm3u8_Click(object sender, EventArgs e)
        {
            Settingslines[1] = OldPlayList;
            File.WriteAllLines(AppDirectorySettings, Settingslines);
            btnSetm3u8.Enabled = !btnSetm3u8.Enabled;
            lblStatusInfo.Text = "Path to m3u8 playlist is set....";
            lblStatusInfo.Refresh();
            Thread.Sleep(2000);
            lblStatusInfo.Text = "";
        }
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!File.Exists(OldPlayList))
            {
                lblStatusInfo.Text = "Path to .m3u8 not set!";
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";
            }
            else if (!Settingslines[0].Contains("http"))
            {
                lblStatusInfo.Text = "Html url not set!";
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";
            }
            else
            {
                lblStatusInfo.Text = "Closing Kodi Media Center....";
                sleep();
                kodiForceClose();
                lblStatusInfo.Text = "Downloading HTML From HTTP Source....";
                sleep();
                downloadFile();
                lblStatusInfo.Text = "Parsing wmsAuthSign From HTML Code....";
                sleep();
                getAuthSign();
                lblStatusInfo.Text = "Updating .m3u8 File with new wmsAuthSign....";
                sleep();
                getOldAuthSign();
                lblStatusInfo.Text = "Cleaning Temporary Files....";
                sleep();
                cleanUp();
                lblStatusInfo.Text = "Opening Kodi Media Center....";
                sleep();
                openKodi();
                lblStatusInfo.Text = "GoodBye!";
                sleep();
                tmeFadeOut.Start();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            tmeFadeOut.Start();
        }
        void sleep()
        {
            lblStatusInfo.Refresh();
            Thread.Sleep(1000);
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity != 1.0)
            {
                this.Opacity += 0.1;
            }
            else
            {
                tmrFadeIn.Stop();
            }
        }

        private void tmeFadeOut_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.001)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                tmeFadeOut.Stop();
                this.Close();
            }
        }

        private void btnShowM3u8_Click(object sender, EventArgs e)/////////
        {
            if (File.Exists(OldPlayList))
            {
                Process.Start("notepad.exe", OldPlayList);
            }
            else
            {
                lblStatusInfo.Text = "Path to .m3u8 not set!";
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";
            }
        }

        private void btnHtmlTest_Click(object sender, EventArgs e)
        {
            if (Settingslines[0].Contains("http"))
            {
                Process.Start(Settingslines[0]);
            }
            else
            {
                lblStatusInfo.Text = "Html url not set!";
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";

            }
        }
       
        private void wmsExpire_Click(object sender, EventArgs e)
        {
            if (Settingslines[2] == "Data not available!")
            {
                lblStatusInfo.Text = Settingslines[2];
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";
            }
            else
            {
                lblStatusInfo.Text = "Expires: " + strExpireTime;
                lblStatusInfo.Refresh();
                Thread.Sleep(2000);
                lblStatusInfo.Text = " ";
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
    

