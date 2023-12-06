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
    public partial class LoaiSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        LoaiSanPhamBLL bLL = new LoaiSanPhamBLL();
        public LoaiSanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_ncc FROM `nha_cung_cap` ORDER BY `ma_ncc` ASC");
            foreach (DataRow dr in dt.Rows)
                cb_MaNcc.Items.Add(dr["ma_ncc"]);
        }
        private void LoaiSanPham_Load(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> list = bLL.GetList();
            grid_LoaiSanPham.DataSource = list;
            grid_LoaiSanPham.Columns["trangThai"].Visible = false;
            grid_LoaiSanPham.Columns["maloai"].HeaderText = "Mã loại";
            grid_LoaiSanPham.Columns["mancc"].HeaderText = "Mã nhà cung cấp";
            grid_LoaiSanPham.Columns["tenloai"].HeaderText = "Tên loại";

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            grid_LoaiSanPham_CellClick(null, datagridviewArgs);
        }
        private void grid_LoaiSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_TenLoai.Enabled = false;
            cb_MaNcc.Enabled = false;
            btn_saveLoai.Visible = false;
            btn_Huy.Visible = false;

            if (e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();
            row = grid_LoaiSanPham.Rows[e.RowIndex];
            tb_MaLoai.Text = Convert.ToString(row.Cells["maloai"].Value);
            tb_TenLoai.Text = Convert.ToString(row.Cells["tenloai"].Value);
            cb_MaNcc.Text = Convert.ToString(row.Cells["mancc"].Value);
        }


        private void btn_saveLoai_Click(object sender, EventArgs e)
        {

            int mancc;
            String tenloai = tb_TenLoai.Text;
            int maloai = int.Parse(tb_MaLoai.Text);
            if (cb_MaNcc.Text != "")
            {
                mancc = int.Parse(cb_MaNcc.Text);
            }
            else
            {
                mancc = 0;
            }
            if (tenloai != "" && mancc > 0)
            {
                LoaiSanPhamDTO loaisanpham = new LoaiSanPhamDTO(maloai, tenloai, mancc, "1");
                bLL.Update(loaisanpham);
                tb_TenLoai.Enabled = false;
                cb_MaNcc.Enabled = false;
                btn_saveLoai.Visible = false;
                btn_Huy.Visible = false;
                MessageBox.Show("Sửa thông tin loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<LoaiSanPhamDTO> list = bLL.GetList();
                grid_LoaiSanPham.DataSource = list;
            }
            else
            {
                MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ThemLoaiSP_Click(object sender, EventArgs e)
        {
            ThemLoaiSanPham themloaisanpham = new ThemLoaiSanPham();
            themloaisanpham.ShowDialog();
        }

        private void SuaLoaiSP_Click(object sender, EventArgs e)
        {
            if (tb_MaLoai.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_TenLoai.Enabled = true;
                cb_MaNcc.Enabled = true;
                btn_saveLoai.Visible = true;
                btn_Huy.Visible = true;
            }
            
        }
        private void TaiLai_Click(object sender, EventArgs e)
        {
            List<LoaiSanPhamDTO> list = bLL.GetList();
            grid_LoaiSanPham.DataSource = list;
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            int index = grid_LoaiSanPham.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            grid_LoaiSanPham_CellClick(null, datagridviewArgs);
        }
        private void TimKiem(object sender, EventArgs e)
        {
            string timkiem = tb_TimLoai.Text;
            LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> list = bll.timkiem(timkiem);
            grid_LoaiSanPham.DataSource = list;
        }

        private void btn_deleteLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (tb_MaLoai.Text != "")
            {
                int maloai = int.Parse(tb_MaLoai.Text.ToString());

                //Lấy danh sách SẢN PHẨM thuộc loại sản phẩm đang được chọn
                SanPhamBLL spbLL = new SanPhamBLL();
                List<SanPhamDTO> list = spbLL.getSPByLoaiSP(maloai);

                if (list.Count != 0) //Nếu danh sách khác rỗng => vẫn tồn tại sản phẩm thuộc về loại này
                {
                    MessageBox.Show("Không xóa được vì vẫn còn sản phẩm thuộc về loại sản phẩm này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bLL.Delete(maloai);

                    MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiLai_Click(null, null);
                    var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                    grid_LoaiSanPham_CellClick(null, datagridviewArgs);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucLoaiSanPham kp = new KhoiPhucLoaiSanPham();
            kp.ShowDialog();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
