namespace GUI
{
    partial class CapNhatThongTinNhanVienGUI
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachNhanVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenNhanVien = new System.Windows.Forms.ColumnHeader();
            this.LoaiNhanVien = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.NgayVaoCongTy = new System.Windows.Forms.ColumnHeader();
            this.ThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.dtp_NgayVaoCongTy = new System.Windows.Forms.DateTimePicker();
            this.cbo_LoaiNhanVien = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.btn_CapNhatNhanVien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_TenNhanVien_TimKiem = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien.SuspendLayout();
            this.ThongTinNhanVien.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(89, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(352, 24);
            this.lblTitle.TabIndex = 8;
            this.lblTitle.Text = "CẬP NHẬT THÔNG TIN NHÂN VIÊN";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(429, 440);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 13;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.lsv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(12, 120);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(506, 160);
            this.grb_DanhSachNhanVien.TabIndex = 12;
            this.grb_DanhSachNhanVien.TabStop = false;
            this.grb_DanhSachNhanVien.Text = "Danh sách nhân viên";
            // 
            // lsv_DanhSachNhanVien
            // 
            this.lsv_DanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenNhanVien,
            this.LoaiNhanVien,
            this.DienThoai,
            this.NgayVaoCongTy});
            this.lsv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachNhanVien.FullRowSelect = true;
            this.lsv_DanhSachNhanVien.GridLines = true;
            this.lsv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachNhanVien.Name = "lsv_DanhSachNhanVien";
            this.lsv_DanhSachNhanVien.Size = new System.Drawing.Size(500, 141);
            this.lsv_DanhSachNhanVien.TabIndex = 1;
            this.lsv_DanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachNhanVien.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachNhanVien_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenNhanVien
            // 
            this.TenNhanVien.Text = "Tên Nhân Viên";
            this.TenNhanVien.Width = 130;
            // 
            // LoaiNhanVien
            // 
            this.LoaiNhanVien.Text = "Loại Nhân Viên";
            this.LoaiNhanVien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoaiNhanVien.Width = 102;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện Thoại";
            this.DienThoai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DienThoai.Width = 88;
            // 
            // NgayVaoCongTy
            // 
            this.NgayVaoCongTy.Text = "Ngày Vào Công Ty";
            this.NgayVaoCongTy.Width = 119;
            // 
            // ThongTinNhanVien
            // 
            this.ThongTinNhanVien.Controls.Add(this.dtp_NgayVaoCongTy);
            this.ThongTinNhanVien.Controls.Add(this.cbo_LoaiNhanVien);
            this.ThongTinNhanVien.Controls.Add(this.label4);
            this.ThongTinNhanVien.Controls.Add(this.label3);
            this.ThongTinNhanVien.Controls.Add(this.label2);
            this.ThongTinNhanVien.Controls.Add(this.label1);
            this.ThongTinNhanVien.Controls.Add(this.txt_DienThoai);
            this.ThongTinNhanVien.Controls.Add(this.txt_TenNhanVien);
            this.ThongTinNhanVien.Controls.Add(this.btn_CapNhatNhanVien);
            this.ThongTinNhanVien.Location = new System.Drawing.Point(12, 286);
            this.ThongTinNhanVien.Name = "ThongTinNhanVien";
            this.ThongTinNhanVien.Size = new System.Drawing.Size(506, 148);
            this.ThongTinNhanVien.TabIndex = 14;
            this.ThongTinNhanVien.TabStop = false;
            this.ThongTinNhanVien.Text = "Cập nhật thông tin nhân viên";
            // 
            // dtp_NgayVaoCongTy
            // 
            this.dtp_NgayVaoCongTy.CustomFormat = "MM/dd/yyyy";
            this.dtp_NgayVaoCongTy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoCongTy.Location = new System.Drawing.Point(389, 78);
            this.dtp_NgayVaoCongTy.Name = "dtp_NgayVaoCongTy";
            this.dtp_NgayVaoCongTy.Size = new System.Drawing.Size(103, 20);
            this.dtp_NgayVaoCongTy.TabIndex = 5;
            // 
            // cbo_LoaiNhanVien
            // 
            this.cbo_LoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiNhanVien.FormattingEnabled = true;
            this.cbo_LoaiNhanVien.Location = new System.Drawing.Point(118, 79);
            this.cbo_LoaiNhanVien.Name = "cbo_LoaiNhanVien";
            this.cbo_LoaiNhanVien.Size = new System.Drawing.Size(142, 21);
            this.cbo_LoaiNhanVien.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày vào công ty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Họ tên nhân viên";
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(389, 42);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(103, 20);
            this.txt_DienThoai.TabIndex = 2;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(118, 42);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(142, 20);
            this.txt_TenNhanVien.TabIndex = 2;
            // 
            // btn_CapNhatNhanVien
            // 
            this.btn_CapNhatNhanVien.Location = new System.Drawing.Point(417, 119);
            this.btn_CapNhatNhanVien.Name = "btn_CapNhatNhanVien";
            this.btn_CapNhatNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btn_CapNhatNhanVien.TabIndex = 1;
            this.btn_CapNhatNhanVien.Text = "&Lưu";
            this.btn_CapNhatNhanVien.UseVisualStyleBackColor = true;
            this.btn_CapNhatNhanVien.Click += new System.EventHandler(this.btn_CapNhatNhanVien_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_TimChinhXac);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien_TimKiem);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Tim);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 69);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(389, 36);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 32;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_TenNhanVien_TimKiem
            // 
            this.txt_TenNhanVien_TimKiem.Location = new System.Drawing.Point(118, 34);
            this.txt_TenNhanVien_TimKiem.Name = "txt_TenNhanVien_TimKiem";
            this.txt_TenNhanVien_TimKiem.Size = new System.Drawing.Size(142, 20);
            this.txt_TenNhanVien_TimKiem.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên nhân viên";
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(295, 32);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(75, 23);
            this.btn_Tim.TabIndex = 1;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // CapNhatThongTinNhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.ThongTinNhanVien);
            this.Controls.Add(this.lblTitle);
            this.MaximizeBox = false;
            this.Name = "CapNhatThongTinNhanVienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat thong tin nhan vien";
            this.Load += new System.EventHandler(this.CapNhatThongTinNhanVienGUI_Load);
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            this.ThongTinNhanVien.ResumeLayout(false);
            this.ThongTinNhanVien.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.ListView lsv_DanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.ColumnHeader LoaiNhanVien;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader NgayVaoCongTy;
        private System.Windows.Forms.GroupBox ThongTinNhanVien;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoCongTy;
        private System.Windows.Forms.ComboBox cbo_LoaiNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Button btn_CapNhatNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_TenNhanVien_TimKiem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
    }
}