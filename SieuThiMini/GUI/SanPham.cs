using Google.Protobuf.WellKnownTypes;
using Org.BouncyCastle.Utilities.Collections;
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
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class SanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;

        public SanPham()
        {
            InitializeComponent();
            dt = dp.ExecuteQuery("SELECT ma_loai FROM `loai_san_pham` ORDER BY `ma_loai` ASC");
            foreach (DataRow dr in dt.Rows)
                cb_Maloai.Items.Add(dr["ma_loai"]);
        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            SanPhamBLL bLL = new SanPhamBLL();
            List<SanPhamDTO> list = bLL.GetList();
            grid_SanPham.DataSource = list;

            grid_SanPham.Columns["trangthai"].Visible = false;
            grid_SanPham.Columns["maSanpham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["maLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["tenSanpham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["soLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["gia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["gianhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            grid_SanPham.Columns["maSanpham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["maLoai"].HeaderText = "Mã loại";
            grid_SanPham.Columns["tenSanpham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["soLuong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["gia"].HeaderText = "Giá";
            grid_SanPham.Columns["gianhap"].HeaderText = "Giá nhập";

            grid_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["maSanpham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["maLoai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["soLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["gianhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            grid_SanPham_CellClick(null, datagridviewArgs);
        }
        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_TenSanPham.Enabled = false;
            tb_GiaNhap.Enabled = false;
            tb_GiaSanPham.Enabled = false;
            btn_saveSanPham.Visible = false;
            btn_Huy.Visible = false;
            cb_Maloai.Enabled = false;

            if (e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();
            row = grid_SanPham.Rows[e.RowIndex];
            tb_MaSanPham.Text = Convert.ToString(row.Cells["maSanpham"].Value);
            cb_Maloai.Text = Convert.ToString(row.Cells["maLoai"].Value);
            tb_TenSanPham.Text = Convert.ToString(row.Cells["tenSanpham"].Value);
            tb_GiaSanPham.Text = Convert.ToString(row.Cells["gia"].Value);
            tb_GiaNhap.Text = Convert.ToString(row.Cells["gianhap"].Value);
            tb_SoLuongSanPham.Text = Convert.ToString(row.Cells["soLuong"].Value);
        }
        private void ThemSanPham_Click(object sender, EventArgs e)
        {
            ThemSanPham themSanPham = new ThemSanPham();
            themSanPham.ShowDialog();
        }
        private void SuaSanPham_Click(object sender, EventArgs e)
        {
            if (tb_MaSanPham.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 sản phẩm để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_TenSanPham.Enabled = true;
                tb_GiaSanPham.Enabled = true;
                tb_GiaNhap.Enabled = true;
                btn_saveSanPham.Visible = true;
                btn_Huy.Visible = true;
                cb_Maloai.Enabled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            
            int maloai = int.Parse(cb_Maloai.Text);
            int masp = int.Parse(tb_MaSanPham.Text);
            String tensp = tb_TenSanPham.Text;
            int soluong = int.Parse(tb_SoLuongSanPham.Text);
            int gia;
            int gianhap;
            if (tb_GiaSanPham.Text != "" && tb_GiaNhap.Text != "")
            {
                gianhap = int.Parse(tb_GiaNhap.Text);
                gia = int.Parse(tb_GiaSanPham.Text);
            }
            else
            {
                gia = 0;
                gianhap = 0;
            }
            if (tensp != "" && gia > 0 && gianhap > 0)
            {
                SanPhamDTO sanpham = new SanPhamDTO(masp, tensp, soluong, gia, gianhap, maloai,"1");
                SanPhamBLL bLL = new SanPhamBLL();
                bLL.Update(sanpham);
                tb_TenSanPham.Enabled = false;
                tb_GiaSanPham.Enabled = false;
                tb_GiaNhap.Enabled = false;
                cb_Maloai.Enabled = false;
                btn_saveSanPham.Visible = false;
                btn_Huy.Visible = false;
                MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dt = dp.ExecuteQuery("SELECT ma_san_pham, ma_loai, ten_san_pham, so_luong, gia , gia_nhap FROM san_pham WHERE trang_thai = 1");
                grid_SanPham.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Các hạn chế gồm:\n \n1. Không được bỏ trống bất cứ thông tin nào \n2. Giá bán và giá nhập phải lớn hơn 0", "Thông tin không hợp lệ! Hãy kiểm tra lại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            int index = grid_SanPham.SelectedRows[0].Index;
            var datagridviewArgs = new DataGridViewCellEventArgs(0, index);
            grid_SanPham_CellClick(null, datagridviewArgs);
        }
        private void btn_deleteSanPham_Click(object sender, EventArgs e)
        {
            int masp = int.Parse(tb_MaSanPham.Text);
            int soluong = int.Parse(tb_SoLuongSanPham.Text);
            if( soluong == 0)
            {
                SanPhamBLL bll = new SanPhamBLL();
                bll.Delete(masp);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TaiLai_Click(null, null);
            }
            else
            {
                MessageBox.Show("Không được xóa sản phẩm vẫn còn số lượng lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void TimKiem(object sender, EventArgs e)
        {
            String timkiem = tb_TimSanPham.Text;
            SanPhamBLL bLL = new SanPhamBLL();
            List<SanPhamDTO> list = bLL.Timkiem(timkiem);
            grid_SanPham.DataSource = list;

        }
        private void TaiLai_Click(object sender, EventArgs e)
        {
            SanPhamBLL bLL = new SanPhamBLL();
            List<SanPhamDTO> list = bLL.GetList();
            grid_SanPham.DataSource = list;
        }

        private void KhoiPhuc_Click(object sender, EventArgs e)
        {
            KhoiPhucSanPham kp = new KhoiPhucSanPham();
            kp.ShowDialog();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
