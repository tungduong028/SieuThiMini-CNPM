namespace SieuThiMini.GUI
{
    partial class KhoiPhucTaiKhoan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid_TaiKhoan = new System.Windows.Forms.DataGridView();
            this.Cotma_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotten_tai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotmat_khau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotphan_quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cottrang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TimSanPham = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_TaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_TaiKhoan
            // 
            this.grid_TaiKhoan.AllowUserToAddRows = false;
            this.grid_TaiKhoan.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_TaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_TaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_TaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cotma_tai_khoan,
            this.Cotten_tai_khoan,
            this.Cotmat_khau,
            this.Cotphan_quyen,
            this.Cottrang_thai});
            this.grid_TaiKhoan.Location = new System.Drawing.Point(12, 187);
            this.grid_TaiKhoan.Name = "grid_TaiKhoan";
            this.grid_TaiKhoan.RowHeadersVisible = false;
            this.grid_TaiKhoan.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_TaiKhoan.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_TaiKhoan.RowTemplate.Height = 24;
            this.grid_TaiKhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_TaiKhoan.Size = new System.Drawing.Size(608, 554);
            this.grid_TaiKhoan.TabIndex = 0;
            this.grid_TaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_TaiKhoan_CellClick);
            // 
            // Cotma_tai_khoan
            // 
            this.Cotma_tai_khoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotma_tai_khoan.DataPropertyName = "ma_tai_khoan";
            this.Cotma_tai_khoan.HeaderText = "Mã tài khoản";
            this.Cotma_tai_khoan.MinimumWidth = 6;
            this.Cotma_tai_khoan.Name = "Cotma_tai_khoan";
            this.Cotma_tai_khoan.ReadOnly = true;
            // 
            // Cotten_tai_khoan
            // 
            this.Cotten_tai_khoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotten_tai_khoan.DataPropertyName = "ten_tai_khoan";
            this.Cotten_tai_khoan.HeaderText = "Tên tài khoản";
            this.Cotten_tai_khoan.MinimumWidth = 6;
            this.Cotten_tai_khoan.Name = "Cotten_tai_khoan";
            this.Cotten_tai_khoan.ReadOnly = true;
            // 
            // Cotmat_khau
            // 
            this.Cotmat_khau.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotmat_khau.DataPropertyName = "mat_khau";
            this.Cotmat_khau.HeaderText = "Mật khẩu";
            this.Cotmat_khau.MinimumWidth = 6;
            this.Cotmat_khau.Name = "Cotmat_khau";
            this.Cotmat_khau.ReadOnly = true;
            this.Cotmat_khau.Visible = false;
            // 
            // Cotphan_quyen
            // 
            this.Cotphan_quyen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotphan_quyen.DataPropertyName = "phan_quyen";
            this.Cotphan_quyen.HeaderText = "Phân quyền";
            this.Cotphan_quyen.MinimumWidth = 6;
            this.Cotphan_quyen.Name = "Cotphan_quyen";
            this.Cotphan_quyen.ReadOnly = true;
            // 
            // Cottrang_thai
            // 
            this.Cottrang_thai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cottrang_thai.DataPropertyName = "trang_thai";
            this.Cottrang_thai.HeaderText = "Trạng thái";
            this.Cottrang_thai.MinimumWidth = 6;
            this.Cottrang_thai.Name = "Cottrang_thai";
            this.Cottrang_thai.ReadOnly = true;
            this.Cottrang_thai.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khôi phục tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tìm kiếm";
            // 
            // tb_TimSanPham
            // 
            this.tb_TimSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimSanPham.Location = new System.Drawing.Point(181, 55);
            this.tb_TimSanPham.Name = "tb_TimSanPham";
            this.tb_TimSanPham.Size = new System.Drawing.Size(345, 38);
            this.tb_TimSanPham.TabIndex = 23;
            this.tb_TimSanPham.TextChanged += new System.EventHandler(this.tb_TimSanPham_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(185, 120);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 61);
            this.btn_Refresh.TabIndex = 24;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.Navy;
            this.btn_KhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(310, 120);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(119, 61);
            this.btn_KhoiPhuc.TabIndex = 22;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // KhoiPhucTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(632, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TimSanPham);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_TaiKhoan);
            this.Name = "KhoiPhucTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục Tài Khoản";
            this.Load += new System.EventHandler(this.KhoiPhucTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_TaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_TaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotma_tai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotten_tai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotmat_khau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotphan_quyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cottrang_thai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TimSanPham;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_KhoiPhuc;
    }
}