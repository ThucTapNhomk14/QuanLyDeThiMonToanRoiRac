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
    public partial class HangSanXuat : Form
    {
        int a = 0;
        public HangSanXuat()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void btnThem_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxDiaChi.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxTenHSX.Enabled = true;
        }
        private void ThemHSX(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into HangSX Values(N'" + tbxMaHSX.Text + "','" + tbxTenHSX.Text + "','" + tbxDiaChi.Text + "')";


                acc.excuteNonQuery(sql);


                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HangSanXuat_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxDiaChi.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxTenHSX.Enabled = true;
            
        }
        private void SuaHSX(object sender, EventArgs e)
        {
            if (tbxMaHSX.Text != "")
            {
                string sql = "UPDATE HangSX SET MaHSX ='" + tbxMaHSX.Text + "', TenHSX ='" + tbxTenHSX.Text + "',DiaChi ='" + tbxDiaChi.Text + "' WHERE MaHSX='" + tbxMaHSX.Text + "'";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Cập Nhật Thành Công");
                HangSanXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {

           


            string sql = "delete from HangSX where MaHSX='" + tbxMaHSX.Text + "'";

            acc.excuteNonQuery(sql);


           
                tbxMaHSX.Clear();

                tbxTenHSX.Clear();

                tbxDiaChi.Clear();
            
            MessageBox.Show("Xoá thành công !");

            HangSanXuat_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void HangSanXuat_Load(object sender, EventArgs e)
        {

            tbxTenHSX.Enabled = false;
            tbxMaHSX.Enabled = false;
            tbxDiaChi.Enabled = false;
            string sql = "select *from HangSX";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvHangSanXuat.DataSource = ds.Tables[0];
            
        }

        private void dgvHangSanXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDiaChi.Text = dgvHangSanXuat.CurrentRow.Cells["DiaChi"].Value.ToString();
            tbxMaHSX.Text = dgvHangSanXuat.CurrentRow.Cells["MaHSX"].Value.ToString();
            tbxTenHSX.Text = dgvHangSanXuat.CurrentRow.Cells["TenHSX"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(a == 0) ThemHSX(sender, e);
            if (a == 1) SuaHSX(sender, e);
        }
    }
}
