namespace QLBH
{
    partial class MENU
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
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnKienTra = new System.Windows.Forms.Button();
            this.btnThanhToanHD = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbltk = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnKTHDBH = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Location = new System.Drawing.Point(80, 52);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 23);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập Hàng";
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnKienTra
            // 
            this.btnKienTra.Location = new System.Drawing.Point(41, 98);
            this.btnKienTra.Name = "btnKienTra";
            this.btnKienTra.Size = new System.Drawing.Size(154, 29);
            this.btnKienTra.TabIndex = 1;
            this.btnKienTra.Text = "Kiểm Tra Hàng Hóa HIện Có";
            this.btnKienTra.UseVisualStyleBackColor = true;
            this.btnKienTra.Click += new System.EventHandler(this.btnKienTra_Click);
            // 
            // btnThanhToanHD
            // 
            this.btnThanhToanHD.Location = new System.Drawing.Point(28, 150);
            this.btnThanhToanHD.Name = "btnThanhToanHD";
            this.btnThanhToanHD.Size = new System.Drawing.Size(185, 23);
            this.btnThanhToanHD.TabIndex = 2;
            this.btnThanhToanHD.Text = "Thanh toán hóa đơn nhập hàng";
            this.btnThanhToanHD.UseVisualStyleBackColor = true;
            this.btnThanhToanHD.Click += new System.EventHandler(this.btnThanhToanHD_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(80, 192);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Bán Hàng";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbltk
            // 
            this.lbltk.AutoSize = true;
            this.lbltk.Location = new System.Drawing.Point(1, 0);
            this.lbltk.Name = "lbltk";
            this.lbltk.Size = new System.Drawing.Size(32, 13);
            this.lbltk.TabIndex = 4;
            this.lbltk.Text = "User:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(13, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "a";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(80, 275);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnKTHDBH
            // 
            this.btnKTHDBH.Location = new System.Drawing.Point(28, 235);
            this.btnKTHDBH.Name = "btnKTHDBH";
            this.btnKTHDBH.Size = new System.Drawing.Size(185, 23);
            this.btnKTHDBH.TabIndex = 4;
            this.btnKTHDBH.Text = "Kiểm tra hóa đơn bán hàng";
            this.btnKTHDBH.UseVisualStyleBackColor = true;
            this.btnKTHDBH.Click += new System.EventHandler(this.btnKTHDBH_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 333);
            this.Controls.Add(this.btnKTHDBH);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lbltk);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnThanhToanHD);
            this.Controls.Add(this.btnKienTra);
            this.Controls.Add(this.btnNhapHang);
            this.Name = "MENU";
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnKienTra;
        private System.Windows.Forms.Button btnThanhToanHD;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbltk;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnKTHDBH;
    }
}