namespace GUI
{
    partial class LoaiHangGUI
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
            this.lsv_DanhSachHienCo = new System.Windows.Forms.ListView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_ThongTin = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachLoaiHang = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grb_ThongTin.SuspendLayout();
            this.grb_DanhSachLoaiHang.SuspendLayout();
            this.grb_ThaoTac.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(132, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 25);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "QUẢN LÝ LOẠI HÀNG";
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_ThongTin);
            this.grb_ThongTin.Location = new System.Drawing.Point(238, 47);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(260, 163);
            this.grb_ThongTin.TabIndex = 4;
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
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(423, 347);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "&Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // grb_DanhSachLoaiHang
            // 
            this.grb_DanhSachLoaiHang.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachLoaiHang.Controls.Add(this.lsv_DanhSachHienCo);
            this.grb_DanhSachLoaiHang.Location = new System.Drawing.Point(2, 47);
            this.grb_DanhSachLoaiHang.Name = "grb_DanhSachLoaiHang";
            this.grb_DanhSachLoaiHang.Size = new System.Drawing.Size(229, 323);
            this.grb_DanhSachLoaiHang.TabIndex = 3;
            this.grb_DanhSachLoaiHang.TabStop = false;
            this.grb_DanhSachLoaiHang.Text = "Danh sách loại hàng";
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
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(44, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa các loại hàng đã chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(111, 30);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(143, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "&Sửa tên loại hàng";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btnXoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btnThem);
            this.grb_ThaoTac.Location = new System.Drawing.Point(238, 216);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(261, 117);
            this.grb_ThaoTac.TabIndex = 0;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(6, 30);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 23);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm loại hàng";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(324, 347);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // LoaiHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 375);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachLoaiHang);
            this.Controls.Add(this.grb_ThaoTac);
            this.MaximizeBox = false;
            this.Name = "LoaiHangGUI";
            this.Text = "Quan ly cac Loai hang";
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.grb_DanhSachLoaiHang.ResumeLayout(false);
            this.grb_DanhSachLoaiHang.PerformLayout();
            this.grb_ThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsv_DanhSachHienCo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.TextBox txt_ThongTin;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachLoaiHang;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuu;

    }
}