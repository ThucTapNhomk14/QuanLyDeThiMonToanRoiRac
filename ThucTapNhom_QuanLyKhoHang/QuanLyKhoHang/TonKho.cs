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
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        accessData acc = new accessData();
        private void btnThem_Click(object sender, EventArgs e)
        {
            tbxMaHSX.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxSoLuong.Enabled = true;

        }
        private void ThemSPTonKho(object sender, EventArgs e)
        {
            try
            {

                string sql = "insert into TonKho Values(N'" + tbxMaSP.Text + "','" + tbxMaHSX.Text + "','" + tbxSoLuong.Text + "')";


                acc.excuteNonQuery(sql);



                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TonKho_Load(sender, e);

            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            tbxMaHSX.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxSoLuong.Enabled = true;
            if (tbxMaSP.Text != "")
            {
                string sql = "UPDATE TonKho SET MaSP ='" + tbxMaSP.Text + "', MaHSX ='" + tbxMaHSX.Text + "',SoLuong ='" + tbxSoLuong.Text + "' WHERE MaSP='" + tbxMaSP.Text + "'";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Cập Nhật Thành Công");
                TonKho_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           


            string sql = "delete from TonKho where MaSP='" + tbxMaSP.Text + "'";

            acc.excuteNonQuery(sql);


            
                tbxMaSP.Clear();
                
                tbxMaHSX.Clear();
              
                tbxSoLuong.Clear();
           
            MessageBox.Show("Xoá thành công !");

            TonKho_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            tbxSoLuong.Enabled = false;
            tbxMaSP.Enabled = false;
            tbxMaHSX.Enabled = false;
            string sql = "select *from TonKho";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvTonKho.DataSource = ds.Tables[0];
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dgvTonKho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxSoLuong.Text = dgvTonKho.CurrentRow.Cells["SoLuong"].Value.ToString();
            tbxMaSP.Text = dgvTonKho.CurrentRow.Cells["MaSP"].Value.ToString();
            tbxMaHSX.Text = dgvTonKho.CurrentRow.Cells["MaHSX"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThemSPTonKho(sender, e);
        }
    }
}
