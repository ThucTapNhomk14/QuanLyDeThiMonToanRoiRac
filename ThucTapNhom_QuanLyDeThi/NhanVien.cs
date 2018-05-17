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

namespace ThucTapNhom_QuanLyDeThi
{
    public partial class NhanVien : Form
    {
        connect con = new connect();
        bool kt ;
        int r;
        string tk, mk, quyen;
        public NhanVien()
        {
            InitializeComponent();
        }

        public NhanVien(string tk,string mk,string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            this.quyen = quyen;
        }

        private void thêmTàiKhoản_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }

        private void hienthi()
        {

            DataTable db = new DataTable();
            try
            {
                db = con.GetData("sp_TTNV");
                dgvNhanVien.DataSource = db;
                dgvNhanVien.Refresh();
            }
            catch
            {
                MessageBox.Show("Lỗi hiển thị");
            }
        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void sửaTàiKhoản_Click(object sender, EventArgs e)
        {
            txtMaNV.Enabled = true;
            txtHoTen.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSDT.Enabled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(kt==true)
            {
                txtMaNV.Visible = true;
                label1.Visible = true;
                groupBox1.Enabled = false;
                btSua.Enabled = true;
                btXoa.Enabled = true;
            }
            else
            {
                groupBox1.Enabled = false;
                btThem.Enabled = true;
                btXoa.Enabled = true;
                txtMaNV.Enabled = true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(kt==true)
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn thêm nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        //sp_ThemNV] (@Ten @DC @SDT @NS @ChucVu 
                        
                        if (con.SetData("sp_ThemNV N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "',N'" + dtpNgaySinh.Text + "',N'" + txtChucVu.Text + "'") == true)
                            MessageBox.Show("Bạn đã thêm vào thành công.", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn thêm vào không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
            else
            {
                try
                {
                    DialogResult dg = new DialogResult();
                    dg = MessageBox.Show("Bạn có muốn thay đổi thông tin nhân viên này không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dg == DialogResult.Yes)
                    {
                        //sp_SuaNV(@MaNV  @Ten n @DC  @SDT  @NS  @ChucVu
                        if (con.SetData("sp_SuaNV N'" + txtMaNV.Text + "',N'" + txtHoTen.Text + "',N'" + txtDiaChi.Text + "',N'" + txtSDT.Text + "',N'" + dtpNgaySinh.Text + "',N'" + txtChucVu.Text + "'") == true)
                            MessageBox.Show("Bạn đã thay đổi thành công.", "Thông báo");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Bạn sửa vào không thành công.", "Kiểm tra lại");
                }
                hienthi();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            Main t = new Main(tk, mk, quyen);
            t.ShowDialog();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Text = "";
            txtSDT.Text = "";
            txtChucVu.Text = "";
            txtMaNV.Visible = false;
            label1.Visible = false;

            kt = true;
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            btThem.Enabled = false;
            btXoa.Enabled = false;



            txtMaNV.Enabled = false;

            int k = dgvNhanVien.CurrentCell.RowIndex;
            r = k;
            txtMaNV.Text = dgvNhanVien.Rows[k].Cells[0].Value.ToString();
            txtHoTen.Text= dgvNhanVien.Rows[k].Cells[1].Value.ToString();
            txtDiaChi.Text= dgvNhanVien.Rows[k].Cells[2].Value.ToString();
            txtSDT.Text= dgvNhanVien.Rows[k].Cells[3].Value.ToString();
            dtpNgaySinh.Text= dgvNhanVien.Rows[k].Cells[4].Value.ToString();
            txtChucVu.Text= dgvNhanVien.Rows[k].Cells[5].Value.ToString();
            txtHoTen.Focus();
            kt = false;
        }
    }
}
