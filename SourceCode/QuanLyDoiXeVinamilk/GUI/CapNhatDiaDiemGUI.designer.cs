namespace GUI
{
    partial class frm_CapNhatDiaDiem
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
            this.grb_TieuChiTimKiem = new System.Windows.Forms.GroupBox();
            this.chc_TimChinhXac = new System.Windows.Forms.CheckBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.lbl_DiaChi = new System.Windows.Forms.Label();
            this.txt_TenDiaDiem = new System.Windows.Forms.TextBox();
            this.lbl_TenDiaDiem = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.grb_ThongTinDiaDiem = new System.Windows.Forms.GroupBox();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_ASign = new System.Windows.Forms.Label();
            this.cbo_LoaiDiaDiem = new System.Windows.Forms.ComboBox();
            this.txt_NguoiLienHe = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_ToaDoY = new System.Windows.Forms.TextBox();
            this.txt_SoDienThoai = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_TenDiaDiem_ThongTin = new System.Windows.Forms.TextBox();
            this.lbl_NguoiLienHe = new System.Windows.Forms.Label();
            this.lbl_ToaDoX = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_ToaDoY = new System.Windows.Forms.Label();
            this.lbl_LoaiDiaDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
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
            this.lbl_Title.Location = new System.Drawing.Point(182, 7);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(320, 25);
            this.lbl_Title.TabIndex = 30;
            this.lbl_Title.Text = "CẬP NHẬT THÔNG ĐỊA ĐIỂM";
            // 
            // lsv_DanhSachDiaDiem
            // 
            this.lsv_DanhSachDiaDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_DanhSachDiaDiem.FullRowSelect = true;
            this.lsv_DanhSachDiaDiem.Location = new System.Drawing.Point(3, 16);
            this.lsv_DanhSachDiaDiem.Name = "lsv_DanhSachDiaDiem";
            this.lsv_DanhSachDiaDiem.Size = new System.Drawing.Size(658, 135);
            this.lsv_DanhSachDiaDiem.TabIndex = 26;
            this.lsv_DanhSachDiaDiem.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachDiaDiem.View = System.Windows.Forms.View.Details;
            // 
            // grb_TieuChiTimKiem
            // 
            this.grb_TieuChiTimKiem.Controls.Add(this.chc_TimChinhXac);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_DiaChi);
            this.grb_TieuChiTimKiem.Controls.Add(this.txt_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.lbl_TenDiaDiem);
            this.grb_TieuChiTimKiem.Controls.Add(this.btn_TimKiem);
            this.grb_TieuChiTimKiem.Location = new System.Drawing.Point(18, 35);
            this.grb_TieuChiTimKiem.Name = "grb_TieuChiTimKiem";
            this.grb_TieuChiTimKiem.Size = new System.Drawing.Size(661, 79);
            this.grb_TieuChiTimKiem.TabIndex = 0;
            this.grb_TieuChiTimKiem.TabStop = false;
            this.grb_TieuChiTimKiem.Text = "Tìm kiếm địa điểm";
            // 
            // chc_TimChinhXac
            // 
            this.chc_TimChinhXac.AutoSize = true;
            this.chc_TimChinhXac.Location = new System.Drawing.Point(19, 49);
            this.chc_TimChinhXac.Name = "chc_TimChinhXac";
            this.chc_TimChinhXac.Size = new System.Drawing.Size(94, 17);
            this.chc_TimChinhXac.TabIndex = 2;
            this.chc_TimChinhXac.Text = "Tì&m chính xác";
            this.chc_TimChinhXac.UseVisualStyleBackColor = true;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(418, 15);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(227, 20);
            this.txt_DiaChi.TabIndex = 1;
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
            // txt_TenDiaDiem
            // 
            this.txt_TenDiaDiem.Location = new System.Drawing.Point(101, 15);
            this.txt_TenDiaDiem.Name = "txt_TenDiaDiem";
            this.txt_TenDiaDiem.Size = new System.Drawing.Size(193, 20);
            this.txt_TenDiaDiem.TabIndex = 0;
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
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.TabStop = false;
            this.btn_TimKiem.Text = "Tìm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
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
            // grb_ThongTinDiaDiem
            // 
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_Luu);
            this.grb_ThongTinDiaDiem.Controls.Add(this.comboBox1);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ASign);
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_NguoiLienHe);
            this.grb_ThongTinDiaDiem.Controls.Add(this.textBox1);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_ToaDoY);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_SoDienThoai);
            this.grb_ThongTinDiaDiem.Controls.Add(this.textBox2);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.txt_TenDiaDiem_ThongTin);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_NguoiLienHe);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ToaDoX);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ToaDoY);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_LoaiDiaDiem);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label1);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_SoDienThoai);
            this.grb_ThongTinDiaDiem.Controls.Add(this.label2);
            this.grb_ThongTinDiaDiem.Location = new System.Drawing.Point(18, 280);
            this.grb_ThongTinDiaDiem.Name = "grb_ThongTinDiaDiem";
            this.grb_ThongTinDiaDiem.Size = new System.Drawing.Size(664, 178);
            this.grb_ThongTinDiaDiem.TabIndex = 1;
            this.grb_ThongTinDiaDiem.TabStop = false;
            this.grb_ThongTinDiaDiem.Text = "Thông tin địa điểm";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Luu.Enabled = false;
            this.btn_Luu.Location = new System.Drawing.Point(294, 150);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 46;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(548, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // lbl_ASign
            // 
            this.lbl_ASign.AutoSize = true;
            this.lbl_ASign.Location = new System.Drawing.Point(524, 129);
            this.lbl_ASign.Name = "lbl_ASign";
            this.lbl_ASign.Size = new System.Drawing.Size(18, 13);
            this.lbl_ASign.TabIndex = 45;
            this.lbl_ASign.Text = "@";
            // 
            // cbo_LoaiDiaDiem
            // 
            this.cbo_LoaiDiaDiem.FormattingEnabled = true;
            this.cbo_LoaiDiaDiem.Items.AddRange(new object[] {
            "Bình thường",
            "Chính thức"});
            this.cbo_LoaiDiaDiem.Location = new System.Drawing.Point(91, 78);
            this.cbo_LoaiDiaDiem.Name = "cbo_LoaiDiaDiem";
            this.cbo_LoaiDiaDiem.Size = new System.Drawing.Size(100, 21);
            this.cbo_LoaiDiaDiem.TabIndex = 3;
            // 
            // txt_NguoiLienHe
            // 
            this.txt_NguoiLienHe.Location = new System.Drawing.Point(548, 79);
            this.txt_NguoiLienHe.Name = "txt_NguoiLienHe";
            this.txt_NguoiLienHe.Size = new System.Drawing.Size(101, 20);
            this.txt_NguoiLienHe.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txt_ToaDoY
            // 
            this.txt_ToaDoY.Location = new System.Drawing.Point(548, 32);
            this.txt_ToaDoY.Name = "txt_ToaDoY";
            this.txt_ToaDoY.Size = new System.Drawing.Size(101, 20);
            this.txt_ToaDoY.TabIndex = 2;
            // 
            // txt_SoDienThoai
            // 
            this.txt_SoDienThoai.Location = new System.Drawing.Point(317, 79);
            this.txt_SoDienThoai.Name = "txt_SoDienThoai";
            this.txt_SoDienThoai.Size = new System.Drawing.Size(101, 20);
            this.txt_SoDienThoai.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 20);
            this.textBox2.TabIndex = 6;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(389, 124);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(132, 20);
            this.txt_Email.TabIndex = 7;
            // 
            // txt_TenDiaDiem_ThongTin
            // 
            this.txt_TenDiaDiem_ThongTin.Location = new System.Drawing.Point(91, 32);
            this.txt_TenDiaDiem_ThongTin.Name = "txt_TenDiaDiem_ThongTin";
            this.txt_TenDiaDiem_ThongTin.Size = new System.Drawing.Size(101, 20);
            this.txt_TenDiaDiem_ThongTin.TabIndex = 0;
            // 
            // lbl_NguoiLienHe
            // 
            this.lbl_NguoiLienHe.AutoSize = true;
            this.lbl_NguoiLienHe.Location = new System.Drawing.Point(452, 86);
            this.lbl_NguoiLienHe.Name = "lbl_NguoiLienHe";
            this.lbl_NguoiLienHe.Size = new System.Drawing.Size(69, 13);
            this.lbl_NguoiLienHe.TabIndex = 36;
            this.lbl_NguoiLienHe.Text = "Người liên hệ";
            // 
            // lbl_ToaDoX
            // 
            this.lbl_ToaDoX.AutoSize = true;
            this.lbl_ToaDoX.Location = new System.Drawing.Point(228, 35);
            this.lbl_ToaDoX.Name = "lbl_ToaDoX";
            this.lbl_ToaDoX.Size = new System.Drawing.Size(50, 13);
            this.lbl_ToaDoX.TabIndex = 33;
            this.lbl_ToaDoX.Text = "Tọa độ x";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(351, 129);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 35;
            this.lbl_Email.Text = "Email";
            // 
            // lbl_ToaDoY
            // 
            this.lbl_ToaDoY.AutoSize = true;
            this.lbl_ToaDoY.Location = new System.Drawing.Point(452, 35);
            this.lbl_ToaDoY.Name = "lbl_ToaDoY";
            this.lbl_ToaDoY.Size = new System.Drawing.Size(50, 13);
            this.lbl_ToaDoY.TabIndex = 34;
            this.lbl_ToaDoY.Text = "Tọa độ y";
            // 
            // lbl_LoaiDiaDiem
            // 
            this.lbl_LoaiDiaDiem.AutoSize = true;
            this.lbl_LoaiDiaDiem.Location = new System.Drawing.Point(6, 86);
            this.lbl_LoaiDiaDiem.Name = "lbl_LoaiDiaDiem";
            this.lbl_LoaiDiaDiem.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoaiDiaDiem.TabIndex = 32;
            this.lbl_LoaiDiaDiem.Text = "Loại địa điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Địa chỉ";
            // 
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(228, 86);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(70, 13);
            this.lbl_SoDienThoai.TabIndex = 30;
            this.lbl_SoDienThoai.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Tên địa điểm";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Thoat.Location = new System.Drawing.Point(607, 464);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 3;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // frm_CapNhatDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 499);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_TieuChiTimKiem);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.grb_ThongTinDiaDiem);
            this.Controls.Add(this.btn_Thoat);
            this.Name = "frm_CapNhatDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cap nhat dia diem";
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
        private System.Windows.Forms.GroupBox grb_ThongTinDiaDiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.CheckBox chc_TimChinhXac;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.Label lbl_DiaChi;
        private System.Windows.Forms.TextBox txt_TenDiaDiem;
        private System.Windows.Forms.Label lbl_TenDiaDiem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_ASign;
        private System.Windows.Forms.ComboBox cbo_LoaiDiaDiem;
        private System.Windows.Forms.TextBox txt_NguoiLienHe;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_ToaDoY;
        private System.Windows.Forms.TextBox txt_SoDienThoai;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_TenDiaDiem_ThongTin;
        private System.Windows.Forms.Label lbl_NguoiLienHe;
        private System.Windows.Forms.Label lbl_ToaDoX;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_ToaDoY;
        private System.Windows.Forms.Label lbl_LoaiDiaDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Luu;
    }
}