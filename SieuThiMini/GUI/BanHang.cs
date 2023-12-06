using NPOI.SS.Formula.Functions;
using SieuThiMini.BLL;
using SieuThiMini.DAL;
using SieuThiMini.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThiMini.GUI
{
    public partial class BanHang : Form
    {

        private DataProvider dp = new DataProvider();
        int maNV;

        public BanHang(int maNV)
        {
            InitializeComponent();
            this.maNV = maNV; 
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            // Loại
            cbo_LoaiMon.Items.Add("Tất cả");
            cbo_LoaiMon.SelectedIndex = 0;
            LoaiSanPhamBLL lspBLL = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> dsLSP = lspBLL.GetList();
            foreach(LoaiSanPhamDTO i in dsLSP)
                cbo_LoaiMon.Items.Add(i.tenLoai);

            // DS Sản phẩm
            SanPhamBLL spBLL = new SanPhamBLL();
            List<SanPhamDTO> dsSP = spBLL.GetList();
            dsSP.RemoveAll(x => x.soLuong < 1);
            grid_SanPham.DataSource = dsSP;
            grid_SanPham.Columns["giaNhap"].Visible = false;
            grid_SanPham.Columns["maLoai"].Visible = false;
            grid_SanPham.Columns["trangthai"].Visible = false;
            grid_SanPham.CurrentCell.Selected = false;

            // Hóa đơn
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            grid_HoaDon.DataSource = dsCTHD;
            grid_HoaDon.Columns["maHoadon"].Visible = false;

            // Sửa tên cột
            grid_SanPham.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
            grid_SanPham.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
            grid_SanPham.Columns["soLuong"].HeaderText = "Số lượng";
            grid_SanPham.Columns["gia"].HeaderText = "Giá";

            grid_HoaDon.Columns["maSanPham"].HeaderText = "Mã sản phẩm";
            grid_HoaDon.Columns["tenSanPham"].HeaderText = "Tên sản phẩm";
            grid_HoaDon.Columns["soLuong"].HeaderText = "Số lượng";
            grid_HoaDon.Columns["giaSanPham"].HeaderText = "Giá";
            grid_HoaDon.Columns["thanhTien"].HeaderText = "Thành tiền";
        }

        private void update()
        {
            SanPhamBLL spBLL = new SanPhamBLL();
            LoaiSanPhamBLL lspBLL = new LoaiSanPhamBLL();
            List<SanPhamDTO> dsSP = spBLL.GetList();
            dsSP.RemoveAll(x => x.soLuong < 1);
            if(cbo_LoaiMon.SelectedIndex != 0)
            {
                string LoaiMonSelected = cbo_LoaiMon.GetItemText(cbo_LoaiMon.SelectedItem);
                int maLoai = lspBLL.getLoaiSPByNameLoaiSP(LoaiMonSelected)[0].maLoai;
                dsSP.RemoveAll(x => x.maLoai != maLoai);
                grid_SanPham.DataSource = dsSP;
                grid_SanPham.CurrentCell.Selected = false;
            }
            else
            {
                grid_SanPham.DataSource = dsSP;
                grid_SanPham.CurrentCell.Selected = false;
            }
        }
        private void update_TT()
        {
            if (grid_HoaDon.Rows.Count == 0)
            {
                label_TT.Text = "0";
                return;
            }
            decimal tong_tien = 0;
            foreach (DataGridViewRow dr in grid_HoaDon.Rows)
                tong_tien += Convert.ToDecimal(dr.Cells["thanhTien"].Value);
            label_TT.Text = tong_tien.ToString();
        }

        private void cbo_LoaiMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            update();
        }
        

        private void button_ThemMon_Click(object sender, EventArgs e)
        {
            if(grid_SanPham.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần thêm.");
                return;
            }
            else if(ud_SoLuong.Value == 0)
            {
                MessageBox.Show("Số lượng sản phẩm đã hết.");
                return;
            }

            //dt = (DataTable)grid_SanPham.DataSource;
            DataGridViewRow selectedRow = grid_SanPham.Rows[grid_SanPham.CurrentRow.Index];
            //update("UPDATE san_pham SET so_luong = so_luong - "+ ud_SoLuong.Value +"", grid_SanPham);

            foreach(DataGridViewRow dr in grid_HoaDon.Rows)
            {
                if (Convert.ToInt32(dr.Cells["maSanPham"].Value) == Convert.ToInt32(selectedRow.Cells["maSanPham"].Value))
                {
                    dr.Cells["soLuong"].Value = Convert.ToInt32(dr.Cells["soLuong"].Value) + ud_SoLuong.Value;
                    dr.Cells["thanhTien"].Value = Convert.ToDecimal(dr.Cells["giaSanPham"].Value) * Convert.ToInt32(dr.Cells["soLuong"].Value);
                    ud_SoLuong.Maximum = Convert.ToInt32(selectedRow.Cells["soLuong"].Value) - Convert.ToInt32(dr.Cells["soLuong"].Value);
                    grid_HoaDon.CurrentRow.Selected = false;
                    update_TT(); 
                    return;
                }
            }
            int maSanPham = Convert.ToInt32(selectedRow.Cells["maSanPham"].Value);
            string tenSanPham = selectedRow.Cells["tenSanPham"].Value.ToString();
            int soLuong = Convert.ToInt32(ud_SoLuong.Value);
            decimal gia = Convert.ToDecimal(selectedRow.Cells["gia"].Value);
            decimal total = ud_SoLuong.Value * gia;
            HoaDonBLL hdBLL = new HoaDonBLL();
            List<HoaDonDTO> dsHD = hdBLL.GetList();
            CTHoaDonDTO cthd = new CTHoaDonDTO(dsHD.Count - 1, maSanPham, tenSanPham, soLuong, (int)gia, (int)total);
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            dsCTHD.AddRange((List<CTHoaDonDTO>)grid_HoaDon.DataSource);
            dsCTHD.Add(cthd);
            grid_HoaDon.DataSource = dsCTHD;
            ud_SoLuong.Maximum = Convert.ToInt32(selectedRow.Cells["soLuong"].Value) - soLuong;
            //grid_HoaDon.CurrentRow.Selected = false;
            update_TT(); 
            return;
        }

        private void grid_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Số lượng
            foreach(DataGridViewRow dr in grid_HoaDon.Rows)
                if (Convert.ToInt32(dr.Cells["maSanPham"].Value) == Convert.ToInt32(grid_SanPham.Rows[e.RowIndex].Cells["maSanPham"].Value))
                {
                    ud_SoLuong.Maximum = Convert.ToDecimal(grid_SanPham.Rows[e.RowIndex].Cells["soLuong"].Value) - Convert.ToDecimal(dr.Cells["soLuong"].Value);
                    if(ud_SoLuong.Maximum > 0)
                        ud_SoLuong.Value = 1;
                    return;
                }
            ud_SoLuong.Maximum = Convert.ToDecimal(grid_SanPham.Rows[e.RowIndex].Cells["soLuong"].Value);
            if(ud_SoLuong.Maximum > 0)
                ud_SoLuong.Value = 1;
        }

        private void button_XoaMon_Click(object sender, EventArgs e)
        {
            if(grid_HoaDon.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn món để xóa.");
                return;
            }
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            dsCTHD.AddRange((List<CTHoaDonDTO>)grid_HoaDon.DataSource);
            dsCTHD.RemoveAll(x => x.maSanpham == Convert.ToInt32(grid_HoaDon.Rows[grid_HoaDon.CurrentRow.Index].Cells[1].Value));
            grid_HoaDon.DataSource = dsCTHD;
            grid_SanPham.CurrentRow.Selected = false;
            update_TT();
        }

        private void button_ThanhToan_Click(object sender, EventArgs e)
        {
            if(grid_HoaDon.Rows.Count == 0)
            {
                MessageBox.Show("Chọn món vào hóa đơn để thanh toán.");
                return;
            }
            DateTime ngayXuat = DateTime.Now;
            HoaDonDTO hdDTO = new HoaDonDTO(0, ngayXuat, maNV, Convert.ToInt32(label_TT.Text), "1");
            HoaDonBLL hdBLL = new HoaDonBLL();
            hdBLL.Insert(hdDTO);
            List<HoaDonDTO> lhdDTO = hdBLL.GetList();
            HoaDonDTO hdDTO_l = lhdDTO[lhdDTO.Count - 1];
            CTHoaDonBLL cthdBLL = new CTHoaDonBLL();
            List<CTHoaDonDTO> dsCTHD = new List<CTHoaDonDTO>();
            dsCTHD = (List<CTHoaDonDTO>)grid_HoaDon.DataSource;
            SanPhamBLL spBLL = new SanPhamBLL();
            foreach(CTHoaDonDTO ct in dsCTHD) {
                ct.maHoadon = hdDTO_l.maHoaDon;
                SanPhamDTO spDTO = spBLL.getSPByMaSp(ct.maSanpham.ToString());
                spBLL.UpdateSoLuong(ct.maSanpham, spDTO.soLuong - ct.soLuong);
                cthdBLL.Insert(ct);
            }
            List<SanPhamDTO> dsSP = spBLL.GetList();
            dsSP.RemoveAll(x => x.soLuong < 1);
            grid_SanPham.DataSource = dsSP;
            grid_SanPham.CurrentCell.Selected = false;

            lhdDTO.Clear();
            List<CTHoaDonDTO> temp = new List<CTHoaDonDTO>();
            grid_HoaDon.DataSource = temp;

            update_TT(); 
            MessageBox.Show("Thanh toán thành công.");
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string input = textBox_TimKiem.Text;
            SanPhamBLL spBLL = new SanPhamBLL();
            List<SanPhamDTO> dsSP = spBLL.GetList();
            dsSP.RemoveAll(x => x.soLuong < 1);

            var filtered = dsSP.Where(s => s.tenSanpham.ToLower().Contains(input.ToLower())).ToList();

            grid_SanPham.DataSource = filtered;
        }
    }
}
