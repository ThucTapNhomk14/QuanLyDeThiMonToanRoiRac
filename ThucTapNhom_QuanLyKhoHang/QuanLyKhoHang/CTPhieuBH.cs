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
    public partial class CTPhieuBH : Form
    {
        int a = 0;
        public CTPhieuBH()
        {
            InitializeComponent();
        }
        accessData acc = new accessData();
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            a = 0;
            tbxMaPBH.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxTGBH.Enabled = true;
            tbxMaNV.Enabled = true;
            dtNgayLap.Enabled = true;

        }
        private void themPBH(object sender, EventArgs e)
        {
            try
            {



                string sql = "insert into PhieuBH Values(N'" + tbxMaPBH.Text + "','" + tbxMaSP.Text + "','" + tbxMaNV.Text + "','" + dtNgayLap.Text + "',N'" + tbxTGBH.Text + "')";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Thêm Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CTPhieuBH_Load(sender, e);
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            a = 1;
            tbxMaPBH.Enabled = true;
            tbxMaSP.Enabled = true;
            tbxTGBH.Enabled = true;
            tbxMaNV.Enabled = true;
            dtNgayLap.Enabled = true;

            
        }
        private void SuaPhieuBH(object sender, EventArgs e)
        {
            if (tbxMaPBH.Text != "")
            {
                string sql = "UPDATE PhieuBH SET MaPBH ='" + tbxMaPBH.Text + "', MaSP ='" + tbxMaSP.Text + "',MaNV ='" + tbxMaNV.Text + "',NgayLap ='" + dtNgayLap.Text + "',TGBH ='" + tbxTGBH.Text + "' WHERE MaPBH='" + tbxMaPBH.Text + "'";

                acc.excuteNonQuery(sql);



                MessageBox.Show("Cập Nhật Thành Công");

                CTPhieuBH_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Nhập sai mã sản phẩm!", "Thông báo");
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
           


            string sql = "delete from PhieuBH where MaPBH='" + tbxMaPBH.Text + "'";

            acc.excuteNonQuery(sql);


           
                tbxMaPBH.Clear();
                tbxMaSP.Clear();

                tbxMaNV.Clear();
                //dtNgayLap.Clear();
                tbxTGBH.Clear();
                
           
            MessageBox.Show("Xoá thành công !");

            CTPhieuBH_Load(sender, e);
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiaoDien menu = new GiaoDien();
            menu.ShowDialog();
        }

        private void CTPhieuBH_Load(object sender, EventArgs e)
        {
            tbxMaPBH.Enabled = false;
            tbxMaSP.Enabled = false;
            tbxTGBH.Enabled = false;
            tbxMaNV.Enabled = false;
            dtNgayLap.Enabled = false;
            string sql = "select *from PhieuBH";
            DataSet ds = new DataSet();
            SqlDataAdapter dap = acc.executeDatatable(sql);
            dap.Fill(ds);

            dgvPhieuBH.DataSource = ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                themPBH(sender, e);
            }
            else SuaPhieuBH(sender, e);
        }

        private void dgvPhieuBH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxMaPBH.Text = dgvPhieuBH.CurrentRow.Cells["MaPBH"].Value.ToString();
            tbxMaSP.Text = dgvPhieuBH.CurrentRow.Cells["MaSP"].Value.ToString();
            tbxTGBH.Text = dgvPhieuBH.CurrentRow.Cells["TGBH"].Value.ToString();
            tbxMaNV.Text = dgvPhieuBH.CurrentRow.Cells["MaNV"].Value.ToString();
            dtNgayLap.Text = dgvPhieuBH.CurrentRow.Cells["NgayLap"].Value.ToString();
        }
    }
}
