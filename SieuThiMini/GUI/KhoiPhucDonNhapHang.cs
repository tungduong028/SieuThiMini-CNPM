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
    public partial class KhoiPhucDonNhapHang : Form
    {
        public KhoiPhucDonNhapHang()
        {
            InitializeComponent();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_TimKiem.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DNHDeleted.DataSource = danhSachDonNhap;
            }
            else
            {
                DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachDonNhap.AsEnumerable()
                    .Where(row => row.maDonNH.ToString().ToLower().Contains(searchText)
                    || row.maNhacungcap.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_DNHDeleted.DataSource = filteredRows;
            }
        }

        private void grid_DNHDeleted_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KhoiPhucDonNhapHang_Load(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

            List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetListDeleted();

            grid_DNHDeleted.DataSource = danhSachDonNhap;

            grid_DNHDeleted.Columns["maDonNh"].HeaderText = "Mã Đơn Nhập";
            grid_DNHDeleted.Columns["maNhacungcap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_DNHDeleted.Columns["maNhanvien"].HeaderText = "Mã Nhân Viên";
            grid_DNHDeleted.Columns["ngayNhap"].HeaderText = "Ngày Đặt";
            grid_DNHDeleted.Columns["tongTien"].HeaderText = "Tổng Tiền";
            grid_DNHDeleted.Columns["trangThai"].HeaderText = "Trạng Thái";

            grid_DNHDeleted.Columns["maDonNh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["maNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["maNhanvien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["ngayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["tongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DNHDeleted.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (grid_DNHDeleted.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DNHDeleted.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DNHDeleted.Rows[selectedRowIndex];
                string maDonNh = selectedRow.Cells["maDonNh"].Value.ToString();
                DonNhapHangBLL donnhap = new DonNhapHangBLL();
                donnhap.Update(maDonNh);

                DonNhapHangBLL dn = new DonNhapHangBLL();
                List<DonNhapHangDTO> danhSachDonNhap = dn.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DNHDeleted.DataSource = danhSachDonNhap;


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
