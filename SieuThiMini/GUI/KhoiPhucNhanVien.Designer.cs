namespace SieuThiMini.GUI
{
    partial class KhoiPhucNhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.grid_NhanVien = new System.Windows.Forms.DataGridView();
            this.Cotma_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotten_nhan_vien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotngay_sinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotsdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cotmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cottai_khoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cottrang_thai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TimNhanVien = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_NhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khôi phục nhân viên";
            // 
            // grid_NhanVien
            // 
            this.grid_NhanVien.AllowUserToAddRows = false;
            this.grid_NhanVien.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_NhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_NhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cotma_nhan_vien,
            this.Cotten_nhan_vien,
            this.Cotngay_sinh,
            this.Cotsdt,
            this.Cotmail,
            this.Cottai_khoan,
            this.Cottrang_thai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_NhanVien.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_NhanVien.Location = new System.Drawing.Point(12, 200);
            this.grid_NhanVien.Name = "grid_NhanVien";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_NhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_NhanVien.RowHeadersVisible = false;
            this.grid_NhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grid_NhanVien.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_NhanVien.RowTemplate.Height = 24;
            this.grid_NhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_NhanVien.Size = new System.Drawing.Size(722, 444);
            this.grid_NhanVien.TabIndex = 3;
            this.grid_NhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_NhanVien_CellClick);
            // 
            // Cotma_nhan_vien
            // 
            this.Cotma_nhan_vien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotma_nhan_vien.DataPropertyName = "ma_nhan_vien";
            this.Cotma_nhan_vien.HeaderText = "Mã nhân viên";
            this.Cotma_nhan_vien.MinimumWidth = 6;
            this.Cotma_nhan_vien.Name = "Cotma_nhan_vien";
            this.Cotma_nhan_vien.ReadOnly = true;
            // 
            // Cotten_nhan_vien
            // 
            this.Cotten_nhan_vien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotten_nhan_vien.DataPropertyName = "ten_nhan_vien";
            this.Cotten_nhan_vien.HeaderText = "Tên nhân viên";
            this.Cotten_nhan_vien.MinimumWidth = 6;
            this.Cotten_nhan_vien.Name = "Cotten_nhan_vien";
            this.Cotten_nhan_vien.ReadOnly = true;
            // 
            // Cotngay_sinh
            // 
            this.Cotngay_sinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotngay_sinh.DataPropertyName = "ngay_sinh";
            this.Cotngay_sinh.HeaderText = "Ngày sinh";
            this.Cotngay_sinh.MinimumWidth = 6;
            this.Cotngay_sinh.Name = "Cotngay_sinh";
            this.Cotngay_sinh.ReadOnly = true;
            // 
            // Cotsdt
            // 
            this.Cotsdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotsdt.DataPropertyName = "sdt";
            this.Cotsdt.HeaderText = "SDT";
            this.Cotsdt.MinimumWidth = 6;
            this.Cotsdt.Name = "Cotsdt";
            this.Cotsdt.ReadOnly = true;
            // 
            // Cotmail
            // 
            this.Cotmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cotmail.DataPropertyName = "mail";
            this.Cotmail.HeaderText = "Mail";
            this.Cotmail.MinimumWidth = 6;
            this.Cotmail.Name = "Cotmail";
            this.Cotmail.ReadOnly = true;
            // 
            // Cottai_khoan
            // 
            this.Cottai_khoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cottai_khoan.DataPropertyName = "tai_khoan";
            this.Cottai_khoan.HeaderText = "Tài khoản";
            this.Cottai_khoan.MinimumWidth = 6;
            this.Cottai_khoan.Name = "Cottai_khoan";
            this.Cottai_khoan.ReadOnly = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tìm kiếm";
            // 
            // tb_TimNhanVien
            // 
            this.tb_TimNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimNhanVien.Location = new System.Drawing.Point(198, 56);
            this.tb_TimNhanVien.Name = "tb_TimNhanVien";
            this.tb_TimNhanVien.Size = new System.Drawing.Size(408, 38);
            this.tb_TimNhanVien.TabIndex = 23;
            this.tb_TimNhanVien.TextChanged += new System.EventHandler(this.tb_TimNhanVien_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(243, 121);
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
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(409, 121);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(119, 61);
            this.btn_KhoiPhuc.TabIndex = 22;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // KhoiPhucNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(749, 656);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TimNhanVien);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.grid_NhanVien);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KhoiPhucNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục Nhân Viên";
            this.Load += new System.EventHandler(this.KhoiPhucNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_NhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_NhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotma_nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotten_nhan_vien;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotngay_sinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cotmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cottai_khoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cottrang_thai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TimNhanVien;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_KhoiPhuc;
    }
}