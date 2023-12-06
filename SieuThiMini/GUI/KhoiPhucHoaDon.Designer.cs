namespace SieuThiMini.GUI
{
    partial class KhoiPhucHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiPhucHoaDon));
            this.label1 = new System.Windows.Forms.Label();
            this.grid_DsHDXoa = new System.Windows.Forms.DataGridView();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DsHDXoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH SẢN PHẨM BỊ XÓA";
            // 
            // grid_DsHDXoa
            // 
            this.grid_DsHDXoa.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid_DsHDXoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DsHDXoa.Location = new System.Drawing.Point(32, 146);
            this.grid_DsHDXoa.Name = "grid_DsHDXoa";
            this.grid_DsHDXoa.ReadOnly = true;
            this.grid_DsHDXoa.RowHeadersVisible = false;
            this.grid_DsHDXoa.RowHeadersWidth = 51;
            this.grid_DsHDXoa.RowTemplate.Height = 24;
            this.grid_DsHDXoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DsHDXoa.Size = new System.Drawing.Size(582, 464);
            this.grid_DsHDXoa.TabIndex = 1;
            this.grid_DsHDXoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DsHDXoa_CellContentClick);
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(546, 86);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(68, 54);
            this.btn_Restore.TabIndex = 2;
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(6, 21);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(295, 27);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // KhoiPhucHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(642, 622);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.grid_DsHDXoa);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "KhoiPhucHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục hóa đơn";
            this.Load += new System.EventHandler(this.KhoiPhucHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_DsHDXoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_DsHDXoa;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiem;
    }
}