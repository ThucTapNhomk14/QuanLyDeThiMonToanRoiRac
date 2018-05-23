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
    public partial class CTPhieuXuat : Form
    {
        int a = 0;
        public CTPhieuXuat()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxSoLuong.Enabled = true;
            dtNgayXuat.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxMaPX.Enabled = true;
            tbxMaNV.Enabled = true;
            tbxDonGia.Enabled = true;

            
        }
        private void ThemPN(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into PhieuXuat Values(N'" + tbxMaPX.Text + "','" + tbxMaSP.Text + "','" + tbxMaNV.Text + "','" + dtNgayXuat.Text + "',N'" + tbxSoLuong.Text + "',N'" + tbxDonGia.Text + "')";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CTPhieuXuat_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxSoLuong.Enabled = true;
            dtNgayXuat.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxMaPX.Enabled = true;
            tbxMaNV.Enabled = true;
            tbxDonGia.Enabled = true;
            

        }
        private void SuaPhieuXuat(object sender, EventArgs e)
        {
            if (tbxMaPX.Text != "")
            {
                string sql = "UPDATE PhieuXuat SET MaPX ='" + tbxMaPX.Text + "', MaSP ='" + tbxMaSP.Text + "',MaNV ='" + tbxMaNV.Text + "',NgayXuat ='" + dtNgayXuat.Text + "',SoLuong ='" + tbxSoLuong.Text + "',DonGia ='" + tbxDonGia.Text + "' WHERE MaPX='" + tbxMaPX.Text + "'";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Cập Nhật Thành Công");
                CTPhieuXuat_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            string sql = "delete from PhieuXuat where MaPX='" + tbxMaPX.Text + "'";

            acc.excuteNonQuery(sql);          
                tbxMaPX.Clear();
                tbxMaSP.Clear();             
                tbxMaNV.Clear();
                //dtNgayXuat.Clear();
                tbxSoLuong.Clear();
                tbxDonGia.Clear();
            
            MessageBox.Show("Xoá thành công !");

            CTPhieuXuat_Load(sender, e);
        }

        private void CTPhieuXuat_Load(object sender, EventArgs e)
        {

            tbxSoLuong.Enabled = false;
            dtNgayXuat.Enabled = false;
            tbxMaSP.Enabled = false;
            tbxMaPX.Enabled = false;
            tbxMaNV.Enabled = false;
            tbxDonGia.Enabled = false;
            string sql = "select *from PhieuXuat";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);
            dgvPhieuXuat.DataSource = ds.Tables[0];
          
        }

        private void dgvPhieuXuat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxDonGia.Text = dgvPhieuXuat.CurrentRow.Cells["DonGia"].Value.ToString();
            tbxMaNV.Text = dgvPhieuXuat.CurrentRow.Cells["MaNV"].Value.ToString();
            tbxMaPX.Text = dgvPhieuXuat.CurrentRow.Cells["MaPX"].Value.ToString();
            tbxMaSP.Text = dgvPhieuXuat.CurrentRow.Cells["MaSP"].Value.ToString();
            dtNgayXuat.Text = dgvPhieuXuat.CurrentRow.Cells["NgayXuat"].Value.ToString();
            tbxSoLuong.Text = dgvPhieuXuat.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 0) ThemPN(sender, e);
            else SuaPhieuXuat(sender, e);
        }
    }
}
