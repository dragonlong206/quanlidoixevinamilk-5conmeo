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
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.BienSo = new System.Windows.Forms.ColumnHeader();
            this.grb_ThongTinXe = new System.Windows.Forms.GroupBox();
            this.txt_NgayTiepNhan = new System.Windows.Forms.TextBox();
            this.lbl_NgayTiepNhan = new System.Windows.Forms.Label();
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
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_BienSo_TimKiem = new System.Windows.Forms.TextBox();
            this.txt_HieuXe_TimKiem = new System.Windows.Forms.TextBox();
            this.cbo_HangXe_TimKiem = new System.Windows.Forms.ComboBox();
            this.lbl_HieuXe_TimKiem = new System.Windows.Forms.Label();
            this.lbl_HangXe_TimKiem = new System.Windows.Forms.Label();
            this.grb_DanhSachXe.SuspendLayout();
            this.grb_ThongTinXe.SuspendLayout();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(271, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(96, 25);
            this.lbl_Title.TabIndex = 4;
            this.lbl_Title.Text = "XÓA XE";
            // 
            // grb_DanhSachXe
            // 
            this.grb_DanhSachXe.Controls.Add(this.lsv_DanhSachXe);
            this.grb_DanhSachXe.Location = new System.Drawing.Point(9, 133);
            this.grb_DanhSachXe.Name = "grb_DanhSachXe";
            this.grb_DanhSachXe.Size = new System.Drawing.Size(178, 328);
            this.grb_DanhSachXe.TabIndex = 3;
            this.grb_DanhSachXe.TabStop = false;
            this.grb_DanhSachXe.Text = "Danh sách xe";
            // 
            // lsv_DanhSachXe
            // 
            this.lsv_DanhSachXe.CheckBoxes = true;
            this.lsv_DanhSachXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.BienSo});
            this.lsv_DanhSachXe.FullRowSelect = true;
            this.lsv_DanhSachXe.GridLines = true;
            this.lsv_DanhSachXe.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachXe.Name = "lsv_DanhSachXe";
            this.lsv_DanhSachXe.Size = new System.Drawing.Size(163, 300);
            this.lsv_DanhSachXe.TabIndex = 0;
            this.lsv_DanhSachXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachXe.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachXe.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachXe_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // BienSo
            // 
            this.BienSo.Text = "Biển Số";
            this.BienSo.Width = 144;
            // 
            // grb_ThongTinXe
            // 
            this.grb_ThongTinXe.Controls.Add(this.txt_NgayTiepNhan);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NgayTiepNhan);
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
            this.grb_ThongTinXe.Location = new System.Drawing.Point(193, 133);
            this.grb_ThongTinXe.Name = "grb_ThongTinXe";
            this.grb_ThongTinXe.Size = new System.Drawing.Size(461, 328);
            this.grb_ThongTinXe.TabIndex = 0;
            this.grb_ThongTinXe.TabStop = false;
            this.grb_ThongTinXe.Text = "Thông tin xe";
            // 
            // txt_NgayTiepNhan
            // 
            this.txt_NgayTiepNhan.Location = new System.Drawing.Point(340, 300);
            this.txt_NgayTiepNhan.Name = "txt_NgayTiepNhan";
            this.txt_NgayTiepNhan.ReadOnly = true;
            this.txt_NgayTiepNhan.Size = new System.Drawing.Size(101, 20);
            this.txt_NgayTiepNhan.TabIndex = 44;
            // 
            // lbl_NgayTiepNhan
            // 
            this.lbl_NgayTiepNhan.AutoSize = true;
            this.lbl_NgayTiepNhan.Location = new System.Drawing.Point(229, 303);
            this.lbl_NgayTiepNhan.Name = "lbl_NgayTiepNhan";
            this.lbl_NgayTiepNhan.Size = new System.Drawing.Size(79, 13);
            this.lbl_NgayTiepNhan.TabIndex = 43;
            this.lbl_NgayTiepNhan.Text = "Ngày tiếp nhận";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(111, 115);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.ReadOnly = true;
            this.txt_NhanVien.Size = new System.Drawing.Size(101, 20);
            this.txt_NhanVien.TabIndex = 0;
            this.txt_NhanVien.TabStop = false;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(26, 118);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(56, 13);
            this.lbl_NhanVien.TabIndex = 42;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // txt_SoMay
            // 
            this.txt_SoMay.Location = new System.Drawing.Point(111, 300);
            this.txt_SoMay.Name = "txt_SoMay";
            this.txt_SoMay.ReadOnly = true;
            this.txt_SoMay.Size = new System.Drawing.Size(101, 20);
            this.txt_SoMay.TabIndex = 0;
            this.txt_SoMay.TabStop = false;
            // 
            // txt_TrongTai
            // 
            this.txt_TrongTai.Location = new System.Drawing.Point(340, 115);
            this.txt_TrongTai.Name = "txt_TrongTai";
            this.txt_TrongTai.ReadOnly = true;
            this.txt_TrongTai.Size = new System.Drawing.Size(101, 20);
            this.txt_TrongTai.TabIndex = 0;
            this.txt_TrongTai.TabStop = false;
            // 
            // txt_LoaiHang
            // 
            this.txt_LoaiHang.Location = new System.Drawing.Point(340, 70);
            this.txt_LoaiHang.Name = "txt_LoaiHang";
            this.txt_LoaiHang.ReadOnly = true;
            this.txt_LoaiHang.Size = new System.Drawing.Size(101, 20);
            this.txt_LoaiHang.TabIndex = 0;
            this.txt_LoaiHang.TabStop = false;
            // 
            // txt_HangXe
            // 
            this.txt_HangXe.Location = new System.Drawing.Point(111, 70);
            this.txt_HangXe.Name = "txt_HangXe";
            this.txt_HangXe.ReadOnly = true;
            this.txt_HangXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HangXe.TabIndex = 0;
            this.txt_HangXe.TabStop = false;
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Location = new System.Drawing.Point(111, 29);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.ReadOnly = true;
            this.txt_BienSo.Size = new System.Drawing.Size(101, 20);
            this.txt_BienSo.TabIndex = 0;
            // 
            // txt_HieuXe
            // 
            this.txt_HieuXe.Location = new System.Drawing.Point(111, 162);
            this.txt_HieuXe.Name = "txt_HieuXe";
            this.txt_HieuXe.ReadOnly = true;
            this.txt_HieuXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HieuXe.TabIndex = 0;
            this.txt_HieuXe.TabStop = false;
            // 
            // txt_NamSanXuat
            // 
            this.txt_NamSanXuat.Location = new System.Drawing.Point(111, 208);
            this.txt_NamSanXuat.Name = "txt_NamSanXuat";
            this.txt_NamSanXuat.ReadOnly = true;
            this.txt_NamSanXuat.Size = new System.Drawing.Size(101, 20);
            this.txt_NamSanXuat.TabIndex = 0;
            this.txt_NamSanXuat.TabStop = false;
            // 
            // txt_DinhMucNhienLieu
            // 
            this.txt_DinhMucNhienLieu.Location = new System.Drawing.Point(340, 208);
            this.txt_DinhMucNhienLieu.Name = "txt_DinhMucNhienLieu";
            this.txt_DinhMucNhienLieu.ReadOnly = true;
            this.txt_DinhMucNhienLieu.Size = new System.Drawing.Size(101, 20);
            this.txt_DinhMucNhienLieu.TabIndex = 0;
            this.txt_DinhMucNhienLieu.TabStop = false;
            // 
            // txt_NgayDangKiem
            // 
            this.txt_NgayDangKiem.Location = new System.Drawing.Point(340, 255);
            this.txt_NgayDangKiem.Name = "txt_NgayDangKiem";
            this.txt_NgayDangKiem.ReadOnly = true;
            this.txt_NgayDangKiem.Size = new System.Drawing.Size(101, 20);
            this.txt_NgayDangKiem.TabIndex = 0;
            this.txt_NgayDangKiem.TabStop = false;
            // 
            // txt_SoKhung
            // 
            this.txt_SoKhung.Location = new System.Drawing.Point(111, 251);
            this.txt_SoKhung.Name = "txt_SoKhung";
            this.txt_SoKhung.ReadOnly = true;
            this.txt_SoKhung.Size = new System.Drawing.Size(101, 20);
            this.txt_SoKhung.TabIndex = 0;
            this.txt_SoKhung.TabStop = false;
            // 
            // txt_DungTichBinh
            // 
            this.txt_DungTichBinh.Location = new System.Drawing.Point(340, 162);
            this.txt_DungTichBinh.Name = "txt_DungTichBinh";
            this.txt_DungTichBinh.ReadOnly = true;
            this.txt_DungTichBinh.Size = new System.Drawing.Size(101, 20);
            this.txt_DungTichBinh.TabIndex = 0;
            this.txt_DungTichBinh.TabStop = false;
            // 
            // lbl_DinhMucNhienLieu
            // 
            this.lbl_DinhMucNhienLieu.AutoSize = true;
            this.lbl_DinhMucNhienLieu.Location = new System.Drawing.Point(229, 211);
            this.lbl_DinhMucNhienLieu.Name = "lbl_DinhMucNhienLieu";
            this.lbl_DinhMucNhienLieu.Size = new System.Drawing.Size(100, 13);
            this.lbl_DinhMucNhienLieu.TabIndex = 30;
            this.lbl_DinhMucNhienLieu.Text = "Định mức nhiên liệu";
            // 
            // lbl_DungTichBinh
            // 
            this.lbl_DungTichBinh.AutoSize = true;
            this.lbl_DungTichBinh.Location = new System.Drawing.Point(229, 165);
            this.lbl_DungTichBinh.Name = "lbl_DungTichBinh";
            this.lbl_DungTichBinh.Size = new System.Drawing.Size(78, 13);
            this.lbl_DungTichBinh.TabIndex = 29;
            this.lbl_DungTichBinh.Text = "Dung tích bình";
            // 
            // lbl_SoMay
            // 
            this.lbl_SoMay.AutoSize = true;
            this.lbl_SoMay.Location = new System.Drawing.Point(26, 303);
            this.lbl_SoMay.Name = "lbl_SoMay";
            this.lbl_SoMay.Size = new System.Drawing.Size(42, 13);
            this.lbl_SoMay.TabIndex = 26;
            this.lbl_SoMay.Text = "Số máy";
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(26, 165);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(43, 13);
            this.lbl_HieuXe.TabIndex = 25;
            this.lbl_HieuXe.Text = "Hiệu xe";
            // 
            // lbl_NamSanXuat
            // 
            this.lbl_NamSanXuat.AutoSize = true;
            this.lbl_NamSanXuat.Location = new System.Drawing.Point(26, 211);
            this.lbl_NamSanXuat.Name = "lbl_NamSanXuat";
            this.lbl_NamSanXuat.Size = new System.Drawing.Size(72, 13);
            this.lbl_NamSanXuat.TabIndex = 24;
            this.lbl_NamSanXuat.Text = "Năm sản xuất";
            // 
            // lbl_SoKhung
            // 
            this.lbl_SoKhung.AutoSize = true;
            this.lbl_SoKhung.Location = new System.Drawing.Point(26, 262);
            this.lbl_SoKhung.Name = "lbl_SoKhung";
            this.lbl_SoKhung.Size = new System.Drawing.Size(53, 13);
            this.lbl_SoKhung.TabIndex = 23;
            this.lbl_SoKhung.Text = "Số khung";
            // 
            // lbl_NgayDangKiem
            // 
            this.lbl_NgayDangKiem.AutoSize = true;
            this.lbl_NgayDangKiem.Location = new System.Drawing.Point(229, 258);
            this.lbl_NgayDangKiem.Name = "lbl_NgayDangKiem";
            this.lbl_NgayDangKiem.Size = new System.Drawing.Size(85, 13);
            this.lbl_NgayDangKiem.TabIndex = 22;
            this.lbl_NgayDangKiem.Text = "Ngày đăng kiểm";
            // 
            // lbl_TrongTai
            // 
            this.lbl_TrongTai.AutoSize = true;
            this.lbl_TrongTai.Location = new System.Drawing.Point(229, 118);
            this.lbl_TrongTai.Name = "lbl_TrongTai";
            this.lbl_TrongTai.Size = new System.Drawing.Size(49, 13);
            this.lbl_TrongTai.TabIndex = 21;
            this.lbl_TrongTai.Text = "Trọng tải";
            // 
            // lbl_LoaiHang
            // 
            this.lbl_LoaiHang.AutoSize = true;
            this.lbl_LoaiHang.Location = new System.Drawing.Point(229, 73);
            this.lbl_LoaiHang.Name = "lbl_LoaiHang";
            this.lbl_LoaiHang.Size = new System.Drawing.Size(54, 13);
            this.lbl_LoaiHang.TabIndex = 20;
            this.lbl_LoaiHang.Text = "Loại hàng";
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(26, 32);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(42, 13);
            this.lbl_BienSo.TabIndex = 19;
            this.lbl_BienSo.Text = "Biển số";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Location = new System.Drawing.Point(26, 73);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(47, 13);
            this.lbl_HangXe.TabIndex = 19;
            this.lbl_HangXe.Text = "Hãng xe";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Xoa.Location = new System.Drawing.Point(9, 479);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_Xoa.TabIndex = 1;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Location = new System.Drawing.Point(579, 479);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.label1);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_BienSo_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_HieuXe_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.cbo_HangXe_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_HieuXe_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_HangXe_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(9, 48);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(645, 79);
            this.grb_TieuChiTimKiem.TabIndex = 26;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tiêu chí tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Biển số xe";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(295, 45);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(101, 24);
            this.btn_TimKiem.TabIndex = 23;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_BienSo_TimKiem
            // 
            this.txt_BienSo_TimKiem.Location = new System.Drawing.Point(77, 19);
            this.txt_BienSo_TimKiem.Name = "txt_BienSo_TimKiem";
            this.txt_BienSo_TimKiem.Size = new System.Drawing.Size(101, 20);
            this.txt_BienSo_TimKiem.TabIndex = 0;
            // 
            // txt_HieuXe_TimKiem
            // 
            this.txt_HieuXe_TimKiem.Location = new System.Drawing.Point(295, 19);
            this.txt_HieuXe_TimKiem.Name = "txt_HieuXe_TimKiem";
            this.txt_HieuXe_TimKiem.Size = new System.Drawing.Size(101, 20);
            this.txt_HieuXe_TimKiem.TabIndex = 3;
            // 
            // cbo_HangXe_TimKiem
            // 
            this.cbo_HangXe_TimKiem.FormattingEnabled = true;
            this.cbo_HangXe_TimKiem.Items.AddRange(new object[] {
            "TOYOTA",
            "HONDA",
            "MERCIDES"});
            this.cbo_HangXe_TimKiem.Location = new System.Drawing.Point(524, 19);
            this.cbo_HangXe_TimKiem.Name = "cbo_HangXe_TimKiem";
            this.cbo_HangXe_TimKiem.Size = new System.Drawing.Size(101, 21);
            this.cbo_HangXe_TimKiem.TabIndex = 1;
            // 
            // lbl_HieuXe_TimKiem
            // 
            this.lbl_HieuXe_TimKiem.AutoSize = true;
            this.lbl_HieuXe_TimKiem.Location = new System.Drawing.Point(210, 22);
            this.lbl_HieuXe_TimKiem.Name = "lbl_HieuXe_TimKiem";
            this.lbl_HieuXe_TimKiem.Size = new System.Drawing.Size(43, 13);
            this.lbl_HieuXe_TimKiem.TabIndex = 25;
            this.lbl_HieuXe_TimKiem.Text = "Hiệu xe";
            // 
            // lbl_HangXe_TimKiem
            // 
            this.lbl_HangXe_TimKiem.AutoSize = true;
            this.lbl_HangXe_TimKiem.Location = new System.Drawing.Point(415, 22);
            this.lbl_HangXe_TimKiem.Name = "lbl_HangXe_TimKiem";
            this.lbl_HangXe_TimKiem.Size = new System.Drawing.Size(47, 13);
            this.lbl_HangXe_TimKiem.TabIndex = 19;
            this.lbl_HangXe_TimKiem.Text = "Hãng xe";
            // 
            // XoaXeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 510);
            this.Controls.Add(this.grb_TieuChiTimKiem);
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
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
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
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader BienSo;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.TextBox txt_BienSo_TimKiem;
        private System.Windows.Forms.TextBox txt_HieuXe_TimKiem;
        private System.Windows.Forms.ComboBox cbo_HangXe_TimKiem;
        private System.Windows.Forms.Label lbl_HieuXe_TimKiem;
        private System.Windows.Forms.Label lbl_HangXe_TimKiem;
        private System.Windows.Forms.TextBox txt_NgayTiepNhan;
        private System.Windows.Forms.Label lbl_NgayTiepNhan;
    }
}