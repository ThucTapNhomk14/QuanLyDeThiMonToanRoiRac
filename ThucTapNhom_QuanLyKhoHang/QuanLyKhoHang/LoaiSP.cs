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
    public partial class LoaiSP : Form
    {
        int a = 0;
        public LoaiSP()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void LoaiSP_Load(object sender, EventArgs e)
        {
            tbxMaLSP.Enabled = false;
            tbxTenLSP.Enabled = false;

            string sql = "select *from LoaiSP";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvLoaiSP.DataSource = ds.Tables[0];
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxTenLSP.Enabled = true;
            tbxMaLSP.Enabled = true;
            
        }
        private void ThemLoaiSP(object sender, EventArgs e)
        {
            try
            {



                string sql = "insert into LoaiSP Values(N'" + tbxMaLSP.Text + "','" + tbxTenLSP.Text + "')";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaiSP_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxMaLSP.Enabled = false;
            tbxTenLSP.Enabled = false;
            
        }
        private void SuaLoaiSP(object sender, EventArgs e)
        {
            if (tbxMaLSP.Text != "")
            {
                string sql = "UPDATE LoaiSP SET MaLSP ='" + tbxMaLSP.Text + "', TenLoai ='" + tbxTenLSP.Text + "' WHERE MaLSP='" + tbxMaLSP.Text + "'";

                acc.excuteNonQuery(sql);
                MessageBox.Show("Cập Nhật Thành Công");
                LoaiSP_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from LoaiSP where MaLSP='" + tbxMaLSP.Text + "'";

            acc.excuteNonQuery(sql);
                tbxMaLSP.Clear();
                tbxTenLSP.Clear();          
            MessageBox.Show("Xoá thành công !");

            LoaiSP_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void dgvLoaiSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaLSP.Text = dgvLoaiSP.CurrentRow.Cells["MaLSP"].Value.ToString();
            tbxTenLSP.Text = dgvLoaiSP.CurrentRow.Cells["TenLSP"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 0) ThemLoaiSP(sender, e);
            else SuaLoaiSP(sender, e);
        }
    }
}
