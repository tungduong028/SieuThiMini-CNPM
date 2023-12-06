namespace SieuThiMini.GUI
{
    partial class ThemDonNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemDonNhapHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_DonNhapHang = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_XoaDon = new System.Windows.Forms.Button();
            this.button_ThemDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_ncc = new System.Windows.Forms.ComboBox();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_TT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DonNhapHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grid_DonNhapHang);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 611);
            this.panel1.TabIndex = 1;
            // 
            // grid_DonNhapHang
            // 
            this.grid_DonNhapHang.AllowUserToAddRows = false;
            this.grid_DonNhapHang.AllowUserToDeleteRows = false;
            this.grid_DonNhapHang.AllowUserToResizeColumns = false;
            this.grid_DonNhapHang.AllowUserToResizeRows = false;
            this.grid_DonNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_DonNhapHang.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_DonNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DonNhapHang.Location = new System.Drawing.Point(3, 41);
            this.grid_DonNhapHang.MultiSelect = false;
            this.grid_DonNhapHang.Name = "grid_DonNhapHang";
            this.grid_DonNhapHang.RowHeadersVisible = false;
            this.grid_DonNhapHang.RowHeadersWidth = 51;
            this.grid_DonNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DonNhapHang.Size = new System.Drawing.Size(419, 566);
            this.grid_DonNhapHang.TabIndex = 2;
            this.grid_DonNhapHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DonNhapHang_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn nhập hàng";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button_XoaDon);
            this.panel2.Controls.Add(this.button_ThemDon);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(442, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 123);
            this.panel2.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_SoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(296, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(80, 52);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số lượng";
            // 
            // ud_SoLuong
            // 
            this.ud_SoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ud_SoLuong.Location = new System.Drawing.Point(6, 25);
            this.ud_SoLuong.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.ud_SoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ud_SoLuong.Name = "ud_SoLuong";
            this.ud_SoLuong.Size = new System.Drawing.Size(68, 21);
            this.ud_SoLuong.TabIndex = 0;
            this.ud_SoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button_XoaDon
            // 
            this.button_XoaDon.BackColor = System.Drawing.Color.Navy;
            this.button_XoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_XoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaDon.ForeColor = System.Drawing.Color.White;
            this.button_XoaDon.Image = ((System.Drawing.Image)(resources.GetObject("button_XoaDon.Image")));
            this.button_XoaDon.Location = new System.Drawing.Point(226, 66);
            this.button_XoaDon.Name = "button_XoaDon";
            this.button_XoaDon.Size = new System.Drawing.Size(113, 47);
            this.button_XoaDon.TabIndex = 2;
            this.button_XoaDon.Text = " Xóa";
            this.button_XoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_XoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_XoaDon.UseVisualStyleBackColor = false;
            this.button_XoaDon.Click += new System.EventHandler(this.button_XoaDon_Click);
            // 
            // button_ThemDon
            // 
            this.button_ThemDon.BackColor = System.Drawing.Color.Navy;
            this.button_ThemDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThemDon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ThemDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemDon.ForeColor = System.Drawing.Color.White;
            this.button_ThemDon.Image = ((System.Drawing.Image)(resources.GetObject("button_ThemDon.Image")));
            this.button_ThemDon.Location = new System.Drawing.Point(106, 66);
            this.button_ThemDon.Name = "button_ThemDon";
            this.button_ThemDon.Size = new System.Drawing.Size(113, 47);
            this.button_ThemDon.TabIndex = 1;
            this.button_ThemDon.Text = " Thêm";
            this.button_ThemDon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ThemDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ThemDon.UseVisualStyleBackColor = false;
            this.button_ThemDon.Click += new System.EventHandler(this.button_ThemMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_ncc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhà cung cấp";
            // 
            // cbo_ncc
            // 
            this.cbo_ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_ncc.FormattingEnabled = true;
            this.cbo_ncc.Location = new System.Drawing.Point(6, 21);
            this.cbo_ncc.Name = "cbo_ncc";
            this.cbo_ncc.Size = new System.Drawing.Size(173, 23);
            this.cbo_ncc.TabIndex = 0;
            this.cbo_ncc.SelectedIndexChanged += new System.EventHandler(this.cbo_ncc_SelectedIndexChanged);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.AllowUserToAddRows = false;
            this.grid_SanPham.AllowUserToDeleteRows = false;
            this.grid_SanPham.AllowUserToResizeColumns = false;
            this.grid_SanPham.AllowUserToResizeRows = false;
            this.grid_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(442, 132);
            this.grid_SanPham.MultiSelect = false;
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.ReadOnly = true;
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.grid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SanPham.Size = new System.Drawing.Size(448, 392);
            this.grid_SanPham.TabIndex = 6;
            this.grid_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_ThanhToan);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(442, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 84);
            this.panel3.TabIndex = 7;
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.BackColor = System.Drawing.Color.Navy;
            this.button_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.button_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("button_ThanhToan.Image")));
            this.button_ThanhToan.Location = new System.Drawing.Point(289, 14);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(147, 59);
            this.button_ThanhToan.TabIndex = 3;
            this.button_ThanhToan.Text = "Thanh toán";
            this.button_ThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ThanhToan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ThanhToan.UseVisualStyleBackColor = false;
            this.button_ThanhToan.Click += new System.EventHandler(this.button_ThanhToan_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.White;
            this.groupBox5.Controls.Add(this.label_TT);
            this.groupBox5.Location = new System.Drawing.Point(13, 14);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(270, 59);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng tiền cần thanh toán";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(6, 22);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(24, 26);
            this.label_TT.TabIndex = 0;
            this.label_TT.Text = "0";
            // 
            // ThemDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(900, 618);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.grid_SanPham);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ThemDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhập hàng";
            this.Load += new System.EventHandler(this.ThemDonDatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DonNhapHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView grid_DonNhapHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ud_SoLuong;
        private System.Windows.Forms.Button button_XoaDon;
        private System.Windows.Forms.Button button_ThemDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_ncc;
        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_TT;
    }
}