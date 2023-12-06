using System.Windows.Forms;

namespace QLBH
{
    partial class KIEMTRAHH
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
        private void InitializeComponent()
        {
            this.dtgHH = new System.Windows.Forms.DataGridView();
            this.label_Tenhang = new System.Windows.Forms.Label();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHH)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgHH
            // 
            this.dtgHH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHH.Location = new System.Drawing.Point(9, 88);
            this.dtgHH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgHH.Name = "dtgHH";
            this.dtgHH.RowHeadersWidth = 51;
            this.dtgHH.RowTemplate.Height = 29;
            this.dtgHH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHH.Size = new System.Drawing.Size(513, 184);
            this.dtgHH.TabIndex = 0;
            this.dtgHH.TabStop = false;
            // 
            // label_Tenhang
            // 
            this.label_Tenhang.AutoSize = true;
            this.label_Tenhang.Location = new System.Drawing.Point(157, 46);
            this.label_Tenhang.Name = "label_Tenhang";
            this.label_Tenhang.Size = new System.Drawing.Size(56, 13);
            this.label_Tenhang.TabIndex = 1;
            this.label_Tenhang.Text = "Tên hàng:";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(219, 43);
            this.txttk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(142, 20);
            this.txttk.TabIndex = 2;
            this.txttk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(0, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(32, 13);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = "User:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(41, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(13, 13);
            this.lblTen.TabIndex = 4;
            this.lblTen.Text = "a";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(478, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Trở lại";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KIEMTRAHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 293);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.label_Tenhang);
            this.Controls.Add(this.dtgHH);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "KIEMTRAHH";
            this.Text = " Kiểm tra hàng hóa";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private DataGridView dtgHH;
        private Label label_Tenhang;
        private TextBox txttk;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #endregion

        private Label lbluser;
        private Label lblTen;
        private Button btnBack;
    }
}