namespace GUI
{
    partial class frm_CapNhatMatHang
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
            this.txt_TenMatHang_TimKiem = new System.Windows.Forms.TextBox();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachMatHang = new System.Windows.Forms.ListView();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
            this.grb_ThongTinDiaDiem = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbo_LoaiDiaDiem = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_DonViTinh = new System.Windows.Forms.TextBox();
            this.txtTenDiaDiem = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_LoaiDiaDiem = new System.Windows.Forms.Label();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_CapNhatSoLuongHang = new System.Windows.Forms.Button();
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
            this.lbl_Title.Location = new System.Drawing.Point(107, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(487, 31);
            this.lbl_Title.TabIndex = 16;
            this.lbl_Title.Text = "CẬP NHẬT THÔNG TIN MẶT HÀNG";
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenMatHang_TimKiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenMatHang);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(16, 46);
            this.grb_TieuChiTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Padding = new System.Windows.Forms.Padding(4);
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(695, 66);
            this.grb_TieuChiTimKiem.TabIndex = 32;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm mặt hàng";
            // 
            // txt_TenMatHang_TimKiem
            // 
            this.txt_TenMatHang_TimKiem.Location = new System.Drawing.Point(135, 18);
            this.txt_TenMatHang_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenMatHang_TimKiem.Name = "txt_TenMatHang_TimKiem";
            this.txt_TenMatHang_TimKiem.Size = new System.Drawing.Size(256, 22);
            this.txt_TenMatHang_TimKiem.TabIndex = 0;
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(21, 22);
            this.lbl_TenMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(96, 17);
            this.lbl_TenMatHang.TabIndex = 31;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackgroundImage = global::GUI.Properties.Resources.Search;
            this.btn_TimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_TimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_TimKiem.Location = new System.Drawing.Point(433, 15);
            this.btn_TimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(93, 30);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "T&ìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachMatHang);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(16, 119);
            this.grb_KetQuaTongQuan.Margin = new System.Windows.Forms.Padding(4);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Padding = new System.Windows.Forms.Padding(4);
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(695, 190);
            this.grb_KetQuaTongQuan.TabIndex = 34;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách mặt hàng";
            // 
            // lsv_DanhSachMatHang
            // 
            this.lsv_DanhSachMatHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lsv_DanhSachMatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachMatHang.FullRowSelect = true;
            this.lsv_DanhSachMatHang.GridLines = true;
            this.lsv_DanhSachMatHang.Location = new System.Drawing.Point(4, 19);
            this.lsv_DanhSachMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.lsv_DanhSachMatHang.Name = "lsv_DanhSachMatHang";
            this.lsv_DanhSachMatHang.Size = new System.Drawing.Size(687, 167);
            this.lsv_DanhSachMatHang.TabIndex = 26;
            this.lsv_DanhSachMatHang.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachMatHang.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachMatHang.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachMatHang_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chọn";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã Mặt Hàng";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên Mặt Hàng";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Số Lượng";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Đơn Vị Tính";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Loại";
            // 
            // grb_ThongTinDiaDiem
            // 
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_Luu);
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.textBox1);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_DonViTinh);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txtTenDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_SoLuong);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_DonViTinh);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label2);
            this.grb_ThongTinDiaDiem.Location = new System.Drawing.Point(16, 316);
            this.grb_ThongTinDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinDiaDiem.Name = "grb_ThongTinDiaDiem";
            this.grb_ThongTinDiaDiem.Padding = new System.Windows.Forms.Padding(4);
            this.grb_ThongTinDiaDiem.Size = new System.Drawing.Size(695, 180);
            this.grb_ThongTinDiaDiem.TabIndex = 33;
            this.grb_ThongTinDiaDiem.TabStop = false;
            this.grb_ThongTinDiaDiem.Text = "Thông tin địa điểm";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(292, 143);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 28);
            this.btn_Luu.TabIndex = 34;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // cbo_LoaiDiaDiem
            // 
            this.cbo_LoaiDiaDiem.FormattingEnabled = true;
            this.cbo_LoaiDiaDiem.Items.AddRange(new object[] {
            "Bình thường",
            "Chính thức"});
            this.cbo_LoaiDiaDiem.Location = new System.Drawing.Point(505, 94);
            this.cbo_LoaiDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.cbo_LoaiDiaDiem.Name = "cbo_LoaiDiaDiem";
            this.cbo_LoaiDiaDiem.Size = new System.Drawing.Size(132, 24);
            this.cbo_LoaiDiaDiem.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 1;
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Location = new System.Drawing.Point(121, 94);
            this.txt_DonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(133, 22);
            this.txt_DonViTinh.TabIndex = 4;
            // 
            // txtTenDiaDiem
            // 
            this.txtTenDiaDiem.Location = new System.Drawing.Point(121, 39);
            this.txtTenDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenDiaDiem.Name = "txtTenDiaDiem";
            this.txtTenDiaDiem.Size = new System.Drawing.Size(133, 22);
            this.txtTenDiaDiem.TabIndex = 0;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(387, 39);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbl_SoLuong.TabIndex = 33;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_LoaiDiaDiem
            // 
            this.lbl_LoaiDiaDiem.AutoSize = true;
            this.lbl_LoaiDiaDiem.Location = new System.Drawing.Point(387, 97);
            this.lbl_LoaiDiaDiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoaiDiaDiem.Name = "lbl_LoaiDiaDiem";
            this.lbl_LoaiDiaDiem.Size = new System.Drawing.Size(92, 17);
            this.lbl_LoaiDiaDiem.TabIndex = 32;
            this.lbl_LoaiDiaDiem.Text = "Loại địa điểm";
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(8, 97);
            this.lbl_DonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(75, 17);
            this.lbl_DonViTinh.TabIndex = 30;
            this.lbl_DonViTinh.Text = "Đơn vị tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên địa điểm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(611, 503);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 34;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhatSoLuongHang
            // 
            this.btn_CapNhatSoLuongHang.Location = new System.Drawing.Point(16, 503);
            this.btn_CapNhatSoLuongHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_CapNhatSoLuongHang.Name = "btn_CapNhatSoLuongHang";
            this.btn_CapNhatSoLuongHang.Size = new System.Drawing.Size(195, 28);
            this.btn_CapNhatSoLuongHang.TabIndex = 35;
            this.btn_CapNhatSoLuongHang.Text = "Cập nhật &số lượng hàng";
            this.btn_CapNhatSoLuongHang.UseVisualStyleBackColor = true;
            // 
            // frm_CapNhatMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 538);
            this.Controls.Add(this.btn_CapNhatSoLuongHang);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.grb_ThongTinDiaDiem);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_CapNhatMatHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat thong tin mat hang";
            this.Load += new System.EventHandler(this.frm_CapNhatMatHang_Load);
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
        private System.Windows.Forms.ComboBox cbo_LoaiDiaDiem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_DonViTinh;
        private System.Windows.Forms.TextBox txtTenDiaDiem;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_LoaiDiaDiem;
        private System.Windows.Forms.Label lbl_DonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_CapNhatSoLuongHang;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
    }
}