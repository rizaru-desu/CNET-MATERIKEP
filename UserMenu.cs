using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace APPS
{
    public partial class UserMenu : UserControl
    {
        public static string path = "";
        public static string tittleForm = "";
        public static string tabledata = "";

        public UserMenu()
        {
            InitializeComponent();
            radMenuBedah1.Click += new EventHandler(RadMenuBedah1_Click);
            radMenuBedah2.Click += new EventHandler(RadMenuBedah2_Click);
        }

        private void RadMenuBedah2_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KMB2.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RadMenuBedah1_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KMB.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Kesehatan_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"/component/ebook/k-k.pdf");
        }

        private void Btn_SOP_Click(object sender, EventArgs e)
        {
            tabledata = "SELECT * FROM table_sop";
            XtraFormData xfd = XtraFormData.GETINSTANE();
            xfd.Show();
        }

        private void Btn_Ebook_Click(object sender, EventArgs e)
        {
            tabledata = "SELECT * FROM table_ebook";
            XtraFormData xfd = XtraFormData.GETINSTANE();
            xfd.Show();
        }

        private void Btn_Jurnal_Click(object sender, EventArgs e)
        {
            tabledata = "SELECT * FROM table_jurnal";
            XtraFormData xfd = XtraFormData.GETINSTANE();
            xfd.Show();
        }

        private void Btn_bedah_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                radContextBedah.Show(Cursor.Position);
            }
        }

        private void Btn_Biomedik_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "BIO.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Konsep_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KDK.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Jiwa_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "JIWA.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Kegawat_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "GDR.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Gerontik_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "GRNK.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Manajemen_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "MK.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Anak_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KPAK.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Maternitas_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "MTRS.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_kdm_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KDM.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Komunitas_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "KNK.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Mikro_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "MKGI.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Ukom_Click(object sender, EventArgs e)
        {
            try
            {
                splashScreenManager1.ShowWaitForm();
                for (int i = 0; i < 100; i++)
                {
                    Thread.Sleep(100);
                }
                path = "Ukom1.dll.swf";
                XtraFormFlash c = XtraFormFlash.GETINSTANE();
                c.Show();
                splashScreenManager1.CloseWaitForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
