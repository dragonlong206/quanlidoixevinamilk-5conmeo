namespace GUI
{
    partial class NhapNhanVienGUI
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
            this.btn_NhapNhanVien = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.grb_DanhSachNhanVien.SuspendLayout();
            this.ThongTinNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(169, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(186, 24);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "NHẬP NHÂN VIÊN";
            // 
            // btn_NhapNhanVien
            // 
            this.btn_NhapNhanVien.Location = new System.Drawing.Point(417, 119);
            this.btn_NhapNhanVien.Name = "btn_NhapNhanVien";
            this.btn_NhapNhanVien.Size = new System.Drawing.Size(75, 23);
            this.btn_NhapNhanVien.TabIndex = 5;
            this.btn_NhapNhanVien.Text = "&Lưu";
            this.btn_NhapNhanVien.UseVisualStyleBackColor = true;
            this.btn_NhapNhanVien.Click += new System.EventHandler(this.btn_NhapNhanVien_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(429, 437);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // grb_DanhSachNhanVien
            // 
            this.grb_DanhSachNhanVien.Controls.Add(this.lsv_DanhSachNhanVien);
            this.grb_DanhSachNhanVien.Location = new System.Drawing.Point(12, 53);
            this.grb_DanhSachNhanVien.Name = "grb_DanhSachNhanVien";
            this.grb_DanhSachNhanVien.Size = new System.Drawing.Size(506, 224);
            this.grb_DanhSachNhanVien.TabIndex = 0;
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
            this.lsv_DanhSachNhanVien.Size = new System.Drawing.Size(500, 205);
            this.lsv_DanhSachNhanVien.TabIndex = 1;
            this.lsv_DanhSachNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachNhanVien.View = System.Windows.Forms.View.Details;
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
            this.ThongTinNhanVien.Controls.Add(this.btn_Huy);
            this.ThongTinNhanVien.Controls.Add(this.btn_NhapNhanVien);
            this.ThongTinNhanVien.Location = new System.Drawing.Point(12, 283);
            this.ThongTinNhanVien.Name = "ThongTinNhanVien";
            this.ThongTinNhanVien.Size = new System.Drawing.Size(506, 148);
            this.ThongTinNhanVien.TabIndex = 2;
            this.ThongTinNhanVien.TabStop = false;
            this.ThongTinNhanVien.Text = "Thêm nhân viên mới";
            // 
            // dtp_NgayVaoCongTy
            // 
            this.dtp_NgayVaoCongTy.CustomFormat = "MM/dd/yyyy";
            this.dtp_NgayVaoCongTy.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayVaoCongTy.Location = new System.Drawing.Point(389, 78);
            this.dtp_NgayVaoCongTy.Name = "dtp_NgayVaoCongTy";
            this.dtp_NgayVaoCongTy.Size = new System.Drawing.Size(103, 20);
            this.dtp_NgayVaoCongTy.TabIndex = 3;
            // 
            // cbo_LoaiNhanVien
            // 
            this.cbo_LoaiNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiNhanVien.FormattingEnabled = true;
            this.cbo_LoaiNhanVien.Location = new System.Drawing.Point(118, 79);
            this.cbo_LoaiNhanVien.Name = "cbo_LoaiNhanVien";
            this.cbo_LoaiNhanVien.Size = new System.Drawing.Size(142, 21);
            this.cbo_LoaiNhanVien.TabIndex = 2;
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
            this.txt_DienThoai.TabIndex = 1;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(118, 42);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(142, 20);
            this.txt_TenNhanVien.TabIndex = 0;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(327, 119);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "&Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // NhapNhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 468);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grb_DanhSachNhanVien);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ThongTinNhanVien);
            this.MaximizeBox = false;
            this.Name = "NhapNhanVienGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap nhan vien";
            this.Load += new System.EventHandler(this.NhapNhanVienGUI_Load);
            this.grb_DanhSachNhanVien.ResumeLayout(false);
            this.ThongTinNhanVien.ResumeLayout(false);
            this.ThongTinNhanVien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btn_NhapNhanVien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grb_DanhSachNhanVien;
        private System.Windows.Forms.GroupBox ThongTinNhanVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.ComboBox cbo_LoaiNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.DateTimePicker dtp_NgayVaoCongTy;
        private System.Windows.Forms.ListView lsv_DanhSachNhanVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenNhanVien;
        private System.Windows.Forms.ColumnHeader LoaiNhanVien;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader NgayVaoCongTy;
    }
}