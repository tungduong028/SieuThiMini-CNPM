using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.OpenXmlFormats.Dml.Chart;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;

namespace SieuThiMini.GUI
{


    public partial class ChiTietHoaDon : Form
    {
        private string maHoaDon;
        private string manhanvien;
        private CTHoaDonBLL cthdBLL;

        public ChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            this.manhanvien = manhanvien;
            this.cthdBLL = new CTHoaDonBLL();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Chỉ cho phép khung cố định, không cho phép thay đổi kích thước

            // Vô hiệu hóa nút phóng to màn hình
            this.MaximizeBox = false;

            // Vô hiệu hóa nút thu nhỏ màn hình
            this.MinimizeBox = false;

        }


        private void ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            
            
            HoaDonBLL hoaDonBLL = new HoaDonBLL();
            HoaDonDTO hoaDon = hoaDonBLL.getHDByMaHD(maHoaDon);


            // Hiển thị thông tin hóa đơn (ví dụ: lấy thông tin của hóa đơn đầu tiên)
            display_Time.Text = hoaDon.ngayXuat.ToString();
            display_MaNV.Text = hoaDon.maNhanVien.ToString();

            grid_CTHD.Columns.Add("ten_san_pham", "Tên Sản Phẩm");
            this.Controls.Add(grid_CTHD);

            // Gọi hàm getCTHoaDonByMaHD từ BLL để lấy danh sách chi tiết hóa đơn
            List<CTHoaDonDTO> cthdList = cthdBLL.getCTHoaDonByMaHD(maHoaDon);


            // Tạo một DataTable mới chỉ với các cột cần hiển thị
            DataTable dt = new DataTable();
            dt.Columns.Add("ten_san_pham", typeof(string));
            dt.Columns.Add("so_luong", typeof(int));
            dt.Columns.Add("gia_tien", typeof(double));
            dt.Columns.Add("thanh_tien", typeof(double)); // Thêm cột thanh_tien vào DataTable

            dt.Columns["ten_san_pham"].ColumnName = "Tên sản phẩm";
            dt.Columns["so_luong"].ColumnName = "Số lượng";
            dt.Columns["gia_tien"].ColumnName = "Giá tiền";
            dt.Columns["thanh_tien"].ColumnName = "Thành tiền";

            // Đổ dữ liệu từ danh sách chi tiết hóa đơn vào DataTable và tính tổng tiền
            double tongTien = 0;
            int mhd = 0;
            foreach (var cthd in cthdList)
            {
                dt.Rows.Add(cthd.tenSanpham, cthd.soLuong, cthd.giaSanpham, cthd.thanhTien);
                tongTien += cthd.thanhTien;
                mhd = cthd.maHoadon;

            }
            display_MaHD.Text = mhd.ToString();
            // Thêm dòng tổng tiền vào DataTable
            dt.Rows.Add("Tổng Tiền", DBNull.Value, DBNull.Value, tongTien);

            // Xóa các cột dư thừa trong DataGridView
            grid_CTHD.Columns.Remove("ten_san_pham");

            // Gán DataTable cho DataGridView
            grid_CTHD.DataSource = dt;
        }

        private void btn_InHD_Click(object sender, EventArgs e)
        {
            // Tạo tệp PDF mới
            
            PdfDocument document = new PdfDocument();
            PdfPage page = document.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont font = new XFont("Arial", 12);
            XFont fontTitle = new XFont("Arial bold", 14);
            XFont fontHeader = new XFont("Arial bold", 16);
            // Vẽ thông tin hóa đơn lên tệp PDF
            int y = 50, x = 100;
            gfx.DrawString("HÓA ĐƠN BÁN HÀNG", fontHeader, XBrushes.Black, new XRect(0, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 40;
            gfx.DrawString($"Ngày xuất: {display_Time.Text}", font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
            y += 40;
            gfx.DrawString($"Mã hóa đơn: {display_MaHD.Text}", font, XBrushes.Black, new XRect(x, y, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Mã nhân viên: {display_MaNV.Text}", font, XBrushes.Black, new XRect(x + 50, y, page.Width, page.Height), XStringFormats.TopCenter);
            y += 50;

            // Vẽ bảng cho thông tin chi tiết hóa đơn
            int tableX = x;
            int tableY = y;
            int cellWidth = 100; // Độ rộng của mỗi ô
            int cellHeight = 20; // Độ cao của mỗi ô
            int numRows = grid_CTHD.Rows.Count;
            int numColumns = 4; // Số cột trong bảng (Tên sản phẩm, Số lượng, Giá tiền, Thành tiền)

            // Vẽ tiêu đề cho bảng
            gfx.DrawRectangle(XPens.Black, tableX, tableY, cellWidth * numColumns, cellHeight);
            gfx.DrawString("Tên sản phẩm", fontTitle, XBrushes.Black, new XRect(tableX, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Số lượng", fontTitle, XBrushes.Black, new XRect(tableX + cellWidth, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Giá tiền", fontTitle, XBrushes.Black, new XRect(tableX + 2 * cellWidth, tableY, cellWidth, cellHeight), XStringFormats.Center);
            gfx.DrawString("Thành tiền", fontTitle, XBrushes.Black, new XRect(tableX + 3 * cellWidth, tableY, cellWidth, cellHeight), XStringFormats.Center);

            // Vẽ dữ liệu từ DataGridView vào bảng
            for (int rowIdx = 0; rowIdx < numRows; rowIdx++)
            {
                y += cellHeight;
                tableY += cellHeight;
                gfx.DrawRectangle(XPens.Black, tableX, tableY, cellWidth * numColumns, cellHeight);

                for (int colIdx = 0; colIdx < numColumns; colIdx++)
                {
                    string cellValue = grid_CTHD.Rows[rowIdx].Cells[colIdx].Value.ToString();
                    gfx.DrawString(cellValue, font, XBrushes.Black, new XRect(tableX + colIdx * cellWidth, tableY, cellWidth, cellHeight), XStringFormats.Center);
                }
            }

            // Sử dụng SaveFileDialog để chọn đường dẫn và tên tệp PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                // Lưu tệp PDF vào đường dẫn đã chọn
                document.Save(filePath);

                // Mở tệp PDF bằng ứng dụng mặc định
                Process.Start(filePath);
            }
        }

        private void grid_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}