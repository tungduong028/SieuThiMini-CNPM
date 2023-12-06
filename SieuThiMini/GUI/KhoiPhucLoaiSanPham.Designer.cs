namespace SieuThiMini.GUI
{
    partial class KhoiPhucLoaiSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.tb_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.Data_View_LoaiSanPham = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Data_View_LoaiSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "KHÔI PHỤC LOẠI SẢN PHẨM";
            // 
            // btn_KhoiPhuc
            // 
            this.btn_KhoiPhuc.BackColor = System.Drawing.Color.Navy;
            this.btn_KhoiPhuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KhoiPhuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_KhoiPhuc.ForeColor = System.Drawing.Color.White;
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(324, 132);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(119, 61);
            this.btn_KhoiPhuc.TabIndex = 11;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // tb_TimKiem
            // 
            this.tb_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimKiem.Location = new System.Drawing.Point(201, 67);
            this.tb_TimKiem.Name = "tb_TimKiem";
            this.tb_TimKiem.Size = new System.Drawing.Size(345, 38);
            this.tb_TimKiem.TabIndex = 13;
            this.tb_TimKiem.TextChanged += new System.EventHandler(this.TimKiem);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(199, 132);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 61);
            this.btn_Refresh.TabIndex = 14;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // Data_View_LoaiSanPham
            // 
            this.Data_View_LoaiSanPham.AllowUserToAddRows = false;
            this.Data_View_LoaiSanPham.AllowUserToDeleteRows = false;
            this.Data_View_LoaiSanPham.AllowUserToResizeColumns = false;
            this.Data_View_LoaiSanPham.AllowUserToResizeRows = false;
            this.Data_View_LoaiSanPham.BackgroundColor = System.Drawing.Color.Snow;
            this.Data_View_LoaiSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_View_LoaiSanPham.Location = new System.Drawing.Point(12, 199);
            this.Data_View_LoaiSanPham.Name = "Data_View_LoaiSanPham";
            this.Data_View_LoaiSanPham.ReadOnly = true;
            this.Data_View_LoaiSanPham.RowHeadersVisible = false;
            this.Data_View_LoaiSanPham.RowHeadersWidth = 51;
            this.Data_View_LoaiSanPham.RowTemplate.Height = 24;
            this.Data_View_LoaiSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data_View_LoaiSanPham.Size = new System.Drawing.Size(615, 542);
            this.Data_View_LoaiSanPham.TabIndex = 15;
            this.Data_View_LoaiSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tìm kiếm";
            // 
            // KhoiPhucLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(639, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data_View_LoaiSanPham);
            this.Controls.Add(this.tb_TimKiem);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucLoaiSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục loại sản phẩm";
            this.Load += new System.EventHandler(this.KhoiPhucLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Data_View_LoaiSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.TextBox tb_TimKiem;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.DataGridView Data_View_LoaiSanPham;
        private System.Windows.Forms.Label label2;
    }
}