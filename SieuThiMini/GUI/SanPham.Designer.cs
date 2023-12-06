namespace SieuThiMini.GUI
{
    partial class SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tb_GiaNhap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_Maloai = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_saveSanPham = new System.Windows.Forms.Button();
            this.tb_SoLuongSanPham = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_GiaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_MaSanPham = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TimSanPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_editSanPham = new System.Windows.Forms.Button();
            this.btn_deleteSanPham = new System.Windows.Forms.Button();
            this.btn_addSanPham = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tb_GiaNhap);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cb_Maloai);
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_saveSanPham);
            this.panel1.Controls.Add(this.tb_SoLuongSanPham);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_GiaSanPham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_TenSanPham);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_MaSanPham);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 394);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tb_GiaNhap
            // 
            this.tb_GiaNhap.Enabled = false;
            this.tb_GiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaNhap.Location = new System.Drawing.Point(248, 236);
            this.tb_GiaNhap.Name = "tb_GiaNhap";
            this.tb_GiaNhap.Size = new System.Drawing.Size(503, 38);
            this.tb_GiaNhap.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 32);
            this.label8.TabIndex = 14;
            this.label8.Text = "Giá nhập";
            // 
            // cb_Maloai
            // 
            this.cb_Maloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Maloai.Enabled = false;
            this.cb_Maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Maloai.FormattingEnabled = true;
            this.cb_Maloai.Location = new System.Drawing.Point(248, 66);
            this.cb_Maloai.Name = "cb_Maloai";
            this.cb_Maloai.Size = new System.Drawing.Size(503, 39);
            this.cb_Maloai.TabIndex = 13;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(402, 339);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(128, 50);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Visible = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_saveSanPham
            // 
            this.btn_saveSanPham.BackColor = System.Drawing.Color.Navy;
            this.btn_saveSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_saveSanPham.Location = new System.Drawing.Point(219, 339);
            this.btn_saveSanPham.Name = "btn_saveSanPham";
            this.btn_saveSanPham.Size = new System.Drawing.Size(128, 50);
            this.btn_saveSanPham.TabIndex = 11;
            this.btn_saveSanPham.Text = "Lưu";
            this.btn_saveSanPham.UseVisualStyleBackColor = false;
            this.btn_saveSanPham.Visible = false;
            this.btn_saveSanPham.Click += new System.EventHandler(this.Save_Click);
            // 
            // tb_SoLuongSanPham
            // 
            this.tb_SoLuongSanPham.Enabled = false;
            this.tb_SoLuongSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SoLuongSanPham.Location = new System.Drawing.Point(248, 291);
            this.tb_SoLuongSanPham.Name = "tb_SoLuongSanPham";
            this.tb_SoLuongSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_SoLuongSanPham.TabIndex = 10;
            this.tb_SoLuongSanPham.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng";
            // 
            // tb_GiaSanPham
            // 
            this.tb_GiaSanPham.Enabled = false;
            this.tb_GiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaSanPham.Location = new System.Drawing.Point(248, 182);
            this.tb_GiaSanPham.Name = "tb_GiaSanPham";
            this.tb_GiaSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_GiaSanPham.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá";
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.Enabled = false;
            this.tb_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenSanPham.Location = new System.Drawing.Point(248, 123);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_TenSanPham.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_MaSanPham
            // 
            this.tb_MaSanPham.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_MaSanPham.Enabled = false;
            this.tb_MaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaSanPham.Location = new System.Drawing.Point(248, 12);
            this.tb_MaSanPham.Name = "tb_MaSanPham";
            this.tb_MaSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_MaSanPham.TabIndex = 2;
            this.tb_MaSanPham.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_TimSanPham);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(792, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 152);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "( Tên, mã loại, mã sản phẩm )";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tb_TimSanPham
            // 
            this.tb_TimSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimSanPham.Location = new System.Drawing.Point(18, 91);
            this.tb_TimSanPham.Name = "tb_TimSanPham";
            this.tb_TimSanPham.Size = new System.Drawing.Size(362, 38);
            this.tb_TimSanPham.TabIndex = 1;
            this.tb_TimSanPham.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm sản phẩm";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.AllowUserToAddRows = false;
            this.grid_SanPham.AllowUserToDeleteRows = false;
            this.grid_SanPham.AllowUserToResizeColumns = false;
            this.grid_SanPham.AllowUserToResizeRows = false;
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(12, 412);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_SanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.grid_SanPham.RowTemplate.Height = 24;
            this.grid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SanPham.Size = new System.Drawing.Size(1176, 336);
            this.grid_SanPham.TabIndex = 0;
            this.grid_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_SanPham_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_Reload);
            this.panel3.Controls.Add(this.btn_editSanPham);
            this.panel3.Controls.Add(this.btn_deleteSanPham);
            this.panel3.Controls.Add(this.btn_addSanPham);
            this.panel3.Location = new System.Drawing.Point(792, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 236);
            this.panel3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 57);
            this.button1.TabIndex = 103;
            this.button1.Text = "Khôi phục";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.KhoiPhuc_Click);
            // 
            // btn_Reload
            // 
            this.btn_Reload.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reload.ForeColor = System.Drawing.Color.White;
            this.btn_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.btn_Reload.Location = new System.Drawing.Point(201, 162);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(178, 59);
            this.btn_Reload.TabIndex = 102;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.TaiLai_Click);
            // 
            // btn_editSanPham
            // 
            this.btn_editSanPham.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_editSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_editSanPham.Location = new System.Drawing.Point(199, 90);
            this.btn_editSanPham.Name = "btn_editSanPham";
            this.btn_editSanPham.Size = new System.Drawing.Size(180, 57);
            this.btn_editSanPham.TabIndex = 9;
            this.btn_editSanPham.Text = "Sửa";
            this.btn_editSanPham.UseVisualStyleBackColor = false;
            this.btn_editSanPham.Click += new System.EventHandler(this.SuaSanPham_Click);
            // 
            // btn_deleteSanPham
            // 
            this.btn_deleteSanPham.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_deleteSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_deleteSanPham.Location = new System.Drawing.Point(16, 90);
            this.btn_deleteSanPham.Name = "btn_deleteSanPham";
            this.btn_deleteSanPham.Size = new System.Drawing.Size(180, 57);
            this.btn_deleteSanPham.TabIndex = 10;
            this.btn_deleteSanPham.Text = "Xóa";
            this.btn_deleteSanPham.UseVisualStyleBackColor = false;
            this.btn_deleteSanPham.Click += new System.EventHandler(this.btn_deleteSanPham_Click);
            // 
            // btn_addSanPham
            // 
            this.btn_addSanPham.BackColor = System.Drawing.Color.Navy;
            this.btn_addSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_addSanPham.Location = new System.Drawing.Point(16, 20);
            this.btn_addSanPham.Name = "btn_addSanPham";
            this.btn_addSanPham.Size = new System.Drawing.Size(363, 64);
            this.btn_addSanPham.TabIndex = 6;
            this.btn_addSanPham.Text = "Thêm Sản Phẩm";
            this.btn_addSanPham.UseVisualStyleBackColor = false;
            this.btn_addSanPham.Click += new System.EventHandler(this.ThemSanPham_Click);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_SanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(1200, 760);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "San Pham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_SoLuongSanPham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_GiaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_MaSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tb_TimSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.Button btn_saveSanPham;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.ComboBox cb_Maloai;
        private System.Windows.Forms.TextBox tb_GiaNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_editSanPham;
        private System.Windows.Forms.Button btn_deleteSanPham;
        private System.Windows.Forms.Button btn_addSanPham;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button button1;
    }
}