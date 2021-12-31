namespace QuanLyQuanNhauDanBam
{
    partial class ChonMon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbThucan = new System.Windows.Forms.ComboBox();
            this.numThucAn = new System.Windows.Forms.NumericUpDown();
            this.numThucuong = new System.Windows.Forms.NumericUpDown();
            this.cbNuocuong = new System.Windows.Forms.ComboBox();
            this.dtgridxuongmon = new System.Windows.Forms.DataGridView();
            this.ColSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenmon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btChuyenBan = new System.Windows.Forms.Button();
            this.btThanhToan = new System.Windows.Forms.Button();
            this.btChon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numThucAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridxuongmon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cbThucan);
            this.panel1.Controls.Add(this.numThucAn);
            this.panel1.Controls.Add(this.numThucuong);
            this.panel1.Controls.Add(this.cbNuocuong);
            this.panel1.Location = new System.Drawing.Point(92, 31);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 81);
            this.panel1.TabIndex = 26;
            // 
            // cbThucan
            // 
            this.cbThucan.FormattingEnabled = true;
            this.cbThucan.Items.AddRange(new object[] {
            "Ếch núp lùm",
            "Mỳ xào hải sản",
            "Bá quan nướng",
            "Lẩu bò",
            "Cơm chiên hải sản",
            "Vú dê nướng",
            "Cá riêu hồng chiên xù"});
            this.cbThucan.Location = new System.Drawing.Point(14, 8);
            this.cbThucan.Margin = new System.Windows.Forms.Padding(2);
            this.cbThucan.Name = "cbThucan";
            this.cbThucan.Size = new System.Drawing.Size(180, 21);
            this.cbThucan.TabIndex = 1;
            this.cbThucan.SelectedIndexChanged += new System.EventHandler(this.cbThucan_SelectedIndexChanged);
            // 
            // numThucAn
            // 
            this.numThucAn.Location = new System.Drawing.Point(197, 10);
            this.numThucAn.Margin = new System.Windows.Forms.Padding(2);
            this.numThucAn.Name = "numThucAn";
            this.numThucAn.Size = new System.Drawing.Size(38, 20);
            this.numThucAn.TabIndex = 16;
            // 
            // numThucuong
            // 
            this.numThucuong.Location = new System.Drawing.Point(196, 47);
            this.numThucuong.Margin = new System.Windows.Forms.Padding(2);
            this.numThucuong.Name = "numThucuong";
            this.numThucuong.Size = new System.Drawing.Size(38, 20);
            this.numThucuong.TabIndex = 17;
            // 
            // cbNuocuong
            // 
            this.cbNuocuong.FormattingEnabled = true;
            this.cbNuocuong.Items.AddRange(new object[] {
            "Heneiken",
            "Rượu SOJU",
            "Tiger Bạc",
            "Tiger Nâu",
            "Sài Gòn Đỏ",
            "Bia 333"});
            this.cbNuocuong.Location = new System.Drawing.Point(12, 45);
            this.cbNuocuong.Margin = new System.Windows.Forms.Padding(2);
            this.cbNuocuong.Name = "cbNuocuong";
            this.cbNuocuong.Size = new System.Drawing.Size(180, 21);
            this.cbNuocuong.TabIndex = 3;
            // 
            // dtgridxuongmon
            // 
            this.dtgridxuongmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgridxuongmon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSoluong,
            this.ColTenmon,
            this.ColDonGia});
            this.dtgridxuongmon.Location = new System.Drawing.Point(11, 116);
            this.dtgridxuongmon.Margin = new System.Windows.Forms.Padding(2);
            this.dtgridxuongmon.Name = "dtgridxuongmon";
            this.dtgridxuongmon.RowTemplate.Height = 24;
            this.dtgridxuongmon.Size = new System.Drawing.Size(403, 330);
            this.dtgridxuongmon.TabIndex = 25;
            // 
            // ColSoluong
            // 
            this.ColSoluong.HeaderText = "SL";
            this.ColSoluong.Name = "ColSoluong";
            this.ColSoluong.ReadOnly = true;
            this.ColSoluong.Width = 50;
            // 
            // ColTenmon
            // 
            this.ColTenmon.HeaderText = "Tên món";
            this.ColTenmon.Name = "ColTenmon";
            this.ColTenmon.ReadOnly = true;
            this.ColTenmon.Width = 158;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(10, 116);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(404, 330);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btChuyenBan
            // 
            this.btChuyenBan.BackColor = System.Drawing.Color.Red;
            this.btChuyenBan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChuyenBan.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.btChuyenBan.Location = new System.Drawing.Point(156, 462);
            this.btChuyenBan.Margin = new System.Windows.Forms.Padding(2);
            this.btChuyenBan.Name = "btChuyenBan";
            this.btChuyenBan.Size = new System.Drawing.Size(105, 43);
            this.btChuyenBan.TabIndex = 23;
            this.btChuyenBan.Text = "Đặt Món";
            this.btChuyenBan.UseVisualStyleBackColor = false;
            this.btChuyenBan.Click += new System.EventHandler(this.btChuyenBan_Click);
            // 
            // btThanhToan
            // 
            this.btThanhToan.BackColor = System.Drawing.Color.Green;
            this.btThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThanhToan.ForeColor = System.Drawing.Color.GhostWhite;
            this.btThanhToan.Location = new System.Drawing.Point(10, 462);
            this.btThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.btThanhToan.Name = "btThanhToan";
            this.btThanhToan.Size = new System.Drawing.Size(86, 43);
            this.btThanhToan.TabIndex = 22;
            this.btThanhToan.Text = "Yêu cầu thanh toán";
            this.btThanhToan.UseVisualStyleBackColor = false;
            this.btThanhToan.Click += new System.EventHandler(this.btThanhToan_Click);
            // 
            // btChon
            // 
            this.btChon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChon.Location = new System.Drawing.Point(350, 31);
            this.btChon.Margin = new System.Windows.Forms.Padding(2);
            this.btChon.Name = "btChon";
            this.btChon.Size = new System.Drawing.Size(64, 30);
            this.btChon.TabIndex = 21;
            this.btChon.Text = "Chọn";
            this.btChon.UseVisualStyleBackColor = true;
            this.btChon.Click += new System.EventHandler(this.btChon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(284, -33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thức Ăn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Số Bàn :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Thức ăn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Nước Uống";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "label5";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button1.Location = new System.Drawing.Point(309, 462);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 43);
            this.button1.TabIndex = 32;
            this.button1.Text = "Quay Đầu là híp hóp";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ChonMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgridxuongmon);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btChuyenBan);
            this.Controls.Add(this.btThanhToan);
            this.Controls.Add(this.btChon);
            this.Controls.Add(this.label1);
            this.Name = "ChonMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChonMon";
            this.Load += new System.EventHandler(this.ChonMon_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numThucAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numThucuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgridxuongmon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbThucan;
        private System.Windows.Forms.NumericUpDown numThucAn;
        private System.Windows.Forms.NumericUpDown numThucuong;
        private System.Windows.Forms.ComboBox cbNuocuong;
        private System.Windows.Forms.DataGridView dtgridxuongmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenmon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btChuyenBan;
        private System.Windows.Forms.Button btThanhToan;
        private System.Windows.Forms.Button btChon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}