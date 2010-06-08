namespace GUI
{
    partial class CapNhatThongTinXeFrm
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
            this.lbl_BienSo = new System.Windows.Forms.Label();
            this.grb_ThongTinXe = new System.Windows.Forms.GroupBox();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.lbl_NhanVien = new System.Windows.Forms.Label();
            this.cbo_TrongTai = new System.Windows.Forms.ComboBox();
            this.cbo_LoaiHang = new System.Windows.Forms.ComboBox();
            this.cbo_HangXe = new System.Windows.Forms.ComboBox();
            this.txt_SoMay = new System.Windows.Forms.TextBox();
            this.txt_HieuXe = new System.Windows.Forms.TextBox();
            this.txt_NamSanXuat = new System.Windows.Forms.TextBox();
            this.txt_DinhMucNhienLieu = new System.Windows.Forms.TextBox();
            this.txt_SoKhung = new System.Windows.Forms.TextBox();
            this.dtp_NgayDangKiem = new System.Windows.Forms.DateTimePicker();
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
            this.lbl_HangXe = new System.Windows.Forms.Label();
            this.txt_BienSo = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_ThongTinXe.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(203, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(293, 25);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "CẬP NHẬT THÔNG TIN XE";
            // 
            // lbl_BienSo
            // 
            this.lbl_BienSo.AutoSize = true;
            this.lbl_BienSo.Location = new System.Drawing.Point(208, 50);
            this.lbl_BienSo.Name = "lbl_BienSo";
            this.lbl_BienSo.Size = new System.Drawing.Size(56, 13);
            this.lbl_BienSo.TabIndex = 12;
            this.lbl_BienSo.Text = "Biển số xe";
            // 
            // grb_ThongTinXe
            // 
            this.grb_ThongTinXe.Controls.Add(this.txt_NhanVien);
            this.grb_ThongTinXe.Controls.Add(this.lbl_NhanVien);
            this.grb_ThongTinXe.Controls.Add(this.cbo_TrongTai);
            this.grb_ThongTinXe.Controls.Add(this.cbo_LoaiHang);
            this.grb_ThongTinXe.Controls.Add(this.cbo_HangXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoMay);
            this.grb_ThongTinXe.Controls.Add(this.txt_HieuXe);
            this.grb_ThongTinXe.Controls.Add(this.txt_NamSanXuat);
            this.grb_ThongTinXe.Controls.Add(this.txt_DinhMucNhienLieu);
            this.grb_ThongTinXe.Controls.Add(this.txt_SoKhung);
            this.grb_ThongTinXe.Controls.Add(this.dtp_NgayDangKiem);
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
            this.grb_ThongTinXe.Controls.Add(this.lbl_HangXe);
            this.grb_ThongTinXe.Location = new System.Drawing.Point(22, 76);
            this.grb_ThongTinXe.Name = "grb_ThongTinXe";
            this.grb_ThongTinXe.Size = new System.Drawing.Size(664, 230);
            this.grb_ThongTinXe.TabIndex = 1;
            this.grb_ThongTinXe.TabStop = false;
            this.grb_ThongTinXe.Text = "Thông tin xe";
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Location = new System.Drawing.Point(539, 128);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(101, 20);
            this.txt_NhanVien.TabIndex = 9;
            // 
            // lbl_NhanVien
            // 
            this.lbl_NhanVien.AutoSize = true;
            this.lbl_NhanVien.Location = new System.Drawing.Point(461, 136);
            this.lbl_NhanVien.Name = "lbl_NhanVien";
            this.lbl_NhanVien.Size = new System.Drawing.Size(56, 13);
            this.lbl_NhanVien.TabIndex = 42;
            this.lbl_NhanVien.Text = "Nhân viên";
            // 
            // cbo_TrongTai
            // 
            this.cbo_TrongTai.FormattingEnabled = true;
            this.cbo_TrongTai.Items.AddRange(new object[] {
            "Bình thường",
            "Chính thức"});
            this.cbo_TrongTai.Location = new System.Drawing.Point(111, 128);
            this.cbo_TrongTai.Name = "cbo_TrongTai";
            this.cbo_TrongTai.Size = new System.Drawing.Size(101, 21);
            this.cbo_TrongTai.TabIndex = 7;
            // 
            // cbo_LoaiHang
            // 
            this.cbo_LoaiHang.FormattingEnabled = true;
            this.cbo_LoaiHang.Items.AddRange(new object[] {
            "Bình thường",
            "Chính thức"});
            this.cbo_LoaiHang.Location = new System.Drawing.Point(111, 79);
            this.cbo_LoaiHang.Name = "cbo_LoaiHang";
            this.cbo_LoaiHang.Size = new System.Drawing.Size(101, 21);
            this.cbo_LoaiHang.TabIndex = 4;
            // 
            // cbo_HangXe
            // 
            this.cbo_HangXe.FormattingEnabled = true;
            this.cbo_HangXe.Items.AddRange(new object[] {
            "Bình thường",
            "Chính thức"});
            this.cbo_HangXe.Location = new System.Drawing.Point(111, 31);
            this.cbo_HangXe.Name = "cbo_HangXe";
            this.cbo_HangXe.Size = new System.Drawing.Size(101, 21);
            this.cbo_HangXe.TabIndex = 1;
            // 
            // txt_SoMay
            // 
            this.txt_SoMay.Location = new System.Drawing.Point(539, 83);
            this.txt_SoMay.Name = "txt_SoMay";
            this.txt_SoMay.Size = new System.Drawing.Size(101, 20);
            this.txt_SoMay.TabIndex = 6;
            // 
            // txt_HieuXe
            // 
            this.txt_HieuXe.Location = new System.Drawing.Point(539, 30);
            this.txt_HieuXe.Name = "txt_HieuXe";
            this.txt_HieuXe.Size = new System.Drawing.Size(101, 20);
            this.txt_HieuXe.TabIndex = 3;
            // 
            // txt_NamSanXuat
            // 
            this.txt_NamSanXuat.Location = new System.Drawing.Point(340, 128);
            this.txt_NamSanXuat.Name = "txt_NamSanXuat";
            this.txt_NamSanXuat.Size = new System.Drawing.Size(101, 20);
            this.txt_NamSanXuat.TabIndex = 8;
            // 
            // txt_DinhMucNhienLieu
            // 
            this.txt_DinhMucNhienLieu.Location = new System.Drawing.Point(340, 179);
            this.txt_DinhMucNhienLieu.Name = "txt_DinhMucNhienLieu";
            this.txt_DinhMucNhienLieu.Size = new System.Drawing.Size(101, 20);
            this.txt_DinhMucNhienLieu.TabIndex = 11;
            // 
            // txt_SoKhung
            // 
            this.txt_SoKhung.Location = new System.Drawing.Point(340, 84);
            this.txt_SoKhung.Name = "txt_SoKhung";
            this.txt_SoKhung.Size = new System.Drawing.Size(101, 20);
            this.txt_SoKhung.TabIndex = 5;
            // 
            // dtp_NgayDangKiem
            // 
            this.dtp_NgayDangKiem.CustomFormat = "dd/MM/yyyy";
            this.dtp_NgayDangKiem.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_NgayDangKiem.Location = new System.Drawing.Point(340, 30);
            this.dtp_NgayDangKiem.Name = "dtp_NgayDangKiem";
            this.dtp_NgayDangKiem.Size = new System.Drawing.Size(101, 20);
            this.dtp_NgayDangKiem.TabIndex = 2;
            // 
            // txt_DungTichBinh
            // 
            this.txt_DungTichBinh.Location = new System.Drawing.Point(111, 179);
            this.txt_DungTichBinh.Name = "txt_DungTichBinh";
            this.txt_DungTichBinh.Size = new System.Drawing.Size(101, 20);
            this.txt_DungTichBinh.TabIndex = 10;
            // 
            // lbl_DinhMucNhienLieu
            // 
            this.lbl_DinhMucNhienLieu.AutoSize = true;
            this.lbl_DinhMucNhienLieu.Location = new System.Drawing.Point(231, 186);
            this.lbl_DinhMucNhienLieu.Name = "lbl_DinhMucNhienLieu";
            this.lbl_DinhMucNhienLieu.Size = new System.Drawing.Size(100, 13);
            this.lbl_DinhMucNhienLieu.TabIndex = 30;
            this.lbl_DinhMucNhienLieu.Text = "Định mức nhiên liệu";
            // 
            // lbl_DungTichBinh
            // 
            this.lbl_DungTichBinh.AutoSize = true;
            this.lbl_DungTichBinh.Location = new System.Drawing.Point(26, 186);
            this.lbl_DungTichBinh.Name = "lbl_DungTichBinh";
            this.lbl_DungTichBinh.Size = new System.Drawing.Size(78, 13);
            this.lbl_DungTichBinh.TabIndex = 29;
            this.lbl_DungTichBinh.Text = "Dung tích bình";
            // 
            // lbl_SoMay
            // 
            this.lbl_SoMay.AutoSize = true;
            this.lbl_SoMay.Location = new System.Drawing.Point(461, 90);
            this.lbl_SoMay.Name = "lbl_SoMay";
            this.lbl_SoMay.Size = new System.Drawing.Size(42, 13);
            this.lbl_SoMay.TabIndex = 26;
            this.lbl_SoMay.Text = "Số máy";
            // 
            // lbl_HieuXe
            // 
            this.lbl_HieuXe.AutoSize = true;
            this.lbl_HieuXe.Location = new System.Drawing.Point(461, 39);
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
            this.lbl_SoKhung.Location = new System.Drawing.Point(231, 86);
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
            this.lbl_TrongTai.Location = new System.Drawing.Point(27, 136);
            this.lbl_TrongTai.Name = "lbl_TrongTai";
            this.lbl_TrongTai.Size = new System.Drawing.Size(49, 13);
            this.lbl_TrongTai.TabIndex = 21;
            this.lbl_TrongTai.Text = "Trọng tải";
            // 
            // lbl_LoaiHang
            // 
            this.lbl_LoaiHang.AutoSize = true;
            this.lbl_LoaiHang.Location = new System.Drawing.Point(27, 87);
            this.lbl_LoaiHang.Name = "lbl_LoaiHang";
            this.lbl_LoaiHang.Size = new System.Drawing.Size(54, 13);
            this.lbl_LoaiHang.TabIndex = 20;
            this.lbl_LoaiHang.Text = "Loại hàng";
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Location = new System.Drawing.Point(27, 39);
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(47, 13);
            this.lbl_HangXe.TabIndex = 19;
            this.lbl_HangXe.Text = "Hãng xe";
            // 
            // txt_BienSo
            // 
            this.txt_BienSo.Location = new System.Drawing.Point(362, 47);
            this.txt_BienSo.Name = "txt_BienSo";
            this.txt_BienSo.Size = new System.Drawing.Size(101, 20);
            this.txt_BienSo.TabIndex = 0;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(388, 336);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(231, 336);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 2;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_TimKiem.Location = new System.Drawing.Point(486, 44);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(24, 24);
            this.btn_TimKiem.TabIndex = 23;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // CapNhatThongTinXeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 383);
            this.Controls.Add(this.btn_TimKiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.grb_ThongTinXe);
            this.Controls.Add(this.lbl_BienSo);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.txt_BienSo);
            this.MaximizeBox = false;
            this.Name = "CapNhatThongTinXeFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CapNhatThongTinXeFrm";
            this.grb_ThongTinXe.ResumeLayout(false);
            this.grb_ThongTinXe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_BienSo;
        private System.Windows.Forms.GroupBox grb_ThongTinXe;
        private System.Windows.Forms.ComboBox cbo_TrongTai;
        private System.Windows.Forms.ComboBox cbo_LoaiHang;
        private System.Windows.Forms.ComboBox cbo_HangXe;
        private System.Windows.Forms.TextBox txt_SoMay;
        private System.Windows.Forms.TextBox txt_HieuXe;
        private System.Windows.Forms.TextBox txt_NamSanXuat;
        private System.Windows.Forms.TextBox txt_DinhMucNhienLieu;
        private System.Windows.Forms.TextBox txt_SoKhung;
        private System.Windows.Forms.DateTimePicker dtp_NgayDangKiem;
        private System.Windows.Forms.TextBox txt_DungTichBinh;
        private System.Windows.Forms.Label lbl_DinhMucNhienLieu;
        private System.Windows.Forms.Label lbl_DungTichBinh;
        private System.Windows.Forms.TextBox txt_BienSo;
        private System.Windows.Forms.Label lbl_SoMay;
        private System.Windows.Forms.Label lbl_HieuXe;
        private System.Windows.Forms.Label lbl_NamSanXuat;
        private System.Windows.Forms.Label lbl_SoKhung;
        private System.Windows.Forms.Label lbl_NgayDangKiem;
        private System.Windows.Forms.Label lbl_TrongTai;
        private System.Windows.Forms.Label lbl_LoaiHang;
        private System.Windows.Forms.Label lbl_HangXe;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.Label lbl_NhanVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}