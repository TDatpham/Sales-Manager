namespace QLBH
{
    partial class CHITIETHOADON
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
            this.dtgCTHD = new System.Windows.Forms.DataGridView();
            this.lblBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgCTHD
            // 
            this.dtgCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTHD.Location = new System.Drawing.Point(12, 0);
            this.dtgCTHD.Name = "dtgCTHD";
            this.dtgCTHD.Size = new System.Drawing.Size(455, 290);
            this.dtgCTHD.TabIndex = 0;
            // 
            // lblBack
            // 
            this.lblBack.Location = new System.Drawing.Point(205, 296);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(75, 23);
            this.lblBack.TabIndex = 1;
            this.lblBack.Text = "Trở Lại";
            this.lblBack.UseVisualStyleBackColor = true;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // CHITIETHOADON
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 331);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.dtgCTHD);
            this.Name = "CHITIETHOADON";
            this.Text = "Chi tiết hóa đơn nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCTHD;
        private System.Windows.Forms.Button lblBack;
    }
}