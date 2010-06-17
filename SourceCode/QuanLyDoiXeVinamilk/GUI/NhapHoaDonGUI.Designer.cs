namespace GUI
{
    partial class frm_NhapHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cbo_XeGiaoHang = new System.Windows.Forms.ComboBox();
            this.grb_ChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.dtgv_DanhSachPhanCong = new System.Windows.Forms.DataGridView();
            this.dtp_NgayGiaoHang = new System.Windows.Forms.DateTimePicker();
            this.lbl_Xe = new System.Windows.Forms.Label();
            this.lbl_NgayGiaoHang = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lbl_NgayLapHoaDon = new System.Windows.Forms.Label();
            this.dtp_NgayLapHoaDon = new System.Windows.Forms.DateTimePicker();
            this.STT_PhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDiaDiem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnMatHang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clnSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTrangThai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.grb_ChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(222, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(185, 25);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "NHẬP HÓA ĐƠN";
            // 
            // cbo_XeGiaoHang
            // 
            this.cbo_XeGiaoHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_XeGiaoHang.FormattingEnabled = true;
            this.cbo_XeGiaoHang.Location = new System.Drawing.Point(317, 39);
            this.cbo_XeGiaoHang.Name = "cbo_XeGiaoHang";
            this.cbo_XeGiaoHang.Size = new System.Drawing.Size(105, 21);
            this.cbo_XeGiaoHang.TabIndex = 22;
            // 
            // grb_ChiTietHoaDon
            // 
            this.grb_ChiTietHoaDon.Controls.Add(this.dtgv_DanhSachPhanCong);
            this.grb_ChiTietHoaDon.Location = new System.Drawing.Point(12, 66);
            this.grb_ChiTietHoaDon.Name = "grb_ChiTietHoaDon";
            this.grb_ChiTietHoaDon.Size = new System.Drawing.Size(649, 333);
            this.grb_ChiTietHoaDon.TabIndex = 23;
            this.grb_ChiTietHoaDon.TabStop = false;
            this.grb_ChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // dtgv_DanhSachPhanCong
            // 
            this.dtgv_DanhSachPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_DanhSachPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_PhanCong,
            this.clnDiaDiem,
            this.clnMatHang,
            this.clnSoLuong,
            this.clnTrangThai});
            this.dtgv_DanhSachPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgv_DanhSachPhanCong.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtgv_DanhSachPhanCong.Location = new System.Drawing.Point(3, 16);
            this.dtgv_DanhSachPhanCong.Name = "dtgv_DanhSachPhanCong";
            this.dtgv_DanhSachPhanCong.RowHeadersVisible = false;
            this.dtgv_DanhSachPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgv_DanhSachPhanCong.Size = new System.Drawing.Size(643, 314);
            this.dtgv_DanhSachPhanCong.TabIndex = 0;
            this.dtgv_DanhSachPhanCong.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dtgv_DanhSachPhanCong_RowsAdded);
            // 
            // dtp_NgayGiaoHang
            // 
            this.dtp_NgayGiaoHang.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayGiaoHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayGiaoHang.Location = new System.Drawing.Point(104, 38);
            this.dtp_NgayGiaoHang.Name = "dtp_NgayGiaoHang";
            this.dtp_NgayGiaoHang.Size = new System.Drawing.Size(99, 20);
            this.dtp_NgayGiaoHang.TabIndex = 21;
            this.dtp_NgayGiaoHang.ValueChanged += new System.EventHandler(this.dtp_NgayGiaoHang_ValueChanged);
            // 
            // lbl_Xe
            // 
            this.lbl_Xe.AutoSize = true;
            this.lbl_Xe.Location = new System.Drawing.Point(241, 42);
            this.lbl_Xe.Name = "lbl_Xe";
            this.lbl_Xe.Size = new System.Drawing.Size(70, 13);
            this.lbl_Xe.TabIndex = 27;
            this.lbl_Xe.Text = "Xe giao hàng";
            // 
            // lbl_NgayGiaoHang
            // 
            this.lbl_NgayGiaoHang.AutoSize = true;
            this.lbl_NgayGiaoHang.Location = new System.Drawing.Point(12, 42);
            this.lbl_NgayGiaoHang.Name = "lbl_NgayGiaoHang";
            this.lbl_NgayGiaoHang.Size = new System.Drawing.Size(82, 13);
            this.lbl_NgayGiaoHang.TabIndex = 26;
            this.lbl_NgayGiaoHang.Text = "Ngày giao hàng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(502, 405);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 24;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(583, 405);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 25;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_PhanCong_Click);
            // 
            // lbl_NgayLapHoaDon
            // 
            this.lbl_NgayLapHoaDon.AutoSize = true;
            this.lbl_NgayLapHoaDon.Location = new System.Drawing.Point(464, 42);
            this.lbl_NgayLapHoaDon.Name = "lbl_NgayLapHoaDon";
            this.lbl_NgayLapHoaDon.Size = new System.Drawing.Size(92, 13);
            this.lbl_NgayLapHoaDon.TabIndex = 26;
            this.lbl_NgayLapHoaDon.Text = "Ngày lập hóa đơn";
            // 
            // dtp_NgayLapHoaDon
            // 
            this.dtp_NgayLapHoaDon.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayLapHoaDon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayLapHoaDon.Location = new System.Drawing.Point(562, 38);
            this.dtp_NgayLapHoaDon.Name = "dtp_NgayLapHoaDon";
            this.dtp_NgayLapHoaDon.ShowUpDown = true;
            this.dtp_NgayLapHoaDon.Size = new System.Drawing.Size(99, 20);
            this.dtp_NgayLapHoaDon.TabIndex = 21;
            // 
            // STT_PhanCong
            // 
            this.STT_PhanCong.HeaderText = "STT";
            this.STT_PhanCong.Name = "STT_PhanCong";
            this.STT_PhanCong.Width = 30;
            // 
            // clnDiaDiem
            // 
            this.clnDiaDiem.HeaderText = "Địa điểm";
            this.clnDiaDiem.Name = "clnDiaDiem";
            this.clnDiaDiem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnDiaDiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnDiaDiem.Width = 200;
            // 
            // clnMatHang
            // 
            this.clnMatHang.HeaderText = "Mặt hàng";
            this.clnMatHang.Name = "clnMatHang";
            this.clnMatHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnMatHang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clnMatHang.Width = 150;
            // 
            // clnSoLuong
            // 
            dataGridViewCellStyle11.Format = "t";
            dataGridViewCellStyle11.NullValue = null;
            this.clnSoLuong.DefaultCellStyle = dataGridViewCellStyle11;
            this.clnSoLuong.HeaderText = "Số lượng";
            this.clnSoLuong.Name = "clnSoLuong";
            // 
            // clnTrangThai
            // 
            this.clnTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.Format = "t";
            this.clnTrangThai.DefaultCellStyle = dataGridViewCellStyle12;
            this.clnTrangThai.HeaderText = "Trạng thái";
            this.clnTrangThai.Name = "clnTrangThai";
            this.clnTrangThai.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clnTrangThai.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // frm_NhapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 437);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.cbo_XeGiaoHang);
            this.Controls.Add(this.grb_ChiTietHoaDon);
            this.Controls.Add(this.dtp_NgayLapHoaDon);
            this.Controls.Add(this.dtp_NgayGiaoHang);
            this.Controls.Add(this.lbl_NgayLapHoaDon);
            this.Controls.Add(this.lbl_Xe);
            this.Controls.Add(this.lbl_NgayGiaoHang);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.MaximizeBox = false;
            this.Name = "frm_NhapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap hoa don";
            this.Load += new System.EventHandler(this.frm_NhapHoaDon_Load);
            this.grb_ChiTietHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_DanhSachPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cbo_XeGiaoHang;
        private System.Windows.Forms.GroupBox grb_ChiTietHoaDon;
        private System.Windows.Forms.DataGridView dtgv_DanhSachPhanCong;
        private System.Windows.Forms.DateTimePicker dtp_NgayGiaoHang;
        private System.Windows.Forms.Label lbl_Xe;
        private System.Windows.Forms.Label lbl_NgayGiaoHang;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Label lbl_NgayLapHoaDon;
        private System.Windows.Forms.DateTimePicker dtp_NgayLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_PhanCong;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnDiaDiem;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnMatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnSoLuong;
        private System.Windows.Forms.DataGridViewComboBoxColumn clnTrangThai;
    }
}