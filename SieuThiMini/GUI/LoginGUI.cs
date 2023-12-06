using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
        
    public partial class LoginGUI : Form
    {

        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private TaiKhoanDTO tkDTO;

        public LoginGUI()
        {
            InitializeComponent();
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "quanly1";
            txtPassword.Text = "123456";
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            try
            {
                tkDTO = tkBLL.SignIn(txtUsername.Text, txtPassword.Text);
            }
            catch
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            MessageBox.Show("Đăng nhập thành công.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // nhân viên
            if(tkDTO.maQuyen == 2)
            {
                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                NhanVienDTO nvDTO = nvBLL.getNVByTK(tkDTO.maTaikhoan.ToString());
                var formBH = new BanHang(nvDTO.maNhanvien);
                formBH.FormClosed += (s, args) => this.Close();
                formBH.Show(); 
            }
            // admin & quản lý
            else
            {
                this.Hide();
                NhanVienBLL nvBLL = new NhanVienBLL();
                NhanVienDTO nvDTO = nvBLL.getNVByTK(tkDTO.maTaikhoan.ToString());
                var formQL = new QuanLy(nvDTO.maNhanvien);
                formQL.FormClosed += (s, args) => this.Close();
                formQL.Show(); 
            }

            return;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
