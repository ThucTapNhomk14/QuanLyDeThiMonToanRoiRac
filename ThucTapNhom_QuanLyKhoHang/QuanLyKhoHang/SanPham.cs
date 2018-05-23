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
    public partial class SanPham : Form
    {
        int a = 0;
        public SanPham()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxBaoHanh.Enabled = true;
            tbxGiaBan.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxMaLSP.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxTenSP.Enabled = true;
            tbxTinhNang.Enabled = true;
        }
        private void them(object sender, EventArgs e)
        {
            
            try
            {
                string sql = "insert into SanPham Values('" + tbxMaSP.Text + "',N'" + tbxTenSP.Text + "','" + tbxMaLSP.Text + "','" + tbxMaHSX.Text + "','" + tbxGiaBan.Text + "',N'" + tbxBaoHanh.Text + "',N'" + tbxTinhNang.Text + "')";
                acc.excuteNonQuery(sql);
                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // dataGridView1.Refresh();
                SanPham_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxBaoHanh.Enabled = true;
            tbxGiaBan.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxMaLSP.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxTenSP.Enabled = true;
            tbxTinhNang.Enabled = true;
            

        }
        private void SuaSP(object sender, EventArgs e)
        {
            
            if (tbxMaSP.Text != "")
            {
                string sql = "UPDATE SanPham SET MaSP ='" + tbxMaSP.Text + "', TenSP =N'" + tbxTenSP.Text + "',MaLSP ='" + tbxMaLSP.Text + "',MaHSX ='" + tbxMaHSX.Text + "',Gia ='" + tbxGiaBan.Text + "',BaoHanh =N'" + tbxBaoHanh.Text + "',TinhNang =N'" + tbxTinhNang.Text + "' WHERE MaSP='" + tbxMaSP.Text + "'";

            acc.excuteNonQuery(sql);



                MessageBox.Show("Cập Nhật Thành Công");
                SanPham_Load(sender, e);
    }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            
            
            string sql = "delete from SanPham where MaSP='" + tbxMaSP.Text + "'";

            acc.excuteNonQuery(sql);


          
                tbxMaSP.Clear();
                tbxTenSP.Clear();
                tbxMaLSP.Clear();
                tbxMaHSX.Clear();
                tbxGiaBan.Clear();
                tbxBaoHanh.Clear();
                tbxTinhNang.Clear();
            
            MessageBox.Show("Xoá thành công !");
            SanPham_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaSP.Text = dataGridView1.CurrentRow.Cells["MaSP"].Value.ToString();
            tbxTenSP.Text = dataGridView1.CurrentRow.Cells["TenSP"].Value.ToString();
            tbxMaLSP.Text = dataGridView1.CurrentRow.Cells["MaLSP"].Value.ToString();
            tbxMaHSX.Text = dataGridView1.CurrentRow.Cells["MaHSX"].Value.ToString();
            tbxGiaBan.Text = dataGridView1.CurrentRow.Cells["GiaBan"].Value.ToString();
            tbxBaoHanh.Text = dataGridView1.CurrentRow.Cells["BaoHanh"].Value.ToString();
            tbxTinhNang.Text = dataGridView1.CurrentRow.Cells["TinhNang"].Value.ToString();

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            tbxBaoHanh.Enabled = false;
            tbxGiaBan.Enabled = false;
            tbxMaHSX.Enabled = false;
            tbxMaLSP.Enabled = false;
            tbxMaSP.Enabled = false;
            tbxTenSP.Enabled = false;
            tbxTinhNang.Enabled = false;
           
           
            string sql = "select *from SanPham";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
           
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }
      
        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if (a == 0)
            {
                them(sender, e);
                //MessageBox.Show("Thêm mới thành công !");
            }
            else 
            {
                SuaSP(sender, e);
                //MessageBox.Show("Cập nhật thành công !");
            }

        }

        private void tbxMaSP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
