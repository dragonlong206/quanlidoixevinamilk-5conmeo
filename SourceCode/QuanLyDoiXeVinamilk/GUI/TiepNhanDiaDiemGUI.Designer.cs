namespace GUI
{
    partial class TiepNhanDiaDiemGUI
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_ThemDiaDiem = new System.Windows.Forms.Button();
            this.grb_KetQuaTongQuan = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachDiaDiem = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.LoaiDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.DienThoai = new System.Windows.Forms.ColumnHeader();
            this.DiaChi = new System.Windows.Forms.ColumnHeader();
            this.grb_ThongTinDiaDiem = new System.Windows.Forms.GroupBox();
            this.cbo_Email = new System.Windows.Forms.ComboBox();
            this.lbl_ASign = new System.Windows.Forms.Label();
            this.cbo_LoaiDiaDiem = new System.Windows.Forms.ComboBox();
            this.txt_NguoiLienHe = new System.Windows.Forms.TextBox();
            this.txt_ToaDoY = new System.Windows.Forms.TextBox();
            this.lbl_ToaDoX = new System.Windows.Forms.Label();
            this.txt_ToaDoX = new System.Windows.Forms.TextBox();
            this.txt_DienThoai = new System.Windows.Forms.TextBox();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_TenDiaDiem = new System.Windows.Forms.TextBox();
            this.lbl_NguoiLienHe = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_ToaDoY = new System.Windows.Forms.Label();
            this.lbl_LoaiDiaDiem = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SoDienThoai = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.lbl_Title.Location = new System.Drawing.Point(227, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(239, 25);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "TIẾP NHẬN ĐỊA ĐIỂM";
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(586, 477);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 50;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(493, 149);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 9;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_ThemDiaDiem
            // 
            this.btn_ThemDiaDiem.Location = new System.Drawing.Point(574, 149);
            this.btn_ThemDiaDiem.Name = "btn_ThemDiaDiem";
            this.btn_ThemDiaDiem.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemDiaDiem.TabIndex = 9;
            this.btn_ThemDiaDiem.Text = "Thêm";
            this.btn_ThemDiaDiem.UseVisualStyleBackColor = true;
            this.btn_ThemDiaDiem.Click += new System.EventHandler(this.btn_ThemDiaDiem_Click);
            // 
            // grb_KetQuaTongQuan
            // 
            this.grb_KetQuaTongQuan.Controls.Add(this.lsv_DanhSachDiaDiem);
            this.grb_KetQuaTongQuan.Location = new System.Drawing.Point(12, 55);
            this.grb_KetQuaTongQuan.Name = "grb_KetQuaTongQuan";
            this.grb_KetQuaTongQuan.Size = new System.Drawing.Size(664, 211);
            this.grb_KetQuaTongQuan.TabIndex = 33;
            this.grb_KetQuaTongQuan.TabStop = false;
            this.grb_KetQuaTongQuan.Text = "Danh sách địa điểm đã tiếp nhận";
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
            this.lsv_DanhSachDiaDiem.Size = new System.Drawing.Size(658, 192);
            this.lsv_DanhSachDiaDiem.TabIndex = 0;
            this.lsv_DanhSachDiaDiem.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachDiaDiem.View = System.Windows.Forms.View.Details;
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
            // grb_ThongTinDiaDiem
            // 
            this.grb_ThongTinDiaDiem.Controls.Add(this.cbo_Email);
            this.grb_ThongTinDiaDiem.Controls.Add(this.lbl_ASign);
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_Huy);
            this.grb_ThongTinDiaDiem.Controls.Add(this.btn_ThemDiaDiem);
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
            this.grb_ThongTinDiaDiem.Location = new System.Drawing.Point(12, 284);
            this.grb_ThongTinDiaDiem.Name = "grb_ThongTinDiaDiem";
            this.grb_ThongTinDiaDiem.Size = new System.Drawing.Size(664, 178);
            this.grb_ThongTinDiaDiem.TabIndex = 32;
            this.grb_ThongTinDiaDiem.TabStop = false;
            this.grb_ThongTinDiaDiem.Text = "Tiếp nhận địa điểm mới";
            // 
            // cbo_Email
            // 
            this.cbo_Email.FormattingEnabled = true;
            this.cbo_Email.Location = new System.Drawing.Point(548, 81);
            this.cbo_Email.Name = "cbo_Email";
            this.cbo_Email.Size = new System.Drawing.Size(101, 21);
            this.cbo_Email.TabIndex = 5;
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
            // cbo_LoaiDiaDiem
            // 
            this.cbo_LoaiDiaDiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LoaiDiaDiem.FormattingEnabled = true;
            this.cbo_LoaiDiaDiem.Location = new System.Drawing.Point(102, 81);
            this.cbo_LoaiDiaDiem.Name = "cbo_LoaiDiaDiem";
            this.cbo_LoaiDiaDiem.Size = new System.Drawing.Size(166, 21);
            this.cbo_LoaiDiaDiem.TabIndex = 1;
            // 
            // txt_NguoiLienHe
            // 
            this.txt_NguoiLienHe.Location = new System.Drawing.Point(102, 116);
            this.txt_NguoiLienHe.Name = "txt_NguoiLienHe";
            this.txt_NguoiLienHe.Size = new System.Drawing.Size(166, 20);
            this.txt_NguoiLienHe.TabIndex = 2;
            // 
            // txt_ToaDoY
            // 
            this.txt_ToaDoY.Location = new System.Drawing.Point(617, 116);
            this.txt_ToaDoY.Name = "txt_ToaDoY";
            this.txt_ToaDoY.Size = new System.Drawing.Size(32, 20);
            this.txt_ToaDoY.TabIndex = 8;
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
            // txt_ToaDoX
            // 
            this.txt_ToaDoX.Location = new System.Drawing.Point(548, 116);
            this.txt_ToaDoX.Name = "txt_ToaDoX";
            this.txt_ToaDoX.Size = new System.Drawing.Size(31, 20);
            this.txt_ToaDoX.TabIndex = 7;
            // 
            // txt_DienThoai
            // 
            this.txt_DienThoai.Location = new System.Drawing.Point(354, 116);
            this.txt_DienThoai.Name = "txt_DienThoai";
            this.txt_DienThoai.Size = new System.Drawing.Size(119, 20);
            this.txt_DienThoai.TabIndex = 6;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(355, 44);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(294, 20);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(355, 81);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(163, 20);
            this.txt_Email.TabIndex = 4;
            // 
            // txt_TenDiaDiem
            // 
            this.txt_TenDiaDiem.Location = new System.Drawing.Point(102, 44);
            this.txt_TenDiaDiem.Name = "txt_TenDiaDiem";
            this.txt_TenDiaDiem.Size = new System.Drawing.Size(166, 20);
            this.txt_TenDiaDiem.TabIndex = 0;
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
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(293, 84);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(32, 13);
            this.lbl_Email.TabIndex = 35;
            this.lbl_Email.Text = "Email";
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
            // lbl_LoaiDiaDiem
            // 
            this.lbl_LoaiDiaDiem.AutoSize = true;
            this.lbl_LoaiDiaDiem.Location = new System.Drawing.Point(17, 84);
            this.lbl_LoaiDiaDiem.Name = "lbl_LoaiDiaDiem";
            this.lbl_LoaiDiaDiem.Size = new System.Drawing.Size(71, 13);
            this.lbl_LoaiDiaDiem.TabIndex = 32;
            this.lbl_LoaiDiaDiem.Text = "Loại địa điểm";
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
            // lbl_SoDienThoai
            // 
            this.lbl_SoDienThoai.AutoSize = true;
            this.lbl_SoDienThoai.Location = new System.Drawing.Point(293, 119);
            this.lbl_SoDienThoai.Name = "lbl_SoDienThoai";
            this.lbl_SoDienThoai.Size = new System.Drawing.Size(55, 13);
            this.lbl_SoDienThoai.TabIndex = 30;
            this.lbl_SoDienThoai.Text = "Điện thoại";
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
            // TiepNhanDiaDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 512);
            this.Controls.Add(this.grb_KetQuaTongQuan);
            this.Controls.Add(this.grb_ThongTinDiaDiem);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_Title);
            this.Name = "TiepNhanDiaDiemGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TiepNhanDiaDiemFrm";
            this.Load += new System.EventHandler(this.TiepNhanDiaDiemGUI_Load);
            this.grb_KetQuaTongQuan.ResumeLayout(false);
            this.grb_ThongTinDiaDiem.ResumeLayout(false);
            this.grb_ThongTinDiaDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_ThemDiaDiem;
        private System.Windows.Forms.GroupBox grb_KetQuaTongQuan;
        private System.Windows.Forms.ListView lsv_DanhSachDiaDiem;
        private System.Windows.Forms.GroupBox grb_ThongTinDiaDiem;
        private System.Windows.Forms.ComboBox cbo_Email;
        private System.Windows.Forms.Label lbl_ASign;
        private System.Windows.Forms.ComboBox cbo_LoaiDiaDiem;
        private System.Windows.Forms.TextBox txt_NguoiLienHe;
        private System.Windows.Forms.TextBox txt_ToaDoX;
        private System.Windows.Forms.TextBox txt_ToaDoY;
        private System.Windows.Forms.TextBox txt_DienThoai;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_TenDiaDiem;
        private System.Windows.Forms.Label lbl_NguoiLienHe;
        private System.Windows.Forms.Label lbl_ToaDoX;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_ToaDoY;
        private System.Windows.Forms.Label lbl_LoaiDiaDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SoDienThoai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenDiaDiem;
        private System.Windows.Forms.ColumnHeader LoaiDiaDiem;
        private System.Windows.Forms.ColumnHeader DienThoai;
        private System.Windows.Forms.ColumnHeader DiaChi;
    }
}