using SieuThiMini.BLL;
using SieuThiMini.DAL;
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
    public partial class ThemDonNhapHang : Form
    {
        private DataProvider dp = new DataProvider();
        private DataTable dt;
        int maNV;
        public ThemDonNhapHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV;
        }
        
        

        private void btn_addSanPham_Click(object sender, EventArgs e)
        {
            
        }

        private void ThemDonDatHang_Load(object sender, EventArgs e)
        {
            
            cbo_ncc.Items.Add(" ");

            cbo_ncc.SelectedIndex = 0;
            dt = dp.ExecuteQuery("SELECT ten_ncc FROM nha_cung_cap");
            foreach (DataRow dr in dt.Rows)
                cbo_ncc.Items.Add(dr["ten_ncc"].ToString());

            // Đơn nhập hàng
            dt = dp.ExecuteQuery("SELECT ma_san_pham, ten_san_pham, so_luong, gia, thanh_tien FROM chi_tiet_don_nhap_hang");
            dt.Clear();
            grid_DonNhapHang.DataSource = dt;
            grid_DonNhapHang.Columns["ma_san_pham"].HeaderText = "Mã sản phẩm";
            grid_DonNhapHang.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            grid_DonNhapHang.Columns["so_luong"].HeaderText = "Số lượng";
            grid_DonNhapHang.Columns["gia"].HeaderText = "Giá";
            grid_DonNhapHang.Columns["thanh_tien"].HeaderText = "Thành tiền";
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ThemMon_Click(object sender, EventArgs e)
        {
            cbo_ncc.Enabled = false;
            if (grid_SanPham.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm.");
                return;
            }


            dt = (DataTable)grid_SanPham.DataSource;
            DataGridViewRow selectedRow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];
            string validatencc = selectedRow.Cells["ma_ncc"].Value.ToString();

            foreach (DataGridViewRow dr in grid_DonNhapHang.Rows)
            {
                if (Convert.ToInt32(dr.Cells["ma_san_pham"].Value) == Convert.ToInt32(selectedRow.Cells["ma_san_pham"].Value))
                {
                    dr.Cells["so_luong"].Value = Convert.ToInt32(dr.Cells["so_luong"].Value) + ud_SoLuong.Value;
                    dr.Cells["thanh_tien"].Value = Convert.ToDecimal(dr.Cells["gia"].Value) * Convert.ToInt32(dr.Cells["so_luong"].Value);
                    grid_DonNhapHang.CurrentRow.Selected = false;
                    return;
                }
            }
            dt = (DataTable)grid_DonNhapHang.DataSource;
            int maSanPham = Convert.ToInt32(selectedRow.Cells["ma_san_pham"].Value);
            string tenSanPham = selectedRow.Cells["ten_san_pham"].Value.ToString();
            int soLuong = Convert.ToInt32(ud_SoLuong.Value);
            decimal gia_nhap = Convert.ToDecimal(selectedRow.Cells["gia_nhap"].Value);
            decimal total = ud_SoLuong.Value * gia_nhap;
            dt.Rows.Add(maSanPham, tenSanPham, soLuong, gia_nhap, total);
            grid_DonNhapHang.DataSource = dt;

            decimal totalGia = 0;
            foreach (DataGridViewRow dr in grid_DonNhapHang.Rows)
            {
                totalGia += Convert.ToDecimal(dr.Cells["thanh_tien"].Value);
            }

            // Cập nhật Label label_TT với tổng giá mới
            label_TT.Text = totalGia.ToString();

            grid_DonNhapHang.CurrentRow.Selected = false;
            return;
        }

        private void grid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_ncc.SelectedIndex != 0)
            {
                string nccSelected = cbo_ncc.GetItemText(cbo_ncc.SelectedItem);
                dt = dp.ExecuteQuery($"SELECT ma_san_pham, ncc.ma_ncc, ten_san_pham, gia_nhap " +
                $"FROM san_pham sp, loai_san_pham lsp, nha_cung_cap ncc " +
                $"WHERE sp.ma_loai = lsp.ma_loai AND ncc.ma_ncc = lsp.ma_ncc AND ncc.ten_ncc = '" + nccSelected + "'");
                grid_SanPham.DataSource = dt;
                grid_SanPham.CurrentCell.Selected = false;
            }
            else
            {
                dt = dp.ExecuteQuery("SELECT ma_san_pham, ten_san_pham, gia_nhap FROM san_pham");
                dt.Clear();
                grid_SanPham.DataSource = dt;
            }
      
        }

        private void cbo_loaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button_XoaDon_Click(object sender, EventArgs e)
        {
            if (grid_DonNhapHang.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn món để xóa.");
                return;
            }
            if (grid_DonNhapHang.RowCount == 1)
            {
                cbo_ncc.Enabled = true;
            }    
            grid_DonNhapHang.Rows.Remove(grid_DonNhapHang.Rows[grid_DonNhapHang.CurrentRow.Index]);
            grid_SanPham.CurrentRow.Selected = false;
        }

        private void grid_DonNhapHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == grid_DonNhapHang.Columns["thanh_tien"].Index)
            {
                decimal totalGia = 0;
                foreach (DataGridViewRow dr in grid_DonNhapHang.Rows)
                {
                    totalGia += Convert.ToDecimal(dr.Cells["thanh_tien"].Value);
                }
                label_TT.Text = totalGia.ToString();
            }
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            if (grid_DonNhapHang.Rows.Count == 0)
            {
                MessageBox.Show("Chọn món vào hóa đơn để thanh toán.");
                return;
            }
            else if (cbo_ncc.SelectedItem == null) 
            {
                MessageBox.Show("Chọn nhà cung cấp để thanh toán.");
                return;
            }
            DateTime ngayNhap = DateTime.Now;
            object selectedValue = cbo_ncc.SelectedItem;
            string Nhacungcap = null;

            if (selectedValue != null)
            {
                Nhacungcap = selectedValue.ToString();
               
            }

            NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
            List<NhaCungCapDTO> nccDTO = nhaCungCapBLL.getNCCByNameCC(Nhacungcap);
            int mancc = 0;

            foreach (var ncc in nccDTO)
            {
                mancc = ncc.maNhacungcap;
            }

            DonNhapHangBLL donNhapHangBLL = new DonNhapHangBLL();
            List<DonNhapHangDTO> dnhDTO = donNhapHangBLL.GetList(); 
            DonNhapHangDTO dthDTO_l = dnhDTO[dnhDTO.Count-1];
            int maDonNhap = dthDTO_l.maDonNH + 1;

            CTDonNhapHangBLL ctdnhBLL = new CTDonNhapHangBLL();

            SanPhamBLL spBLL = new SanPhamBLL();

            DonNhapHangDTO dnhDTO2 = new DonNhapHangDTO(0, mancc , maNV,ngayNhap, Convert.ToInt32(label_TT.Text),"1");
            donNhapHangBLL.Insert(dnhDTO2);

            foreach (DataGridViewRow dr in grid_DonNhapHang.Rows)
            {
                CTDonNhapHangDTO ctdnhDTO = new CTDonNhapHangDTO(maDonNhap, Convert.ToInt32(dr.Cells["ma_san_pham"].Value), dr.Cells["ten_san_pham"].Value.ToString(), Convert.ToInt32(dr.Cells["so_luong"].Value), Convert.ToInt32(dr.Cells["gia"].Value), Convert.ToInt32(dr.Cells["thanh_tien"].Value));
                SanPhamDTO spDTO = spBLL.getSPByMaSp(dr.Cells["ma_san_pham"].Value.ToString());
                spBLL.UpdateSoLuong(Convert.ToInt32(dr.Cells["ma_san_pham"].Value), spDTO.soLuong + Convert.ToInt32(dr.Cells["so_luong"].Value));
                ctdnhBLL.Insert(ctdnhDTO);
            }
            dt = dp.ExecuteQuery("SELECT ma_san_pham, ten_san_pham, so_luong, gia_nhap FROM san_pham");
            dt.Clear();
            grid_SanPham.DataSource = dt;
            

            dt = dp.ExecuteQuery("SELECT ma_san_pham, ten_san_pham, so_luong, gia, thanh_tien FROM chi_tiet_don_nhap_hang");
            dt.Clear();
            grid_DonNhapHang.DataSource = dt;
            MessageBox.Show("Thanh toán thành công.");
        }
    }
}
