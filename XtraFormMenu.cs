using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SQLite;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace APPS
{
    public partial class XtraFormMenu : DevExpress.XtraEditors.XtraForm
    {
        public XtraFormMenu()
        {
            InitializeComponent();

            userMenu.Visible = false;

            automaticUpdater1.ToolStripItem = toolStripUpdate;

            // only load files, etc. when NOT closing to install an update
            if (!automaticUpdater1.ClosingForInstall)
            {
                LoadSettings();
                // load important files, etc.
                // LoadFilesEtc();
            }
        }

        void LoadSettings()
        {

        }

        #region INFO SYSTEM
        [DllImport("kernel32.dll")]

        private static extern long GetVolumeInformation(
            string PathName,
            StringBuilder VolumeNameBuffer,
            UInt32 VolumeNameSize,
            ref UInt32 VolumeSerialNumber,
            ref UInt32 MaximumComponentLength,
            ref UInt32 FileSystemFlags,
            StringBuilder FileSystemNameBuffer,
            UInt32 FileSystemNameSize);

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        static extern int SetProcessWorkingSetSize(IntPtr process, int minimumWorkingSetSize, int maximumWorkingSetSize);
        #endregion

        #region Connection DataBase
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        //private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        #endregion

        #region String
        string hash = "R1Z@RU&D1PP4";

        //Get from Database
        string getVolume = "";
        string getSerial = "";

        //Output From MD5
        string outVolume = "";
        string outSerial = "";

        //Output Disk Information
        string IVolume = "";
        string ISerial = "";
        string IFileS = "";
        string IFlags = "";
        #endregion

        #region MD5
        private void TextDecryt()
        {
            byte[] data1 = Convert.FromBase64String(getVolume);
            byte[] data2 = Convert.FromBase64String(getSerial);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform tranform = tripDes.CreateDecryptor();
                    byte[] results1 = tranform.TransformFinalBlock(data1, 0, data1.Length);
                    byte[] results2 = tranform.TransformFinalBlock(data2, 0, data2.Length);
                    outVolume = UTF8Encoding.UTF8.GetString(results1);
                    outSerial = UTF8Encoding.UTF8.GetString(results2);
                }
            }
        }
        #endregion

        #region Get HIWD
        private void GetInfo()
        {
            string drive_letter = System.IO.Directory.GetCurrentDirectory();
            drive_letter = drive_letter.Substring(0, 1) + ":\\";
            uint serial_number = 0;
            uint max_component_length = 0;
            StringBuilder sb_volume_name = new StringBuilder(256);
            UInt32 file_system_flags = new UInt32();
            StringBuilder sb_file_system_name = new StringBuilder(256);

            if (GetVolumeInformation(drive_letter, sb_volume_name,
                (UInt32)sb_volume_name.Capacity, ref serial_number,
                ref max_component_length, ref file_system_flags,
                sb_file_system_name,
                (UInt32)sb_file_system_name.Capacity) == 0)
            {
                MessageBox.Show(this, "Kesalahan mendapatkan informasi volume" + Environment.NewLine + "Disk tidak ditemukan", "PEMBERITAHUAN", MessageBoxButtons.OK);
            }
            else
            {
                IVolume = sb_volume_name.ToString();
                ISerial = serial_number.ToString();
                IFileS = sb_file_system_name.ToString();
                IFlags = "&&H" + file_system_flags.ToString("x");
            }
        }
        #endregion

        #region Load DataBase
        private void loadDB()
        {

            string drive_letter = Directory.GetCurrentDirectory();
            drive_letter = drive_letter.Substring(0, 1) + ":\\";
            string[] files = Directory.GetFiles(drive_letter, "server.db", SearchOption.AllDirectories);
            foreach (string s in files)
            {
                sql_con = new SQLiteConnection("Data Source=" + s + ";Version=3;New=False;Compress=true;");
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();

                SQLiteDataReader dr;
                sql_cmd.CommandText = "SELECT * FROM USB_DEVICE";
                dr = sql_cmd.ExecuteReader();
                while (dr.Read())
                {
                    getVolume = dr["VolumeName"].ToString();
                    getSerial = dr["SerialNumber"].ToString();
                }
                dr.Close();
                dr.Dispose();
            }
        }
        #endregion













        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void XtraFormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void ToolStripTim_Click(object sender, EventArgs e)
        {
            XtraFormTim tp = XtraFormTim.GETINSTANE();
            tp.Show();
        }

        private void XtraFormMenu_Load(object sender, EventArgs e)
        {
            Thread.Sleep(8000);

            radMenuWeb1.Click += new EventHandler(RadMenuWeb1_Click);
            radMenuIG2.Click += new EventHandler(RadMenuIG2_Click);
            radMenuYT3.Click += new EventHandler(RadMenuYT3_Click);
            radMenuTips1.Click += new EventHandler(RadMenuTips1_Click);
            radMenuTips2.Click += new EventHandler(RadMenuTips2_Click);
            radMenuTips3.Click += new EventHandler(RadMenuTips3_Click);
            radMenuTips4.Click += new EventHandler(RadMenuTips4_Click);

            try
            {
                GetInfo();
                loadDB();
                TextDecryt();
                //Matching Drive Information = Data Server
                if (IVolume == outVolume && ISerial == outSerial)
                {
                    userMenu.Visible = true;
                }
                else
                {
                    if (MessageBox.Show("Tidak Dapat Masuk", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message + Environment.NewLine + "Belum Teraktivasi", "Notifikasi", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void ToolStripHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IT Support : +62 813-8788-4041" + Environment.NewLine + "Customer Service: +62 877-8078-7979");
        }

        private void ToolStripOffi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextOfficial.Show(Cursor.Position);
            }
        }

        void RadMenuTips1_Click(object sender, EventArgs e)
        {
            //Shell Word
            Process.Start(Application.StartupPath + @"/tips/tips-1.mp4");
        }

        void RadMenuTips2_Click(object sender, EventArgs e)
        {
            //Shell Word
            Process.Start(Application.StartupPath + @"/tips/tips-2.mp4");
        }

        void RadMenuTips3_Click(object sender, EventArgs e)
        {
            //Shell Word
            Process.Start(Application.StartupPath + @"/tips/tips-3.mp4");
        }

        void RadMenuTips4_Click(object sender, EventArgs e)
        {
            //Shell Word
            Process.Start(Application.StartupPath + @"/tips/tips-4.mp4");
        }

        void RadMenuWeb1_Click(object sender, EventArgs e)
        {
            
            Process.Start("http://sahabatalter.com/");
        } 

        void RadMenuIG2_Click(object sender, EventArgs e)
        {
            
            Process.Start("https://www.instagram.com/alter.indonesia/?hl=id");
        }

        void RadMenuYT3_Click(object sender, EventArgs e)
        {
            
            Process.Start("https://www.youtube.com/channel/UCM9hWNlML85TMnOWkhhkgsA");
        }

        private void ToolStripTips_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextTrick.Show(Cursor.Position);
            }
        }

        private void AutomaticUpdater1_ClosingAborted(object sender, EventArgs e)
        {
            LoadSettings();
        }
    }
}