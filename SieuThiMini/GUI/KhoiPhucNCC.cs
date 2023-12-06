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
    public partial class KhoiPhucNCC : Form
    {
        public KhoiPhucNCC()
        {
            InitializeComponent();
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string searchText = txt_TimKiem.Text.Trim().ToLower(); // Lấy nội dung của TextBox và chuyển về chữ thường

            if (string.IsNullOrEmpty(searchText))
            {

                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();

                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetListDeleted();

                grid_NCCDeleted.DataSource = danhSachNCC;
            }
            else
            {
                NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();

                List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetListDeleted();

                // Nếu TextBox có nội dung, tìm kiếm và lọc dữ liệu dựa trên nội dung
                var filteredRows = danhSachNCC.AsEnumerable()
                    .Where(row => row.maNhacungcap.ToString().ToLower().Contains(searchText)
                    || row.tenNhacungcap.ToString().ToLower().Contains(searchText))
                    .ToList();

                grid_NCCDeleted.DataSource = filteredRows;
            }
        }

        private void KhoiPhucNCC_Load(object sender, EventArgs e)
        {
            NhaCungCapBLL nhaCungCapBLL = new NhaCungCapBLL();

            List<NhaCungCapDTO> danhSachNCC = nhaCungCapBLL.GetListDeleted();

            grid_NCCDeleted.DataSource = danhSachNCC;

            grid_NCCDeleted.Columns["maNhacungcap"].HeaderText = "Mã Nhà Cung Cấp";
            grid_NCCDeleted.Columns["tenNhacungcap"].HeaderText = "Tên Nhà Cung Cấp";
            grid_NCCDeleted.Columns["diaChi"].HeaderText = "Địa Chỉ";
            grid_NCCDeleted.Columns["trangThai"].HeaderText = "Trạng Thái";

            grid_NCCDeleted.Columns["maNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NCCDeleted.Columns["tenNhacungcap"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grid_NCCDeleted.Columns["trangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            if (grid_NCCDeleted.SelectedRows.Count > 0)
            {
                int selectedRowIndex = grid_NCCDeleted.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grid_NCCDeleted.Rows[selectedRowIndex];
                string mancc = selectedRow.Cells["maNhacungcap"].Value.ToString();
                NhaCungCapBLL ncc = new NhaCungCapBLL();
                ncc.Restore(mancc);

                NhaCungCapBLL nhacungcap = new NhaCungCapBLL();
                List<NhaCungCapDTO> danhSachNCC = nhacungcap.GetListDeleted();

                // Đặt nguồn dữ liệu cho DataGridView
                grid_NCCDeleted.DataSource = danhSachNCC;


            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng trước khi xem thông tin.");
            }
        }
    }
}
