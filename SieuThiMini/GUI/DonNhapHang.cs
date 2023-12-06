using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class DonNhapHang : Form
    {
        public DonNhapHang()
        {
            InitializeComponent();
            
        }
        
        
        private void btn_addDonDat_Click(object sender, EventArgs e)
        {
            int maNv = 4;   
            ThemDonNhapHang themDonNhapHang = new ThemDonNhapHang(maNv);
            themDonNhapHang.ShowDialog();
        }
        private void DonDatLoad(object sender, EventArgs e)
        {

            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

            List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetList();

            grid_DSDonNhap.DataSource = danhSachDonNhap;

            grid_DSDonNhap.Columns["maDonNh"].HeaderText = "Mã Đơn Nhập";
            grid_DSDonNhap.Columns["maNhacungcap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_DSDonNhap.Columns["maNhanvien"].HeaderText = "Mã Nhân Viên";
            grid_DSDonNhap.Columns["ngayNhap"].HeaderText = "Ngày Đặt";
            grid_DSDonNhap.Columns["tongTien"].HeaderText = "Tổng Tiền";
            grid_DSDonNhap.Columns["trangThai"].HeaderText = "Trạng Thái";

            grid_DSDonNhap.Columns["maDonNh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhap.Columns["maNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhap.Columns["maNhanvien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhap.Columns["ngayNhap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhap.Columns["tongTien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_DSDonNhap.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_editDonDat_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            
        }

        private void grid_DonNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        


        private void searchDonNhap_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void text_Find_TextChanged(object sender, EventArgs e)
        {
            string searchText = text_Find.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DSDonNhap.DataSource = danhSachDonNhap;
            }
            else
            {
                DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetList();

                // Đặt nguồn dữ liệu cho DataGridView

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachDonNhap.AsEnumerable()
                    .Where(row => row.maDonNH.ToString().ToLower().Contains(searchText)
                    || row.maNhacungcap.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_DSDonNhap.DataSource = filteredRows;
            }
        }

        private void grid_DSHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

                // Gọi phương thức để lấy danh sách hóa đơn từ BLL
                List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetList();

            // Đặt nguồn dữ liệu cho DataGridView
            grid_DSDonNhap.DataSource = danhSachDonNhap;
            text_DateStart.Text = "";
            text_DateEnd.Text = "";
        }

        private void button_ViewDetails_Click(object sender, EventArgs e)
        {
            if (grid_DSDonNhap.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSDonNhap.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSDonNhap.Rows[selectedRowIndex];
                string maDonNh = selectedRow.Cells["maDonNh"].Value.ToString();
                // Truyền thông tin từ dòng đã chọn trực tiếp cho form ChiTietHoaDon
                CTDonNhapHang formChiTiet = new CTDonNhapHang(maDonNh);
                formChiTiet.ShowDialog();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
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
                foreach (DataGridViewColumn col in grid_DSDonNhap.Columns)
                {
                    dt.Columns.Add(col.HeaderText);
                }

                // Thêm dữ liệu từ DataGridView vào DataTable
                foreach (DataGridViewRow row in grid_DSDonNhap.Rows)
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

        private void Find_date_Click(object sender, EventArgs e)
        {
            DateTime ngayBatDau = pickDate_start.Value.Date;
            DateTime ngayKetThuc = pickDate_end.Value.Date;

            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();

            // Gọi phương thức để lấy danh sách hóa đơn từ BLL
            List<DonNhapHangDTO> danhSachDonNhap = donNhapHangBLL.GetList();
            // Lọc danh sách hóa đơn dựa trên khoảng ngày bắt đầu và kết thúc

            if (ngayBatDau < ngayKetThuc)
            {
                var filteredRows = danhSachDonNhap
               .Where(row =>
                   (row.ngayNhap.Date >= ngayBatDau && row.ngayNhap.Date <= ngayKetThuc))
               .ToList();
                grid_DSDonNhap.DataSource = filteredRows;
            }
            else
            {
                MessageBox.Show("Không hợp lệ");
                grid_DSDonNhap.DataSource = danhSachDonNhap;
                text_DateStart.Text = "";
                text_DateEnd.Text = "";
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
                pickDate_end.Value = selectedStartDate;
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

        private void button_Remove_Click(object sender, EventArgs e)
        {
            if (grid_DSDonNhap.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_DSDonNhap.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_DSDonNhap.Rows[selectedRowIndex];
                string maDonNh = selectedRow.Cells["maDonNh"].Value.ToString();

                DonNhapHangBLL donnhap = new DonNhapHangBLL();
                donnhap.Delete(maDonNh);
                List<DonNhapHangDTO> danhSachDonNhap = donnhap.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_DSDonNhap.DataSource = danhSachDonNhap;


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }

        private void button_Restore_Click(object sender, EventArgs e)
        {
            KhoiPhucDonNhapHang khoiPhucDonNhapHang = new KhoiPhucDonNhapHang();
            khoiPhucDonNhapHang.ShowDialog();
        }
    }

        
    }

