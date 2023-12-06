namespace SieuThiMini.GUI
{
    partial class CTDonNhapHang
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.display_MaNV = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.display_MaDN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.display_Time = new System.Windows.Forms.Label();
            this.grid_CTDNH = new System.Windows.Forms.DataGridView();
            this.label_CTKM = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDNH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.display_MaNV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(447, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(147, 47);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã nhân viên";
            // 
            // display_MaNV
            // 
            this.display_MaNV.AutoSize = true;
            this.display_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaNV.Location = new System.Drawing.Point(5, 20);
            this.display_MaNV.Name = "display_MaNV";
            this.display_MaNV.Size = new System.Drawing.Size(23, 25);
            this.display_MaNV.TabIndex = 9;
            this.display_MaNV.Text = "3";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.display_MaDN);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(297, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(144, 48);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã đơn nhập";
            // 
            // display_MaDN
            // 
            this.display_MaDN.AutoSize = true;
            this.display_MaDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaDN.Location = new System.Drawing.Point(5, 20);
            this.display_MaDN.Name = "display_MaDN";
            this.display_MaDN.Size = new System.Drawing.Size(23, 25);
            this.display_MaDN.TabIndex = 5;
            this.display_MaDN.Text = "2";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.display_Time);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(251, 48);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày xuất";
            // 
            // display_Time
            // 
            this.display_Time.AutoSize = true;
            this.display_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Time.Location = new System.Drawing.Point(5, 23);
            this.display_Time.Name = "display_Time";
            this.display_Time.Size = new System.Drawing.Size(23, 25);
            this.display_Time.TabIndex = 6;
            this.display_Time.Text = "1";
            // 
            // grid_CTDNH
            // 
            this.grid_CTDNH.AllowUserToAddRows = false;
            this.grid_CTDNH.AllowUserToDeleteRows = false;
            this.grid_CTDNH.AllowUserToResizeColumns = false;
            this.grid_CTDNH.AllowUserToResizeRows = false;
            this.grid_CTDNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_CTDNH.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_CTDNH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_CTDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CTDNH.Location = new System.Drawing.Point(40, 160);
            this.grid_CTDNH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_CTDNH.Name = "grid_CTDNH";
            this.grid_CTDNH.ReadOnly = true;
            this.grid_CTDNH.RowHeadersVisible = false;
            this.grid_CTDNH.RowHeadersWidth = 51;
            this.grid_CTDNH.RowTemplate.Height = 24;
            this.grid_CTDNH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_CTDNH.ShowCellErrors = false;
            this.grid_CTDNH.ShowCellToolTips = false;
            this.grid_CTDNH.ShowEditingIcon = false;
            this.grid_CTDNH.ShowRowErrors = false;
            this.grid_CTDNH.Size = new System.Drawing.Size(555, 428);
            this.grid_CTDNH.TabIndex = 14;
            this.grid_CTDNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CTHD_CellContentClick);
            // 
            // label_CTKM
            // 
            this.label_CTKM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CTKM.Location = new System.Drawing.Point(35, 103);
            this.label_CTKM.Name = "label_CTKM";
            this.label_CTKM.Size = new System.Drawing.Size(573, 38);
            this.label_CTKM.TabIndex = 13;
            this.label_CTKM.Text = "CHI TIẾT ĐƠN NHẬP HÀNG";
            this.label_CTKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CTDonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(641, 620);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grid_CTDNH);
            this.Controls.Add(this.label_CTKM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(659, 667);
            this.MinimumSize = new System.Drawing.Size(659, 667);
            this.Name = "CTDonNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết đơn nhập hàng";
            this.Load += new System.EventHandler(this.CTDonNhapHang_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTDNH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label display_MaNV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label display_MaDN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label display_Time;
        private System.Windows.Forms.DataGridView grid_CTDNH;
        private System.Windows.Forms.Label label_CTKM;
    }
}