using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanNhauDanBam
{
    public partial class fManage : Form
    {
        public fManage()
        {
            InitializeComponent();
            BanDat.init();
        }

        private void fManage_Load(object sender, EventArgs e)
        {
            ban1.Click += ban_Click;
            ban2.Click += ban_Click;
            ban3.Click += ban_Click;
            ban4.Click += ban_Click;
            ban5.Click += ban_Click;
            ban6.Click += ban_Click;
            ban7.Click += ban_Click;
            ban8.Click += ban_Click;
            ban9.Click += ban_Click;

           for(int i = 0; i < BanDat.trangThaiBan.Length; i++)
            {
                BanDat.trangThaiBan[i] = false;
            }
            refresh();

        }

        private void ban_Click(object sender, EventArgs e)
        {
            PictureBox ban = (PictureBox)sender;

            switch (ban.Name)
            {
                case "ban1":
                    BanDat.banDangChon = 1;
                    break;
                case "ban2":
                    BanDat.banDangChon = 2;
                    break;
                case "ban3":
                    BanDat.banDangChon = 3;
                    break;
                case "ban4":
                    BanDat.banDangChon = 4;
                    break;
                case "ban5":
                    BanDat.banDangChon = 5;
                    break;
                case "ban6":
                    BanDat.banDangChon = 6;
                    break;
                case "ban7":
                    BanDat.banDangChon = 7;
                    break;
                case "ban8":
                    BanDat.banDangChon = 8;
                    break;
                case "ban9":
                    BanDat.banDangChon = 9;
                    break;
            }

            ChonMon cm = new ChonMon();
            cm.ShowDialog();
            refresh();
        }

        private void refresh()
        {
            foreach (Control control in panel2.Controls)
            {
                if (control is PictureBox)
                {
                    int chiSo = Convert.ToInt32(control.Name.Substring(3, 1)) - 1;
                    if (BanDat.monAn[chiSo].Rows.Count <= 0)
                    {
                        control.BackgroundImage = Properties.Resources.icon_icons_com_75956;
                    }
                    else
                    {
                        control.BackgroundImage = Properties.Resources.anh_background_cuc_dep_110341116;
                    }
                }
            }
        }
    }


}
