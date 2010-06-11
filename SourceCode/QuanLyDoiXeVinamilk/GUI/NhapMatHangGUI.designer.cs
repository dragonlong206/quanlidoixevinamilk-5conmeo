namespace GUI
{
    partial class NhapMatHangGUI
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.txt_TenMatHang = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.txt_DonViTinh = new System.Windows.Forms.TextBox();
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.cbo_LoaiHang = new System.Windows.Forms.ComboBox();
            this.gpb_ThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.gpb_ThongTinMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(111, 244);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 26;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(216, 244);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 25;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(165, 67);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(101, 20);
            this.txt_SoLuong.TabIndex = 24;
            // 
            // txt_TenMatHang
            // 
            this.txt_TenMatHang.Location = new System.Drawing.Point(165, 23);
            this.txt_TenMatHang.Name = "txt_TenMatHang";
            this.txt_TenMatHang.Size = new System.Drawing.Size(101, 20);
            this.txt_TenMatHang.TabIndex = 23;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(19, 74);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(49, 13);
            this.lbl_SoLuong.TabIndex = 22;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(19, 30);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(73, 13);
            this.lbl_TenMatHang.TabIndex = 21;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(55, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(200, 25);
            this.lbl_Title.TabIndex = 20;
            this.lbl_Title.Text = "NHẬP MẶT HÀNG";
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(19, 117);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(60, 13);
            this.lbl_DonViTinh.TabIndex = 27;
            this.lbl_DonViTinh.Text = "Đơn vị tính";
            // 
            // txt_DonViTinh
            // 
            this.txt_DonViTinh.Location = new System.Drawing.Point(165, 110);
            this.txt_DonViTinh.Name = "txt_DonViTinh";
            this.txt_DonViTinh.Size = new System.Drawing.Size(101, 20);
            this.txt_DonViTinh.TabIndex = 28;
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Location = new System.Drawing.Point(19, 163);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(54, 13);
            this.lbl_MaLoai.TabIndex = 29;
            this.lbl_MaLoai.Text = "Loại hàng";
            // 
            // cbo_LoaiHang
            // 
            this.cbo_LoaiHang.FormattingEnabled = true;
            this.cbo_LoaiHang.Items.AddRange(new object[] {
            "Hàng Thường",
            "Hàng Nóng",
            "Hàng Lạnh"});
            this.cbo_LoaiHang.Location = new System.Drawing.Point(165, 155);
            this.cbo_LoaiHang.Name = "cbo_LoaiHang";
            this.cbo_LoaiHang.Size = new System.Drawing.Size(100, 21);
            this.cbo_LoaiHang.TabIndex = 30;
            // 
            // gpb_ThongTinMatHang
            // 
            this.gpb_ThongTinMatHang.Controls.Add(this.cbo_LoaiHang);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_MaLoai);
            this.gpb_ThongTinMatHang.Controls.Add(this.txt_DonViTinh);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_DonViTinh);
            this.gpb_ThongTinMatHang.Controls.Add(this.txt_SoLuong);
            this.gpb_ThongTinMatHang.Controls.Add(this.txt_TenMatHang);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_SoLuong);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_TenMatHang);
            this.gpb_ThongTinMatHang.Location = new System.Drawing.Point(13, 47);
            this.gpb_ThongTinMatHang.Name = "gpb_ThongTinMatHang";
            this.gpb_ThongTinMatHang.Size = new System.Drawing.Size(278, 191);
            this.gpb_ThongTinMatHang.TabIndex = 31;
            this.gpb_ThongTinMatHang.TabStop = false;
            this.gpb_ThongTinMatHang.Text = "Thông tin mặt hàng";
            // 
            // NhapMatHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 278);
            this.Controls.Add(this.gpb_ThongTinMatHang);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_Title);
            this.Name = "NhapMatHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhap Mat Hang";
            this.Load += new System.EventHandler(this.NhapMatHangFrm_Load);
            this.gpb_ThongTinMatHang.ResumeLayout(false);
            this.gpb_ThongTinMatHang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txt_SoLuong;
        private System.Windows.Forms.TextBox txt_TenMatHang;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_DonViTinh;
        private System.Windows.Forms.TextBox txt_DonViTinh;
        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.ComboBox cbo_LoaiHang;
        private System.Windows.Forms.GroupBox gpb_ThongTinMatHang;
    }
}