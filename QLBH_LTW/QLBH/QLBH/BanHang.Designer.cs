namespace QLBH
{
    partial class BanHang
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
            this.components = new System.ComponentModel.Container();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.lblMaHang = new System.Windows.Forms.Label();
            this.btnNhap = new System.Windows.Forms.Button();
            this.dtgDS = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sua = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongT = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.lblMHD = new System.Windows.Forms.Label();
            this.txtMHD = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMH
            // 
            this.txtMH.Location = new System.Drawing.Point(69, 46);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(86, 20);
            this.txtMH.TabIndex = 0;
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(12, 52);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(51, 13);
            this.lblMaHang.TabIndex = 1;
            this.lblMaHang.Text = "Mã Hàng";
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(309, 43);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // dtgDS
            // 
            this.dtgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDS.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgDS.Location = new System.Drawing.Point(12, 71);
            this.dtgDS.Name = "dtgDS";
            this.dtgDS.Size = new System.Drawing.Size(384, 234);
            this.dtgDS.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sua,
            this.xoa});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // sua
            // 
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(94, 22);
            this.sua.Text = "Sửa";
            this.sua.Click += new System.EventHandler(this.sua_Click);
            // 
            // xoa
            // 
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(94, 22);
            this.xoa.Text = "Xóa";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(173, 311);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(75, 23);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongT
            // 
            this.lblTongT.AutoSize = true;
            this.lblTongT.Location = new System.Drawing.Point(275, 316);
            this.lblTongT.Name = "lblTongT";
            this.lblTongT.Size = new System.Drawing.Size(55, 13);
            this.lblTongT.TabIndex = 5;
            this.lblTongT.Text = "Tổng tiền:";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(0, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(32, 13);
            this.lbluser.TabIndex = 6;
            this.lbluser.Text = "User:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(37, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(35, 13);
            this.lblTen.TabIndex = 7;
            this.lblTen.Text = "label4";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Location = new System.Drawing.Point(336, 316);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(13, 13);
            this.lblTong.TabIndex = 8;
            this.lblTong.Text = "0";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(339, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(170, 52);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(52, 13);
            this.lblSL.TabIndex = 10;
            this.lblSL.Text = "Số lượng:";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(228, 46);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(44, 20);
            this.txtSL.TabIndex = 11;
            // 
            // lblMHD
            // 
            this.lblMHD.AutoSize = true;
            this.lblMHD.Location = new System.Drawing.Point(9, 316);
            this.lblMHD.Name = "lblMHD";
            this.lblMHD.Size = new System.Drawing.Size(74, 13);
            this.lblMHD.TabIndex = 12;
            this.lblMHD.Text = "Mã Hóa Đơn: ";
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(77, 311);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(78, 20);
            this.txtMHD.TabIndex = 13;
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 348);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.lblMHD);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.lblTongT);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.dtgDS);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.lblMaHang);
            this.Controls.Add(this.txtMH);
            this.Name = "BanHang";
            this.Text = "BanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDS)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.DataGridView dtgDS;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongT;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sua;
        private System.Windows.Forms.ToolStripMenuItem xoa;
        private System.Windows.Forms.Label lblMHD;
        private System.Windows.Forms.TextBox txtMHD;
    }
}