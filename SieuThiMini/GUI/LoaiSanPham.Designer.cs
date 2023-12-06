namespace SieuThiMini.GUI
{
    partial class LoaiSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TimLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_MaNcc = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_saveLoai = new System.Windows.Forms.Button();
            this.tb_TenLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MaLoai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grid_LoaiSanPham = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Reload = new System.Windows.Forms.Button();
            this.btn_editLoaiSanPham = new System.Windows.Forms.Button();
            this.btn_deleteLoaiSanPham = new System.Windows.Forms.Button();
            this.btn_addLoaiSanPham = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LoaiSanPham)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tb_TimLoai);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(792, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(396, 152);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(303, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "( Tên, mã loại, mã nhà cung cấp )";
            // 
            // tb_TimLoai
            // 
            this.tb_TimLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimLoai.Location = new System.Drawing.Point(18, 91);
            this.tb_TimLoai.Name = "tb_TimLoai";
            this.tb_TimLoai.Size = new System.Drawing.Size(362, 38);
            this.tb_TimLoai.TabIndex = 1;
            this.tb_TimLoai.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(360, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tìm kiếm loại sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_MaNcc);
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_saveLoai);
            this.panel1.Controls.Add(this.tb_TenLoai);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_MaLoai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 384);
            this.panel1.TabIndex = 6;
            // 
            // cb_MaNcc
            // 
            this.cb_MaNcc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MaNcc.Enabled = false;
            this.cb_MaNcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MaNcc.FormattingEnabled = true;
            this.cb_MaNcc.Location = new System.Drawing.Point(256, 128);
            this.cb_MaNcc.Name = "cb_MaNcc";
            this.cb_MaNcc.Size = new System.Drawing.Size(503, 39);
            this.cb_MaNcc.TabIndex = 13;
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(400, 293);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(128, 50);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Visible = false;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_saveLoai
            // 
            this.btn_saveLoai.BackColor = System.Drawing.Color.Navy;
            this.btn_saveLoai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_saveLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveLoai.ForeColor = System.Drawing.Color.White;
            this.btn_saveLoai.Location = new System.Drawing.Point(217, 293);
            this.btn_saveLoai.Name = "btn_saveLoai";
            this.btn_saveLoai.Size = new System.Drawing.Size(128, 50);
            this.btn_saveLoai.TabIndex = 11;
            this.btn_saveLoai.Text = "Lưu";
            this.btn_saveLoai.UseVisualStyleBackColor = false;
            this.btn_saveLoai.Visible = false;
            this.btn_saveLoai.Click += new System.EventHandler(this.btn_saveLoai_Click);
            // 
            // tb_TenLoai
            // 
            this.tb_TenLoai.Enabled = false;
            this.tb_TenLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenLoai.Location = new System.Drawing.Point(256, 210);
            this.tb_TenLoai.Name = "tb_TenLoai";
            this.tb_TenLoai.Size = new System.Drawing.Size(503, 38);
            this.tb_TenLoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tên loại sản phẩm";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // tb_MaLoai
            // 
            this.tb_MaLoai.Enabled = false;
            this.tb_MaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_MaLoai.Location = new System.Drawing.Point(256, 44);
            this.tb_MaLoai.Name = "tb_MaLoai";
            this.tb_MaLoai.Size = new System.Drawing.Size(503, 38);
            this.tb_MaLoai.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại sản phẩm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grid_LoaiSanPham
            // 
            this.grid_LoaiSanPham.AllowUserToAddRows = false;
            this.grid_LoaiSanPham.AllowUserToDeleteRows = false;
            this.grid_LoaiSanPham.AllowUserToResizeColumns = false;
            this.grid_LoaiSanPham.AllowUserToResizeRows = false;
            this.grid_LoaiSanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_LoaiSanPham.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_LoaiSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.grid_LoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_LoaiSanPham.Location = new System.Drawing.Point(12, 402);
            this.grid_LoaiSanPham.Name = "grid_LoaiSanPham";
            this.grid_LoaiSanPham.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightCyan;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_LoaiSanPham.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grid_LoaiSanPham.RowHeadersVisible = false;
            this.grid_LoaiSanPham.RowHeadersWidth = 51;
            this.grid_LoaiSanPham.RowTemplate.Height = 24;
            this.grid_LoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_LoaiSanPham.Size = new System.Drawing.Size(1176, 346);
            this.grid_LoaiSanPham.TabIndex = 5;
            this.grid_LoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_LoaiSanPham_CellClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_Reload);
            this.panel4.Controls.Add(this.btn_editLoaiSanPham);
            this.panel4.Controls.Add(this.btn_deleteLoaiSanPham);
            this.panel4.Controls.Add(this.btn_addLoaiSanPham);
            this.panel4.Location = new System.Drawing.Point(792, 170);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(396, 226);
            this.panel4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 57);
            this.button1.TabIndex = 104;
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
            this.btn_Reload.Location = new System.Drawing.Point(203, 157);
            this.btn_Reload.Name = "btn_Reload";
            this.btn_Reload.Size = new System.Drawing.Size(178, 59);
            this.btn_Reload.TabIndex = 102;
            this.btn_Reload.UseVisualStyleBackColor = false;
            this.btn_Reload.Click += new System.EventHandler(this.TaiLai_Click);
            // 
            // btn_editLoaiSanPham
            // 
            this.btn_editLoaiSanPham.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_editLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_editLoaiSanPham.Location = new System.Drawing.Point(203, 84);
            this.btn_editLoaiSanPham.Name = "btn_editLoaiSanPham";
            this.btn_editLoaiSanPham.Size = new System.Drawing.Size(178, 62);
            this.btn_editLoaiSanPham.TabIndex = 9;
            this.btn_editLoaiSanPham.Text = "Sửa";
            this.btn_editLoaiSanPham.UseVisualStyleBackColor = false;
            this.btn_editLoaiSanPham.Click += new System.EventHandler(this.SuaLoaiSP_Click);
            // 
            // btn_deleteLoaiSanPham
            // 
            this.btn_deleteLoaiSanPham.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_deleteLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deleteLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deleteLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_deleteLoaiSanPham.Location = new System.Drawing.Point(12, 84);
            this.btn_deleteLoaiSanPham.Name = "btn_deleteLoaiSanPham";
            this.btn_deleteLoaiSanPham.Size = new System.Drawing.Size(178, 62);
            this.btn_deleteLoaiSanPham.TabIndex = 10;
            this.btn_deleteLoaiSanPham.Text = "Xóa";
            this.btn_deleteLoaiSanPham.UseVisualStyleBackColor = false;
            this.btn_deleteLoaiSanPham.Click += new System.EventHandler(this.btn_deleteLoaiSanPham_Click);
            // 
            // btn_addLoaiSanPham
            // 
            this.btn_addLoaiSanPham.BackColor = System.Drawing.Color.Navy;
            this.btn_addLoaiSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addLoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_addLoaiSanPham.Location = new System.Drawing.Point(12, 20);
            this.btn_addLoaiSanPham.Name = "btn_addLoaiSanPham";
            this.btn_addLoaiSanPham.Size = new System.Drawing.Size(369, 58);
            this.btn_addLoaiSanPham.TabIndex = 6;
            this.btn_addLoaiSanPham.Text = "Thêm Loại Sản Phẩm";
            this.btn_addLoaiSanPham.UseVisualStyleBackColor = false;
            this.btn_addLoaiSanPham.Click += new System.EventHandler(this.ThemLoaiSP_Click);
            // 
            // LoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grid_LoaiSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1200, 760);
            this.MinimumSize = new System.Drawing.Size(1200, 760);
            this.Name = "LoaiSanPham";
            this.Text = "LoaiSanPham";
            this.Load += new System.EventHandler(this.LoaiSanPham_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LoaiSanPham)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_TimLoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_saveLoai;
        private System.Windows.Forms.TextBox tb_TenLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MaLoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView grid_LoaiSanPham;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.ComboBox cb_MaNcc;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Reload;
        private System.Windows.Forms.Button btn_editLoaiSanPham;
        private System.Windows.Forms.Button btn_deleteLoaiSanPham;
        private System.Windows.Forms.Button btn_addLoaiSanPham;
        private System.Windows.Forms.Button button1;
    }
}