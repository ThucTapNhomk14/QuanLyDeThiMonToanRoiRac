﻿namespace QuanLyKhoHang
{
    partial class TimKiem
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxMaSP = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.dgvTimKiem = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BaoHanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhNang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm";
            // 
            // tbxMaSP
            // 
            this.tbxMaSP.Location = new System.Drawing.Point(129, 39);
            this.tbxMaSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxMaSP.Name = "tbxMaSP";
            this.tbxMaSP.Size = new System.Drawing.Size(162, 20);
            this.tbxMaSP.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(301, 40);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(69, 19);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm Kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // dgvTimKiem
            // 
            this.dgvTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.MaLSP,
            this.MaHSX,
            this.Gia,
            this.BaoHanh,
            this.TinhNang});
            this.dgvTimKiem.Location = new System.Drawing.Point(50, 158);
            this.dgvTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTimKiem.Name = "dgvTimKiem";
            this.dgvTimKiem.RowTemplate.Height = 24;
            this.dgvTimKiem.Size = new System.Drawing.Size(387, 122);
            this.dgvTimKiem.TabIndex = 3;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // MaLSP
            // 
            this.MaLSP.DataPropertyName = "MaLSP";
            this.MaLSP.HeaderText = "Mã loại sản phẩm";
            this.MaLSP.Name = "MaLSP";
            // 
            // MaHSX
            // 
            this.MaHSX.DataPropertyName = "MaHSX";
            this.MaHSX.HeaderText = "Mã hãng SX";
            this.MaHSX.Name = "MaHSX";
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            // 
            // BaoHanh
            // 
            this.BaoHanh.DataPropertyName = "BaoHanh";
            this.BaoHanh.HeaderText = "Bảo hành";
            this.BaoHanh.Name = "BaoHanh";
            // 
            // TinhNang
            // 
            this.TinhNang.DataPropertyName = "TinhNang";
            this.TinhNang.HeaderText = "Tính năng";
            this.TinhNang.Name = "TinhNang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(48, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hiển thị";
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.Location = new System.Drawing.Point(381, 41);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(56, 19);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(454, 299);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTimKiem);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.tbxMaSP);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TimKiem";
            this.Text = "TimKiem";
            this.Load += new System.EventHandler(this.TimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxMaSP;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.DataGridView dgvTimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaoHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TinhNang;
        private System.Windows.Forms.Button btnThoat;
    }
}