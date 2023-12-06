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
    public partial class ThemNhanVien : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemNhanVien()
        {
            InitializeComponent();
        }
        private void ThemNhanVien_Load(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_tai_khoan FROM tai_khoan WHERE trang_thai = '1'");
            cb_TaiKhoan.DisplayMember = "ma_tai_khoan";
            cb_TaiKhoan.DataSource = dt;
        }

        private bool MaNhanVienDaTonTai(string mnv)
        {
            dt = dp.ExecuteQuery("SELECT ma_nhan_vien FROM nhan_vien WHERE trang_thai = '1'");
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["ma_nhan_vien"].ToString() == mnv)
                    return true;
            }
            return false;
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            int manhanvien = 0;
            string tennhanvien = tb_TenNhanVien.Text;
            DateTime ngaysinh = DateTime.Parse(dtp_NgaySinh.Text);
            string sdt = tb_SDT.Text;
            string mail = tb_Mail.Text;
            string taikhoan = cb_TaiKhoan.Text;

            if ( tennhanvien != "" && sdt != "" && mail != "" && taikhoan != "")
            {
                NhanVienDTO nhanvien = new NhanVienDTO(manhanvien, tennhanvien, ngaysinh, sdt, mail, int.Parse(taikhoan));
                NhanVienBLL bLL = new NhanVienBLL();
                bLL.Insert(nhanvien);
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
