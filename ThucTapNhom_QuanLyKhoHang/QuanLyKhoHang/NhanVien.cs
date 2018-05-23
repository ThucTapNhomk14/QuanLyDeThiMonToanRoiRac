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
    public partial class NhanVien : Form
    {
        int a = 0;
        public NhanVien()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxMaNV.Enabled = true;
            tbxHoTen.Enabled = true;
            tbxDiaChi.Enabled = true;
            tbxSoDienThoai.Enabled = true;
            cbxGioiTinh.Enabled = true; ;
            dtNgaySinh.Enabled = true;
        }
         private void ThemNV(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into NhanVien Values('" + tbxMaNV.Text + "','" + tbxHoTen.Text + "','" + dtNgaySinh.Text + "','" + cbxGioiTinh.Text + "','" + tbxDiaChi.Text + "','" + tbxSoDienThoai.Text + "')";


                acc.excuteNonQuery(sql);


                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NhanVien_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxMaNV.Enabled = true;
            tbxHoTen.Enabled = true;
            tbxDiaChi.Enabled = true;
            tbxSoDienThoai.Enabled = true;
            cbxGioiTinh.Enabled = true; ;
            dtNgaySinh.Enabled = true;
           
        }
        private void SuaNhanVien(object sender, EventArgs e)
        {
            if (tbxMaNV.Text != "")
            {
                string sql = "UPDATE NhanVien SET MaNV ='" + tbxMaNV.Text + "', HoTen ='" + tbxHoTen.Text + "',NgaySinh ='" + dtNgaySinh.Text + "',GioiTinh ='" + cbxGioiTinh.Text + "',DiaChi ='" + tbxDiaChi.Text + "',SDT ='" + tbxSoDienThoai.Text + "' WHERE MaNV='" + tbxMaNV.Text + "'";

                acc.excuteNonQuery(sql);


                MessageBox.Show("Cập Nhật Thành Công");
                NhanVien_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã nhân viên!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {



            string sql = "delete from NhanVien where MaNV='" + tbxMaNV.Text + "'";

            acc.excuteNonQuery(sql);


                tbxMaNV.Clear();

                tbxHoTen.Clear();
                //tbxNgaySinh.Clear();
                //tbxGioiTinh.Clear();

                tbxDiaChi.Clear();
                tbxSoDienThoai.Clear();
       
            MessageBox.Show("Xoá thành công !");

            NhanVien_Load(sender, e);         
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {


            tbxMaNV.Enabled = false;
            tbxHoTen.Enabled = false;
            tbxDiaChi.Enabled = false;
            tbxSoDienThoai.Enabled = false;
            cbxGioiTinh.Enabled = false;
            dtNgaySinh.Enabled = false;
            string sql = "select *from NhanVien";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvNhanVien.DataSource = ds.Tables[0];
            dgvNhanVien.Refresh();

        }

        private void tbxHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaNV.Text = dgvNhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            tbxHoTen.Text = dgvNhanVien.CurrentRow.Cells["HoTen"].Value.ToString();
            tbxDiaChi.Text = dgvNhanVien.CurrentRow.Cells["DiaChi"].Value.ToString();
            tbxSoDienThoai.Text = dgvNhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            cbxGioiTinh.Text = dgvNhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            dtNgaySinh.Text = dgvNhanVien.CurrentRow.Cells["NgaySinh"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(a == 0)ThemNV(sender, e);
            if (a == 1) SuaNhanVien(sender, e);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
    /*DialogResult tb = MessageBox.Show("Bạn chắc chắn muốn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
                */
}
