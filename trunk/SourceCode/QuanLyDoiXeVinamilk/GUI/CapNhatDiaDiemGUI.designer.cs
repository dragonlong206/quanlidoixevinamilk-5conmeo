namespace GUI
{
    partial class CapNhatDiaDiemGUI
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
            this.lsv_DanhSachDiaDiem = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.LoaiDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenDiaDiem_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenDiaDiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_LoaiDiaDiem = new System.Windows.Forms.Label();
            this.lbl_ToaDoY = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_NguoiLienHe = new System.Windows.Forms.Label();
            this.txt_TenDiaDiem = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_ToaDoX = new System.Windows.Forms.TextBox();
            this.lbl_ToaDoX = new System.Windows.Forms.Label();
            this.txt_ToaDoY = new System.Windows.Forms.TextBox();
            this.txt_NguoiLienHe = new System.Windows.Forms.TextBox();
            this.cbo_LoaiDiaDiem = new System.Windows.Forms.ComboBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.lbl_ASign = new System.Windows.Forms.Label();
            this.cbo_Email = new System.Windows.Forms.ComboBox();
            this.grb_ThongTinDiaDiem = new System.Windows.Forms.GroupBox();
            this.grb_TieuChiTimKiem.SuspendLayout();
            this.grb_KetQuaTongQuan.SuspendLayout();
            this.grb_ThongTinDiaDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(182, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(320, 25);
            this.lbl_Title.TabIndex = 30;
            this.lbl_Title.Text = "CẬP NHẬT THÔNG ĐỊA ĐIỂM";
            // 
            // lsv_DanhSachDiaDiem
            // 
            this.lsv_DanhSachDiaDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenDiaDiem,
            this.LoaiDiaDiem,
            this.DienThoai,
            this.DiaChi});
            this.lsv_DanhSachDiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachDiaDiem.FullRowSelect = true;
            this.lsv_DanhSachDiaDiem.GridLines = true;
            this.lsv_DanhSachDiaDiem.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachDiaDiem.Name = "lsv_DanhSachDiaDiem";
            this.lsv_DanhSachDiaDiem.Size = new System.Drawing.Size(658, 135);
            this.lsv_DanhSachDiaDiem.TabIndex = 4;
            this.lsv_DanhSachDiaDiem.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachDiaDiem.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachDiaDiem.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachDiaDiem_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 50;
            // 
            // TenDiaDiem
            // 
            this.TenDiaDiem.Text = "Tên Địa Điểm";
            this.TenDiaDiem.Width = 130;
            // 
            // LoaiDiaDiem
            // 
            this.LoaiDiaDiem.Text = "Loại Địa Điểm";
            this.LoaiDiaDiem.Width = 110;
            // 
            // DienThoai
            // 
            this.DienThoai.Text = "Điện Thoại";
            this.DienThoai.Width = 100;
            // 
            // DiaChi
            // 
            this.DiaChi.Text = "Địa Chỉ";
            this.DiaChi.Width = 260;
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chk_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_DiaChi_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenDiaDiem_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(18, 35);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(661, 79);
            this.grb_TieuChiTimKiem.TabIndex = 0;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm địa điểm";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(19, 49);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 2;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi_TimKiem
            // 
            this.txt_DiaChi_TimKiem.Location = new System.Drawing.Point(418, 15);
            this.txt_DiaChi_TimKiem.Name = "txt_DiaChi_TimKiem";
            this.txt_DiaChi_TimKiem.Size = new System.Drawing.Size(227, 20);
            this.txt_DiaChi_TimKiem.TabIndex = 1;
            // 
            // lbl_DiaChi
            // 
            this.lbl_DiaChi.AutoSize = true;
            this.lbl_DiaChi.Location = new System.Drawing.Point(353, 18);
            this.lbl_DiaChi.Name = "lbl_DiaChi";
            this.lbl_DiaChi.Size = new System.Drawing.Size(40, 13);
            this.lbl_DiaChi.TabIndex = 33;
            this.lbl_DiaChi.Text = "Địa chỉ";
            // 
            // txt_TenDiaDiem_TimKiem
            // 
            this.txt_TenDiaDiem_TimKiem.Location = new System.Drawing.Point(101, 15);
            this.txt_TenDiaDiem_TimKiem.Name = "txt_TenDiaDiem_TimKiem";
            this.txt_TenDiaDiem_TimKiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenDiaDiem_TimKiem.TabIndex = 0;
            // 
            // lbl_TenDiaDiem
            // 
            this.lbl_TenDiaDiem.AutoSize = true;
            this.lbl_TenDiaDiem.Location = new System.Drawing.Point(16, 18);
            this.lbl_TenDiaDiem.Name = "lbl_TenDiaDiem";
            this.lbl_TenDiaDiem.Size = new System.Drawing.Size(70, 13);
            this.lbl_TenDiaDiem.TabIndex = 31;
            this.lbl_TenDiaDiem.Text = "Tên địa điểm";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(294, 49);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 24);
            this.btn_TimKiem.TabIndex = 3;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachDiaDiem);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(18, 120);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(664, 154);
            this.grb_KetQuaTongQuan.TabIndex = 31;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách địa điểm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Location = new System.Drawing.Point(593, 478);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 50;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên địa điểm";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(293, 119);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbl_SoDienThoai.TabIndex = 30;
            this.lbl_SoDienThoai.Text = "Điện thoại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Địa chỉ";
            // 
            // lbl_LoaiDiaDiem
            // 
            this.lbl_LoaiDiaDiem.AutoSize = true;
            this.lbl_LoaiDiaDiem.Location = new System.Drawing.Point(17, 84);
            this.lbl_LoaiDiaDiem.Name = "lbl_LoaiDiaDiem";
            this.lbl_LoaiDiaDiem.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoaiDiaDiem.TabIndex = 32;
            this.lbl_LoaiDiaDiem.Text = "Loại địa điểm";
            // 
            // lbl_ToaDoY
            // 
            this.lbl_ToaDoY.AutoSize = true;
            this.lbl_ToaDoY.Location = new System.Drawing.Point(585, 119);
            this.lbl_ToaDoY.Name = "lbl_ToaDoY";
            this.lbl_ToaDoY.Size = new System.Drawing.Size(26, 13);
            this.lbl_ToaDoY.TabIndex = 34;
            this.lbl_ToaDoY.Text = "Y = ";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(293, 84);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 35;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_NguoiLienHe
            // 
            this.lbl_NguoiLienHe.AutoSize = true;
            this.lbl_NguoiLienHe.Location = new System.Drawing.Point(17, 119);
            this.lbl_NguoiLienHe.Name = "lbl_NguoiLienHe";
            this.lbl_NguoiLienHe.Size = new System.Drawing.Size(69, 13);
            this.lbl_NguoiLienHe.TabIndex = 36;
            this.lbl_NguoiLienHe.Text = "Người liên hệ";
            // 
            // txt_TenDiaDiem
            // 
            this.txt_TenDiaDiem.Location = new System.Drawing.Point(102, 44);
            this.txt_TenDiaDiem.Name = "txt_TenDiaDiem";
            this.txt_TenDiaDiem.Size = new System.Drawing.Size(166, 20);
            this.txt_TenDiaDiem.TabIndex = 0;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(355, 81);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(163, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(355, 44);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(294, 20);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(354, 116);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(119, 20);
            this.txt_DienThoai.TabIndex = 6;
            // 
            // txt_ToaDoX
            // 
            this.txt_ToaDoX.Location = new System.Drawing.Point(548, 116);
            this.txt_ToaDoX.Name = "txt_ToaDoX";
            this.txt_ToaDoX.Size = new System.Drawing.Size(31, 20);
            this.txt_ToaDoX.TabIndex = 7;
            // 
            // lbl_ToaDoX
            // 
            this.lbl_ToaDoX.AutoSize = true;
            this.lbl_ToaDoX.Location = new System.Drawing.Point(475, 119);
            this.lbl_ToaDoX.Name = "lbl_ToaDoX";
            this.lbl_ToaDoX.Size = new System.Drawing.Size(67, 13);
            this.lbl_ToaDoX.TabIndex = 33;
            this.lbl_ToaDoX.Text = "Tọa độ:  X =";
            // 
            // txt_ToaDoY
            // 
            this.txt_ToaDoY.Location = new System.Drawing.Point(617, 116);
            this.txt_ToaDoY.Name = "txt_ToaDoY";
            this.txt_ToaDoY.Size = new System.Drawing.Size(32, 20);
            this.txt_ToaDoY.TabIndex = 8;
            // 
            // txt_NguoiLienHe
            // 
            this.txt_NguoiLienHe.Location = new System.Drawing.Point(102, 116);
            this.txt_NguoiLienHe.Name = "txt_NguoiLienHe";
            this.txt_NguoiLienHe.Size = new System.Drawing.Size(166, 20);
            this.txt_NguoiLienHe.TabIndex = 2;
            // 
            // cbo_LoaiDiaDiem
            // 
            this.cbo_LoaiDiaDiem.FormattingEnabled = true;
            this.cbo_LoaiDiaDiem.Items.AddRange(new object[] {
            "Đại Lý",
            "Khách Hàng",
            "Kho",
            "Gara"});
            this.cbo_LoaiDiaDiem.Location = new System.Drawing.Point(102, 81);
            this.cbo_LoaiDiaDiem.Name = "cbo_LoaiDiaDiem";
            this.cbo_LoaiDiaDiem.Size = new System.Drawing.Size(166, 21);
            this.cbo_LoaiDiaDiem.TabIndex = 1;
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(574, 149);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 9;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // lbl_ASign
            // 
            this.lbl_ASign.AutoSize = true;
            this.lbl_ASign.Location = new System.Drawing.Point(524, 84);
            this.lbl_ASign.Name = "lbl_ASign";
            this.lbl_ASign.Size = new System.Drawing.Size(18, 13);
            this.lbl_ASign.TabIndex = 45;
            this.lbl_ASign.Text = "@";
            // 
            // cbo_Email
            // 
            this.cbo_Email.FormattingEnabled = true;
            this.cbo_Email.Items.AddRange(new object[] {
            "gmail.com",
            "gmail.com.vn",
            "yahoo.com",
            "yahoo.com.vn"});
            this.cbo_Email.Location = new System.Drawing.Point(548, 81);
            this.cbo_Email.Name = "cbo_Email";
            this.cbo_Email.Size = new System.Drawing.Size(101, 21);
            this.cbo_Email.TabIndex = 5;
            // 
            // grb_ThongTinDiaDiem
            // 
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ASign);
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_Luu);
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_NguoiLienHe);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_ToaDoY);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ToaDoX);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_ToaDoX);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_DienThoai);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_DiaChi);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_TenDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_NguoiLienHe);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ToaDoY);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label1);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_SoDienThoai);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label2);
            this.grb_ThongTinDiaDiem.Location = new System.Drawing.Point(19, 290);
            this.grb_ThongTinDiaDiem.Name = "grb_ThongTinDiaDiem";
            this.grb_ThongTinDiaDiem.Size = new System.Drawing.Size(664, 178);
            this.grb_ThongTinDiaDiem.TabIndex = 33;
            this.grb_ThongTinDiaDiem.TabStop = false;
            this.grb_ThongTinDiaDiem.Text = "Tiếp nhận địa điểm mới";
            // 
            // CapNhatDiaDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 513);
            this.Controls.Add(this.grb_ThongTinDiaDiem);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.btn_Thoat);
            this.Name = "CapNhatDiaDiemGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat dia diem";
            this.Load += new System.EventHandler(this.CapNhatDiaDiemGUI_Load);
            this.grb_TieuChiTimKiem.ResumeLayout(false);
            this.grb_TieuChiTimKiem.PerformLayout();
            this.grb_KetQuaTongQuan.ResumeLayout(false);
            this.grb_ThongTinDiaDiem.ResumeLayout(false);
            this.grb_ThongTinDiaDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ListView lsv_DanhSachDiaDiem;
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox grb_KetQuaTongQuan;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.TextBox txt_DiaChi_TimKiem;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_TenDiaDiem_TimKiem;
        private System.Windows.Forms.Label lbl_TenDiaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_LoaiDiaDiem;
        private System.Windows.Forms.Label lbl_ToaDoY;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_NguoiLienHe;
        private System.Windows.Forms.TextBox txt_TenDiaDiem;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_ToaDoX;
        private System.Windows.Forms.Label lbl_ToaDoX;
        private System.Windows.Forms.TextBox txt_ToaDoY;
        private System.Windows.Forms.TextBox txt_NguoiLienHe;
        private System.Windows.Forms.ComboBox cbo_LoaiDiaDiem;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label lbl_ASign;
        private System.Windows.Forms.ComboBox cbo_Email;
        private System.Windows.Forms.GroupBox grb_ThongTinDiaDiem;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenDiaDiem;
        private System.Windows.Forms.ColumnHeader LoaiDiaDiem;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}