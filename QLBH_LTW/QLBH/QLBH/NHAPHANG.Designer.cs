namespace QLBH
{
    partial class NHAPHANG
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
            this.lblMaHang = new System.Windows.Forms.Label();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.lblGiaMua = new System.Windows.Forms.Label();
            this.lblGiaBan = new System.Windows.Forms.Label();
            this.dtgDSHH = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sua = new System.Windows.Forms.ToolStripMenuItem();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNewHD = new System.Windows.Forms.Button();
            this.lblTongHD = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblsum = new System.Windows.Forms.Label();
            this.lblTenHD = new System.Windows.Forms.Label();
            this.txtMAHD = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSL = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHH)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMaHang
            // 
            this.lblMaHang.AutoSize = true;
            this.lblMaHang.Location = new System.Drawing.Point(78, 28);
            this.lblMaHang.Name = "lblMaHang";
            this.lblMaHang.Size = new System.Drawing.Size(51, 13);
            this.lblMaHang.TabIndex = 0;
            this.lblMaHang.Text = "Mã Hàng";
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(78, 53);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(55, 13);
            this.lblTenHang.TabIndex = 1;
            this.lblTenHang.Text = "Tên Hàng";
            // 
            // lblGiaMua
            // 
            this.lblGiaMua.AutoSize = true;
            this.lblGiaMua.Location = new System.Drawing.Point(78, 81);
            this.lblGiaMua.Name = "lblGiaMua";
            this.lblGiaMua.Size = new System.Drawing.Size(67, 13);
            this.lblGiaMua.TabIndex = 2;
            this.lblGiaMua.Text = "Đơn giá mua";
            // 
            // lblGiaBan
            // 
            this.lblGiaBan.AutoSize = true;
            this.lblGiaBan.Location = new System.Drawing.Point(78, 112);
            this.lblGiaBan.Name = "lblGiaBan";
            this.lblGiaBan.Size = new System.Drawing.Size(65, 13);
            this.lblGiaBan.TabIndex = 3;
            this.lblGiaBan.Text = "Đơn giá bán";
            // 
            // dtgDSHH
            // 
            this.dtgDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDSHH.ContextMenuStrip = this.contextMenuStrip1;
            this.dtgDSHH.Location = new System.Drawing.Point(-1, 168);
            this.dtgDSHH.Name = "dtgDSHH";
            this.dtgDSHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDSHH.Size = new System.Drawing.Size(556, 157);
            this.dtgDSHH.TabIndex = 5;
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
            // btnNewHD
            // 
            this.btnNewHD.Location = new System.Drawing.Point(3, 331);
            this.btnNewHD.Name = "btnNewHD";
            this.btnNewHD.Size = new System.Drawing.Size(103, 23);
            this.btnNewHD.TabIndex = 6;
            this.btnNewHD.Text = "Tạo hóa đơn";
            this.btnNewHD.UseVisualStyleBackColor = true;
            this.btnNewHD.Click += new System.EventHandler(this.btnNewHD_Click);
            // 
            // lblTongHD
            // 
            this.lblTongHD.AutoSize = true;
            this.lblTongHD.Location = new System.Drawing.Point(419, 336);
            this.lblTongHD.Name = "lblTongHD";
            this.lblTongHD.Size = new System.Drawing.Size(78, 13);
            this.lblTongHD.TabIndex = 7;
            this.lblTongHD.Text = "Tổng hóa đơn:";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(163, 25);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(250, 20);
            this.txtMaHang.TabIndex = 8;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(163, 50);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(250, 20);
            this.txtTenHang.TabIndex = 9;
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(163, 78);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(250, 20);
            this.txtGiaMua.TabIndex = 10;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(163, 105);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(250, 20);
            this.txtGiaBan.TabIndex = 11;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(454, 66);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 13;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(0, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(35, 13);
            this.lbluser.TabIndex = 14;
            this.lbluser.Text = "User: ";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(32, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(13, 13);
            this.lblTen.TabIndex = 15;
            this.lblTen.Text = "a";
            // 
            // lblsum
            // 
            this.lblsum.AutoSize = true;
            this.lblsum.Location = new System.Drawing.Point(503, 336);
            this.lblsum.Name = "lblsum";
            this.lblsum.Size = new System.Drawing.Size(13, 13);
            this.lblsum.TabIndex = 16;
            this.lblsum.Text = "0";
            // 
            // lblTenHD
            // 
            this.lblTenHD.AutoSize = true;
            this.lblTenHD.Location = new System.Drawing.Point(195, 336);
            this.lblTenHD.Name = "lblTenHD";
            this.lblTenHD.Size = new System.Drawing.Size(71, 13);
            this.lblTenHD.TabIndex = 17;
            this.lblTenHD.Text = "Mã Hóa Đơn:";
            // 
            // txtMAHD
            // 
            this.txtMAHD.Location = new System.Drawing.Point(272, 333);
            this.txtMAHD.Name = "txtMAHD";
            this.txtMAHD.Size = new System.Drawing.Size(100, 20);
            this.txtMAHD.TabIndex = 19;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(480, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Trở Lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(84, 141);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(49, 13);
            this.lblSL.TabIndex = 21;
            this.lblSL.Text = "Số lượng";
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(163, 138);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(250, 20);
            this.txtSL.TabIndex = 22;
            // 
            // NHAPHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 369);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtMAHD);
            this.Controls.Add(this.lblTenHD);
            this.Controls.Add(this.lblsum);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaMua);
            this.Controls.Add(this.txtTenHang);
            this.Controls.Add(this.txtMaHang);
            this.Controls.Add(this.lblTongHD);
            this.Controls.Add(this.btnNewHD);
            this.Controls.Add(this.dtgDSHH);
            this.Controls.Add(this.lblGiaBan);
            this.Controls.Add(this.lblGiaMua);
            this.Controls.Add(this.lblTenHang);
            this.Controls.Add(this.lblMaHang);
            this.Name = "NHAPHANG";
            this.Text = "Nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgDSHH)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaHang;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.Label lblGiaMua;
        private System.Windows.Forms.Label lblGiaBan;
        private System.Windows.Forms.DataGridView dtgDSHH;
        private System.Windows.Forms.Button btnNewHD;
        private System.Windows.Forms.Label lblTongHD;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblsum;
        private System.Windows.Forms.Label lblTenHD;
        private System.Windows.Forms.TextBox txtMAHD;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sua;
        private System.Windows.Forms.ToolStripMenuItem xoa;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.TextBox txtSL;
    }
}