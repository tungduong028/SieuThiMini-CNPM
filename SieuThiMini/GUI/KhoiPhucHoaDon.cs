using SieuThiMini.BLL;
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
    public partial class KhoiPhucHoaDon : Form
    {
        
        public KhoiPhucHoaDon()
        {
            InitializeComponent();
            
        }

        private void KhoiPhucHoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

            grid_DsHDXoa.DataSource = danhSachHoaDon;
            grid_DsHDXoa.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
            grid_DsHDXoa.Columns["ngayXuat"].HeaderText = "Ngày Xuất";
            grid_DsHDXoa.Columns["maNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_DsHDXoa.Columns["tongTien"].HeaderText = "Tổng Tiền";
            grid_DsHDXoa.Columns["trangThai"].HeaderText = "Trạng Thái";

            grid_DsHDXoa.Columns["maHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DsHDXoa.Columns["ngayXuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DsHDXoa.Columns["maNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DsHDXoa.Columns["tongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DsHDXoa.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (grid_DsHDXoa.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DsHDXoa.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DsHDXoa.Rows[selectedRowIndex];
                string maHoaDon = selectedRow.Cells["maHoaDon"].Value.ToString();
                HoaDonBLL hoadon=new HoaDonBLL();
                hoadon.Update(maHoaDon);

                HoaDonBLL hd = new HoaDonBLL();
                List<HoaDonDTO> danhSachHoaDon = hd.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DsHDXoa.DataSource = danhSachHoaDon;
                


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_TimKiem.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DsHDXoa.DataSource = danhSachHoaDon;
            }
            else
            {
                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachHoaDon.AsEnumerable()
                    .Where(row => row.maHoaDon.ToString().ToLower().Contains(searchText)
                    || row.maNhanVien.ToString().ToLower().Contains(searchText)
                    || row.tongTien.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_DsHDXoa.DataSource = filteredRows;
            }
        }

        private void grid_DsHDXoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
