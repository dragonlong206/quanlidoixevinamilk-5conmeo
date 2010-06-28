namespace GUI
{
    partial class frm_XoaPhanCong
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
            this.grb_DanhSachNgay = new System.Windows.Forms.GroupBox();
            this.lst_DanhSachNgay = new System.Windows.Forms.ListBox();
            this.grb_ChiTietPhanCong = new System.Windows.Forms.GroupBox();
            this.btn_XoaTatCa = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_BoChon = new System.Windows.Forms.Button();
            this.Chon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BienSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaiXe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGianKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Thoat = new System.Windows.Forms.Button();
            dtgv_ChiTietPhanCong = new System.Windows.Forms.DataGridView();
            this.grb_DanhSachNgay.SuspendLayout();
            this.grb_ChiTietPhanCong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dtgv_ChiTietPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(242, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(201, 25);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "XÓA PHÂN CÔNG";
            // 
            // grb_DanhSachNgay
            // 
            this.grb_DanhSachNgay.Controls.Add(this.lst_DanhSachNgay);
            this.grb_DanhSachNgay.Location = new System.Drawing.Point(3, 40);
            this.grb_DanhSachNgay.Name = "grb_DanhSachNgay";
            this.grb_DanhSachNgay.Size = new System.Drawing.Size(157, 403);
            this.grb_DanhSachNgay.TabIndex = 0;
            this.grb_DanhSachNgay.TabStop = false;
            this.grb_DanhSachNgay.Text = "Các ngày có phân công";
            // 
            // lst_DanhSachNgay
            // 
            this.lst_DanhSachNgay.FormattingEnabled = true;
            this.lst_DanhSachNgay.Location = new System.Drawing.Point(6, 20);
            this.lst_DanhSachNgay.Name = "lst_DanhSachNgay";
            this.lst_DanhSachNgay.Size = new System.Drawing.Size(145, 381);
            this.lst_DanhSachNgay.TabIndex = 0;
            this.lst_DanhSachNgay.SelectedIndexChanged += new System.EventHandler(this.lst_DanhSachNgay_SelectedIndexChanged);
            // 
            // grb_ChiTietPhanCong
            // 
            this.grb_ChiTietPhanCong.Controls.Add(this.btn_XoaTatCa);
            this.grb_ChiTietPhanCong.Controls.Add(this.btn_Xoa);
            this.grb_ChiTietPhanCong.Controls.Add(this.btn_BoChon);
            this.grb_ChiTietPhanCong.Controls.Add(dtgv_ChiTietPhanCong);
            this.grb_ChiTietPhanCong.Location = new System.Drawing.Point(167, 40);
            this.grb_ChiTietPhanCong.Name = "grb_ChiTietPhanCong";
            this.grb_ChiTietPhanCong.Size = new System.Drawing.Size(533, 401);
            this.grb_ChiTietPhanCong.TabIndex = 0;
            this.grb_ChiTietPhanCong.TabStop = false;
            this.grb_ChiTietPhanCong.Text = "Chi tiết phân công";
            // 
            // btn_XoaTatCa
            // 
            this.btn_XoaTatCa.Location = new System.Drawing.Point(424, 374);
            this.btn_XoaTatCa.Name = "btn_XoaTatCa";
            this.btn_XoaTatCa.Size = new System.Drawing.Size(103, 23);
            this.btn_XoaTatCa.TabIndex = 2;
            this.btn_XoaTatCa.Text = "Xóa tất &cả";
            this.btn_XoaTatCa.UseVisualStyleBackColor = true;
            this.btn_XoaTatCa.Click += new System.EventHandler(this.btn_XoaTatCa_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(342, 374);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "&Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_BoChon
            // 
            this.btn_BoChon.Location = new System.Drawing.Point(7, 374);
            this.btn_BoChon.Name = "btn_BoChon";
            this.btn_BoChon.Size = new System.Drawing.Size(123, 23);
            this.btn_BoChon.TabIndex = 0;
            this.btn_BoChon.Text = "&Chọn tất cả";
            this.btn_BoChon.UseVisualStyleBackColor = true;
            this.btn_BoChon.Click += new System.EventHandler(this.btn_BoChon_Click);
            // 
            // dtgv_ChiTietPhanCong
            // 
            dtgv_ChiTietPhanCong.AllowUserToAddRows = false;
            dtgv_ChiTietPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgv_ChiTietPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Chon,
            this.BienSo,
            this.TaiXe,
            this.ThoiGianBatDau,
            this.ThoiGianKetThuc});
            dtgv_ChiTietPhanCong.Location = new System.Drawing.Point(7, 20);
            dtgv_ChiTietPhanCong.Name = "dtgv_ChiTietPhanCong";
            dtgv_ChiTietPhanCong.RowHeadersVisible = false;
            dtgv_ChiTietPhanCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dtgv_ChiTietPhanCong.Size = new System.Drawing.Size(520, 347);
            dtgv_ChiTietPhanCong.TabIndex = 0;
            // 
            // Chon
            // 
            this.Chon.HeaderText = "Chọn";
            this.Chon.Name = "Chon";
            this.Chon.Width = 50;
            // 
            // BienSo
            // 
            this.BienSo.DataPropertyName = "BienSoXe";
            this.BienSo.HeaderText = "Biển số xe";
            this.BienSo.Name = "BienSo";
            this.BienSo.Width = 70;
            // 
            // TaiXe
            // 
            this.TaiXe.DataPropertyName = "TaiXe";
            this.TaiXe.HeaderText = "Tài xế";
            this.TaiXe.Name = "TaiXe";
            this.TaiXe.Width = 150;
            // 
            // ThoiGianBatDau
            // 
            this.ThoiGianBatDau.DataPropertyName = "ThoiGianBatDau";
            this.ThoiGianBatDau.HeaderText = "Thời gian bắt đầu";
            this.ThoiGianBatDau.Name = "ThoiGianBatDau";
            this.ThoiGianBatDau.Width = 120;
            // 
            // ThoiGianKetThuc
            // 
            this.ThoiGianKetThuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThoiGianKetThuc.DataPropertyName = "ThoiGianKetThuc";
            this.ThoiGianKetThuc.HeaderText = "Thời gian kết thúc";
            this.ThoiGianKetThuc.Name = "ThoiGianKetThuc";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(625, 447);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // frm_XoaPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 472);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ChiTietPhanCong);
            this.Controls.Add(this.grb_DanhSachNgay);
            this.Controls.Add(this.lbl_Title);
            this.Name = "frm_XoaPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xoa phan cong";
            this.Load += new System.EventHandler(this.frm_XoaPhanCong_Load);
            this.grb_DanhSachNgay.ResumeLayout(false);
            this.grb_ChiTietPhanCong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dtgv_ChiTietPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_DanhSachNgay;
        private System.Windows.Forms.GroupBox grb_ChiTietPhanCong;
        private System.Windows.Forms.ListBox lst_DanhSachNgay;
        private System.Windows.Forms.Button btn_BoChon;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_XoaTatCa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Chon;
        private System.Windows.Forms.DataGridViewTextBoxColumn BienSo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaiXe;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianKetThuc;
        System.Windows.Forms.DataGridView dtgv_ChiTietPhanCong;

    }
}