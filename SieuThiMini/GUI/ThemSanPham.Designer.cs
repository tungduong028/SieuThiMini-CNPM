namespace SieuThiMini.GUI
{
    partial class ThemSanPham
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_Maloai = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_addSanPham = new System.Windows.Forms.Button();
            this.tb_GiaNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_GiaSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cb_Maloai);
            this.panel1.Controls.Add(this.btn_Huy);
            this.panel1.Controls.Add(this.btn_addSanPham);
            this.panel1.Controls.Add(this.tb_GiaNhap);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_GiaSanPham);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tb_TenSanPham);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 392);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cb_Maloai
            // 
            this.cb_Maloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Maloai.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Maloai.FormattingEnabled = true;
            this.cb_Maloai.Location = new System.Drawing.Point(243, 19);
            this.cb_Maloai.Name = "cb_Maloai";
            this.cb_Maloai.Size = new System.Drawing.Size(506, 39);
            this.cb_Maloai.TabIndex = 14;
            this.cb_Maloai.SelectedIndexChanged += new System.EventHandler(this.cb_Maloai_SelectedIndexChanged);
            // 
            // btn_Huy
            // 
            this.btn_Huy.BackColor = System.Drawing.Color.Crimson;
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Location = new System.Drawing.Point(393, 314);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(296, 64);
            this.btn_Huy.TabIndex = 12;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = false;
            this.btn_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_addSanPham
            // 
            this.btn_addSanPham.BackColor = System.Drawing.Color.Navy;
            this.btn_addSanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addSanPham.ForeColor = System.Drawing.Color.White;
            this.btn_addSanPham.Location = new System.Drawing.Point(80, 314);
            this.btn_addSanPham.Name = "btn_addSanPham";
            this.btn_addSanPham.Size = new System.Drawing.Size(296, 64);
            this.btn_addSanPham.TabIndex = 11;
            this.btn_addSanPham.Text = "Thêm sản phẩm";
            this.btn_addSanPham.UseVisualStyleBackColor = false;
            this.btn_addSanPham.Click += new System.EventHandler(this.btn_addSanPham_Click);
            // 
            // tb_GiaNhap
            // 
            this.tb_GiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaNhap.Location = new System.Drawing.Point(243, 242);
            this.tb_GiaNhap.Name = "tb_GiaNhap";
            this.tb_GiaNhap.Size = new System.Drawing.Size(503, 38);
            this.tb_GiaNhap.TabIndex = 10;
            this.tb_GiaNhap.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giá nhập";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tb_GiaSanPham
            // 
            this.tb_GiaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_GiaSanPham.Location = new System.Drawing.Point(243, 166);
            this.tb_GiaSanPham.Name = "tb_GiaSanPham";
            this.tb_GiaSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_GiaSanPham.TabIndex = 8;
            this.tb_GiaSanPham.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Giá";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenSanPham.Location = new System.Drawing.Point(243, 92);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(503, 38);
            this.tb_TenSanPham.TabIndex = 6;
            this.tb_TenSanPham.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(798, 416);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ThemSanPham";
            this.Load += new System.EventHandler(this.ThemSanPham_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_GiaNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_GiaSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_addSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Maloai;
    }
}