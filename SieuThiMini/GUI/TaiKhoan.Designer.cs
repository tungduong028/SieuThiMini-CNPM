namespace SieuThiMini.GUI
{
    partial class TaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cb_PhanQuyen = new System.Windows.Forms.ComboBox();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.tb_MaTaiKhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.btn_SuaTK = new System.Windows.Forms.Button();
            this.btn_XoaTK = new System.Windows.Forms.Button();
            this.btn_TaoTK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TaiKhoan)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_TaiKhoan
            // 
            this.grid_TaiKhoan.AllowUserToAddRows = false;
            this.grid_TaiKhoan.AllowUserToDeleteRows = false;
            this.grid_TaiKhoan.AllowUserToResizeColumns = false;
            this.grid_TaiKhoan.AllowUserToResizeRows = false;
            this.grid_TaiKhoan.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TaiKhoan.Location = new System.Drawing.Point(12, 398);
            this.grid_TaiKhoan.Name = "grid_TaiKhoan";
            this.grid_TaiKhoan.ReadOnly = true;
            this.grid_TaiKhoan.RowHeadersVisible = false;
            this.grid_TaiKhoan.RowHeadersWidth = 51;
            this.grid_TaiKhoan.RowTemplate.Height = 24;
            this.grid_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_TaiKhoan.Size = new System.Drawing.Size(1176, 290);
            this.grid_TaiKhoan.TabIndex = 0;
            this.grid_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TaiKhoan_CellClick);
            this.grid_TaiKhoan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_TaiKhoan_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Controls.Add(this.cb_PhanQuyen);
            this.panel1.Controls.Add(this.tb_MatKhau);
            this.panel1.Controls.Add(this.tb_TenTaiKhoan);
            this.panel1.Controls.Add(this.tb_MaTaiKhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 380);
            this.panel1.TabIndex = 1;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(449, 273);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(150, 50);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Visible = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Navy;
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Location = new System.Drawing.Point(180, 273);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(150, 50);
            this.btn_Luu.TabIndex = 8;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Visible = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cb_PhanQuyen
            // 
            this.cb_PhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PhanQuyen.Enabled = false;
            this.cb_PhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_PhanQuyen.FormattingEnabled = true;
            this.cb_PhanQuyen.Location = new System.Drawing.Point(262, 193);
            this.cb_PhanQuyen.Name = "cb_PhanQuyen";
            this.cb_PhanQuyen.Size = new System.Drawing.Size(180, 39);
            this.cb_PhanQuyen.TabIndex = 3;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MatKhau.Enabled = false;
            this.tb_MatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MatKhau.Location = new System.Drawing.Point(262, 136);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.PasswordChar = '*';
            this.tb_MatKhau.Size = new System.Drawing.Size(480, 38);
            this.tb_MatKhau.TabIndex = 2;
            // 
            // tb_TenTaiKhoan
            // 
            this.tb_TenTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TenTaiKhoan.Enabled = false;
            this.tb_TenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenTaiKhoan.Location = new System.Drawing.Point(262, 79);
            this.tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            this.tb_TenTaiKhoan.Size = new System.Drawing.Size(480, 38);
            this.tb_TenTaiKhoan.TabIndex = 1;
            // 
            // tb_MaTaiKhoan
            // 
            this.tb_MaTaiKhoan.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MaTaiKhoan.Enabled = false;
            this.tb_MaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaTaiKhoan.Location = new System.Drawing.Point(262, 22);
            this.tb_MaTaiKhoan.Name = "tb_MaTaiKhoan";
            this.tb_MaTaiKhoan.Size = new System.Drawing.Size(480, 38);
            this.tb_MaTaiKhoan.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phân quyền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã tài khoản";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.btn_Reload);
            this.panel2.Controls.Add(this.btn_KhoiPhuc);
            this.panel2.Controls.Add(this.btn_SuaTK);
            this.panel2.Controls.Add(this.btn_XoaTK);
            this.panel2.Controls.Add(this.btn_TaoTK);
            this.panel2.Location = new System.Drawing.Point(806, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 214);
            this.panel2.TabIndex = 3;
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(205, 146);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(150, 52);
            this.btn_Reload.TabIndex = 102;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.btn_Reload_Click);
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.Navy;
            this.btn_KhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(27, 146);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(150, 52);
            this.btn_KhoiPhuc.TabIndex = 10;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // btn_SuaTK
            // 
            this.btn_SuaTK.BackColor = System.Drawing.Color.Navy;
            this.btn_SuaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SuaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTK.ForeColor = System.Drawing.Color.White;
            this.btn_SuaTK.Location = new System.Drawing.Point(28, 90);
            this.btn_SuaTK.Name = "btn_SuaTK";
            this.btn_SuaTK.Size = new System.Drawing.Size(150, 50);
            this.btn_SuaTK.TabIndex = 6;
            this.btn_SuaTK.Text = "Sửa";
            this.btn_SuaTK.UseVisualStyleBackColor = false;
            this.btn_SuaTK.Click += new System.EventHandler(this.btn_SuaTK_Click);
            // 
            // btn_XoaTK
            // 
            this.btn_XoaTK.BackColor = System.Drawing.Color.Navy;
            this.btn_XoaTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTK.ForeColor = System.Drawing.Color.White;
            this.btn_XoaTK.Location = new System.Drawing.Point(205, 90);
            this.btn_XoaTK.Name = "btn_XoaTK";
            this.btn_XoaTK.Size = new System.Drawing.Size(150, 50);
            this.btn_XoaTK.TabIndex = 8;
            this.btn_XoaTK.Text = "Xóa";
            this.btn_XoaTK.UseVisualStyleBackColor = false;
            this.btn_XoaTK.Click += new System.EventHandler(this.btn_XoaTK_Click);
            // 
            // btn_TaoTK
            // 
            this.btn_TaoTK.BackColor = System.Drawing.Color.Navy;
            this.btn_TaoTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TaoTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TaoTK.ForeColor = System.Drawing.Color.White;
            this.btn_TaoTK.Location = new System.Drawing.Point(27, 20);
            this.btn_TaoTK.Name = "btn_TaoTK";
            this.btn_TaoTK.Size = new System.Drawing.Size(328, 50);
            this.btn_TaoTK.TabIndex = 5;
            this.btn_TaoTK.Text = "Tạo tài khoản";
            this.btn_TaoTK.UseVisualStyleBackColor = false;
            this.btn_TaoTK.Click += new System.EventHandler(this.btn_TaoTK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.tb_TimKiem);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(806, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(382, 160);
            this.panel3.TabIndex = 5;
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.BackColor = System.Drawing.SystemColors.Window;
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(28, 91);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(327, 38);
            this.tb_TimKiem.TabIndex = 6;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 25);
            this.label8.TabIndex = 100;
            this.label8.Text = "(Nhập tên hoặc mã tài khoản)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(251, 32);
            this.label7.TabIndex = 100;
            this.label7.Text = "Tìm kiếm tài khoản";
            // 
            // TaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_TaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaiKhoan";
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TaiKhoan)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TaiKhoan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaTaiKhoan;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TenTaiKhoan;
        private System.Windows.Forms.Button btn_TaoTK;
        private System.Windows.Forms.Button btn_SuaTK;
        private System.Windows.Forms.Button btn_XoaTK;
        private System.Windows.Forms.ComboBox cb_PhanQuyen;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_KhoiPhuc;
    }
}