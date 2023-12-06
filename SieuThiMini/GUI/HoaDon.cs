using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Data;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Protobuf;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SieuThiMini.GUI
{

    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
            
            
        }

        private void button_ViewDetails_Click(object sender, EventArgs e)
        {
            
            if (grid_DSHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSHoaDon.Rows[selectedRowIndex];
                string maHoaDon = selectedRow.Cells["maHoaDon"].Value.ToString();
                // Truyền thông tin từ dòng đã chọn trực tiếp cho form ChiTietHoaDon
                ChiTietHoaDon formChiTiet = new ChiTietHoaDon(maHoaDon);
                formChiTiet.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();

            // Gọi phương thức để lấy danh sách hóa đơn từ BLL
            List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetList();

            // Đặt nguồn dữ liệu cho DataGridView
            grid_DSHoaDon.DataSource = danhSachHoaDon;
            grid_DSHoaDon.Columns["maHoaDon"].HeaderText = "Mã Hóa Đơn";
            grid_DSHoaDon.Columns["ngayXuat"].HeaderText = "Ngày Xuất";
            grid_DSHoaDon.Columns["maNhanVien"].HeaderText = "Mã Nhân Viên";
            grid_DSHoaDon.Columns["tongTien"].HeaderText = "Tổng Tiền";
            grid_DSHoaDon.Columns["trangThai"].HeaderText = "Trạng Thái";

            grid_DSHoaDon.Columns["maHoaDon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["ngayXuat"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["maNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["tongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSHoaDon.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            

            

        }

        private void Excel_Export_Click(object sender, EventArgs e)
        {
            // Tạo hộp thoại lựa chọn tệp
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Chọn nơi lưu tệp Excel";
            saveFileDialog.FileName = "exported_data.xlsx"; // Tên mặc định của tệp

            // Hiển thị hộp thoại lựa chọn tệp và kiểm tra xem người dùng đã chọn đường dẫn lưu chưa
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;

                // Tạo một tệp Excel mới
                IWorkbook workbook = new XSSFWorkbook();
                ISheet sheet = workbook.CreateSheet("Sheet1");

                // Lấy dữ liệu từ DataGridView
                DataTable dt = new DataTable();

                // Thêm các cột tiêu đề vào DataTable
                foreach (DataGridViewColumn col in grid_DSHoaDon.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in grid_DSHoaDon.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dataRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dataRow);
                }

                // Thêm dòng tiêu đề vào tệp Excel
                IRow headerRow = sheet.CreateRow(0);
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    headerRow.CreateCell(i).SetCellValue(dt.Columns[i].ColumnName);
                }

                // Ghi dữ liệu từ DataTable vào Excel (bắt đầu từ dòng 2)
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    IRow excelRow = sheet.CreateRow(i + 1); // +1 để bỏ qua dòng tiêu đề

                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        ICell excelCell = excelRow.CreateCell(j);
                        excelCell.SetCellValue(dt.Rows[i][j].ToString());
                    }
                }

                // Lưu tệp Excel vào đĩa tại đường dẫn được chọn
                using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(stream);
                }

                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel và lưu tại đường dẫn: " + filePath);
            }

        }

        private void pickDate_start_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = pickDate_start.Value;
            DateTime selectedDateEnd = pickDate_end.Value;
            DateTime currentDate = DateTime.Now;
            if (selectedDate > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                // Đặt giá trị DateTimePicker thành ngày hiện tại
                pickDate_start.Value = currentDate;
                return;
            }
            

            // Hiển thị ngày đã chọn lên TextBox
            text_DateStart.Text = selectedDate.ToShortDateString();
        }

        private void pickDate_end_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedStartDate = pickDate_start.Value;
            DateTime selectedDate = pickDate_end.Value;
            DateTime currentDate = DateTime.Now;

            if (selectedDate > currentDate)
            {
                MessageBox.Show("Vui lòng chọn ngày không lớn hơn ngày hiện tại.");
                // Đặt giá trị DateTimePicker thành ngày hiện tại
                pickDate_end.Value = currentDate;

            }
            else if (selectedStartDate > selectedDate)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.");
                // Đặt giá trị DateTimePicker thành ngày bắt đầu
                pickDate_end.Value = currentDate;
            }
            else if (text_DateStart.Text == "" || text_DateStart.Text.Contains(" "))
            {
                MessageBox.Show("Hãy chọn ngày bắt đầu trước");
            }
            else
            {
                // Hiển thị ngày đã chọn lên TextBox
                text_DateEnd.Text = selectedDate.ToShortDateString();
            }

        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            HoaDonBLL hoaDonBLL = new HoaDonBLL();

            // Gọi phương thức để lấy danh sách hóa đơn từ BLL
            List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetList();

            // Đặt nguồn dữ liệu cho DataGridView
            grid_DSHoaDon.DataSource = danhSachHoaDon;
            text_DateStart.Text = "";
            text_DateEnd.Text = "";
        }

        private void text_Find_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_Find.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DSHoaDon.DataSource = danhSachHoaDon;
            }
            else
            {
                HoaDonBLL hoaDonBLL = new HoaDonBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
               
                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachHoaDon.AsEnumerable()
                    .Where(row => row.maHoaDon.ToString().ToLower().Contains(searchText)
                    || row.maNhanVien.ToString().ToLower().Contains(searchText)
                    || row.tongTien.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_DSHoaDon.DataSource = filteredRows;
            }
        }

        private void Find_date_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = pickDate_start.Value.Date;
            DateTime ngayKetThuc = pickDate_end.Value.Date;

            HoaDonBLL hoaDonBLL = new HoaDonBLL();

            // Gọi phương thức để lấy danh sách hóa đơn từ BLL
            List<HoaDonDTO> danhSachHoaDon = hoaDonBLL.GetList();
            // Lọc danh sách hóa đơn dựa trên khoảng ngày bắt đầu và kết thúc
            
            if (ngayBatDau < ngayKetThuc)
            {
                 var filteredRows = danhSachHoaDon
                .Where(row =>
                    (row.ngayXuat.Date >= ngayBatDau && row.ngayXuat.Date <= ngayKetThuc))
                .ToList();
                grid_DSHoaDon.DataSource = filteredRows;
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                grid_DSHoaDon.DataSource = danhSachHoaDon;
                text_DateStart.Text = "";
                text_DateEnd.Text = "";
            }
            
            

            
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            KhoiPhucHoaDon khoiPhucHoaDon = new KhoiPhucHoaDon();
            khoiPhucHoaDon.ShowDialog();
            
        }

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (grid_DSHoaDon.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSHoaDon.Rows[selectedRowIndex];
                string maHoaDon = selectedRow.Cells["maHoaDon"].Value.ToString();
                
                HoaDonBLL hd = new HoaDonBLL();
                hd.Delete(maHoaDon);
                List<HoaDonDTO> danhSachHoaDon = hd.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DSHoaDon.DataSource = danhSachHoaDon;
                

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }
    }
}
