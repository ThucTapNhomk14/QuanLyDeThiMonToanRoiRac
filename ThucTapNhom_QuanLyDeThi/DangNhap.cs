﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ThucTapNhom_QuanLyDeThi
{
    public partial class DangNhap : Form
    {
        connect con = new connect();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = con.GetData("select * from TaiKhoan where TenTK = '"+txtUser.Text+"' and MK = '"+txtPass.Text+"'");
            if(dt.Rows.Count!=0)
            {
                if(dt.Rows[0][2].ToString()=="Quyen2"|| dt.Rows[0][2].ToString() == "Quyen3")
                {
                    Main t = new Main(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString());
                    this.Hide();
                    t.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu sai!","thông báo");
            }
        }
    }
}
