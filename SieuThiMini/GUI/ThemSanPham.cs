using Microsoft.Win32.SafeHandles;
using NPOI.SS.Formula.Functions;
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
    public partial class ThemSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public ThemSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_loai FROM `loai_san_pham` ORDER BY `ma_loai` ASC");
            cb_Maloai.ValueMember = "ma_loai";
            cb_Maloai.DataSource = dt;
        }
        private void ThemSanPham_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_addSanPham_Click(object sender, EventArgs e)
        {
            int maloai;
            int masp = 0;
            String tensp = tb_TenSanPham.Text;
            int soluong = 0;
            int gia;
            int gianhap;
            if (tb_GiaSanPham.Text != "" && tb_GiaNhap.Text != "" && cb_Maloai.Text != "")
            {
                gia = int.Parse(tb_GiaSanPham.Text);
                gianhap = int.Parse(tb_GiaNhap.Text);
                maloai = int.Parse(cb_Maloai.Text);
            }
            else
            {
                gia = 0;
                gianhap = 0;
                maloai = 0;
            }
            if (tensp != "" && gia > 0 && maloai > 0 && gianhap > 0)
            {
                SanPhamDTO sanpham = new SanPhamDTO(masp, tensp, soluong, gia, gianhap, maloai, "1");
                SanPhamBLL bLL = new SanPhamBLL();
                bLL.Insert(sanpham);
                this.Close();
                MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không được bỏ trống bất cứ ô nào, giá bán và giá nhập phải lớn hơn 0", "Thông tin không hợp lệ, hãy kiểm tra lại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cb_Maloai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
