namespace SieuThiMini.GUI
{
    partial class BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grid_HoaDon = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label_TT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_TimKiem = new System.Windows.Forms.Button();
            this.textBox_TimKiem = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ud_SoLuong = new System.Windows.Forms.NumericUpDown();
            this.button_XoaMon = new System.Windows.Forms.Button();
            this.button_ThemMon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbo_LoaiMon = new System.Windows.Forms.ComboBox();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.grid_HoaDon);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(437, 671);
            this.panel1.TabIndex = 0;
            // 
            // grid_HoaDon
            // 
            this.grid_HoaDon.AllowUserToAddRows = false;
            this.grid_HoaDon.AllowUserToDeleteRows = false;
            this.grid_HoaDon.AllowUserToResizeColumns = false;
            this.grid_HoaDon.AllowUserToResizeRows = false;
            this.grid_HoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_HoaDon.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_HoaDon.Location = new System.Drawing.Point(3, 41);
            this.grid_HoaDon.MultiSelect = false;
            this.grid_HoaDon.Name = "grid_HoaDon";
            this.grid_HoaDon.RowHeadersVisible = false;
            this.grid_HoaDon.RowHeadersWidth = 51;
            this.grid_HoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_HoaDon.Size = new System.Drawing.Size(429, 625);
            this.grid_HoaDon.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn hàng";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_ThanhToan);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(453, 509);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 165);
            this.panel3.TabIndex = 3;
            // 
            // button_ThanhToan
            // 
            this.button_ThanhToan.BackColor = System.Drawing.Color.Navy;
            this.button_ThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThanhToan.ForeColor = System.Drawing.Color.White;
            this.button_ThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("button_ThanhToan.Image")));
            this.button_ThanhToan.Location = new System.Drawing.Point(189, 90);
            this.button_ThanhToan.Name = "button_ThanhToan";
            this.button_ThanhToan.Size = new System.Drawing.Size(210, 64);
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
            this.groupBox5.Size = new System.Drawing.Size(561, 59);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tổng tiền cần thanh toán";
            // 
            // label_TT
            // 
            this.label_TT.AutoSize = true;
            this.label_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TT.Location = new System.Drawing.Point(6, 22);
            this.label_TT.Name = "label_TT";
            this.label_TT.Size = new System.Drawing.Size(29, 31);
            this.label_TT.TabIndex = 0;
            this.label_TT.Text = "0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.button_XoaMon);
            this.panel2.Controls.Add(this.button_ThemMon);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(453, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(588, 110);
            this.panel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_TimKiem);
            this.groupBox3.Controls.Add(this.textBox_TimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(38, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 49);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // button_TimKiem
            // 
            this.button_TimKiem.BackColor = System.Drawing.Color.Navy;
            this.button_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimKiem.ForeColor = System.Drawing.Color.White;
            this.button_TimKiem.Location = new System.Drawing.Point(440, 15);
            this.button_TimKiem.Name = "button_TimKiem";
            this.button_TimKiem.Size = new System.Drawing.Size(58, 28);
            this.button_TimKiem.TabIndex = 3;
            this.button_TimKiem.Text = "Tìm";
            this.button_TimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_TimKiem.UseVisualStyleBackColor = false;
            this.button_TimKiem.Click += new System.EventHandler(this.button_TimKiem_Click);
            // 
            // textBox_TimKiem
            // 
            this.textBox_TimKiem.Location = new System.Drawing.Point(6, 20);
            this.textBox_TimKiem.Name = "textBox_TimKiem";
            this.textBox_TimKiem.Size = new System.Drawing.Size(423, 23);
            this.textBox_TimKiem.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ud_SoLuong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(472, 7);
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
            // button_XoaMon
            // 
            this.button_XoaMon.BackColor = System.Drawing.Color.Navy;
            this.button_XoaMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XoaMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_XoaMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaMon.ForeColor = System.Drawing.Color.White;
            this.button_XoaMon.Image = ((System.Drawing.Image)(resources.GetObject("button_XoaMon.Image")));
            this.button_XoaMon.Location = new System.Drawing.Point(320, 11);
            this.button_XoaMon.Name = "button_XoaMon";
            this.button_XoaMon.Size = new System.Drawing.Size(147, 47);
            this.button_XoaMon.TabIndex = 2;
            this.button_XoaMon.Text = " Xóa";
            this.button_XoaMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_XoaMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_XoaMon.UseVisualStyleBackColor = false;
            this.button_XoaMon.Click += new System.EventHandler(this.button_XoaMon_Click);
            // 
            // button_ThemMon
            // 
            this.button_ThemMon.BackColor = System.Drawing.Color.Navy;
            this.button_ThemMon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_ThemMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemMon.ForeColor = System.Drawing.Color.White;
            this.button_ThemMon.Image = ((System.Drawing.Image)(resources.GetObject("button_ThemMon.Image")));
            this.button_ThemMon.Location = new System.Drawing.Point(166, 11);
            this.button_ThemMon.Name = "button_ThemMon";
            this.button_ThemMon.Size = new System.Drawing.Size(147, 47);
            this.button_ThemMon.TabIndex = 1;
            this.button_ThemMon.Text = " Thêm";
            this.button_ThemMon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_ThemMon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ThemMon.UseVisualStyleBackColor = false;
            this.button_ThemMon.Click += new System.EventHandler(this.button_ThemMon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbo_LoaiMon);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(38, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại sản phẩm";
            // 
            // cbo_LoaiMon
            // 
            this.cbo_LoaiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoaiMon.FormattingEnabled = true;
            this.cbo_LoaiMon.Location = new System.Drawing.Point(6, 21);
            this.cbo_LoaiMon.Name = "cbo_LoaiMon";
            this.cbo_LoaiMon.Size = new System.Drawing.Size(110, 23);
            this.cbo_LoaiMon.TabIndex = 0;
            this.cbo_LoaiMon.SelectedIndexChanged += new System.EventHandler(this.cbo_LoaiMon_SelectedIndexChanged);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
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
            this.grid_SanPham.Location = new System.Drawing.Point(453, 121);
            this.grid_SanPham.MultiSelect = false;
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.ReadOnly = true;
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.grid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SanPham.Size = new System.Drawing.Size(588, 382);
            this.grid_SanPham.TabIndex = 5;
            this.grid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellClick);
            // 
            // BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1052, 679);
            this.Controls.Add(this.grid_SanPham);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.BanHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ud_SoLuong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_ThemMon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbo_LoaiMon;
        private System.Windows.Forms.Button button_XoaMon;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown ud_SoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label_TT;
        private System.Windows.Forms.DataGridView grid_HoaDon;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.Button button_ThanhToan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_TimKiem;
        private System.Windows.Forms.Button button_TimKiem;
    }
}