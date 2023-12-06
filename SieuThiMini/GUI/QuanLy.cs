using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class QuanLy : Form
    {
        private int maNV;
        private NhanVienBLL nvBLL = new NhanVienBLL();
        private NhanVienDTO nvDTO;
        private TaiKhoanBLL tkBLL = new TaiKhoanBLL();
        private TaiKhoanDTO tkDTO;



        public QuanLy(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
            this.nvDTO = nvBLL.getNVByMaNV(maNV.ToString());
            this.tkDTO = tkBLL.getTKByMaTK(nvDTO.maTaikhoan.ToString());


        }

        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();

            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void QuanLy_Load(object sender, EventArgs e)
        {
            label_HoTenNV.Text = nvDTO.tenNhanvien;
            if (tkDTO.maQuyen == 1)
            {
                panel_TaiKhoan.Visible = false;
                panel_nhanvien.Visible = false;
            }

        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var formLogin = new LoginGUI();
            formLogin.Closed += (s, args) => this.Close();
            formLogin.Show();
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            openChildForm(new HoaDon());

        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new SanPham());
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongKe());
        }

        private void button_LoaiSanPham_Click(object sender, EventArgs e)
        {
            openChildForm(new LoaiSanPham());
        }

        private void label_HoTenNV_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new TaiKhoan());
        }

        private void button_NhanVien_Click(object sender, EventArgs e)
        {
            openChildForm(new NhanVien());
        }

        private void button_DonNhapHang_Click(object sender, EventArgs e)
        {
            openChildForm(new DonNhapHang());
        }

        private void button_NhaCungCap_Click(object sender, EventArgs e)
        {
            openChildForm(new NhaCungCap());
        }

        private void panel_Body_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
