namespace SieuThiMini.GUI
{
    partial class KhoiPhucDonNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhoiPhucDonNhapHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.grid_DNHDeleted = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DNHDeleted)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.txt_TimKiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(231, 44);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(4, 17);
            this.txt_TimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(222, 23);
            this.txt_TimKiem.TabIndex = 0;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // grid_DNHDeleted
            // 
            this.grid_DNHDeleted.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.grid_DNHDeleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DNHDeleted.Location = new System.Drawing.Point(23, 112);
            this.grid_DNHDeleted.Margin = new System.Windows.Forms.Padding(2);
            this.grid_DNHDeleted.Name = "grid_DNHDeleted";
            this.grid_DNHDeleted.ReadOnly = true;
            this.grid_DNHDeleted.RowHeadersVisible = false;
            this.grid_DNHDeleted.RowHeadersWidth = 51;
            this.grid_DNHDeleted.RowTemplate.Height = 24;
            this.grid_DNHDeleted.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DNHDeleted.Size = new System.Drawing.Size(436, 377);
            this.grid_DNHDeleted.TabIndex = 5;
            this.grid_DNHDeleted.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DNHDeleted_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "DANH SÁCH ĐƠN NHẬP HÀNG BỊ XÓA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_Restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Restore.Image = ((System.Drawing.Image)(resources.GetObject("btn_Restore.Image")));
            this.btn_Restore.Location = new System.Drawing.Point(409, 63);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(51, 44);
            this.btn_Restore.TabIndex = 6;
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // KhoiPhucDonNhapHang
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(482, 505);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.grid_DNHDeleted);
            this.Controls.Add(this.label1);
            this.Name = "KhoiPhucDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Khôi phục đơn nhập hàng";
            this.Load += new System.EventHandler(this.KhoiPhucDonNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DNHDeleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.DataGridView grid_DNHDeleted;
        private System.Windows.Forms.Label label1;
    }
}