namespace GUI
{
    partial class frm_CapNhatPhanCong
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_NgayPhanCong = new System.Windows.Forms.GroupBox();
            this.btn_XemPhanCong = new System.Windows.Forms.Button();
            this.dtp_NgayPhanCong = new System.Windows.Forms.DateTimePicker();
            this.lbl_NgayPhanCong = new System.Windows.Forms.Label();
            this.grb_ChiTietPhanCong = new System.Windows.Forms.GroupBox();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NhanVienPhanCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_ThongTinPhanCong = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbo_TaiXe = new System.Windows.Forms.ComboBox();
            this.lbl_TaiXe = new System.Windows.Forms.Label();
            this.lbl_KetThuc = new System.Windows.Forms.Label();
            this.cbo_BienSoXe = new System.Windows.Forms.ComboBox();
            this.lbl_ThoiGianBatDau = new System.Windows.Forms.Label();
            this.lbl_BienSoXe = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            dtgv_ChiTietPhanCong = new System.Windows.Forms.DataGridView();
            dtp_ThoiGianKetThuc = new System.Windows.Forms.DateTimePicker();
            dtp_ThoiGianBatDau = new System.Windows.Forms.DateTimePicker();
            this.grb_NgayPhanCong.SuspendLayout();
            this.grb_ChiTietPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dtgv_ChiTietPhanCong)).BeginInit();
            this.grb_ThongTinPhanCong.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(207, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(268, 25);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "CẬP NHẬT PHÂN CÔNG";
            // 
            // grb_NgayPhanCong
            // 
            this.grb_NgayPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_NgayPhanCong.Controls.Add(this.btn_XemPhanCong);
            this.grb_NgayPhanCong.Controls.Add(this.dtp_NgayPhanCong);
            this.grb_NgayPhanCong.Controls.Add(this.lbl_NgayPhanCong);
            this.grb_NgayPhanCong.Location = new System.Drawing.Point(13, 37);
            this.grb_NgayPhanCong.Name = "grb_NgayPhanCong";
            this.grb_NgayPhanCong.Size = new System.Drawing.Size(677, 69);
            this.grb_NgayPhanCong.TabIndex = 0;
            this.grb_NgayPhanCong.TabStop = false;
            this.grb_NgayPhanCong.Text = "Ngày phân công";
            // 
            // btn_XemPhanCong
            // 
            this.btn_XemPhanCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_XemPhanCong.Location = new System.Drawing.Point(412, 27);
            this.btn_XemPhanCong.Name = "btn_XemPhanCong";
            this.btn_XemPhanCong.Size = new System.Drawing.Size(96, 23);
            this.btn_XemPhanCong.TabIndex = 2;
            this.btn_XemPhanCong.Text = "&Xem phân công";
            this.btn_XemPhanCong.UseVisualStyleBackColor = true;
            this.btn_XemPhanCong.Click += new System.EventHandler(this.btn_XemPhanCong_Click);
            // 
            // dtp_NgayPhanCong
            // 
            this.dtp_NgayPhanCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtp_NgayPhanCong.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayPhanCong.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayPhanCong.Location = new System.Drawing.Point(252, 28);
            this.dtp_NgayPhanCong.Name = "dtp_NgayPhanCong";
            this.dtp_NgayPhanCong.Size = new System.Drawing.Size(100, 20);
            this.dtp_NgayPhanCong.TabIndex = 1;
            this.dtp_NgayPhanCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_NgayPhanCong_KeyPress);
            // 
            // lbl_NgayPhanCong
            // 
            this.lbl_NgayPhanCong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_NgayPhanCong.AutoSize = true;
            this.lbl_NgayPhanCong.Location = new System.Drawing.Point(135, 32);
            this.lbl_NgayPhanCong.Name = "lbl_NgayPhanCong";
            this.lbl_NgayPhanCong.Size = new System.Drawing.Size(86, 13);
            this.lbl_NgayPhanCong.TabIndex = 0;
            this.lbl_NgayPhanCong.Text = "Ngày phân công";
            // 
            // grb_ChiTietPhanCong
            // 
            this.grb_ChiTietPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ChiTietPhanCong.Controls.Add(dtgv_ChiTietPhanCong);
            this.grb_ChiTietPhanCong.Location = new System.Drawing.Point(13, 113);
            this.grb_ChiTietPhanCong.Name = "grb_ChiTietPhanCong";
            this.grb_ChiTietPhanCong.Size = new System.Drawing.Size(677, 278);
            this.grb_ChiTietPhanCong.TabIndex = 1;
            this.grb_ChiTietPhanCong.TabStop = false;
            this.grb_ChiTietPhanCong.Text = "Chi tiết phân công";
            // 
            // dtgv_ChiTietPhanCong
            // 
            dtgv_ChiTietPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            dtgv_ChiTietPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ChiTietPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BienSo,
            this.TaiXe,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc,
            this.NhanVienPhanCong});
            dtgv_ChiTietPhanCong.Location = new System.Drawing.Point(3, 16);
            dtgv_ChiTietPhanCong.MultiSelect = false;
            dtgv_ChiTietPhanCong.Name = "dtgv_ChiTietPhanCong";
            dtgv_ChiTietPhanCong.ReadOnly = true;
            dtgv_ChiTietPhanCong.RowHeadersVisible = false;
            dtgv_ChiTietPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgv_ChiTietPhanCong.Size = new System.Drawing.Size(671, 259);
            dtgv_ChiTietPhanCong.TabIndex = 0;
            dtgv_ChiTietPhanCong.SelectionChanged += new System.EventHandler(this.dtgv_ChiTietPhanCong_SelectionChanged);
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSoXe";
            this.BienSo.HeaderText = "Biển số xe";
            this.BienSo.Name = "BienSo";
            this.BienSo.ReadOnly = true;
            this.BienSo.Width = 80;
            // 
            // TaiXe
            // 
            this.TaiXe.DataPropertyName = "TaiXe";
            this.TaiXe.HeaderText = "Tài xế";
            this.TaiXe.Name = "TaiXe";
            this.TaiXe.ReadOnly = true;
            this.TaiXe.Width = 150;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.ReadOnly = true;
            this.ThoiGianBatDau.Width = 150;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.ReadOnly = true;
            this.ThoiGianKetThuc.Width = 150;
            // 
            // NhanVienPhanCong
            // 
            this.NhanVienPhanCong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NhanVienPhanCong.DataPropertyName = "NhanVienPhanCong";
            this.NhanVienPhanCong.HeaderText = "Nhân viên phân công";
            this.NhanVienPhanCong.Name = "NhanVienPhanCong";
            this.NhanVienPhanCong.ReadOnly = true;
            // 
            // grb_ThongTinPhanCong
            // 
            this.grb_ThongTinPhanCong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grb_ThongTinPhanCong.Controls.Add(this.btn_Luu);
            this.grb_ThongTinPhanCong.Controls.Add(dtp_ThoiGianKetThuc);
            this.grb_ThongTinPhanCong.Controls.Add(dtp_ThoiGianBatDau);
            this.grb_ThongTinPhanCong.Controls.Add(this.cbo_TaiXe);
            this.grb_ThongTinPhanCong.Controls.Add(this.lbl_TaiXe);
            this.grb_ThongTinPhanCong.Controls.Add(this.lbl_KetThuc);
            this.grb_ThongTinPhanCong.Controls.Add(this.cbo_BienSoXe);
            this.grb_ThongTinPhanCong.Controls.Add(this.lbl_ThoiGianBatDau);
            this.grb_ThongTinPhanCong.Controls.Add(this.lbl_BienSoXe);
            this.grb_ThongTinPhanCong.Location = new System.Drawing.Point(16, 398);
            this.grb_ThongTinPhanCong.Name = "grb_ThongTinPhanCong";
            this.grb_ThongTinPhanCong.Size = new System.Drawing.Size(671, 100);
            this.grb_ThongTinPhanCong.TabIndex = 2;
            this.grb_ThongTinPhanCong.TabStop = false;
            this.grb_ThongTinPhanCong.Text = "Thông tin phân công";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(512, 15);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(92, 23);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "&Lưu cập nhật";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // dtp_ThoiGianKetThuc
            // 
            dtp_ThoiGianKetThuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            dtp_ThoiGianKetThuc.CustomFormat = "hh:mm:ss";
            dtp_ThoiGianKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp_ThoiGianKetThuc.Location = new System.Drawing.Point(307, 64);
            dtp_ThoiGianKetThuc.Name = "dtp_ThoiGianKetThuc";
            dtp_ThoiGianKetThuc.ShowUpDown = true;
            dtp_ThoiGianKetThuc.Size = new System.Drawing.Size(121, 20);
            dtp_ThoiGianKetThuc.TabIndex = 3;
            dtp_ThoiGianKetThuc.ValueChanged += new System.EventHandler(this.dtp_ThoiGianKetThuc_ValueChanged);
            // 
            // dtp_ThoiGianBatDau
            // 
            dtp_ThoiGianBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            dtp_ThoiGianBatDau.CustomFormat = "hh:mm:ss";
            dtp_ThoiGianBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtp_ThoiGianBatDau.Location = new System.Drawing.Point(69, 60);
            dtp_ThoiGianBatDau.Name = "dtp_ThoiGianBatDau";
            dtp_ThoiGianBatDau.ShowUpDown = true;
            dtp_ThoiGianBatDau.Size = new System.Drawing.Size(121, 20);
            dtp_ThoiGianBatDau.TabIndex = 2;
            dtp_ThoiGianBatDau.ValueChanged += new System.EventHandler(this.dtp_ThoiGianBatDau_ValueChanged);
            // 
            // cbo_TaiXe
            // 
            this.cbo_TaiXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cbo_TaiXe.FormattingEnabled = true;
            this.cbo_TaiXe.Location = new System.Drawing.Point(307, 17);
            this.cbo_TaiXe.Name = "cbo_TaiXe";
            this.cbo_TaiXe.Size = new System.Drawing.Size(121, 21);
            this.cbo_TaiXe.TabIndex = 1;
            this.cbo_TaiXe.SelectedValueChanged += new System.EventHandler(this.cbo_TaiXe_SelectedValueChanged);
            // 
            // lbl_TaiXe
            // 
            this.lbl_TaiXe.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_TaiXe.AutoSize = true;
            this.lbl_TaiXe.Location = new System.Drawing.Point(245, 20);
            this.lbl_TaiXe.Name = "lbl_TaiXe";
            this.lbl_TaiXe.Size = new System.Drawing.Size(36, 13);
            this.lbl_TaiXe.TabIndex = 0;
            this.lbl_TaiXe.Text = "Tài xế";
            // 
            // lbl_KetThuc
            // 
            this.lbl_KetThuc.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_KetThuc.AutoSize = true;
            this.lbl_KetThuc.Location = new System.Drawing.Point(245, 68);
            this.lbl_KetThuc.Name = "lbl_KetThuc";
            this.lbl_KetThuc.Size = new System.Drawing.Size(47, 13);
            this.lbl_KetThuc.TabIndex = 0;
            this.lbl_KetThuc.Text = "Kết thúc";
            // 
            // cbo_BienSoXe
            // 
            this.cbo_BienSoXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbo_BienSoXe.FormattingEnabled = true;
            this.cbo_BienSoXe.Location = new System.Drawing.Point(69, 17);
            this.cbo_BienSoXe.Name = "cbo_BienSoXe";
            this.cbo_BienSoXe.Size = new System.Drawing.Size(121, 21);
            this.cbo_BienSoXe.TabIndex = 0;
            this.cbo_BienSoXe.SelectedValueChanged += new System.EventHandler(this.cbo_BienSoXe_SelectedValueChanged);
            // 
            // lbl_ThoiGianBatDau
            // 
            this.lbl_ThoiGianBatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_ThoiGianBatDau.AutoSize = true;
            this.lbl_ThoiGianBatDau.Location = new System.Drawing.Point(7, 64);
            this.lbl_ThoiGianBatDau.Name = "lbl_ThoiGianBatDau";
            this.lbl_ThoiGianBatDau.Size = new System.Drawing.Size(45, 13);
            this.lbl_ThoiGianBatDau.TabIndex = 0;
            this.lbl_ThoiGianBatDau.Text = "Bắt đầu";
            // 
            // lbl_BienSoXe
            // 
            this.lbl_BienSoXe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_BienSoXe.AutoSize = true;
            this.lbl_BienSoXe.Location = new System.Drawing.Point(7, 20);
            this.lbl_BienSoXe.Name = "lbl_BienSoXe";
            this.lbl_BienSoXe.Size = new System.Drawing.Size(56, 13);
            this.lbl_BienSoXe.TabIndex = 0;
            this.lbl_BienSoXe.Text = "Biển số xe";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Thoat.Location = new System.Drawing.Point(612, 504);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_CapNhatPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 535);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ThongTinPhanCong);
            this.Controls.Add(this.grb_ChiTietPhanCong);
            this.Controls.Add(this.grb_NgayPhanCong);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_CapNhatPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat phan cong";
            this.Load += new System.EventHandler(this.frm_CapNhatPhanCong_Load);
            this.grb_NgayPhanCong.ResumeLayout(false);
            this.grb_NgayPhanCong.PerformLayout();
            this.grb_ChiTietPhanCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dtgv_ChiTietPhanCong)).EndInit();
            this.grb_ThongTinPhanCong.ResumeLayout(false);
            this.grb_ThongTinPhanCong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_NgayPhanCong;
        private System.Windows.Forms.Label lbl_NgayPhanCong;
        private System.Windows.Forms.DateTimePicker dtp_NgayPhanCong;
        private System.Windows.Forms.Button btn_XemPhanCong;
        private System.Windows.Forms.GroupBox grb_ChiTietPhanCong;
        private System.Windows.Forms.GroupBox grb_ThongTinPhanCong;
        private System.Windows.Forms.Label lbl_BienSoXe;
        private System.Windows.Forms.ComboBox cbo_BienSoXe;
        private System.Windows.Forms.ComboBox cbo_TaiXe;
        private System.Windows.Forms.Label lbl_TaiXe;
        private System.Windows.Forms.Label lbl_ThoiGianBatDau;
        private System.Windows.Forms.Label lbl_KetThuc;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NhanVienPhanCong;
        System.Windows.Forms.DataGridView dtgv_ChiTietPhanCong;
        System.Windows.Forms.DateTimePicker dtp_ThoiGianKetThuc;
        System.Windows.Forms.DateTimePicker dtp_ThoiGianBatDau;

    }
}