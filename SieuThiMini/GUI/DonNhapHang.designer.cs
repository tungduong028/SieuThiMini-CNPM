namespace SieuThiMini.GUI
{
    partial class DonNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonNhapHang));
            this.TimKiem = new System.Windows.Forms.GroupBox();
            this.text_Find = new System.Windows.Forms.TextBox();
            this.Date_end = new System.Windows.Forms.GroupBox();
            this.text_DateEnd = new System.Windows.Forms.TextBox();
            this.pickDate_end = new System.Windows.Forms.DateTimePicker();
            this.Date_start = new System.Windows.Forms.GroupBox();
            this.text_DateStart = new System.Windows.Forms.TextBox();
            this.pickDate_start = new System.Windows.Forms.DateTimePicker();
            this.grid_DSDonNhap = new System.Windows.Forms.DataGridView();
            this.button_Restore = new System.Windows.Forms.Button();
            this.button_Remove = new System.Windows.Forms.Button();
            this.Excel_Export = new System.Windows.Forms.Button();
            this.button_ViewDetails = new System.Windows.Forms.Button();
            this.button_Reload = new System.Windows.Forms.Button();
            this.Find_date = new System.Windows.Forms.Button();
            this.btn_addDonNhap = new System.Windows.Forms.Button();
            this.TimKiem.SuspendLayout();
            this.Date_end.SuspendLayout();
            this.Date_start.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSDonNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // TimKiem
            // 
            this.TimKiem.BackColor = System.Drawing.Color.AliceBlue;
            this.TimKiem.Controls.Add(this.text_Find);
            this.TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimKiem.Location = new System.Drawing.Point(40, 39);
            this.TimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimKiem.Name = "TimKiem";
            this.TimKiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TimKiem.Size = new System.Drawing.Size(404, 57);
            this.TimKiem.TabIndex = 2;
            this.TimKiem.TabStop = false;
            this.TimKiem.Text = "Tìm kiếm";
            // 
            // text_Find
            // 
            this.text_Find.Location = new System.Drawing.Point(7, 23);
            this.text_Find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_Find.Name = "text_Find";
            this.text_Find.Size = new System.Drawing.Size(391, 27);
            this.text_Find.TabIndex = 0;
            this.text_Find.TextChanged += new System.EventHandler(this.text_Find_TextChanged);
            // 
            // Date_end
            // 
            this.Date_end.BackColor = System.Drawing.Color.AliceBlue;
            this.Date_end.Controls.Add(this.text_DateEnd);
            this.Date_end.Controls.Add(this.pickDate_end);
            this.Date_end.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_end.Location = new System.Drawing.Point(844, 33);
            this.Date_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_end.Name = "Date_end";
            this.Date_end.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_end.Size = new System.Drawing.Size(235, 57);
            this.Date_end.TabIndex = 10;
            this.Date_end.TabStop = false;
            this.Date_end.Text = "Đến ngày";
            // 
            // text_DateEnd
            // 
            this.text_DateEnd.Location = new System.Drawing.Point(5, 20);
            this.text_DateEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_DateEnd.Name = "text_DateEnd";
            this.text_DateEnd.Size = new System.Drawing.Size(192, 27);
            this.text_DateEnd.TabIndex = 7;
            // 
            // pickDate_end
            // 
            this.pickDate_end.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickDate_end.Location = new System.Drawing.Point(204, 20);
            this.pickDate_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickDate_end.Name = "pickDate_end";
            this.pickDate_end.Size = new System.Drawing.Size(25, 27);
            this.pickDate_end.TabIndex = 0;
            this.pickDate_end.ValueChanged += new System.EventHandler(this.pickDate_end_ValueChanged);
            // 
            // Date_start
            // 
            this.Date_start.BackColor = System.Drawing.Color.AliceBlue;
            this.Date_start.Controls.Add(this.text_DateStart);
            this.Date_start.Controls.Add(this.pickDate_start);
            this.Date_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_start.Location = new System.Drawing.Point(613, 33);
            this.Date_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_start.Name = "Date_start";
            this.Date_start.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Date_start.Size = new System.Drawing.Size(225, 57);
            this.Date_start.TabIndex = 9;
            this.Date_start.TabStop = false;
            this.Date_start.Text = "Từ ngày";
            // 
            // text_DateStart
            // 
            this.text_DateStart.Location = new System.Drawing.Point(5, 22);
            this.text_DateStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_DateStart.Name = "text_DateStart";
            this.text_DateStart.Size = new System.Drawing.Size(183, 27);
            this.text_DateStart.TabIndex = 1;
            // 
            // pickDate_start
            // 
            this.pickDate_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickDate_start.Location = new System.Drawing.Point(195, 22);
            this.pickDate_start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pickDate_start.Name = "pickDate_start";
            this.pickDate_start.Size = new System.Drawing.Size(25, 27);
            this.pickDate_start.TabIndex = 0;
            this.pickDate_start.ValueChanged += new System.EventHandler(this.pickDate_start_ValueChanged);
            // 
            // grid_DSDonNhap
            // 
            this.grid_DSDonNhap.BackgroundColor = System.Drawing.Color.Azure;
            this.grid_DSDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_DSDonNhap.Location = new System.Drawing.Point(47, 222);
            this.grid_DSDonNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grid_DSDonNhap.Name = "grid_DSDonNhap";
            this.grid_DSDonNhap.ReadOnly = true;
            this.grid_DSDonNhap.RowHeadersVisible = false;
            this.grid_DSDonNhap.RowHeadersWidth = 51;
            this.grid_DSDonNhap.RowTemplate.Height = 24;
            this.grid_DSDonNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_DSDonNhap.Size = new System.Drawing.Size(1089, 494);
            this.grid_DSDonNhap.TabIndex = 17;
            this.grid_DSDonNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_DSHoaDon_CellContentClick);
            // 
            // button_Restore
            // 
            this.button_Restore.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Restore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Restore.Image = ((System.Drawing.Image)(resources.GetObject("button_Restore.Image")));
            this.button_Restore.Location = new System.Drawing.Point(992, 118);
            this.button_Restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Restore.Name = "button_Restore";
            this.button_Restore.Size = new System.Drawing.Size(65, 50);
            this.button_Restore.TabIndex = 16;
            this.button_Restore.UseVisualStyleBackColor = false;
            this.button_Restore.Click += new System.EventHandler(this.button_Restore_Click);
            // 
            // button_Remove
            // 
            this.button_Remove.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Remove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Remove.Image = ((System.Drawing.Image)(resources.GetObject("button_Remove.Image")));
            this.button_Remove.Location = new System.Drawing.Point(1063, 118);
            this.button_Remove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Remove.Name = "button_Remove";
            this.button_Remove.Size = new System.Drawing.Size(67, 50);
            this.button_Remove.TabIndex = 15;
            this.button_Remove.UseVisualStyleBackColor = false;
            this.button_Remove.Click += new System.EventHandler(this.button_Remove_Click);
            // 
            // Excel_Export
            // 
            this.Excel_Export.BackColor = System.Drawing.Color.AliceBlue;
            this.Excel_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excel_Export.Image = global::SieuThiMini.Properties.Resources.excel;
            this.Excel_Export.Location = new System.Drawing.Point(299, 114);
            this.Excel_Export.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Excel_Export.Name = "Excel_Export";
            this.Excel_Export.Size = new System.Drawing.Size(69, 50);
            this.Excel_Export.TabIndex = 14;
            this.Excel_Export.UseVisualStyleBackColor = false;
            this.Excel_Export.Click += new System.EventHandler(this.Excel_Export_Click);
            // 
            // button_ViewDetails
            // 
            this.button_ViewDetails.BackColor = System.Drawing.Color.AliceBlue;
            this.button_ViewDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ViewDetails.Image = global::SieuThiMini.Properties.Resources.view_details;
            this.button_ViewDetails.Location = new System.Drawing.Point(207, 114);
            this.button_ViewDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_ViewDetails.Name = "button_ViewDetails";
            this.button_ViewDetails.Size = new System.Drawing.Size(75, 50);
            this.button_ViewDetails.TabIndex = 13;
            this.button_ViewDetails.UseVisualStyleBackColor = false;
            this.button_ViewDetails.Click += new System.EventHandler(this.button_ViewDetails_Click);
            // 
            // button_Reload
            // 
            this.button_Reload.BackColor = System.Drawing.Color.AliceBlue;
            this.button_Reload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Reload.Image = global::SieuThiMini.Properties.Resources.refresh;
            this.button_Reload.Location = new System.Drawing.Point(40, 114);
            this.button_Reload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(144, 50);
            this.button_Reload.TabIndex = 12;
            this.button_Reload.Text = "Reload";
            this.button_Reload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Reload.UseVisualStyleBackColor = false;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // Find_date
            // 
            this.Find_date.BackColor = System.Drawing.Color.AliceBlue;
            this.Find_date.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Find_date.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Find_date.Image = ((System.Drawing.Image)(resources.GetObject("Find_date.Image")));
            this.Find_date.Location = new System.Drawing.Point(1085, 33);
            this.Find_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Find_date.Name = "Find_date";
            this.Find_date.Size = new System.Drawing.Size(67, 57);
            this.Find_date.TabIndex = 11;
            this.Find_date.UseVisualStyleBackColor = false;
            this.Find_date.Click += new System.EventHandler(this.Find_date_Click);
            // 
            // btn_addDonNhap
            // 
            this.btn_addDonNhap.BackColor = System.Drawing.Color.AliceBlue;
            this.btn_addDonNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_addDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addDonNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDonNhap.ForeColor = System.Drawing.Color.White;
            this.btn_addDonNhap.Image = global::SieuThiMini.Properties.Resources.them;
            this.btn_addDonNhap.Location = new System.Drawing.Point(919, 118);
            this.btn_addDonNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addDonNhap.Name = "btn_addDonNhap";
            this.btn_addDonNhap.Size = new System.Drawing.Size(68, 50);
            this.btn_addDonNhap.TabIndex = 0;
            this.btn_addDonNhap.UseVisualStyleBackColor = false;
            this.btn_addDonNhap.Click += new System.EventHandler(this.btn_addDonDat_Click);
            // 
            // DonNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1200, 761);
            this.Controls.Add(this.grid_DSDonNhap);
            this.Controls.Add(this.button_Restore);
            this.Controls.Add(this.button_Remove);
            this.Controls.Add(this.Excel_Export);
            this.Controls.Add(this.button_ViewDetails);
            this.Controls.Add(this.button_Reload);
            this.Controls.Add(this.Find_date);
            this.Controls.Add(this.Date_end);
            this.Controls.Add(this.Date_start);
            this.Controls.Add(this.TimKiem);
            this.Controls.Add(this.btn_addDonNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DonNhapHang";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DonDatLoad);
            this.TimKiem.ResumeLayout(false);
            this.TimKiem.PerformLayout();
            this.Date_end.ResumeLayout(false);
            this.Date_end.PerformLayout();
            this.Date_start.ResumeLayout(false);
            this.Date_start.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DSDonNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_addDonNhap;
        private System.Windows.Forms.GroupBox TimKiem;
        private System.Windows.Forms.TextBox text_Find;
        private System.Windows.Forms.Button Find_date;
        private System.Windows.Forms.GroupBox Date_end;
        private System.Windows.Forms.TextBox text_DateEnd;
        private System.Windows.Forms.DateTimePicker pickDate_end;
        private System.Windows.Forms.GroupBox Date_start;
        private System.Windows.Forms.TextBox text_DateStart;
        private System.Windows.Forms.DateTimePicker pickDate_start;
        private System.Windows.Forms.Button button_Restore;
        private System.Windows.Forms.Button button_Remove;
        private System.Windows.Forms.Button Excel_Export;
        private System.Windows.Forms.Button button_ViewDetails;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.DataGridView grid_DSDonNhap;
    }
}