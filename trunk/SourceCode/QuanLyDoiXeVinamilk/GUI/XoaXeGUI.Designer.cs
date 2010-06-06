namespace GUI
{
    partial class XoaXeGUI
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
            this.grb_DanhSachXe = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachXe = new System.Windows.Forms.ListView();
            this.BienSo = new System.Windows.Forms.ColumnHeader();
            this.HieuXe = new System.Windows.Forms.ColumnHeader();
            this.grb_ThongTinXe = new System.Windows.Forms.GroupBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.txt_SoMay = new System.Windows.Forms.TextBox();
            this.txt_TrongTai = new System.Windows.Forms.TextBox();
            this.txt_LoaiHang = new System.Windows.Forms.TextBox();
            this.txt_HangXe = new System.Windows.Forms.TextBox();
            this.txt_BienSo = new System.Windows.Forms.TextBox();
            this.txt_HieuXe = new System.Windows.Forms.TextBox();
            this.txt_NamSanXuat = new System.Windows.Forms.TextBox();
            this.txt_DinhMucNhienLieu = new System.Windows.Forms.TextBox();
            this.txt_NgayDangKiem = new System.Windows.Forms.TextBox();
            this.txt_SoKhung = new System.Windows.Forms.TextBox();
            this.txt_DungTichBinh = new System.Windows.Forms.TextBox();
            this.lbl_DinhMucNhienLieu = new System.Windows.Forms.Label();
            this.lbl_DungTichBinh = new System.Windows.Forms.Label();
            this.lbl_SoMay = new System.Windows.Forms.Label();
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.lbl_NamSanXuat = new System.Windows.Forms.Label();
            this.lbl_SoKhung = new System.Windows.Forms.Label();
            this.lbl_NgayDangKiem = new System.Windows.Forms.Label();
            this.lbl_TrongTai = new System.Windows.Forms.Label();
            this.lbl_LoaiHang = new System.Windows.Forms.Label();
            this.lbl_BienSo = new System.Windows.Forms.Label();
            this.lbl_HangXe = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachXe.SuspendLayout();
            this.grb_ThongTinXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(300, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(96, 25);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "XÓA XE";
            // 
            // grb_DanhSachXe
            // 
            this.grb_DanhSachXe.Controls.Add(this.lsv_DanhSachXe);
            this.grb_DanhSachXe.Location = new System.Drawing.Point(12, 36);
            this.grb_DanhSachXe.Name = "grb_DanhSachXe";
            this.grb_DanhSachXe.Size = new System.Drawing.Size(218, 328);
            this.grb_DanhSachXe.TabIndex = 3;
            this.grb_DanhSachXe.TabStop = false;
            this.grb_DanhSachXe.Text = "Danh sách xe";
            // 
            // lsv_DanhSachXe
            // 
            this.lsv_DanhSachXe.CheckBoxes = true;
            this.lsv_DanhSachXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BienSo,
            this.HieuXe});
            this.lsv_DanhSachXe.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachXe.Name = "lsv_DanhSachXe";
            this.lsv_DanhSachXe.Size = new System.Drawing.Size(205, 300);
            this.lsv_DanhSachXe.TabIndex = 0;
            this.lsv_DanhSachXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachXe.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachXe.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachXe_SelectedIndexChanged);
            // 
            // BienSo
            // 
            this.BienSo.Text = "Biển Số";
            this.BienSo.Width = 102;
            // 
            // HieuXe
            // 
            this.HieuXe.Text = "Hiệu Xe";
            this.HieuXe.Width = 144;
            // 
            // grb_ThongTinXe
            // 
            this.grb_ThongTinXe.Controls.Add(this.txt_NhanVien);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NhanVien);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoMay);
            this.grb_ThongTinXe.Controls.Add(this.txt_TrongTai);
            this.grb_ThongTinXe.Controls.Add(this.txt_LoaiHang);
            this.grb_ThongTinXe.Controls.Add(this.txt_HangXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_BienSo);
            this.grb_ThongTinXe.Controls.Add(this.txt_HieuXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_NamSanXuat);
            this.grb_ThongTinXe.Controls.Add(this.txt_DinhMucNhienLieu);
            this.grb_ThongTinXe.Controls.Add(this.txt_NgayDangKiem);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoKhung);
            this.grb_ThongTinXe.Controls.Add(this.txt_DungTichBinh);
            this.grb_ThongTinXe.Controls.Add(this.lbl_DinhMucNhienLieu);
            this.grb_ThongTinXe.Controls.Add(this.lbl_DungTichBinh);
            this.grb_ThongTinXe.Controls.Add(this.lbl_SoMay);
            this.grb_ThongTinXe.Controls.Add(this.lbl_HieuXe);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NamSanXuat);
            this.grb_ThongTinXe.Controls.Add(this.lbl_SoKhung);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NgayDangKiem);
            this.grb_ThongTinXe.Controls.Add(this.lbl_TrongTai);
            this.grb_ThongTinXe.Controls.Add(this.lbl_LoaiHang);
            this.grb_ThongTinXe.Controls.Add(this.lbl_BienSo);
            this.grb_ThongTinXe.Controls.Add(this.lbl_HangXe);
            this.grb_ThongTinXe.Location = new System.Drawing.Point(236, 36);
            this.grb_ThongTinXe.Name = "grb_ThongTinXe";
            this.grb_ThongTinXe.Size = new System.Drawing.Size(461, 328);
            this.grb_ThongTinXe.TabIndex = 0;
            this.grb_ThongTinXe.TabStop = false;
            this.grb_ThongTinXe.Text = "Thông tin xe";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(340, 225);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.ReadOnly = true;
            this.txt_NhanVien.Size = new System.Drawing.Size(101, 20);
            this.txt_NhanVien.TabIndex = 0;
            this.txt_NhanVien.TabStop = false;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(231, 232);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(56, 13);
            this.lbl_NhanVien.TabIndex = 42;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // txt_SoMay
            // 
            this.txt_SoMay.Location = new System.Drawing.Point(340, 180);
            this.txt_SoMay.Name = "txt_SoMay";
            this.txt_SoMay.ReadOnly = true;
            this.txt_SoMay.Size = new System.Drawing.Size(101, 20);
            this.txt_SoMay.TabIndex = 0;
            this.txt_SoMay.TabStop = false;
            // 
            // txt_TrongTai
            // 
            this.txt_TrongTai.Location = new System.Drawing.Point(111, 180);
            this.txt_TrongTai.Name = "txt_TrongTai";
            this.txt_TrongTai.ReadOnly = true;
            this.txt_TrongTai.Size = new System.Drawing.Size(101, 20);
            this.txt_TrongTai.TabIndex = 0;
            this.txt_TrongTai.TabStop = false;
            // 
            // txt_LoaiHang
            // 
            this.txt_LoaiHang.Location = new System.Drawing.Point(111, 129);
            this.txt_LoaiHang.Name = "txt_LoaiHang";
            this.txt_LoaiHang.ReadOnly = true;
            this.txt_LoaiHang.Size = new System.Drawing.Size(101, 20);
            this.txt_LoaiHang.TabIndex = 0;
            this.txt_LoaiHang.TabStop = false;
            // 
            // txt_HangXe
            // 
            this.txt_HangXe.Location = new System.Drawing.Point(111, 84);
            this.txt_HangXe.Name = "txt_HangXe";
            this.txt_HangXe.ReadOnly = true;
            this.txt_HangXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HangXe.TabIndex = 0;
            this.txt_HangXe.TabStop = false;
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Location = new System.Drawing.Point(111, 32);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.Size = new System.Drawing.Size(101, 20);
            this.txt_BienSo.TabIndex = 0;
            // 
            // txt_HieuXe
            // 
            this.txt_HieuXe.Location = new System.Drawing.Point(111, 225);
            this.txt_HieuXe.Name = "txt_HieuXe";
            this.txt_HieuXe.ReadOnly = true;
            this.txt_HieuXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HieuXe.TabIndex = 0;
            this.txt_HieuXe.TabStop = false;
            // 
            // txt_NamSanXuat
            // 
            this.txt_NamSanXuat.Location = new System.Drawing.Point(340, 128);
            this.txt_NamSanXuat.Name = "txt_NamSanXuat";
            this.txt_NamSanXuat.ReadOnly = true;
            this.txt_NamSanXuat.Size = new System.Drawing.Size(101, 20);
            this.txt_NamSanXuat.TabIndex = 0;
            this.txt_NamSanXuat.TabStop = false;
            // 
            // txt_DinhMucNhienLieu
            // 
            this.txt_DinhMucNhienLieu.Location = new System.Drawing.Point(340, 266);
            this.txt_DinhMucNhienLieu.Name = "txt_DinhMucNhienLieu";
            this.txt_DinhMucNhienLieu.ReadOnly = true;
            this.txt_DinhMucNhienLieu.Size = new System.Drawing.Size(101, 20);
            this.txt_DinhMucNhienLieu.TabIndex = 0;
            this.txt_DinhMucNhienLieu.TabStop = false;
            // 
            // txt_NgayDangKiem
            // 
            this.txt_NgayDangKiem.Location = new System.Drawing.Point(340, 32);
            this.txt_NgayDangKiem.Name = "txt_NgayDangKiem";
            this.txt_NgayDangKiem.ReadOnly = true;
            this.txt_NgayDangKiem.Size = new System.Drawing.Size(101, 20);
            this.txt_NgayDangKiem.TabIndex = 0;
            this.txt_NgayDangKiem.TabStop = false;
            // 
            // txt_SoKhung
            // 
            this.txt_SoKhung.Location = new System.Drawing.Point(340, 84);
            this.txt_SoKhung.Name = "txt_SoKhung";
            this.txt_SoKhung.ReadOnly = true;
            this.txt_SoKhung.Size = new System.Drawing.Size(101, 20);
            this.txt_SoKhung.TabIndex = 0;
            this.txt_SoKhung.TabStop = false;
            // 
            // txt_DungTichBinh
            // 
            this.txt_DungTichBinh.Location = new System.Drawing.Point(111, 266);
            this.txt_DungTichBinh.Name = "txt_DungTichBinh";
            this.txt_DungTichBinh.ReadOnly = true;
            this.txt_DungTichBinh.Size = new System.Drawing.Size(101, 20);
            this.txt_DungTichBinh.TabIndex = 0;
            this.txt_DungTichBinh.TabStop = false;
            // 
            // lbl_DinhMucNhienLieu
            // 
            this.lbl_DinhMucNhienLieu.AutoSize = true;
            this.lbl_DinhMucNhienLieu.Location = new System.Drawing.Point(231, 273);
            this.lbl_DinhMucNhienLieu.Name = "lbl_DinhMucNhienLieu";
            this.lbl_DinhMucNhienLieu.Size = new System.Drawing.Size(100, 13);
            this.lbl_DinhMucNhienLieu.TabIndex = 30;
            this.lbl_DinhMucNhienLieu.Text = "Định mức nhiên liệu";
            // 
            // lbl_DungTichBinh
            // 
            this.lbl_DungTichBinh.AutoSize = true;
            this.lbl_DungTichBinh.Location = new System.Drawing.Point(26, 273);
            this.lbl_DungTichBinh.Name = "lbl_DungTichBinh";
            this.lbl_DungTichBinh.Size = new System.Drawing.Size(78, 13);
            this.lbl_DungTichBinh.TabIndex = 29;
            this.lbl_DungTichBinh.Text = "Dung tích bình";
            // 
            // lbl_SoMay
            // 
            this.lbl_SoMay.AutoSize = true;
            this.lbl_SoMay.Location = new System.Drawing.Point(231, 187);
            this.lbl_SoMay.Name = "lbl_SoMay";
            this.lbl_SoMay.Size = new System.Drawing.Size(42, 13);
            this.lbl_SoMay.TabIndex = 26;
            this.lbl_SoMay.Text = "Số máy";
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(27, 232);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(43, 13);
            this.lbl_HieuXe.TabIndex = 25;
            this.lbl_HieuXe.Text = "Hiệu xe";
            // 
            // lbl_NamSanXuat
            // 
            this.lbl_NamSanXuat.AutoSize = true;
            this.lbl_NamSanXuat.Location = new System.Drawing.Point(231, 136);
            this.lbl_NamSanXuat.Name = "lbl_NamSanXuat";
            this.lbl_NamSanXuat.Size = new System.Drawing.Size(72, 13);
            this.lbl_NamSanXuat.TabIndex = 24;
            this.lbl_NamSanXuat.Text = "Năm sản xuất";
            // 
            // lbl_SoKhung
            // 
            this.lbl_SoKhung.AutoSize = true;
            this.lbl_SoKhung.Location = new System.Drawing.Point(231, 91);
            this.lbl_SoKhung.Name = "lbl_SoKhung";
            this.lbl_SoKhung.Size = new System.Drawing.Size(53, 13);
            this.lbl_SoKhung.TabIndex = 23;
            this.lbl_SoKhung.Text = "Số khung";
            // 
            // lbl_NgayDangKiem
            // 
            this.lbl_NgayDangKiem.AutoSize = true;
            this.lbl_NgayDangKiem.Location = new System.Drawing.Point(231, 39);
            this.lbl_NgayDangKiem.Name = "lbl_NgayDangKiem";
            this.lbl_NgayDangKiem.Size = new System.Drawing.Size(85, 13);
            this.lbl_NgayDangKiem.TabIndex = 22;
            this.lbl_NgayDangKiem.Text = "Ngày đăng kiểm";
            // 
            // lbl_TrongTai
            // 
            this.lbl_TrongTai.AutoSize = true;
            this.lbl_TrongTai.Location = new System.Drawing.Point(27, 187);
            this.lbl_TrongTai.Name = "lbl_TrongTai";
            this.lbl_TrongTai.Size = new System.Drawing.Size(49, 13);
            this.lbl_TrongTai.TabIndex = 21;
            this.lbl_TrongTai.Text = "Trọng tải";
            // 
            // lbl_LoaiHang
            // 
            this.lbl_LoaiHang.AutoSize = true;
            this.lbl_LoaiHang.Location = new System.Drawing.Point(27, 138);
            this.lbl_LoaiHang.Name = "lbl_LoaiHang";
            this.lbl_LoaiHang.Size = new System.Drawing.Size(54, 13);
            this.lbl_LoaiHang.TabIndex = 20;
            this.lbl_LoaiHang.Text = "Loại hàng";
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(26, 39);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(42, 13);
            this.lbl_BienSo.TabIndex = 19;
            this.lbl_BienSo.Text = "Biển số";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Location = new System.Drawing.Point(27, 91);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(47, 13);
            this.lbl_HangXe.TabIndex = 19;
            this.lbl_HangXe.Text = "Hãng xe";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(12, 382);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(622, 382);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // XoaXeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 417);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.grb_ThongTinXe);
            this.Controls.Add(this.grb_DanhSachXe);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "XoaXeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XoaXeFrm";
            this.Load += new System.EventHandler(this.XoaXeGUI_Load);
            this.grb_DanhSachXe.ResumeLayout(false);
            this.grb_ThongTinXe.ResumeLayout(false);
            this.grb_ThongTinXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_DanhSachXe;
        private System.Windows.Forms.GroupBox grb_ThongTinXe;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.TextBox txt_SoMay;
        private System.Windows.Forms.TextBox txt_HieuXe;
        private System.Windows.Forms.TextBox txt_NamSanXuat;
        private System.Windows.Forms.TextBox txt_DinhMucNhienLieu;
        private System.Windows.Forms.TextBox txt_SoKhung;
        private System.Windows.Forms.TextBox txt_DungTichBinh;
        private System.Windows.Forms.Label lbl_DinhMucNhienLieu;
        private System.Windows.Forms.Label lbl_DungTichBinh;
        private System.Windows.Forms.Label lbl_SoMay;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.Label lbl_NamSanXuat;
        private System.Windows.Forms.Label lbl_SoKhung;
        private System.Windows.Forms.Label lbl_NgayDangKiem;
        private System.Windows.Forms.Label lbl_TrongTai;
        private System.Windows.Forms.Label lbl_LoaiHang;
        private System.Windows.Forms.Label lbl_HangXe;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.TextBox txt_BienSo;
        private System.Windows.Forms.TextBox txt_HangXe;
        private System.Windows.Forms.TextBox txt_LoaiHang;
        private System.Windows.Forms.TextBox txt_TrongTai;
        private System.Windows.Forms.TextBox txt_NgayDangKiem;
        private System.Windows.Forms.ListView lsv_DanhSachXe;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ColumnHeader BienSo;
        private System.Windows.Forms.ColumnHeader HieuXe;
    }
}