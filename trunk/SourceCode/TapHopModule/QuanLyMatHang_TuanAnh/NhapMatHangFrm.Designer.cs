namespace GUI
{
    partial class NhapMatHangFrm
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
            this.txt_TenNhanVien = new System.Windows.Forms.TextBox();
            this.lbl_SoLuong = new System.Windows.Forms.Label();
            this.lbl_TenMatHang = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_DonViTinh = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbl_MaLoai = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpb_ThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.gpb_ThongTinMatHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(148, 300);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(100, 28);
            this.btn_Luu.TabIndex = 26;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(288, 300);
            this.btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_Thoat.TabIndex = 25;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(220, 82);
            this.txt_SoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(133, 22);
            this.txt_SoLuong.TabIndex = 24;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(220, 28);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Size = new System.Drawing.Size(133, 22);
            this.txt_TenNhanVien.TabIndex = 23;
            // 
            // lbl_SoLuong
            // 
            this.lbl_SoLuong.AutoSize = true;
            this.lbl_SoLuong.Location = new System.Drawing.Point(25, 91);
            this.lbl_SoLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_SoLuong.Name = "lbl_SoLuong";
            this.lbl_SoLuong.Size = new System.Drawing.Size(64, 17);
            this.lbl_SoLuong.TabIndex = 22;
            this.lbl_SoLuong.Text = "Số lượng";
            // 
            // lbl_TenMatHang
            // 
            this.lbl_TenMatHang.AutoSize = true;
            this.lbl_TenMatHang.Location = new System.Drawing.Point(25, 37);
            this.lbl_TenMatHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TenMatHang.Name = "lbl_TenMatHang";
            this.lbl_TenMatHang.Size = new System.Drawing.Size(96, 17);
            this.lbl_TenMatHang.TabIndex = 21;
            this.lbl_TenMatHang.Text = "Tên mặt hàng";
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(73, 11);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(253, 31);
            this.lbl_Title.TabIndex = 20;
            this.lbl_Title.Text = "NHẬP MẶT HÀNG";
            // 
            // lbl_DonViTinh
            // 
            this.lbl_DonViTinh.AutoSize = true;
            this.lbl_DonViTinh.Location = new System.Drawing.Point(25, 144);
            this.lbl_DonViTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DonViTinh.Name = "lbl_DonViTinh";
            this.lbl_DonViTinh.Size = new System.Drawing.Size(75, 17);
            this.lbl_DonViTinh.TabIndex = 27;
            this.lbl_DonViTinh.Text = "Đơn vị tính";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(220, 135);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 22);
            this.textBox1.TabIndex = 28;
            // 
            // lbl_MaLoai
            // 
            this.lbl_MaLoai.AutoSize = true;
            this.lbl_MaLoai.Location = new System.Drawing.Point(25, 201);
            this.lbl_MaLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MaLoai.Name = "lbl_MaLoai";
            this.lbl_MaLoai.Size = new System.Drawing.Size(53, 17);
            this.lbl_MaLoai.TabIndex = 29;
            this.lbl_MaLoai.Text = "Mã loại";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(220, 191);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 24);
            this.comboBox1.TabIndex = 30;
            // 
            // gpb_ThongTinMatHang
            // 
            this.gpb_ThongTinMatHang.Controls.Add(this.comboBox1);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_MaLoai);
            this.gpb_ThongTinMatHang.Controls.Add(this.textBox1);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_DonViTinh);
            this.gpb_ThongTinMatHang.Controls.Add(this.txt_SoLuong);
            this.gpb_ThongTinMatHang.Controls.Add(this.txt_TenNhanVien);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_SoLuong);
            this.gpb_ThongTinMatHang.Controls.Add(this.lbl_TenMatHang);
            this.gpb_ThongTinMatHang.Location = new System.Drawing.Point(17, 58);
            this.gpb_ThongTinMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_ThongTinMatHang.Name = "gpb_ThongTinMatHang";
            this.gpb_ThongTinMatHang.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_ThongTinMatHang.Size = new System.Drawing.Size(371, 235);
            this.gpb_ThongTinMatHang.TabIndex = 31;
            this.gpb_ThongTinMatHang.TabStop = false;
            this.gpb_ThongTinMatHang.Text = "Thông tin mặt hàng";
            // 
            // NhapMatHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 342);
            this.Controls.Add(this.gpb_ThongTinMatHang);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NhapMatHangFrm";
            this.Text = "NhapMatHangFrm";
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
        private System.Windows.Forms.TextBox txt_TenNhanVien;
        private System.Windows.Forms.Label lbl_SoLuong;
        private System.Windows.Forms.Label lbl_TenMatHang;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_DonViTinh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_MaLoai;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox gpb_ThongTinMatHang;
    }
}