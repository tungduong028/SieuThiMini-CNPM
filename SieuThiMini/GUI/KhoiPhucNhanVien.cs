using SieuThiMini.BLL;
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
    public partial class KhoiPhucNhanVien : Form
    {
        NhanVienBLL nvBll = new NhanVienBLL();
        public KhoiPhucNhanVien()
        {
            InitializeComponent();
        }

        private void KhoiPhucNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = nvBll.getDeletedNhanVien();
            grid_NhanVien.DataSource = dt;
        }

        private void grid_NhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void tb_TimNhanVien_TextChanged(object sender, EventArgs e)
        {
            grid_NhanVien.DataSource = nvBll.getDeletedNhanVienByKey(tb_TimNhanVien.Text);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            grid_NhanVien.DataSource = nvBll.getDeletedNhanVien();
        }

        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Khôi phục thông tin này?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                nvBll.Restore(grid_NhanVien.SelectedRows[0].Cells[0].Value.ToString());
                grid_NhanVien.DataSource = nvBll.getDeletedNhanVien();
            }
            else
            {
                return;
            }
        }

    }
}
