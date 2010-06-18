namespace GUI
{
    partial class QuanLyLoaiHangGUI
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
            this.grb_TrongTaiHienCo = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachLoaiHang = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenLoaiHang = new System.Windows.Forms.ColumnHeader();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_TimLoaiHang = new System.Windows.Forms.Button();
            this.btn_XoaLoaiHang = new System.Windows.Forms.Button();
            this.txt_TenLoaiHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SuaLoaiHang = new System.Windows.Forms.Button();
            this.btn_ThemLoaiHang = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_TrongTaiHienCo.SuspendLayout();
            this.grb_ThaoTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(87, 17);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 25);
            this.lbl_Title.TabIndex = 5;
            this.lbl_Title.Text = "QUẢN LÝ LOẠI HÀNG";
            // 
            // grb_TrongTaiHienCo
            // 
            this.grb_TrongTaiHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_TrongTaiHienCo.Controls.Add(this.lsv_DanhSachLoaiHang);
            this.grb_TrongTaiHienCo.Location = new System.Drawing.Point(12, 72);
            this.grb_TrongTaiHienCo.Name = "grb_TrongTaiHienCo";
            this.grb_TrongTaiHienCo.Size = new System.Drawing.Size(194, 228);
            this.grb_TrongTaiHienCo.TabIndex = 22;
            this.grb_TrongTaiHienCo.TabStop = false;
            this.grb_TrongTaiHienCo.Text = "Danh sách loại hàng";
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(7, 205);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 1;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // lsv_DanhSachLoaiHang
            // 
            this.lsv_DanhSachLoaiHang.CheckBoxes = true;
            this.lsv_DanhSachLoaiHang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenLoaiHang});
            this.lsv_DanhSachLoaiHang.FullRowSelect = true;
            this.lsv_DanhSachLoaiHang.GridLines = true;
            this.lsv_DanhSachLoaiHang.LabelEdit = true;
            this.lsv_DanhSachLoaiHang.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachLoaiHang.Name = "lsv_DanhSachLoaiHang";
            this.lsv_DanhSachLoaiHang.Size = new System.Drawing.Size(181, 179);
            this.lsv_DanhSachLoaiHang.TabIndex = 0;
            this.lsv_DanhSachLoaiHang.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachLoaiHang.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachLoaiHang.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachLoaiHang_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 54;
            // 
            // TenLoaiHang
            // 
            this.TenLoaiHang.Text = "Tên Loại Hàng";
            this.TenLoaiHang.Width = 120;
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_TimLoaiHang);
            this.grb_ThaoTac.Controls.Add(this.btn_XoaLoaiHang);
            this.grb_ThaoTac.Controls.Add(this.txt_TenLoaiHang);
            this.grb_ThaoTac.Controls.Add(this.label2);
            this.grb_ThaoTac.Controls.Add(this.btn_SuaLoaiHang);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemLoaiHang);
            this.grb_ThaoTac.Location = new System.Drawing.Point(212, 72);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 23;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_TimLoaiHang
            // 
            this.btn_TimLoaiHang.Location = new System.Drawing.Point(16, 134);
            this.btn_TimLoaiHang.Name = "btn_TimLoaiHang";
            this.btn_TimLoaiHang.Size = new System.Drawing.Size(82, 23);
            this.btn_TimLoaiHang.TabIndex = 20;
            this.btn_TimLoaiHang.Text = "Tìm";
            this.btn_TimLoaiHang.UseVisualStyleBackColor = true;
            this.btn_TimLoaiHang.Click += new System.EventHandler(this.btn_TimLoaiHang_Click);
            // 
            // btn_XoaLoaiHang
            // 
            this.btn_XoaLoaiHang.Location = new System.Drawing.Point(16, 182);
            this.btn_XoaLoaiHang.Name = "btn_XoaLoaiHang";
            this.btn_XoaLoaiHang.Size = new System.Drawing.Size(82, 23);
            this.btn_XoaLoaiHang.TabIndex = 2;
            this.btn_XoaLoaiHang.Text = "Xóa";
            this.btn_XoaLoaiHang.UseVisualStyleBackColor = true;
            this.btn_XoaLoaiHang.Click += new System.EventHandler(this.btn_XoaLoaiHang_Click);
            // 
            // txt_TenLoaiHang
            // 
            this.txt_TenLoaiHang.Location = new System.Drawing.Point(17, 71);
            this.txt_TenLoaiHang.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenLoaiHang.Name = "txt_TenLoaiHang";
            this.txt_TenLoaiHang.Size = new System.Drawing.Size(127, 20);
            this.txt_TenLoaiHang.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên loại hàng";
            // 
            // btn_SuaLoaiHang
            // 
            this.btn_SuaLoaiHang.Location = new System.Drawing.Point(118, 182);
            this.btn_SuaLoaiHang.Name = "btn_SuaLoaiHang";
            this.btn_SuaLoaiHang.Size = new System.Drawing.Size(82, 23);
            this.btn_SuaLoaiHang.TabIndex = 1;
            this.btn_SuaLoaiHang.Text = "Sửa";
            this.btn_SuaLoaiHang.UseVisualStyleBackColor = true;
            this.btn_SuaLoaiHang.Click += new System.EventHandler(this.btn_SuaLoaiHang_Click);
            // 
            // btn_ThemLoaiHang
            // 
            this.btn_ThemLoaiHang.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemLoaiHang.Name = "btn_ThemLoaiHang";
            this.btn_ThemLoaiHang.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemLoaiHang.TabIndex = 0;
            this.btn_ThemLoaiHang.Text = "Thêm";
            this.btn_ThemLoaiHang.UseVisualStyleBackColor = true;
            this.btn_ThemLoaiHang.Click += new System.EventHandler(this.btn_ThemLoaiHang_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(330, 315);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 24;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // QuanLyLoaiHangGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 350);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TrongTaiHienCo);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "QuanLyLoaiHangGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly cac Loai hang";
            this.Load += new System.EventHandler(this.QuanLyLoaiHangGUI_Load);
            this.grb_TrongTaiHienCo.ResumeLayout(false);
            this.grb_TrongTaiHienCo.PerformLayout();
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThaoTac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_TrongTaiHienCo;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachLoaiHang;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenLoaiHang;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_TimLoaiHang;
        private System.Windows.Forms.Button btn_XoaLoaiHang;
        private System.Windows.Forms.TextBox txt_TenLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SuaLoaiHang;
        private System.Windows.Forms.Button btn_ThemLoaiHang;
        private System.Windows.Forms.Button btn_Thoat;

    }
}