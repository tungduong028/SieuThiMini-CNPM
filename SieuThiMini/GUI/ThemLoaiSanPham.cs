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
    public partial class ThemLoaiSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemLoaiSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            cb_MaNcc.ValueMember = "ma_ncc";
            cb_MaNcc.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_TenSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addSanPham_Click(object sender, EventArgs e)
        {
            int mancc;
            if (cb_MaNcc.Text != "")
            {
                mancc = int.Parse(cb_MaNcc.Text);
            }
            else
            {
                mancc = 0;
            }
            String tenloai = tb_TenLoai.Text;
            int maloai = 0;
            if (tenloai != "" && mancc >0)
            {
                LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO(maloai, tenloai, mancc, "1");
                LoaiSanPhamBLL bLL = new LoaiSanPhamBLL();
                bLL.Insert(loaisanpham);
                this.Close();
                MessageBox.Show("Thêm loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ ô nào", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemLoaiSanPham_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
