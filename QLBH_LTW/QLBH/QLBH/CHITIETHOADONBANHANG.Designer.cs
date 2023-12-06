namespace QLBH
{
    partial class CHITIETHOADONBANHANG
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
            this.dtDSHH = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtDSHH
            // 
            this.dtDSHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDSHH.Location = new System.Drawing.Point(12, 12);
            this.dtDSHH.Name = "dtDSHH";
            this.dtDSHH.Size = new System.Drawing.Size(380, 258);
            this.dtDSHH.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(169, 281);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CHITIETHOADONBANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 316);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtDSHH);
            this.Name = "CHITIETHOADONBANHANG";
            this.Text = "Chi tiết hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.CHITIETHOADONBANHANG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtDSHH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtDSHH;
        private System.Windows.Forms.Button btnBack;
    }
}