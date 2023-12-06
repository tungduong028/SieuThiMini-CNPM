using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class NhanVien : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        private NhanVienBLL nvBLL = new NhanVienBLL();
        public NhanVien()
        {
            InitializeComponent();
        }

        private void cb_TaiKhoan_Load()
        {
            dt = dp.ExecuteQuery("SELECT ma_tai_khoan FROM tai_khoan WHERE trang_thai = '1'");
            cb_TaiKhoan.DisplayMember = "ma_tai_khoan";
            cb_TaiKhoan.DataSource = dt;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            cb_TaiKhoan_Load();
            grid_NhanVien.DataSource = nvBLL.getNhanVien();
            grid_NhanVien.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
            grid_NhanVien.Columns["ten_nhan_vien"].HeaderText = "Tên nhân viên";
            grid_NhanVien.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
            grid_NhanVien.Columns["sdt"].HeaderText = "SĐT";
            grid_NhanVien.Columns["mail"].HeaderText = "Mail";
            grid_NhanVien.Columns["tai_khoan"].HeaderText = "Tài khoản";
            grid_NhanVien.Columns["ma_nhan_vien"].Width = 110;
            grid_NhanVien.Columns["ten_nhan_vien"].Width = 179;
            grid_NhanVien.Columns["ngay_sinh"].Width = 140;
            grid_NhanVien.Columns["sdt"].Width = 140;
            grid_NhanVien.Columns["mail"].Width = 200;
            grid_NhanVien.Columns["tai_khoan"].Width = 110;
            grid_NhanVien.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_NhanVien.Columns["ma_nhan_vien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_NhanVien.Columns["ngay_sinh"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_NhanVien.Columns["sdt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_NhanVien.Columns["mail"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_NhanVien.Columns["tai_khoan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void grid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            if (e.RowIndex == -1) return;
            row = grid_NhanVien.Rows[e.RowIndex];
            tb_MaNhanVien.Text = Convert.ToString(row.Cells["ma_nhan_vien"].Value);
            tb_TenNhanVien.Text = Convert.ToString(row.Cells["ten_nhan_vien"].Value);
            dtp_NgaySinh.Text = Convert.ToString(row.Cells["ngay_sinh"].Value);
            tb_SDT.Text = Convert.ToString(row.Cells["sdt"].Value);
            tb_Mail.Text = Convert.ToString(row.Cells["mail"].Value);
            cb_TaiKhoan.Text = Convert.ToString(row.Cells["tai_khoan"].Value);
        }
        private void btn_Reload_Click(object sender, EventArgs e)
        {
            cb_TaiKhoan_Load();
            grid_NhanVien.DataSource = nvBLL.getNhanVien();
        }
        private void btn_ThemNhanVien_Click(object sender, EventArgs e)
        {
            ThemNhanVien themNhanVien = new ThemNhanVien();
            themNhanVien.ShowDialog();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (tb_MaNhanVien.Text == "")
                MessageBox.Show("Hãy chọn 1 nhân viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tb_TenNhanVien.Enabled = true;
                dtp_NgaySinh.Enabled = true;
                tb_SDT.Enabled = true;
                tb_Mail.Enabled = true;
                cb_TaiKhoan.Enabled = true;
                btn_Luu.Visible = true;
                btn_Huy.Visible = true;
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            string manhanvien = tb_MaNhanVien.Text;
            string tennhanvien = tb_TenNhanVien.Text;
            DateTime ngaysinh = DateTime.Parse(dtp_NgaySinh.Text);
            string sdt = tb_SDT.Text;
            string mail = tb_Mail.Text;
            string mataikhoan = cb_TaiKhoan.Text;

            if(manhanvien != "" && tennhanvien != "" 
                && Convert.ToString(ngaysinh) != "" && sdt != "" && mail != "")
            {
                NhanVienDTO nhanvien = new NhanVienDTO(int.Parse(manhanvien), tennhanvien, ngaysinh, sdt, mail, int.Parse(mataikhoan));
                NhanVienBLL bLL = new NhanVienBLL();
                bLL.Update(nhanvien);
                cb_TaiKhoan_Load();

                tb_TenNhanVien.Enabled = false;
                dtp_NgaySinh.Enabled = false;
                tb_SDT.Enabled = false;
                tb_Mail.Enabled = false;
                cb_TaiKhoan.Enabled = false;
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
            tb_TenNhanVien.Enabled = false; tb_MaNhanVien.Text = "";
            dtp_NgaySinh.Enabled = false;   tb_TenNhanVien.Text = "";
            dtp_NgaySinh.Value = DateTime.Parse("01/01/2000");
            tb_SDT.Enabled = false;         tb_SDT.Text = "";
            tb_Mail.Enabled = false;        tb_Mail.Text = "";
            cb_TaiKhoan.Enabled = false;    cb_TaiKhoan.SelectedIndex = 0;
            btn_Luu.Visible = false;
            btn_Huy.Visible = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string manhanvien = tb_MaNhanVien.Text;
            NhanVienBLL nvBLL = new NhanVienBLL();
            if (cb_TaiKhoan.Text == "0")
            {
                nvBLL.Delete(manhanvien);
                MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Nhân viên đang còn tài khoản sử dụng, hãy chuyển sang tài khoản mã = 0 nếu muốn xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_KhoiPhucNV_Click(object sender, EventArgs e)
        {
            KhoiPhucNhanVien khoiPhucNhanVien = new KhoiPhucNhanVien();
            khoiPhucNhanVien.ShowDialog();
        }

        private void TimKiem(object sender, EventArgs e)
        {
            string input = tb_TimKiem.Text;
            grid_NhanVien.DataSource = nvBLL.TimKiem(input);
        }

        private void grid_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}