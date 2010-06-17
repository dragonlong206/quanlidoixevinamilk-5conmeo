namespace GUI
{
    partial class QuanLyThamSoGUI
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
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_TimLoaiThamSo = new System.Windows.Forms.Button();
            this.btn_XoaLoaiThamSo = new System.Windows.Forms.Button();
            this.txt_TenLoaiThamSo = new System.Windows.Forms.TextBox();
            this.lbl_LoaiThamSo = new System.Windows.Forms.Label();
            this.btn_SuaLoaiThamSo = new System.Windows.Forms.Button();
            this.btn_ThemLoaiThamSo = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_ThamSoHienCo = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachThamSo = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenThamSo = new System.Windows.Forms.ColumnHeader();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.GiaTri = new System.Windows.Forms.ColumnHeader();
            this.grb_ThaoTac.SuspendLayout();
            this.grb_ThamSoHienCo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_TimLoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_XoaLoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.txt_TenLoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.lbl_LoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_SuaLoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemLoaiThamSo);
            this.grb_ThaoTac.Location = new System.Drawing.Point(366, 74);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 30;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_TimLoaiThamSo
            // 
            this.btn_TimLoaiThamSo.Location = new System.Drawing.Point(16, 134);
            this.btn_TimLoaiThamSo.Name = "btn_TimLoaiThamSo";
            this.btn_TimLoaiThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_TimLoaiThamSo.TabIndex = 20;
            this.btn_TimLoaiThamSo.Text = "Tìm";
            this.btn_TimLoaiThamSo.UseVisualStyleBackColor = true;
            // 
            // btn_XoaLoaiThamSo
            // 
            this.btn_XoaLoaiThamSo.Location = new System.Drawing.Point(16, 182);
            this.btn_XoaLoaiThamSo.Name = "btn_XoaLoaiThamSo";
            this.btn_XoaLoaiThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_XoaLoaiThamSo.TabIndex = 2;
            this.btn_XoaLoaiThamSo.Text = "Xóa";
            this.btn_XoaLoaiThamSo.UseVisualStyleBackColor = true;
            // 
            // txt_TenLoaiThamSo
            // 
            this.txt_TenLoaiThamSo.Location = new System.Drawing.Point(17, 71);
            this.txt_TenLoaiThamSo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenLoaiThamSo.Name = "txt_TenLoaiThamSo";
            this.txt_TenLoaiThamSo.Size = new System.Drawing.Size(127, 20);
            this.txt_TenLoaiThamSo.TabIndex = 18;
            // 
            // lbl_LoaiThamSo
            // 
            this.lbl_LoaiThamSo.AutoSize = true;
            this.lbl_LoaiThamSo.Location = new System.Drawing.Point(14, 46);
            this.lbl_LoaiThamSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoaiThamSo.Name = "lbl_LoaiThamSo";
            this.lbl_LoaiThamSo.Size = new System.Drawing.Size(67, 13);
            this.lbl_LoaiThamSo.TabIndex = 19;
            this.lbl_LoaiThamSo.Text = "Loại tham số";
            // 
            // btn_SuaLoaiThamSo
            // 
            this.btn_SuaLoaiThamSo.Location = new System.Drawing.Point(118, 182);
            this.btn_SuaLoaiThamSo.Name = "btn_SuaLoaiThamSo";
            this.btn_SuaLoaiThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_SuaLoaiThamSo.TabIndex = 1;
            this.btn_SuaLoaiThamSo.Text = "Sửa";
            this.btn_SuaLoaiThamSo.UseVisualStyleBackColor = true;
            // 
            // btn_ThemLoaiThamSo
            // 
            this.btn_ThemLoaiThamSo.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemLoaiThamSo.Name = "btn_ThemLoaiThamSo";
            this.btn_ThemLoaiThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemLoaiThamSo.TabIndex = 0;
            this.btn_ThemLoaiThamSo.Text = "Thêm";
            this.btn_ThemLoaiThamSo.UseVisualStyleBackColor = true;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(491, 308);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            // 
            // grb_ThamSoHienCo
            // 
            this.grb_ThamSoHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_ThamSoHienCo.Controls.Add(this.lsv_DanhSachThamSo);
            this.grb_ThamSoHienCo.Location = new System.Drawing.Point(23, 74);
            this.grb_ThamSoHienCo.Name = "grb_ThamSoHienCo";
            this.grb_ThamSoHienCo.Size = new System.Drawing.Size(325, 228);
            this.grb_ThamSoHienCo.TabIndex = 29;
            this.grb_ThamSoHienCo.TabStop = false;
            this.grb_ThamSoHienCo.Text = "Danh sách tham số";
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
            // 
            // lsv_DanhSachThamSo
            // 
            this.lsv_DanhSachThamSo.CheckBoxes = true;
            this.lsv_DanhSachThamSo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenThamSo,
            this.GiaTri});
            this.lsv_DanhSachThamSo.FullRowSelect = true;
            this.lsv_DanhSachThamSo.GridLines = true;
            this.lsv_DanhSachThamSo.LabelEdit = true;
            this.lsv_DanhSachThamSo.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachThamSo.Name = "lsv_DanhSachThamSo";
            this.lsv_DanhSachThamSo.Size = new System.Drawing.Size(312, 179);
            this.lsv_DanhSachThamSo.TabIndex = 0;
            this.lsv_DanhSachThamSo.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachThamSo.View = System.Windows.Forms.View.Details;
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 54;
            // 
            // TenThamSo
            // 
            this.TenThamSo.Text = "Tên Tham Số";
            this.TenThamSo.Width = 120;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(185, 19);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(222, 25);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "QUẢN LÝ THAM SỐ";
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.Width = 87;
            // 
            // QuanLyThamSoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 347);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ThamSoHienCo);
            this.Controls.Add(this.lbl_Title);
            this.Name = "QuanLyThamSoGUI";
            this.Text = "QuanLyThamSoGUI";
            this.Load += new System.EventHandler(this.QuanLyThamSoGUI_Load);
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThaoTac.PerformLayout();
            this.grb_ThamSoHienCo.ResumeLayout(false);
            this.grb_ThamSoHienCo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_TimLoaiThamSo;
        private System.Windows.Forms.Button btn_XoaLoaiThamSo;
        private System.Windows.Forms.TextBox txt_TenLoaiThamSo;
        private System.Windows.Forms.Label lbl_LoaiThamSo;
        private System.Windows.Forms.Button btn_SuaLoaiThamSo;
        private System.Windows.Forms.Button btn_ThemLoaiThamSo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_ThamSoHienCo;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachThamSo;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenThamSo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ColumnHeader GiaTri;
    }
}