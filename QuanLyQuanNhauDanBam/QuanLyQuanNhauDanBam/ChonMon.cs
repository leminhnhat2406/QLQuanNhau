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
    public partial class ChonMon : Form
    {
        
        public ChonMon()
        {
            InitializeComponent();
            label5.Text = BanDat.banDangChon.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btChon_Click(object sender, EventArgs e)
        {
            dtgridxuongmon.Rows.Add(numThucAn.Value, cbThucan.Text, 0);
            BanDat.monAn[BanDat.banDangChon - 1].Rows.Add(numThucAn.Value, cbThucan.Text, 0);
        }

        private void btThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void cbThucan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addData()
        {
            
            
        }

        private void btChuyenBan_Click(object sender, EventArgs e)
        {
            addData();
            this.Close();
        }

        private void ChonMon_Load(object sender, EventArgs e)
        {
            foreach(DataRow dr in BanDat.monAn[BanDat.banDangChon - 1].Rows)
            {
                dtgridxuongmon.Rows.Add(dr.ItemArray);
            }
        }
    }
}
