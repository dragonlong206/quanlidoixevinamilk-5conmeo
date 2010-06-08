namespace GUI
{
    partial class frm_LoaiDiaDiem
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
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.lsv_DanhSachHienCo = new System.Windows.Forms.ListView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_ThongTin = new System.Windows.Forms.TextBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grb_DanhSachLoaiDiaDiem = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.grb_ThongTin.SuspendLayout();
            this.grb_DanhSachLoaiDiaDiem.SuspendLayout();
            this.grb_ThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(330, 341);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.btn_Luu.TabIndex = 7;
            this.btn_Luu.Text = "&Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(48, 22);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(168, 23);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "&Thêm loại địa điểm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(429, 341);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // lsv_DanhSachHienCo
            // 
            this.lsv_DanhSachHienCo.CheckBoxes = true;
            this.lsv_DanhSachHienCo.LabelEdit = true;
            this.lsv_DanhSachHienCo.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachHienCo.Name = "lsv_DanhSachHienCo";
            this.lsv_DanhSachHienCo.Size = new System.Drawing.Size(216, 266);
            this.lsv_DanhSachHienCo.TabIndex = 0;
            this.lsv_DanhSachHienCo.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachHienCo.View = System.Windows.Forms.View.List;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(116, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(277, 25);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "QUẢN LÝ LOẠI ĐỊA ĐIỂM";
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_ThongTin);
            this.grb_ThongTin.Location = new System.Drawing.Point(244, 41);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(260, 163);
            this.grb_ThongTin.TabIndex = 10;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin";
            // 
            // txt_ThongTin
            // 
            this.txt_ThongTin.Location = new System.Drawing.Point(7, 16);
            this.txt_ThongTin.Multiline = true;
            this.txt_ThongTin.Name = "txt_ThongTin";
            this.txt_ThongTin.ReadOnly = true;
            this.txt_ThongTin.Size = new System.Drawing.Size(247, 141);
            this.txt_ThongTin.TabIndex = 0;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(48, 51);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(168, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "&Cập nhật loại địa điểm";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(48, 80);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(168, 23);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "&Xóa các loại địa điểm đã chọn";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // grb_DanhSachLoaiDiaDiem
            // 
            this.grb_DanhSachLoaiDiaDiem.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachLoaiDiaDiem.Controls.Add(this.lsv_DanhSachHienCo);
            this.grb_DanhSachLoaiDiaDiem.Location = new System.Drawing.Point(8, 41);
            this.grb_DanhSachLoaiDiaDiem.Name = "grb_DanhSachLoaiDiaDiem";
            this.grb_DanhSachLoaiDiaDiem.Size = new System.Drawing.Size(229, 323);
            this.grb_DanhSachLoaiDiaDiem.TabIndex = 9;
            this.grb_DanhSachLoaiDiaDiem.TabStop = false;
            this.grb_DanhSachLoaiDiaDiem.Text = "Danh sách loại địa điểm";
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(7, 300);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 1;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_Xoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btn_Them);
            this.grb_ThaoTac.Location = new System.Drawing.Point(244, 210);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(261, 117);
            this.grb_ThaoTac.TabIndex = 6;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // frm_LoaiDiaDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 375);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.grb_DanhSachLoaiDiaDiem);
            this.Controls.Add(this.grb_ThaoTac);
            this.MaximizeBox = false;
            this.Name = "frm_LoaiDiaDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly loai dia diem";
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.grb_DanhSachLoaiDiaDiem.ResumeLayout(false);
            this.grb_DanhSachLoaiDiaDiem.PerformLayout();
            this.grb_ThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.ListView lsv_DanhSachHienCo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.TextBox txt_ThongTin;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grb_DanhSachLoaiDiaDiem;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
    }
}