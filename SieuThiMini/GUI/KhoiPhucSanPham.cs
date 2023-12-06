using SieuThiMini.BLL;
using SieuThiMini.DAL;
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
    public partial class KhoiPhucSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public KhoiPhucSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucSanPham_Load(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_san_pham, ma_loai, ten_san_pham, so_luong, gia, gia_nhap FROM san_pham WHERE trang_thai = 0");
            grid_SanPham.DataSource = dt;

            grid_SanPham.Columns["ma_san_pham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["ma_loai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["ten_san_pham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["so_luong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["gia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_SanPham.Columns["gia_nhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            grid_SanPham.Columns["ma_san_pham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["ma_loai"].HeaderText = "Mã loại";
            grid_SanPham.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["so_luong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["gia"].HeaderText = "Giá";
            grid_SanPham.Columns["gia_nhap"].HeaderText = "Giá nhập";

            grid_SanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["ma_san_pham"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["ma_loai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["so_luong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["gia"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_SanPham.Columns["gia_nhap"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_san_pham, ma_loai, ten_san_pham, so_luong, gia, gia_nhap FROM san_pham WHERE trang_thai = 0");
            grid_SanPham.DataSource = dt;
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if (grid_SanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_SanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_SanPham.Rows[selectedRowIndex];
                int masp = int.Parse(selectedRow.Cells["ma_san_pham"].Value.ToString());

                SanPhamBLL bll = new SanPhamBLL();
                bll.Restore(masp);

                MessageBox.Show("Khôi phục loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Refresh_Click(null, null);
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tb_TimKiem_TextChanged(object sender, EventArgs e)
        {
            String masp = tb_TimSanPham.Text;
            String maloai = tb_TimSanPham.Text;
            String tensanpham = tb_TimSanPham.Text;
            if (masp != "" || maloai != "" || tensanpham != "")
            {
                dt = dp.ExecuteQuery("SELECT ma_san_pham, ma_loai, ten_san_pham, so_luong, gia , gia_nhap FROM san_pham WHERE ma_san_pham = '" + masp + "' AND trang_thai = 0 OR ma_loai ='" + maloai + "' AND trang_thai = 0 OR ten_san_pham LIKE'%" + tensanpham + "%' AND trang_thai = 0");
                grid_SanPham.DataSource = dt;
            }
            else
            {
                dt = dp.ExecuteQuery("SELECT ma_san_pham, ma_loai, ten_san_pham, so_luong, gia , gia_nhap FROM san_pham WHERE trang_thai = 0");
                grid_SanPham.DataSource = dt;
            }
        }
    }
}
