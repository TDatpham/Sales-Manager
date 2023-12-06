namespace QLBH
{
    partial class KIEMTRAHOADONBANHANG
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
            this.lbluser = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.txtMHD = new System.Windows.Forms.TextBox();
            this.dtgHoaDon = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(1, -1);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(32, 13);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "User:";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Location = new System.Drawing.Point(39, -1);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(35, 13);
            this.lblten.TabIndex = 1;
            this.lblten.Text = "label1";
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Location = new System.Drawing.Point(39, 33);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(71, 13);
            this.lblMaHoaDon.TabIndex = 2;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn:";
            // 
            // txtMHD
            // 
            this.txtMHD.Location = new System.Drawing.Point(116, 30);
            this.txtMHD.Name = "txtMHD";
            this.txtMHD.Size = new System.Drawing.Size(237, 20);
            this.txtMHD.TabIndex = 3;
            this.txtMHD.TextChanged += new System.EventHandler(this.txtMHD_TextChanged);
            // 
            // dtgHoaDon
            // 
            this.dtgHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHoaDon.Location = new System.Drawing.Point(12, 56);
            this.dtgHoaDon.Name = "dtgHoaDon";
            this.dtgHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHoaDon.Size = new System.Drawing.Size(410, 249);
            this.dtgHoaDon.TabIndex = 4;
            this.dtgHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHoaDon_CellDoubleClick);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(360, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KIEMTRAHOADONBANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 317);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtgHoaDon);
            this.Controls.Add(this.txtMHD);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.lblten);
            this.Controls.Add(this.lbluser);
            this.Name = "KIEMTRAHOADONBANHANG";
            this.Text = "Kiểm tra hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.KIEMTRAHOADONBANHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblMaHoaDon;
        private System.Windows.Forms.TextBox txtMHD;
        private System.Windows.Forms.DataGridView dtgHoaDon;
        private System.Windows.Forms.Button btnBack;
    }
}