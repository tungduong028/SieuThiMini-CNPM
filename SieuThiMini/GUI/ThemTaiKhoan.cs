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
    public partial class ThemTaiKhoan : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;

        public ThemTaiKhoan()
        {
            InitializeComponent();
        }
        private void ThemTaiKhoan_Load(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_quyen FROM phan_quyen");
            cb_PhanQuyen.DisplayMember = "ma_quyen";
            cb_PhanQuyen.DataSource = dt;
        }

        private bool MaTaiKhoanDaTonTai(string mtk)
        {
            dt = dp.ExecuteQuery("SELECT ma_tai_khoan FROM tai_khoan");
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["ma_tai_khoan"].ToString() == mtk)
                    return true;
            }
            return false;
        }
        public bool IsNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            int mataikhoan = 0;
            string tentaikhoan = tb_TenTaiKhoan.Text;
            string matkhau = tb_MatKhau.Text;
            string phanquyen = cb_PhanQuyen.Text;
            if ( tentaikhoan != "" && matkhau != "")
            {
                TaiKhoanDTO taikhoan = new TaiKhoanDTO(mataikhoan, tentaikhoan, matkhau, int.Parse(phanquyen), "1");
                TaiKhoanBLL bLL = new TaiKhoanBLL();
                bLL.Insert(taikhoan);
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
