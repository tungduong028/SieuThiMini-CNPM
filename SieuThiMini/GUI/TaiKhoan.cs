using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class TaiKhoan : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        TaiKhoanBLL TaiKhoanBLL = new TaiKhoanBLL();
        public TaiKhoan()
        {
            InitializeComponent();
        }
        private void cb_PhanQuyen_Load()
        {
            dt = dp.ExecuteQuery("SELECT ma_quyen FROM phan_quyen");
            cb_PhanQuyen.DisplayMember = "ma_quyen";
            cb_PhanQuyen.DataSource = dt;
        }

        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            cb_PhanQuyen_Load();
            grid_TaiKhoan.DataSource = TaiKhoanBLL.getTaiKhoan();
            grid_TaiKhoan.Columns["ma_tai_khoan"].HeaderText = "Mã tài khoản";
            grid_TaiKhoan.Columns["ten_tai_khoan"].HeaderText = "Tên tài khoản";
            grid_TaiKhoan.Columns["mat_khau"].HeaderText = "Mật khẩu";
            grid_TaiKhoan.Columns["phan_quyen"].HeaderText = "Phân quyền";
            grid_TaiKhoan.Columns["ma_tai_khoan"].Width = 187;
            grid_TaiKhoan.Columns["ten_tai_khoan"].Width = 318;
            grid_TaiKhoan.Columns["mat_khau"].Width = 187;
            grid_TaiKhoan.Columns["phan_quyen"].Width = 187;
            grid_TaiKhoan.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TaiKhoan.Columns["ma_tai_khoan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TaiKhoan.Columns["mat_khau"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_TaiKhoan.Columns["phan_quyen"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void grid_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1) return;
            row = grid_TaiKhoan.Rows[e.RowIndex];
            tb_MaTaiKhoan.Text = Convert.ToString(row.Cells["ma_tai_khoan"].Value);
            tb_TenTaiKhoan.Text = Convert.ToString(row.Cells["ten_tai_khoan"].Value);
            tb_MatKhau.Text = Convert.ToString(row.Cells["mat_khau"].Value);
            cb_PhanQuyen.Text = Convert.ToString(row.Cells["phan_quyen"].Value);
        }

        private void grid_TaiKhoan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (grid_TaiKhoan.Columns[e.ColumnIndex].Index == 2)
            {
                if (e.Value != null)
                {
                    e.Value = new string('*', e.Value.ToString().Length);
                    e.FormattingApplied = true;
                }
            }
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            cb_PhanQuyen_Load();
            grid_TaiKhoan.DataSource = TaiKhoanBLL.getTaiKhoan();
        }
        private void btn_TaoTK_Click(object sender, EventArgs e)
        {
            ThemTaiKhoan themtaikhoan = new ThemTaiKhoan();
            themtaikhoan.ShowDialog();
        }

        private void btn_SuaTK_Click(object sender, EventArgs e)
        {
            if (tb_MaTaiKhoan.Text == "")
                MessageBox.Show("Hãy chọn 1 tài khoản để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tb_TenTaiKhoan.Enabled = true;
                tb_MatKhau.Enabled = true;
                cb_PhanQuyen.Enabled = true;
                btn_Luu.Visible = true;
                btn_Huy.Visible = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string mataikhoan = tb_MaTaiKhoan.Text;
            string tentaikhoan = tb_TenTaiKhoan.Text;
            string matkhau = tb_MatKhau.Text;
            string phanquyen = cb_PhanQuyen.Text;

            if (mataikhoan != "" && tentaikhoan != "" && matkhau != "" && phanquyen != "")
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO(int.Parse(mataikhoan), tentaikhoan, matkhau, int.Parse(phanquyen), "1");
                TaiKhoanBLL bLL = new TaiKhoanBLL();
                bLL.Update(taikhoan);

                tb_TenTaiKhoan.Enabled = false;
                tb_MatKhau.Enabled = false;
                cb_PhanQuyen.Enabled = false;
                btn_Luu.Visible = false;
                btn_Huy.Visible = false;
                MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            tb_MaTaiKhoan.Text = "";
            tb_TenTaiKhoan.Text = "";
            tb_MatKhau.Text = "";
            cb_PhanQuyen.Text = "";
            tb_TenTaiKhoan.Enabled = false;
            tb_MatKhau.Enabled = false;
            cb_PhanQuyen.Enabled = false;
            btn_Luu.Visible = false;
            btn_Huy.Visible = false;
        }

        private void btn_XoaTK_Click(object sender, EventArgs e)
        {
            string mataikhoan = tb_MaTaiKhoan.Text;
            NhanVienBLL nvBLL = new NhanVienBLL();
            if (mataikhoan != "" && mataikhoan != "1" && nvBLL.getNVByTaiKhoan(mataikhoan).Count == 0)
            {
                TaiKhoanBLL.Delete(mataikhoan);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Chọn 1 tài khoản để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucTaiKhoan khoiPhucTaiKhoan = new KhoiPhucTaiKhoan();
            khoiPhucTaiKhoan.ShowDialog();
        }

        private void TimKiem(object sender, EventArgs e)
        {
            string input = tb_TimKiem.Text;
            grid_TaiKhoan.DataSource = TaiKhoanBLL.TimKiem(input);
        }

    }
}
