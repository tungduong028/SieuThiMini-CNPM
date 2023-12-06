using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPOI.SS.Formula.Functions;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;

namespace SieuThiMini.GUI
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            ThongKeBLL thongKeBLL = new ThongKeBLL();
            So_TongSP.Text = thongKeBLL.TongSoLuongSanPham().ToString();
            So_NhaCC.Text=thongKeBLL.SoLuongNhaCC().ToString();
            lb_nhanvien.Text=thongKeBLL.SoLuongNhanVien().ToString();
            lb_TaiKhoan.Text=thongKeBLL.SoTaiKhoan().ToString();
            tb_Year.Text=DateTime.Now.Year.ToString();
            comboBox1.Text = "0";

        }
        private void Timkiem_Click(object sender, EventArgs e)
        {
            ThongKeBLL thongKeBLL = new ThongKeBLL();
            int namhientai = DateTime.Now.Year;
            int selectedMonth;
            int selectedYear;
            DataTable result;


            if (string.IsNullOrEmpty(tb_Year.Text.Trim()))
            {
                tb_Year.Text = namhientai.ToString();
                selectedYear = namhientai;
            }
            else if (!int.TryParse(tb_Year.Text.Trim(), out selectedYear) || selectedYear <= 2000 || selectedYear > namhientai)
            {
                if (!int.TryParse(tb_Year.Text.Trim(), out selectedYear))
                {
                    MessageBox.Show("Vui lòng nhập năm là một số.");
                }
                else if (selectedYear <= 2000)
                {
                    MessageBox.Show("Vui lòng nhập năm là một số lớn hơn 2000.");
                    tb_Year.Text = namhientai.ToString();
                }
                else if (selectedYear > namhientai)
                {
                    MessageBox.Show("Không thể thống kê vì năm lớn hơn năm hiện tại.");
                    tb_Year.Text = namhientai.ToString();
                }
            }

            if (comboBox1.SelectedItem.ToString().Trim().Equals("0"))
            {
                So_Von.Text = thongKeBLL.TongChiPhiNhapHangTheoNam(selectedYear).ToString() + " đồng";
                So_DoanhThu.Text = thongKeBLL.TongDoanhThuHangNam(selectedYear).ToString() + " đồng";

                lbl_TKDonNhapHang.Text = thongKeBLL.SoDonNhapHangNam(selectedYear).ToString();
                lbl_TKHDdaban.Text = thongKeBLL.SoHoaDonNam(selectedYear).ToString();

                result = thongKeBLL.TimMaNhanVienCoTongTienLonNhatTheoNam(selectedYear);


            }
            else
            {
                selectedMonth = int.Parse(comboBox1.SelectedItem.ToString());
                So_Von.Text = thongKeBLL.TongChiPhiNhapHangTheoThangNam(selectedMonth, selectedYear).ToString() + " đồng";
                So_DoanhThu.Text = thongKeBLL.TongDoanhThuHangThangNam(selectedMonth, selectedYear).ToString() + " đồng";

                lbl_TKDonNhapHang.Text = thongKeBLL.SoDonNhapHangThangNam(selectedMonth, selectedYear).ToString();
                lbl_TKHDdaban.Text = thongKeBLL.SoHoaDonThangNam(selectedMonth, selectedYear).ToString();

                result = thongKeBLL.TimMaNhanVienCoTongTienLonNhatTheoThangNam(selectedMonth, selectedYear);


            }
            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];
                string maNhanVien = row["ma_nhan_vien"].ToString();
                string tenNhanVien = row["ten_nhan_vien"].ToString();
                string tongTienLonNhat = row["TongTienLonNhat"].ToString();

                // Hiển thị thông tin trên giao diện người dùng (label, textbox, v.v.)
                lb_MaNhanvien.Text = maNhanVien;
                lb_TenNhanvien.Text = tenNhanVien;
                lb_TongTienNhanVien.Text = tongTienLonNhat;
            }
            else
            {
                lb_MaNhanvien.Text = "...";
                lb_TenNhanvien.Text = "...";
                lb_TongTienNhanVien.Text = "...";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }
    }
}
