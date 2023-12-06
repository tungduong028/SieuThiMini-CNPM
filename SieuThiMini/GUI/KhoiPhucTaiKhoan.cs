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
    public partial class KhoiPhucTaiKhoan : Form
    {
        TaiKhoanBLL tkBll = new TaiKhoanBLL();
        public KhoiPhucTaiKhoan()
        {
            InitializeComponent();
        }

        private void KhoiPhucTaiKhoan_Load(object sender, EventArgs e)
        {
            DataTable dt = tkBll.getDeletedTaiKhoan();
            grid_TaiKhoan.DataSource = dt;
        }

        private void grid_TaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void btn_KhoiPhuc_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Khôi phục tài khoản này?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                tkBll.Restore(grid_TaiKhoan.SelectedRows[0].Cells[0].Value.ToString());
                grid_TaiKhoan.DataSource = tkBll.getDeletedTaiKhoan();
            }
            else
            {
                return;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            grid_TaiKhoan.DataSource = tkBll.getDeletedTaiKhoan();
        }

        private void tb_TimSanPham_TextChanged(object sender, EventArgs e)
        {
            grid_TaiKhoan.DataSource = tkBll.findDeletedAcountWithKey(tb_TimSanPham.Text);
        }
    }
}
