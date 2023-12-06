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
    public partial class ThemNhaCungCap : Form
    {
        public ThemNhaCungCap()
        {
            InitializeComponent();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addNCC_Click(object sender, EventArgs e)
        {
            String tenncc = tb_TenNCC.Text;
            String diachi = tb_DiaChi.Text;
            int mancc = 0;
            string trangthai = "1";
            if (tenncc != "" && diachi != "")
            {
                NhaCungCapDTO dto = new NhaCungCapDTO(mancc, tenncc, diachi, trangthai);
                NhaCungCapBLL bll = new NhaCungCapBLL();

                bll.Insert(dto);

                this.Close();
                MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ hãy kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
