namespace SieuThiMini.GUI
{
    partial class KhoiPhucSanPham
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
            this.grid_SanPham = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_TimSanPham = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_KhoiPhuc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_SanPham
            // 
            this.grid_SanPham.AllowUserToAddRows = false;
            this.grid_SanPham.AllowUserToDeleteRows = false;
            this.grid_SanPham.AllowUserToResizeColumns = false;
            this.grid_SanPham.AllowUserToResizeRows = false;
            this.grid_SanPham.BackgroundColor = System.Drawing.Color.Snow;
            this.grid_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_SanPham.Location = new System.Drawing.Point(12, 199);
            this.grid_SanPham.Name = "grid_SanPham";
            this.grid_SanPham.ReadOnly = true;
            this.grid_SanPham.RowHeadersVisible = false;
            this.grid_SanPham.RowHeadersWidth = 51;
            this.grid_SanPham.RowTemplate.Height = 24;
            this.grid_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_SanPham.Size = new System.Drawing.Size(615, 542);
            this.grid_SanPham.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Tìm kiếm";
            // 
            // tb_TimSanPham
            // 
            this.tb_TimSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TimSanPham.Location = new System.Drawing.Point(208, 67);
            this.tb_TimSanPham.Name = "tb_TimSanPham";
            this.tb_TimSanPham.Size = new System.Drawing.Size(345, 38);
            this.tb_TimSanPham.TabIndex = 19;
            this.tb_TimSanPham.TextChanged += new System.EventHandler(this.tb_TimKiem_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.Location = new System.Drawing.Point(206, 132);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(119, 61);
            this.btn_Refresh.TabIndex = 20;
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
            this.btn_KhoiPhuc.Location = new System.Drawing.Point(331, 132);
            this.btn_KhoiPhuc.Name = "btn_KhoiPhuc";
            this.btn_KhoiPhuc.Size = new System.Drawing.Size(119, 61);
            this.btn_KhoiPhuc.TabIndex = 18;
            this.btn_KhoiPhuc.Text = "Khôi phục";
            this.btn_KhoiPhuc.UseVisualStyleBackColor = false;
            this.btn_KhoiPhuc.Click += new System.EventHandler(this.btn_KhoiPhuc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 38);
            this.label1.TabIndex = 17;
            this.label1.Text = "KHÔI PHỤC SẢN PHẨM";
            // 
            // KhoiPhucSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(639, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_TimSanPham);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_KhoiPhuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_SanPham);
            this.Name = "KhoiPhucSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục sản phẩm";
            this.Load += new System.EventHandler(this.KhoiPhucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_SanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_TimSanPham;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_KhoiPhuc;
        private System.Windows.Forms.Label label1;
    }
}