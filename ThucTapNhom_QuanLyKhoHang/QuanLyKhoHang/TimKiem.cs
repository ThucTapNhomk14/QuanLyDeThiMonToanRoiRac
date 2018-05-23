using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QuanLyKhoHang
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void btnTim_Click(object sender, EventArgs e)
        {
            
            try {
                string sql = "SELECT *FROM SanPham WHERE MaSP='" + tbxMaSP.Text + "';";
                SqlDataAdapter dap = acc.executeDatatable(sql);
                DataSet ds = new DataSet();
                DataTable dtbTimKiem = new DataTable();
                dap.Fill(ds);
                dgvTimKiem.DataSource = ds.Tables[0];
                dgvTimKiem.Refresh();



            }





            catch (Exception)
            {
                MessageBox.Show("error");
            }


        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }
    }
}
