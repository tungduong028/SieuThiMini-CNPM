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
    public partial class NhaCungCap : Form
    {
        DataTable dt;
        DataProvider dp = new DataProvider();
        NhaCungCapBLL bLL = new NhaCungCapBLL();
        public NhaCungCap()
        {
            InitializeComponent();
        }

        private void NCCLoad(object sender, EventArgs e)
        {
            NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
            List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetList();

            grid_NhaCungCap.DataSource = danhSachNCC;
            grid_NhaCungCap.Columns["maNhacungcap"].HeaderText = "Mã nhà cung cấp";
            grid_NhaCungCap.Columns["tenNhacungcap"].HeaderText = "Tên nhà cung cấp";
            grid_NhaCungCap.Columns["diaChi"].HeaderText = "Địa Chỉ";
            grid_NhaCungCap.Columns["trangThai"].Visible = false;

            var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
            grid_NhaCungCap_CellClick(null, datagridviewArgs);
        }
        private void tb_MaSanPham_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addNCC_Click(object sender, EventArgs e)
        {
            ThemNhaCungCap themNhaCungCap = new ThemNhaCungCap();
            themNhaCungCap.ShowDialog();
        }

        private void btn_editNCC_Click(object sender, EventArgs e)
        {
            if(tb_MaNCC.Text == "")
            {
                MessageBox.Show("Hãy chọn 1 nhà cung cấp để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tb_tenncc.Enabled = true;
             
                tb_diachi.Enabled = true;
                btn_saveNCC.Visible = true;
                btn_HuyNCC.Visible = true;
            }
        }

        private void btn_saveNCC_Click(object sender, EventArgs e)
        {
            int mancc = int.Parse(tb_MaNCC.Text);
            string tenncc = tb_tenncc.Text;
            string diachi = tb_diachi.Text;
            string trangthai = "1";
            if (tenncc != "" && diachi != "")
            {
                NhaCungCapDTO dto = new NhaCungCapDTO(mancc, tenncc, diachi, trangthai);
                NhaCungCapBLL bll = new NhaCungCapBLL();
                bll.Update(dto);
                tb_tenncc.Enabled = false;
                tb_diachi.Enabled = false;
                btn_saveNCC.Visible = false;
                btn_HuyNCC.Visible = false;
                MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<NhaCungCapDTO> danhSachNCC = bll.GetList();

                grid_NhaCungCap.DataSource = danhSachNCC;
            }
        }

        private void btn_HuyNCC_Click(object sender, EventArgs e)
        {
            tb_tenncc.Enabled = false;
            tb_MaNCC.Enabled = false;
            tb_diachi.Enabled = false;
            btn_saveNCC.Visible = false;
            btn_HuyNCC.Visible = false;
        }

        private void grid_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tb_TimNCC_TextChanged(object sender, EventArgs e)
        {
            string searchText = tb_TimNCC.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetList();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_NhaCungCap.DataSource = danhSachNCC;
            }
            else
            {
                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetList();

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachNCC.AsEnumerable()
                    .Where(row => row.maNhacungcap.ToString().ToLower().Contains(searchText)
                    || row.tenNhacungcap.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_NhaCungCap.DataSource = filteredRows;
            }
        }

        private void grid_NhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_MaNCC.Enabled = false;
            tb_tenncc.Enabled = false;
            tb_diachi.Enabled = false;
            btn_saveNCC.Visible = false;
            btn_HuyNCC.Visible = false;


            if (e.RowIndex == -1) return;
            DataGridViewRow row = new DataGridViewRow();
            row = grid_NhaCungCap.Rows[e.RowIndex];
            tb_MaNCC.Text = Convert.ToString(row.Cells["maNhacungcap"].Value);
            tb_tenncc.Text = Convert.ToString(row.Cells["tenNhacungcap"].Value);
            tb_diachi.Text = Convert.ToString(row.Cells["diaChi"].Value);
        }

        private void tb_TaiLai_Click(object sender, EventArgs e)
        {
            NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();
            List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetList();
            grid_NhaCungCap.DataSource = danhSachNCC;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (tb_MaNCC.Text != "")
            {
                int mancc = int.Parse(tb_MaNCC.Text);
                LoaiSanPhamBLL lsp = new LoaiSanPhamBLL();
                List<LoaiSanPhamDTO> list = lsp.getLoaiSPByNCC(mancc);

                if (list.Count != 0)
                {
                    MessageBox.Show("Không xóa được vì vẫn còn loại sản phẩm thuộc về nhà cung cấp này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    bLL.Delete(mancc);

                    MessageBox.Show("xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TaiLai_Click(null, null);
                    var datagridviewArgs = new DataGridViewCellEventArgs(0, 0);
                    grid_NhaCungCap_CellClick(null, datagridviewArgs);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 nhà cung cấp để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            KhoiPhucNCC khoiPhucNCC = new KhoiPhucNCC();
            khoiPhucNCC.ShowDialog();
        }
    }
}
