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
    public partial class KhoiPhucLoaiSanPham : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        public KhoiPhucLoaiSanPham()
        {
            InitializeComponent();
        }

        private void KhoiPhucLoaiSanPham_Load(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_loai, ma_ncc, ten_loai FROM loai_san_pham WHERE trang_thai = 0");
            Data_View_LoaiSanPham.DataSource = dt;

            Data_View_LoaiSanPham.Columns["ma_loai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data_View_LoaiSanPham.Columns["ma_ncc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Data_View_LoaiSanPham.Columns["ten_loai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            Data_View_LoaiSanPham.Columns["ma_loai"].HeaderText = "Mã loại";
            Data_View_LoaiSanPham.Columns["ma_ncc"].HeaderText = "Mã nhà cung cấp";
            Data_View_LoaiSanPham.Columns["ten_loai"].HeaderText = "Tên loại";

            Data_View_LoaiSanPham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_View_LoaiSanPham.Columns["ma_loai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_View_LoaiSanPham.Columns["ma_ncc"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Data_View_LoaiSanPham.Columns["ten_loai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dt = dp.ExecuteQuery("SELECT ma_loai, ma_ncc, ten_loai FROM loai_san_pham WHERE trang_thai = 0");
            Data_View_LoaiSanPham.DataSource = dt;
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            if(Data_View_LoaiSanPham.SelectedRows.Count > 0)
            {
                int selectedRowIndex = Data_View_LoaiSanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = Data_View_LoaiSanPham.Rows[selectedRowIndex];
                int maloai = int.Parse(selectedRow.Cells["ma_loai"].Value.ToString());

                LoaiSanPhamBLL bll = new LoaiSanPhamBLL();
                bll.Restore(maloai);

                MessageBox.Show("Khôi phục loại sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Refresh_Click(null, null );
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 loại sản phẩm để khôi phục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimKiem(object sender, EventArgs e)
        {
            String maloai = tb_TimKiem.Text;
            String mancc = tb_TimKiem.Text;
            String tenloai = tb_TimKiem.Text;
            if (maloai != "" || mancc != "" || tenloai != "")
            {
                dt = dp.ExecuteQuery("SELECT ma_loai, ma_ncc, ten_loai FROM loai_san_pham WHERE ma_loai = '" + maloai + "' AND trang_thai = 0 OR ma_ncc ='" + mancc + "' AND trang_thai = 0 OR ten_loai LIKE '%" + tenloai + "%'" + " AND trang_thai = 0");
                Data_View_LoaiSanPham.DataSource = dt;
            }
            else
            {
                dt = dp.ExecuteQuery("SELECT ma_loai, ma_ncc, ten_loai  FROM loai_san_pham WHERE trang_thai = 0");
                Data_View_LoaiSanPham.DataSource = dt;
            }
        }
    }
}
