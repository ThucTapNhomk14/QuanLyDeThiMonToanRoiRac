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
    public partial class CTPhieuNhap : Form
    {
        int a = 0;
        public CTPhieuNhap()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxMaPN.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxMaNV.Enabled = true;
            dtNgayNhap.Enabled = true;
            tbxSoLuong.Enabled = true;
            tbxDonGia.Enabled = true;


        }
        private void ThemPN(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into PhieuNhap Values(N'" + tbxMaPN.Text + "','" + tbxMaSP.Text + "','" + tbxMaHSX.Text + "','" + tbxMaNV.Text + "','" + dtNgayNhap.Text + "',N'" + tbxSoLuong.Text + "',N'" + tbxDonGia.Text + "')";

                acc.excuteNonQuery(sql);

                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CTPhieuNhap_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxMaPN.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxMaHSX.Enabled = true;
            tbxMaNV.Enabled = true;
            dtNgayNhap.Enabled = true;
            tbxSoLuong.Enabled = true;
            tbxDonGia.Enabled = true;
            

        }
        private void SuaPhieuNhap(object sender, EventArgs e)
        {
            if (tbxMaPN.Text != "")
            {
                string sql = "UPDATE PhieuNhap SET MaPN ='" + tbxMaPN.Text + "', MaSP ='" + tbxMaSP.Text + "',MaHSX ='" + tbxMaHSX.Text + "',MaNV ='" + tbxMaNV.Text + "',NgayNhap ='" + dtNgayNhap.Text + "',SoLuong ='" + tbxSoLuong.Text + "',DonGia ='" + tbxDonGia.Text + "' WHERE MaPN='" + tbxMaPN.Text + "'";

                acc.excuteNonQuery(sql);

                MessageBox.Show("Cập Nhật Thành Công");
                CTPhieuNhap_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            

            string sql = "delete from PhieuNhap where MaPN='" + tbxMaPN.Text + "'";

            acc.excuteNonQuery(sql);

          
                tbxMaPN.Clear();
                tbxMaSP.Clear();
                tbxMaHSX.Clear();
                tbxMaNV.Clear();
                //dtNgayNhap.Clear();
                tbxSoLuong.Clear();
                tbxDonGia.Clear();
            
            MessageBox.Show("Xoá thành công !");
            CTPhieuNhap_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void CTPhieuNhap_Load(object sender, EventArgs e)
        {
            tbxMaPN.Enabled = false;
            tbxMaSP.Enabled = false;
            tbxMaHSX.Enabled = false;
            tbxMaNV.Enabled = false;
            dtNgayNhap.Enabled = false;
            tbxSoLuong.Enabled = false;
            tbxDonGia.Enabled = false;
            string sql = "select *from PhieuNhap";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvPhieuNhap.DataSource = ds.Tables[0];
          
        }

        private void dgvPhieuNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaSP.Text = dgvPhieuNhap.CurrentRow.Cells["MaSP"].Value.ToString();
            tbxMaPN.Text = dgvPhieuNhap.CurrentRow.Cells["MaPN"].Value.ToString();
            tbxMaNV.Text = dgvPhieuNhap.CurrentRow.Cells["MaNV"].Value.ToString();
            tbxMaHSX.Text = dgvPhieuNhap.CurrentRow.Cells["MaHSX"].Value.ToString();
            tbxDonGia.Text = dgvPhieuNhap.CurrentRow.Cells["DonGia"].Value.ToString();
            dtNgayNhap.Text = dgvPhieuNhap.CurrentRow.Cells["NgayNhap"].Value.ToString();
            tbxSoLuong.Text = dgvPhieuNhap.CurrentRow.Cells["SoLuong"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (a == 0) ThemPN(sender, e);
            else SuaPhieuNhap(sender, e);
        }
    }
}
