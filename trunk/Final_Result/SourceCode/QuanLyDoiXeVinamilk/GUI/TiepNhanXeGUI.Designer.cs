namespace GUI
{
    partial class TiepNhanXeGUI
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
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grbDanhSachXeDaTiepNhan = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachXe = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.BienSo = new System.Windows.Forms.ColumnHeader();
            this.HangXe = new System.Windows.Forms.ColumnHeader();
            this.HieuXe = new System.Windows.Forms.ColumnHeader();
            this.LoaiHang = new System.Windows.Forms.ColumnHeader();
            this.TrongTai = new System.Windows.Forms.ColumnHeader();
            this.NhanVienTiepNhan = new System.Windows.Forms.ColumnHeader();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_LoaiHang = new System.Windows.Forms.Label();
            this.lbl_TrongTai = new System.Windows.Forms.Label();
            this.lbl_NgayDangKiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_DungTichBinh = new System.Windows.Forms.Label();
            this.lbl_HieuXe = new System.Windows.Forms.Label();
            this.lbl_NamSanXuat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DinhMucNhienLieu = new System.Windows.Forms.Label();
            this.dtp_NgayDangKiem = new System.Windows.Forms.DateTimePicker();
            this.txt_DinhMucNhienLieu = new System.Windows.Forms.TextBox();
            this.txt_DungTichBinh = new System.Windows.Forms.TextBox();
            this.txt_HieuXe = new System.Windows.Forms.TextBox();
            this.lblHangXe = new System.Windows.Forms.Label();
            this.txt_NamSanXuat = new System.Windows.Forms.TextBox();
            this.cbo_HangXe = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiHang = new System.Windows.Forms.ComboBox();
            this.cbo_TrongTai = new System.Windows.Forms.ComboBox();
            this.lbl_SoKhung = new System.Windows.Forms.Label();
            this.txt_SoKhung = new System.Windows.Forms.TextBox();
            this.cbo_NhanVienTiepNhan = new System.Windows.Forms.ComboBox();
            this.dtp_NgayTiepNhan = new System.Windows.Forms.DateTimePicker();
            this.lbl_SoMay = new System.Windows.Forms.Label();
            this.txt_SoMay = new System.Windows.Forms.TextBox();
            this.lbl_BienSo2 = new System.Windows.Forms.Label();
            this.txt_BienSo = new System.Windows.Forms.TextBox();
            this.grb_ThongTinXe = new System.Windows.Forms.GroupBox();
            this.grbDanhSachXeDaTiepNhan.SuspendLayout();
            this.grb_ThongTinXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(229, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(218, 25);
            this.lbl_Title.TabIndex = 6;
            this.lbl_Title.Text = "TIẾP NHẬN XE MỚI";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Location = new System.Drawing.Point(592, 536);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grbDanhSachXeDaTiepNhan
            // 
            this.grbDanhSachXeDaTiepNhan.Controls.Add(this.lsv_DanhSachXe);
            this.grbDanhSachXeDaTiepNhan.Location = new System.Drawing.Point(30, 37);
            this.grbDanhSachXeDaTiepNhan.Name = "grbDanhSachXeDaTiepNhan";
            this.grbDanhSachXeDaTiepNhan.Size = new System.Drawing.Size(664, 190);
            this.grbDanhSachXeDaTiepNhan.TabIndex = 34;
            this.grbDanhSachXeDaTiepNhan.TabStop = false;
            this.grbDanhSachXeDaTiepNhan.Text = "Danh sách xe đã tiếp nhận";
            // 
            // lsv_DanhSachXe
            // 
            this.lsv_DanhSachXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.BienSo,
            this.HangXe,
            this.HieuXe,
            this.LoaiHang,
            this.TrongTai,
            this.NhanVienTiepNhan});
            this.lsv_DanhSachXe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachXe.FullRowSelect = true;
            this.lsv_DanhSachXe.GridLines = true;
            this.lsv_DanhSachXe.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachXe.Name = "lsv_DanhSachXe";
            this.lsv_DanhSachXe.Size = new System.Drawing.Size(658, 171);
            this.lsv_DanhSachXe.TabIndex = 1;
            this.lsv_DanhSachXe.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachXe.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 41;
            // 
            // BienSo
            // 
            this.BienSo.Text = "Biển Số";
            this.BienSo.Width = 77;
            // 
            // HangXe
            // 
            this.HangXe.Text = "Hãng Xe";
            this.HangXe.Width = 104;
            // 
            // HieuXe
            // 
            this.HieuXe.Text = "Hiệu Xe";
            this.HieuXe.Width = 109;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Text = "Loại Hàng";
            this.LoaiHang.Width = 102;
            // 
            // TrongTai
            // 
            this.TrongTai.Text = "Trọng Tải";
            this.TrongTai.Width = 77;
            // 
            // NhanVienTiepNhan
            // 
            this.NhanVienTiepNhan.Text = "Nhân viên tiếp nhận";
            this.NhanVienTiepNhan.Width = 139;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Huy.Location = new System.Drawing.Point(468, 264);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 4;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luu.Location = new System.Drawing.Point(559, 264);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_LoaiHang
            // 
            this.lbl_LoaiHang.AutoSize = true;
            this.lbl_LoaiHang.Location = new System.Drawing.Point(21, 136);
            this.lbl_LoaiHang.Name = "lbl_LoaiHang";
            this.lbl_LoaiHang.Size = new System.Drawing.Size(54, 13);
            this.lbl_LoaiHang.TabIndex = 59;
            this.lbl_LoaiHang.Text = "Loại hàng";
            // 
            // lbl_TrongTai
            // 
            this.lbl_TrongTai.AutoSize = true;
            this.lbl_TrongTai.Location = new System.Drawing.Point(21, 183);
            this.lbl_TrongTai.Name = "lbl_TrongTai";
            this.lbl_TrongTai.Size = new System.Drawing.Size(49, 13);
            this.lbl_TrongTai.TabIndex = 60;
            this.lbl_TrongTai.Text = "Trọng tải";
            // 
            // lbl_NgayDangKiem
            // 
            this.lbl_NgayDangKiem.AutoSize = true;
            this.lbl_NgayDangKiem.Location = new System.Drawing.Point(225, 90);
            this.lbl_NgayDangKiem.Name = "lbl_NgayDangKiem";
            this.lbl_NgayDangKiem.Size = new System.Drawing.Size(85, 13);
            this.lbl_NgayDangKiem.TabIndex = 61;
            this.lbl_NgayDangKiem.Text = "Ngày đăng kiểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Ngày tiếp nhận";
            // 
            // lbl_DungTichBinh
            // 
            this.lbl_DungTichBinh.AutoSize = true;
            this.lbl_DungTichBinh.Location = new System.Drawing.Point(225, 183);
            this.lbl_DungTichBinh.Name = "lbl_DungTichBinh";
            this.lbl_DungTichBinh.Size = new System.Drawing.Size(78, 13);
            this.lbl_DungTichBinh.TabIndex = 63;
            this.lbl_DungTichBinh.Text = "Dung tích bình";
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(455, 90);
            this.lbl_HieuXe.Name = "lbl_HieuXe";
            this.lbl_HieuXe.Size = new System.Drawing.Size(43, 13);
            this.lbl_HieuXe.TabIndex = 64;
            this.lbl_HieuXe.Text = "Hiệu xe";
            // 
            // lbl_NamSanXuat
            // 
            this.lbl_NamSanXuat.AutoSize = true;
            this.lbl_NamSanXuat.Location = new System.Drawing.Point(455, 136);
            this.lbl_NamSanXuat.Name = "lbl_NamSanXuat";
            this.lbl_NamSanXuat.Size = new System.Drawing.Size(72, 13);
            this.lbl_NamSanXuat.TabIndex = 65;
            this.lbl_NamSanXuat.Text = "Năm sản xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "Nhân viên";
            // 
            // lbl_DinhMucNhienLieu
            // 
            this.lbl_DinhMucNhienLieu.AutoSize = true;
            this.lbl_DinhMucNhienLieu.Location = new System.Drawing.Point(225, 228);
            this.lbl_DinhMucNhienLieu.Name = "lbl_DinhMucNhienLieu";
            this.lbl_DinhMucNhienLieu.Size = new System.Drawing.Size(100, 13);
            this.lbl_DinhMucNhienLieu.TabIndex = 67;
            this.lbl_DinhMucNhienLieu.Text = "Định mức nhiên liệu";
            // 
            // dtp_NgayDangKiem
            // 
            this.dtp_NgayDangKiem.CustomFormat = "MM/dd/yyyy";
            this.dtp_NgayDangKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayDangKiem.Location = new System.Drawing.Point(334, 86);
            this.dtp_NgayDangKiem.Name = "dtp_NgayDangKiem";
            this.dtp_NgayDangKiem.Size = new System.Drawing.Size(101, 20);
            this.dtp_NgayDangKiem.TabIndex = 50;
            // 
            // txt_DinhMucNhienLieu
            // 
            this.txt_DinhMucNhienLieu.Location = new System.Drawing.Point(334, 225);
            this.txt_DinhMucNhienLieu.Name = "txt_DinhMucNhienLieu";
            this.txt_DinhMucNhienLieu.Size = new System.Drawing.Size(101, 20);
            this.txt_DinhMucNhienLieu.TabIndex = 57;
            // 
            // txt_DungTichBinh
            // 
            this.txt_DungTichBinh.Location = new System.Drawing.Point(334, 180);
            this.txt_DungTichBinh.Name = "txt_DungTichBinh";
            this.txt_DungTichBinh.Size = new System.Drawing.Size(101, 20);
            this.txt_DungTichBinh.TabIndex = 55;
            // 
            // txt_HieuXe
            // 
            this.txt_HieuXe.Location = new System.Drawing.Point(533, 88);
            this.txt_HieuXe.Name = "txt_HieuXe";
            this.txt_HieuXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HieuXe.TabIndex = 51;
            // 
            // lblHangXe
            // 
            this.lblHangXe.AutoSize = true;
            this.lblHangXe.Location = new System.Drawing.Point(21, 91);
            this.lblHangXe.Name = "lblHangXe";
            this.lblHangXe.Size = new System.Drawing.Size(47, 13);
            this.lblHangXe.TabIndex = 58;
            this.lblHangXe.Text = "Hãng xe";
            // 
            // txt_NamSanXuat
            // 
            this.txt_NamSanXuat.Location = new System.Drawing.Point(533, 133);
            this.txt_NamSanXuat.Name = "txt_NamSanXuat";
            this.txt_NamSanXuat.Size = new System.Drawing.Size(101, 20);
            this.txt_NamSanXuat.TabIndex = 53;
            // 
            // cbo_HangXe
            // 
            this.cbo_HangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_HangXe.FormattingEnabled = true;
            this.cbo_HangXe.Items.AddRange(new object[] {
            "TOYOTA",
            "HONDA",
            "MERCIDES"});
            this.cbo_HangXe.Location = new System.Drawing.Point(105, 87);
            this.cbo_HangXe.Name = "cbo_HangXe";
            this.cbo_HangXe.Size = new System.Drawing.Size(101, 21);
            this.cbo_HangXe.TabIndex = 49;
            // 
            // cbo_LoaiHang
            // 
            this.cbo_LoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiHang.FormattingEnabled = true;
            this.cbo_LoaiHang.Items.AddRange(new object[] {
            "Hàng Thường",
            "Hàng Nóng",
            "Hàng Lạnh"});
            this.cbo_LoaiHang.Location = new System.Drawing.Point(105, 133);
            this.cbo_LoaiHang.Name = "cbo_LoaiHang";
            this.cbo_LoaiHang.Size = new System.Drawing.Size(101, 21);
            this.cbo_LoaiHang.TabIndex = 52;
            // 
            // cbo_TrongTai
            // 
            this.cbo_TrongTai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_TrongTai.FormattingEnabled = true;
            this.cbo_TrongTai.Items.AddRange(new object[] {
            "1 Tấn",
            "2 Tấn",
            "3 Tấn",
            "5 Tấn"});
            this.cbo_TrongTai.Location = new System.Drawing.Point(105, 180);
            this.cbo_TrongTai.Name = "cbo_TrongTai";
            this.cbo_TrongTai.Size = new System.Drawing.Size(101, 21);
            this.cbo_TrongTai.TabIndex = 54;
            // 
            // lbl_SoKhung
            // 
            this.lbl_SoKhung.AutoSize = true;
            this.lbl_SoKhung.Location = new System.Drawing.Point(455, 183);
            this.lbl_SoKhung.Name = "lbl_SoKhung";
            this.lbl_SoKhung.Size = new System.Drawing.Size(53, 13);
            this.lbl_SoKhung.TabIndex = 68;
            this.lbl_SoKhung.Text = "Số khung";
            // 
            // txt_SoKhung
            // 
            this.txt_SoKhung.Location = new System.Drawing.Point(533, 180);
            this.txt_SoKhung.Name = "txt_SoKhung";
            this.txt_SoKhung.Size = new System.Drawing.Size(101, 20);
            this.txt_SoKhung.TabIndex = 56;
            // 
            // cbo_NhanVienTiepNhan
            // 
            this.cbo_NhanVienTiepNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_NhanVienTiepNhan.FormattingEnabled = true;
            this.cbo_NhanVienTiepNhan.Items.AddRange(new object[] {
            "Bùi Kim Hoa",
            "Nguyễn Anh",
            "Nguyễn Khuyến"});
            this.cbo_NhanVienTiepNhan.Location = new System.Drawing.Point(105, 225);
            this.cbo_NhanVienTiepNhan.Name = "cbo_NhanVienTiepNhan";
            this.cbo_NhanVienTiepNhan.Size = new System.Drawing.Size(101, 21);
            this.cbo_NhanVienTiepNhan.TabIndex = 69;
            // 
            // dtp_NgayTiepNhan
            // 
            this.dtp_NgayTiepNhan.CustomFormat = "MM/dd/yyyy";
            this.dtp_NgayTiepNhan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayTiepNhan.Location = new System.Drawing.Point(334, 132);
            this.dtp_NgayTiepNhan.Name = "dtp_NgayTiepNhan";
            this.dtp_NgayTiepNhan.Size = new System.Drawing.Size(101, 20);
            this.dtp_NgayTiepNhan.TabIndex = 70;
            // 
            // lbl_SoMay
            // 
            this.lbl_SoMay.AutoSize = true;
            this.lbl_SoMay.Location = new System.Drawing.Point(455, 228);
            this.lbl_SoMay.Name = "lbl_SoMay";
            this.lbl_SoMay.Size = new System.Drawing.Size(42, 13);
            this.lbl_SoMay.TabIndex = 71;
            this.lbl_SoMay.Text = "Số máy";
            // 
            // txt_SoMay
            // 
            this.txt_SoMay.Location = new System.Drawing.Point(533, 225);
            this.txt_SoMay.Name = "txt_SoMay";
            this.txt_SoMay.Size = new System.Drawing.Size(101, 20);
            this.txt_SoMay.TabIndex = 72;
            // 
            // lbl_BienSo2
            // 
            this.lbl_BienSo2.AutoSize = true;
            this.lbl_BienSo2.Location = new System.Drawing.Point(21, 43);
            this.lbl_BienSo2.Name = "lbl_BienSo2";
            this.lbl_BienSo2.Size = new System.Drawing.Size(44, 13);
            this.lbl_BienSo2.TabIndex = 73;
            this.lbl_BienSo2.Text = "Biển Số";
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Location = new System.Drawing.Point(105, 40);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.Size = new System.Drawing.Size(101, 20);
            this.txt_BienSo.TabIndex = 74;
            // 
            // grb_ThongTinXe
            // 
            this.grb_ThongTinXe.Controls.Add(this.txt_BienSo);
            this.grb_ThongTinXe.Controls.Add(this.lbl_BienSo2);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoMay);
            this.grb_ThongTinXe.Controls.Add(this.lbl_SoMay);
            this.grb_ThongTinXe.Controls.Add(this.dtp_NgayTiepNhan);
            this.grb_ThongTinXe.Controls.Add(this.cbo_NhanVienTiepNhan);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoKhung);
            this.grb_ThongTinXe.Controls.Add(this.lbl_SoKhung);
            this.grb_ThongTinXe.Controls.Add(this.cbo_TrongTai);
            this.grb_ThongTinXe.Controls.Add(this.cbo_LoaiHang);
            this.grb_ThongTinXe.Controls.Add(this.cbo_HangXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_NamSanXuat);
            this.grb_ThongTinXe.Controls.Add(this.lblHangXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_HieuXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_DungTichBinh);
            this.grb_ThongTinXe.Controls.Add(this.txt_DinhMucNhienLieu);
            this.grb_ThongTinXe.Controls.Add(this.dtp_NgayDangKiem);
            this.grb_ThongTinXe.Controls.Add(this.lbl_DinhMucNhienLieu);
            this.grb_ThongTinXe.Controls.Add(this.label1);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NamSanXuat);
            this.grb_ThongTinXe.Controls.Add(this.lbl_HieuXe);
            this.grb_ThongTinXe.Controls.Add(this.lbl_DungTichBinh);
            this.grb_ThongTinXe.Controls.Add(this.label2);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NgayDangKiem);
            this.grb_ThongTinXe.Controls.Add(this.lbl_TrongTai);
            this.grb_ThongTinXe.Controls.Add(this.lbl_LoaiHang);
            this.grb_ThongTinXe.Controls.Add(this.btn_Luu);
            this.grb_ThongTinXe.Controls.Add(this.btn_Huy);
            this.grb_ThongTinXe.Location = new System.Drawing.Point(33, 233);
            this.grb_ThongTinXe.Name = "grb_ThongTinXe";
            this.grb_ThongTinXe.Size = new System.Drawing.Size(661, 297);
            this.grb_ThongTinXe.TabIndex = 1;
            this.grb_ThongTinXe.TabStop = false;
            this.grb_ThongTinXe.Text = "Tiếp nhận xe mới";
            // 
            // TiepNhanXeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 566);
            this.Controls.Add(this.grbDanhSachXeDaTiepNhan);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ThongTinXe);
            this.Controls.Add(this.lbl_Title);
            this.Name = "TiepNhanXeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiepNhanXeMoiFrm";
            this.Load += new System.EventHandler(this.TiepNhanXeGUI_Load);
            this.grbDanhSachXeDaTiepNhan.ResumeLayout(false);
            this.grb_ThongTinXe.ResumeLayout(false);
            this.grb_ThongTinXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grbDanhSachXeDaTiepNhan;
        private System.Windows.Forms.ListView lsv_DanhSachXe;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader BienSo;
        private System.Windows.Forms.ColumnHeader HangXe;
        private System.Windows.Forms.ColumnHeader HieuXe;
        private System.Windows.Forms.ColumnHeader LoaiHang;
        private System.Windows.Forms.ColumnHeader TrongTai;
        private System.Windows.Forms.ColumnHeader NhanVienTiepNhan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_LoaiHang;
        private System.Windows.Forms.Label lbl_TrongTai;
        private System.Windows.Forms.Label lbl_NgayDangKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_DungTichBinh;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.Label lbl_NamSanXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DinhMucNhienLieu;
        private System.Windows.Forms.DateTimePicker dtp_NgayDangKiem;
        private System.Windows.Forms.TextBox txt_DinhMucNhienLieu;
        private System.Windows.Forms.TextBox txt_DungTichBinh;
        private System.Windows.Forms.TextBox txt_HieuXe;
        private System.Windows.Forms.Label lblHangXe;
        private System.Windows.Forms.TextBox txt_NamSanXuat;
        private System.Windows.Forms.ComboBox cbo_HangXe;
        private System.Windows.Forms.ComboBox cbo_LoaiHang;
        private System.Windows.Forms.ComboBox cbo_TrongTai;
        private System.Windows.Forms.Label lbl_SoKhung;
        private System.Windows.Forms.TextBox txt_SoKhung;
        private System.Windows.Forms.ComboBox cbo_NhanVienTiepNhan;
        private System.Windows.Forms.DateTimePicker dtp_NgayTiepNhan;
        private System.Windows.Forms.Label lbl_SoMay;
        private System.Windows.Forms.TextBox txt_SoMay;
        private System.Windows.Forms.Label lbl_BienSo2;
        private System.Windows.Forms.TextBox txt_BienSo;
        private System.Windows.Forms.GroupBox grb_ThongTinXe;
    }
}