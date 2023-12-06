
namespace SieuThiMini.GUI
{
    partial class ChiTietHoaDon
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
            this.label_CTKM = new System.Windows.Forms.Label();
            this.grid_CTHD = new System.Windows.Forms.DataGridView();
            this.display_MaHD = new System.Windows.Forms.Label();
            this.display_Time = new System.Windows.Forms.Label();
            this.btn_InHD = new System.Windows.Forms.Button();
            this.display_MaNV = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_CTKM
            // 
            this.label_CTKM.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CTKM.Location = new System.Drawing.Point(39, 81);
            this.label_CTKM.Name = "label_CTKM";
            this.label_CTKM.Size = new System.Drawing.Size(573, 38);
            this.label_CTKM.TabIndex = 1;
            this.label_CTKM.Text = "CHI TIẾT HÓA ĐƠN ";
            this.label_CTKM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid_CTHD
            // 
            this.grid_CTHD.AllowUserToAddRows = false;
            this.grid_CTHD.AllowUserToDeleteRows = false;
            this.grid_CTHD.AllowUserToResizeColumns = false;
            this.grid_CTHD.AllowUserToResizeRows = false;
            this.grid_CTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_CTHD.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_CTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid_CTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_CTHD.Location = new System.Drawing.Point(44, 138);
            this.grid_CTHD.Name = "grid_CTHD";
            this.grid_CTHD.ReadOnly = true;
            this.grid_CTHD.RowHeadersVisible = false;
            this.grid_CTHD.RowHeadersWidth = 51;
            this.grid_CTHD.RowTemplate.Height = 24;
            this.grid_CTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_CTHD.ShowCellErrors = false;
            this.grid_CTHD.ShowCellToolTips = false;
            this.grid_CTHD.ShowEditingIcon = false;
            this.grid_CTHD.ShowRowErrors = false;
            this.grid_CTHD.Size = new System.Drawing.Size(554, 428);
            this.grid_CTHD.TabIndex = 4;
            this.grid_CTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CTHD_CellContentClick);
            // 
            // display_MaHD
            // 
            this.display_MaHD.AutoSize = true;
            this.display_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaHD.Location = new System.Drawing.Point(6, 20);
            this.display_MaHD.Name = "display_MaHD";
            this.display_MaHD.Size = new System.Drawing.Size(23, 25);
            this.display_MaHD.TabIndex = 5;
            this.display_MaHD.Text = "2";
            // 
            // display_Time
            // 
            this.display_Time.AutoSize = true;
            this.display_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Time.Location = new System.Drawing.Point(6, 23);
            this.display_Time.Name = "display_Time";
            this.display_Time.Size = new System.Drawing.Size(23, 25);
            this.display_Time.TabIndex = 6;
            this.display_Time.Text = "1";
            // 
            // btn_InHD
            // 
            this.btn_InHD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InHD.Location = new System.Drawing.Point(285, 576);
            this.btn_InHD.Name = "btn_InHD";
            this.btn_InHD.Size = new System.Drawing.Size(72, 34);
            this.btn_InHD.TabIndex = 7;
            this.btn_InHD.Text = "In";
            this.btn_InHD.UseVisualStyleBackColor = true;
            this.btn_InHD.Click += new System.EventHandler(this.btn_InHD_Click);
            // 
            // display_MaNV
            // 
            this.display_MaNV.AutoSize = true;
            this.display_MaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_MaNV.Location = new System.Drawing.Point(6, 20);
            this.display_MaNV.Name = "display_MaNV";
            this.display_MaNV.Size = new System.Drawing.Size(23, 25);
            this.display_MaNV.TabIndex = 9;
            this.display_MaNV.Text = "3";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.display_Time);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 48);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày xuất";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.display_MaHD);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(301, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 48);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mã hóa đơn";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox3.Controls.Add(this.display_MaNV);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(451, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 47);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mã nhân viên";
            // 
            // ChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(642, 622);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_InHD);
            this.Controls.Add(this.grid_CTHD);
            this.Controls.Add(this.label_CTKM);
            this.Name = "ChiTietHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.ChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_CTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_CTKM;
        private System.Windows.Forms.DataGridView grid_CTHD;
        private System.Windows.Forms.Label display_MaHD;
        private System.Windows.Forms.Label display_Time;
        private System.Windows.Forms.Button btn_InHD;
        private System.Windows.Forms.Label display_MaNV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}