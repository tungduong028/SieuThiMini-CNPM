using NPOI.OpenXmlFormats.Dml.Chart;
using SieuThiMini.BLL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class CTDonNhapHang : Form
    {
        private string maDonNh;
        
        public CTDonNhapHang(string maDonNh)
        {
            InitializeComponent();
            this.maDonNh = maDonNh;
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tb_MaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void DonDatLoad(object sender, EventArgs e)
        {
            
        }

        private void btn_addDonNhap_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_saveDonNhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_HuyDon_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_editDonNhap_Click(object sender, EventArgs e)
        {
          
        }

        private void searchDonNhap_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lb_maDonNhap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_CTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CTDonNhapHang_Load(object sender, EventArgs e)
        {
            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
            DonNhapHangDTO donNhap = donNhapHangBLL.getDNHByMaDNH(maDonNh);

            display_Time.Text = donNhap.ngayNhap.ToString();
            display_MaDN.Text = donNhap.maDonNH.ToString();
            display_MaNV.Text = donNhap.maNhanvien.ToString();

            grid_CTDNH.Columns.Add("ten_san_pham", "Tên Sản Phẩm");
            this.Controls.Add(grid_CTDNH);

            CTDonNhapHangBLL ctdnBLL = new CTDonNhapHangBLL();

            List<CTDonNhapHangDTO> ctdnhList = ctdnBLL.getCTDNHByMaDNH(maDonNh);

            // Tạo một DataTable mới chỉ với các cột cần hiển thị
            DataTable dt = new DataTable();
            dt.Columns.Add("ten_san_pham", typeof(string));
            dt.Columns.Add("so_luong", typeof(int));
            dt.Columns.Add("gia", typeof(double));
            dt.Columns.Add("thanh_tien", typeof(double)); // Thêm cột thanh_tien vào DataTable

            dt.Columns["ten_san_pham"].ColumnName = "Tên sản phẩm";
            dt.Columns["so_luong"].ColumnName = "Số lượng";
            dt.Columns["gia"].ColumnName = "Giá tiền";
            dt.Columns["thanh_tien"].ColumnName = "Thành tiền";
            

            // Đổ dữ liệu từ danh sách chi tiết hóa đơn vào DataTable và tính tổng tiền
            double tongTien = 0;
            int mhd = 0;

            foreach (var ctdnh in ctdnhList)
            {
                dt.Rows.Add(ctdnh.tenSanpham, ctdnh.soLuong, ctdnh.giaSanpham, ctdnh.thanhTien);
                tongTien += ctdnh.thanhTien;
                mhd = ctdnh.maDonNH;

            }
            display_MaDN.Text = mhd.ToString();
            // Thêm dòng tổng tiền vào DataTable
            dt.Rows.Add("Tổng Tiền", DBNull.Value, DBNull.Value, tongTien);

            // Xóa các cột dư thừa trong DataGridView
            grid_CTDNH.Columns.Remove("ten_san_pham");

            // Gán DataTable cho DataGridView
            grid_CTDNH.DataSource = dt;
        }
    }
}
