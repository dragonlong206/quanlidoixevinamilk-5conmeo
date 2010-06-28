namespace GUI
{
    partial class LoaiDiaDiemGUI
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
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_TimLoaiDiaDiem = new System.Windows.Forms.Button();
            this.btn_XoaLoaiDiaDiem = new System.Windows.Forms.Button();
            this.txt_TenLoaiDiaDiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SuaLoaiDiaDiem = new System.Windows.Forms.Button();
            this.btn_ThemLoaiDiaDiem = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_DanhSachLoaiDiaDiem = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachLoaiDiaDiem = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenLoaiDiaDiem = new System.Windows.Forms.ColumnHeader();
            this.grb_ThaoTac.SuspendLayout();
            this.grb_DanhSachLoaiDiaDiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(74, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(277, 25);
            this.lbl_Title.TabIndex = 11;
            this.lbl_Title.Text = "QUẢN LÝ LOẠI ĐỊA ĐIỂM";
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_TimLoaiDiaDiem);
            this.grb_ThaoTac.Controls.Add(this.btn_XoaLoaiDiaDiem);
            this.grb_ThaoTac.Controls.Add(this.txt_TenLoaiDiaDiem);
            this.grb_ThaoTac.Controls.Add(this.label2);
            this.grb_ThaoTac.Controls.Add(this.btn_SuaLoaiDiaDiem);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemLoaiDiaDiem);
            this.grb_ThaoTac.Location = new System.Drawing.Point(212, 63);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 0;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_TimLoaiDiaDiem
            // 
            this.btn_TimLoaiDiaDiem.Location = new System.Drawing.Point(16, 134);
            this.btn_TimLoaiDiaDiem.Name = "btn_TimLoaiDiaDiem";
            this.btn_TimLoaiDiaDiem.Size = new System.Drawing.Size(82, 23);
            this.btn_TimLoaiDiaDiem.TabIndex = 1;
            this.btn_TimLoaiDiaDiem.Text = "Tìm";
            this.btn_TimLoaiDiaDiem.UseVisualStyleBackColor = true;
            this.btn_TimLoaiDiaDiem.Click += new System.EventHandler(this.btn_TimLoaiDiaDiem_Click);
            // 
            // btn_XoaLoaiDiaDiem
            // 
            this.btn_XoaLoaiDiaDiem.Location = new System.Drawing.Point(16, 182);
            this.btn_XoaLoaiDiaDiem.Name = "btn_XoaLoaiDiaDiem";
            this.btn_XoaLoaiDiaDiem.Size = new System.Drawing.Size(82, 23);
            this.btn_XoaLoaiDiaDiem.TabIndex = 3;
            this.btn_XoaLoaiDiaDiem.Text = "Xóa";
            this.btn_XoaLoaiDiaDiem.UseVisualStyleBackColor = true;
            this.btn_XoaLoaiDiaDiem.Click += new System.EventHandler(this.btn_XoaLoaiDiaDiem_Click);
            // 
            // txt_TenLoaiDiaDiem
            // 
            this.txt_TenLoaiDiaDiem.Location = new System.Drawing.Point(17, 71);
            this.txt_TenLoaiDiaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenLoaiDiaDiem.Name = "txt_TenLoaiDiaDiem";
            this.txt_TenLoaiDiaDiem.Size = new System.Drawing.Size(127, 20);
            this.txt_TenLoaiDiaDiem.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Loại địa điểm";
            // 
            // btn_SuaLoaiDiaDiem
            // 
            this.btn_SuaLoaiDiaDiem.Location = new System.Drawing.Point(118, 182);
            this.btn_SuaLoaiDiaDiem.Name = "btn_SuaLoaiDiaDiem";
            this.btn_SuaLoaiDiaDiem.Size = new System.Drawing.Size(82, 23);
            this.btn_SuaLoaiDiaDiem.TabIndex = 4;
            this.btn_SuaLoaiDiaDiem.Text = "Sửa";
            this.btn_SuaLoaiDiaDiem.UseVisualStyleBackColor = true;
            this.btn_SuaLoaiDiaDiem.Click += new System.EventHandler(this.btn_SuaLoaiDiaDiem_Click);
            // 
            // btn_ThemLoaiDiaDiem
            // 
            this.btn_ThemLoaiDiaDiem.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemLoaiDiaDiem.Name = "btn_ThemLoaiDiaDiem";
            this.btn_ThemLoaiDiaDiem.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemLoaiDiaDiem.TabIndex = 2;
            this.btn_ThemLoaiDiaDiem.Text = "Thêm";
            this.btn_ThemLoaiDiaDiem.UseVisualStyleBackColor = true;
            this.btn_ThemLoaiDiaDiem.Click += new System.EventHandler(this.btn_ThemLoaiDiaDiem_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(330, 306);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 1;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_DanhSachLoaiDiaDiem
            // 
            this.grb_DanhSachLoaiDiaDiem.Controls.Add(this.chk_ChonTatCa);
            this.grb_DanhSachLoaiDiaDiem.Controls.Add(this.lsv_DanhSachLoaiDiaDiem);
            this.grb_DanhSachLoaiDiaDiem.Location = new System.Drawing.Point(12, 63);
            this.grb_DanhSachLoaiDiaDiem.Name = "grb_DanhSachLoaiDiaDiem";
            this.grb_DanhSachLoaiDiaDiem.Size = new System.Drawing.Size(194, 228);
            this.grb_DanhSachLoaiDiaDiem.TabIndex = 25;
            this.grb_DanhSachLoaiDiaDiem.TabStop = false;
            this.grb_DanhSachLoaiDiaDiem.Text = "Danh sách loại địa điểm";
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
            // lsv_DanhSachLoaiDiaDiem
            // 
            this.lsv_DanhSachLoaiDiaDiem.CheckBoxes = true;
            this.lsv_DanhSachLoaiDiaDiem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.TenLoaiDiaDiem});
            this.lsv_DanhSachLoaiDiaDiem.FullRowSelect = true;
            this.lsv_DanhSachLoaiDiaDiem.GridLines = true;
            this.lsv_DanhSachLoaiDiaDiem.LabelEdit = true;
            this.lsv_DanhSachLoaiDiaDiem.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachLoaiDiaDiem.Name = "lsv_DanhSachLoaiDiaDiem";
            this.lsv_DanhSachLoaiDiaDiem.Size = new System.Drawing.Size(181, 179);
            this.lsv_DanhSachLoaiDiaDiem.TabIndex = 0;
            this.lsv_DanhSachLoaiDiaDiem.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachLoaiDiaDiem.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachLoaiDiaDiem.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachLoaiDiaDiem_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 54;
            // 
            // TenLoaiDiaDiem
            // 
            this.TenLoaiDiaDiem.Text = "Tên Loại Địa Điểm";
            this.TenLoaiDiaDiem.Width = 120;
            // 
            // LoaiDiaDiemGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 339);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_DanhSachLoaiDiaDiem);
            this.Controls.Add(this.lbl_Title);
            this.MaximizeBox = false;
            this.Name = "LoaiDiaDiemGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly loai dia diem";
            this.Load += new System.EventHandler(this.LoaiDiaDiemGUI_Load);
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThaoTac.PerformLayout();
            this.grb_DanhSachLoaiDiaDiem.ResumeLayout(false);
            this.grb_DanhSachLoaiDiaDiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_TimLoaiDiaDiem;
        private System.Windows.Forms.Button btn_XoaLoaiDiaDiem;
        private System.Windows.Forms.TextBox txt_TenLoaiDiaDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SuaLoaiDiaDiem;
        private System.Windows.Forms.Button btn_ThemLoaiDiaDiem;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_DanhSachLoaiDiaDiem;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachLoaiDiaDiem;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenLoaiDiaDiem;
    }
}