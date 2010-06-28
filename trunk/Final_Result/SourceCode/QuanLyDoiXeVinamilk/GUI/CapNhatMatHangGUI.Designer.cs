namespace GUI
{
    partial class CapNhatMatHangGUI
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
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chk_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_TenMatHang_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachMatHang = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenMatHang = new System.Windows.Forms.ColumnHeader();
            this.SoLuong = new System.Windows.Forms.ColumnHeader();
            this.DonViTinh = new System.Windows.Forms.ColumnHeader();
            this.LoaiHang = new System.Windows.Forms.ColumnHeader();
            this.grb_ThongTinDiaDiem = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbo_LoaiHang = new System.Windows.Forms.ComboBox();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_DonViTinh = new System.Windows.Forms.TextBox();
            this.txt_TenMatHang = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_LoaiDiaDiem = new System.Windows.Forms.Label();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
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
            this.lbl_Title.Location = new System.Drawing.Point(80, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(382, 25);
            this.lbl_Title.TabIndex = 16;
            this.lbl_Title.Text = "CẬP NHẬT THÔNG TIN MẶT HÀNG";
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chk_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenMatHang_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenMatHang);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(10, 61);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(521, 68);
            this.grb_TieuChiTimKiem.TabIndex = 0;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm mặt hàng";
            // 
            // chk_TimChinhXac
            // 
            this.chk_TimChinhXac.AutoSize = true;
            this.chk_TimChinhXac.Location = new System.Drawing.Point(421, 32);
            this.chk_TimChinhXac.Name = "chk_TimChinhXac";
            this.chk_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chk_TimChinhXac.TabIndex = 2;
            this.chk_TimChinhXac.Text = "Tì&m chính xác";
            this.chk_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_TenMatHang_TimKiem
            // 
            this.txt_TenMatHang_TimKiem.Location = new System.Drawing.Point(101, 30);
            this.txt_TenMatHang_TimKiem.Name = "txt_TenMatHang_TimKiem";
            this.txt_TenMatHang_TimKiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenMatHang_TimKiem.TabIndex = 0;
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(16, 33);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(73, 13);
            this.lbl_TenMatHang.TabIndex = 31;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(325, 27);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(70, 24);
            this.btn_TimKiem.TabIndex = 1;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachMatHang);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(10, 135);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(521, 154);
            this.grb_KetQuaTongQuan.TabIndex = 34;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách mặt hàng";
            // 
            // lsv_DanhSachMatHang
            // 
            this.lsv_DanhSachMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenMatHang,
            this.SoLuong,
            this.DonViTinh,
            this.LoaiHang});
            this.lsv_DanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachMatHang.FullRowSelect = true;
            this.lsv_DanhSachMatHang.GridLines = true;
            this.lsv_DanhSachMatHang.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachMatHang.Name = "lsv_DanhSachMatHang";
            this.lsv_DanhSachMatHang.Size = new System.Drawing.Size(515, 135);
            this.lsv_DanhSachMatHang.TabIndex = 26;
            this.lsv_DanhSachMatHang.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachMatHang.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachMatHang.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachMatHang_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            // 
            // TenMatHang
            // 
            this.TenMatHang.Text = "Tên Mặt Hàng";
            this.TenMatHang.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số Lượng";
            this.SoLuong.Width = 97;
            // 
            // DonViTinh
            // 
            this.DonViTinh.Text = "Đơn Vị Tính";
            this.DonViTinh.Width = 96;
            // 
            // LoaiHang
            // 
            this.LoaiHang.Text = "Loại Hàng";
            this.LoaiHang.Width = 119;
            // 
            // grb_ThongTinDiaDiem
            // 
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_Luu);
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_LoaiHang);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_SoLuong);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_DonViTinh);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_TenMatHang);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_SoLuong);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_DonViTinh);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label2);
            this.grb_ThongTinDiaDiem.Location = new System.Drawing.Point(10, 295);
            this.grb_ThongTinDiaDiem.Name = "grb_ThongTinDiaDiem";
            this.grb_ThongTinDiaDiem.Size = new System.Drawing.Size(521, 130);
            this.grb_ThongTinDiaDiem.TabIndex = 1;
            this.grb_ThongTinDiaDiem.TabStop = false;
            this.grb_ThongTinDiaDiem.Text = "Thông tin mặt hàng";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(440, 101);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbo_LoaiHang
            // 
            this.cbo_LoaiHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiHang.FormattingEnabled = true;
            this.cbo_LoaiHang.Location = new System.Drawing.Point(379, 68);
            this.cbo_LoaiHang.Name = "cbo_LoaiHang";
            this.cbo_LoaiHang.Size = new System.Drawing.Size(136, 21);
            this.cbo_LoaiHang.TabIndex = 3;
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(379, 29);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(136, 20);
            this.txt_SoLuong.TabIndex = 1;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Location = new System.Drawing.Point(114, 68);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(144, 20);
            this.txt_DonViTinh.TabIndex = 2;
            // 
            // txt_TenMatHang
            // 
            this.txt_TenMatHang.Location = new System.Drawing.Point(114, 29);
            this.txt_TenMatHang.Name = "txt_TenMatHang";
            this.txt_TenMatHang.Size = new System.Drawing.Size(144, 20);
            this.txt_TenMatHang.TabIndex = 0;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(290, 32);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbl_SoLuong.TabIndex = 33;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_LoaiDiaDiem
            // 
            this.lbl_LoaiDiaDiem.AutoSize = true;
            this.lbl_LoaiDiaDiem.Location = new System.Drawing.Point(290, 71);
            this.lbl_LoaiDiaDiem.Name = "lbl_LoaiDiaDiem";
            this.lbl_LoaiDiaDiem.Size = new System.Drawing.Size(54, 13);
            this.lbl_LoaiDiaDiem.TabIndex = 32;
            this.lbl_LoaiDiaDiem.Text = "Loại hàng";
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(16, 71);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(60, 13);
            this.lbl_DonViTinh.TabIndex = 30;
            this.lbl_DonViTinh.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên mặt hàng";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(450, 431);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // CapNhatMatHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 460);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.grb_ThongTinDiaDiem);
            this.Controls.Add(this.lbl_Title);
            this.Name = "CapNhatMatHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat thong tin mat hang";
            this.Load += new System.EventHandler(this.CapNhatMatHangGUI_Load);
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
        private System.Windows.Forms.GroupBox grb_TieuChiTimKiem;
        private System.Windows.Forms.TextBox txt_TenMatHang_TimKiem;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.GroupBox grb_KetQuaTongQuan;
        private System.Windows.Forms.ListView lsv_DanhSachMatHang;
        private System.Windows.Forms.GroupBox grb_ThongTinDiaDiem;
        private System.Windows.Forms.ComboBox cbo_LoaiHang;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_DonViTinh;
        private System.Windows.Forms.TextBox txt_TenMatHang;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_LoaiDiaDiem;
        private System.Windows.Forms.Label lbl_DonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_TimChinhXac;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenMatHang;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader DonViTinh;
        private System.Windows.Forms.ColumnHeader LoaiHang;
    }
}