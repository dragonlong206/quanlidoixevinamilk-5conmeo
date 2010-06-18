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
            this.txt_GiaTriThamSo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimThamSo = new System.Windows.Forms.Button();
            this.btn_XoaThamSo = new System.Windows.Forms.Button();
            this.txt_TenThamSo = new System.Windows.Forms.TextBox();
            this.lbl_LoaiThamSo = new System.Windows.Forms.Label();
            this.btn_SuaThamSo = new System.Windows.Forms.Button();
            this.btn_ThemThamSo = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_ThamSoHienCo = new System.Windows.Forms.GroupBox();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.lsv_DanhSachThamSo = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.TenThamSo = new System.Windows.Forms.ColumnHeader();
            this.GiaTri = new System.Windows.Forms.ColumnHeader();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_ThaoTac.SuspendLayout();
            this.grb_ThamSoHienCo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.txt_GiaTriThamSo);
            this.grb_ThaoTac.Controls.Add(this.label1);
            this.grb_ThaoTac.Controls.Add(this.btn_TimThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_XoaThamSo);
            this.grb_ThaoTac.Controls.Add(this.txt_TenThamSo);
            this.grb_ThaoTac.Controls.Add(this.lbl_LoaiThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_SuaThamSo);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemThamSo);
            this.grb_ThaoTac.Location = new System.Drawing.Point(307, 74);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 30;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // txt_GiaTriThamSo
            // 
            this.txt_GiaTriThamSo.Location = new System.Drawing.Point(73, 81);
            this.txt_GiaTriThamSo.Name = "txt_GiaTriThamSo";
            this.txt_GiaTriThamSo.Size = new System.Drawing.Size(127, 20);
            this.txt_GiaTriThamSo.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Giá trị";
            // 
            // btn_TimThamSo
            // 
            this.btn_TimThamSo.Location = new System.Drawing.Point(16, 134);
            this.btn_TimThamSo.Name = "btn_TimThamSo";
            this.btn_TimThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_TimThamSo.TabIndex = 20;
            this.btn_TimThamSo.Text = "Tìm";
            this.btn_TimThamSo.UseVisualStyleBackColor = true;
            this.btn_TimThamSo.Click += new System.EventHandler(this.btn_TimThamSo_Click);
            // 
            // btn_XoaThamSo
            // 
            this.btn_XoaThamSo.Location = new System.Drawing.Point(16, 182);
            this.btn_XoaThamSo.Name = "btn_XoaThamSo";
            this.btn_XoaThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_XoaThamSo.TabIndex = 2;
            this.btn_XoaThamSo.Text = "Xóa";
            this.btn_XoaThamSo.UseVisualStyleBackColor = true;
            this.btn_XoaThamSo.Click += new System.EventHandler(this.btn_XoaThamSo_Click);
            // 
            // txt_TenThamSo
            // 
            this.txt_TenThamSo.Location = new System.Drawing.Point(73, 43);
            this.txt_TenThamSo.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenThamSo.Name = "txt_TenThamSo";
            this.txt_TenThamSo.Size = new System.Drawing.Size(127, 20);
            this.txt_TenThamSo.TabIndex = 18;
            // 
            // lbl_LoaiThamSo
            // 
            this.lbl_LoaiThamSo.AutoSize = true;
            this.lbl_LoaiThamSo.Location = new System.Drawing.Point(14, 46);
            this.lbl_LoaiThamSo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoaiThamSo.Name = "lbl_LoaiThamSo";
            this.lbl_LoaiThamSo.Size = new System.Drawing.Size(48, 13);
            this.lbl_LoaiThamSo.TabIndex = 19;
            this.lbl_LoaiThamSo.Text = "Tham số";
            // 
            // btn_SuaThamSo
            // 
            this.btn_SuaThamSo.Location = new System.Drawing.Point(118, 182);
            this.btn_SuaThamSo.Name = "btn_SuaThamSo";
            this.btn_SuaThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_SuaThamSo.TabIndex = 1;
            this.btn_SuaThamSo.Text = "Sửa";
            this.btn_SuaThamSo.UseVisualStyleBackColor = true;
            this.btn_SuaThamSo.Click += new System.EventHandler(this.btn_SuaThamSo_Click);
            // 
            // btn_ThemThamSo
            // 
            this.btn_ThemThamSo.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemThamSo.Name = "btn_ThemThamSo";
            this.btn_ThemThamSo.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemThamSo.TabIndex = 0;
            this.btn_ThemThamSo.Text = "Thêm";
            this.btn_ThemThamSo.UseVisualStyleBackColor = true;
            this.btn_ThemThamSo.Click += new System.EventHandler(this.btn_ThemThamSo_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(425, 308);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 31;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_ThamSoHienCo
            // 
            this.grb_ThamSoHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_ThamSoHienCo.Controls.Add(this.lsv_DanhSachThamSo);
            this.grb_ThamSoHienCo.Location = new System.Drawing.Point(12, 74);
            this.grb_ThamSoHienCo.Name = "grb_ThamSoHienCo";
            this.grb_ThamSoHienCo.Size = new System.Drawing.Size(289, 228);
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
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
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
            this.lsv_DanhSachThamSo.Size = new System.Drawing.Size(271, 179);
            this.lsv_DanhSachThamSo.TabIndex = 0;
            this.lsv_DanhSachThamSo.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachThamSo.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachThamSo.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachThamSo_SelectedIndexChanged);
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
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.Width = 87;
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(150, 19);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(222, 25);
            this.lbl_Title.TabIndex = 28;
            this.lbl_Title.Text = "QUẢN LÝ THAM SỐ";
            // 
            // QuanLyThamSoGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 336);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_ThamSoHienCo);
            this.Controls.Add(this.lbl_Title);
            this.Name = "QuanLyThamSoGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button btn_TimThamSo;
        private System.Windows.Forms.Button btn_XoaThamSo;
        private System.Windows.Forms.TextBox txt_TenThamSo;
        private System.Windows.Forms.Label lbl_LoaiThamSo;
        private System.Windows.Forms.Button btn_SuaThamSo;
        private System.Windows.Forms.Button btn_ThemThamSo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_ThamSoHienCo;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.ListView lsv_DanhSachThamSo;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader TenThamSo;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.TextBox txt_GiaTriThamSo;
        private System.Windows.Forms.Label label1;
    }
}