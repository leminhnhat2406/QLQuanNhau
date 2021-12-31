namespace QuanLyQuanNhauDanBam
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblogin = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbpass = new System.Windows.Forms.Label();
            this.btDangNhap = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(377, 105);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(137, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // lblogin
            // 
            this.lblogin.AutoSize = true;
            this.lblogin.BackColor = System.Drawing.Color.Transparent;
            this.lblogin.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblogin.Location = new System.Drawing.Point(266, 103);
            this.lblogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblogin.Name = "lblogin";
            this.lblogin.Size = new System.Drawing.Size(112, 19);
            this.lblogin.TabIndex = 0;
            this.lblogin.Text = "Tên đăng nhập:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(377, 140);
            this.txtPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(137, 20);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lbpass
            // 
            this.lbpass.AutoSize = true;
            this.lbpass.BackColor = System.Drawing.Color.Transparent;
            this.lbpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbpass.Location = new System.Drawing.Point(297, 138);
            this.lbpass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbpass.Name = "lbpass";
            this.lbpass.Size = new System.Drawing.Size(80, 19);
            this.lbpass.TabIndex = 1;
            this.lbpass.Text = "Mật khẩu:";
            // 
            // btDangNhap
            // 
            this.btDangNhap.BackColor = System.Drawing.Color.Green;
            this.btDangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangNhap.ForeColor = System.Drawing.Color.Lavender;
            this.btDangNhap.Location = new System.Drawing.Point(323, 185);
            this.btDangNhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btDangNhap.Name = "btDangNhap";
            this.btDangNhap.Size = new System.Drawing.Size(92, 29);
            this.btDangNhap.TabIndex = 2;
            this.btDangNhap.Text = "Đăng Nhập";
            this.btDangNhap.UseVisualStyleBackColor = false;
            this.btDangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btExit.Location = new System.Drawing.Point(446, 185);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(68, 29);
            this.btExit.TabIndex = 3;
            this.btExit.Text = "Thoát";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyQuanNhauDanBam.Properties.Resources.quan_nhau_danbam_trong_Itaewon_Class;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(596, 397);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.lblogin);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.lbpass);
            this.Controls.Add(this.btDangNhap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbpass;
        private System.Windows.Forms.Button btDangNhap;
        private System.Windows.Forms.Button btExit;
    }
}

