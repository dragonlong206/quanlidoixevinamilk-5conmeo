namespace GUI
{
    partial class QuanLyTrongTaiGUI
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.btn_ThemTrongTai = new System.Windows.Forms.Button();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_DonVi = new System.Windows.Forms.TextBox();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.lbl_DonVi = new System.Windows.Forms.Label();
            this.lbl_GiaTri = new System.Windows.Forms.Label();
            this.lsv_DanhSachTrongTai = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.GiaTri = new System.Windows.Forms.ColumnHeader();
            this.DonVi = new System.Windows.Forms.ColumnHeader();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_TrongTaiHienCo = new System.Windows.Forms.GroupBox();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_TimTrongTai = new System.Windows.Forms.Button();
            this.grb_ThongTin.SuspendLayout();
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
            this.lbl_Title.Location = new System.Drawing.Point(91, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 25);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "QUẢN LÝ TRỌNG TẢI";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(16, 75);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(106, 75);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 23);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // chk_ChonTatCa
            // 
            this.chk_ChonTatCa.AutoSize = true;
            this.chk_ChonTatCa.Location = new System.Drawing.Point(7, 229);
            this.chk_ChonTatCa.Name = "chk_ChonTatCa";
            this.chk_ChonTatCa.Size = new System.Drawing.Size(81, 17);
            this.chk_ChonTatCa.TabIndex = 1;
            this.chk_ChonTatCa.Text = "Chọn tất cả";
            this.chk_ChonTatCa.UseVisualStyleBackColor = true;
            this.chk_ChonTatCa.CheckedChanged += new System.EventHandler(this.chk_ChonTatCa_CheckedChanged);
            // 
            // btn_ThemTrongTai
            // 
            this.btn_ThemTrongTai.Location = new System.Drawing.Point(106, 29);
            this.btn_ThemTrongTai.Name = "btn_ThemTrongTai";
            this.btn_ThemTrongTai.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemTrongTai.TabIndex = 1;
            this.btn_ThemTrongTai.Text = "Thêm";
            this.btn_ThemTrongTai.UseVisualStyleBackColor = true;
            this.btn_ThemTrongTai.Click += new System.EventHandler(this.btnThemTrongTai_Click);
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_DonVi);
            this.grb_ThongTin.Controls.Add(this.txt_GiaTri);
            this.grb_ThongTin.Controls.Add(this.lbl_DonVi);
            this.grb_ThongTin.Controls.Add(this.lbl_GiaTri);
            this.grb_ThongTin.Location = new System.Drawing.Point(225, 61);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(198, 133);
            this.grb_ThongTin.TabIndex = 0;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin chi tiết";
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Location = new System.Drawing.Point(72, 92);
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.Size = new System.Drawing.Size(109, 20);
            this.txt_DonVi.TabIndex = 1;
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(72, 44);
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(109, 20);
            this.txt_GiaTri.TabIndex = 0;
            // 
            // lbl_DonVi
            // 
            this.lbl_DonVi.AutoSize = true;
            this.lbl_DonVi.Location = new System.Drawing.Point(13, 95);
            this.lbl_DonVi.Name = "lbl_DonVi";
            this.lbl_DonVi.Size = new System.Drawing.Size(38, 13);
            this.lbl_DonVi.TabIndex = 23;
            this.lbl_DonVi.Text = "Đơn vị";
            // 
            // lbl_GiaTri
            // 
            this.lbl_GiaTri.AutoSize = true;
            this.lbl_GiaTri.Location = new System.Drawing.Point(13, 47);
            this.lbl_GiaTri.Name = "lbl_GiaTri";
            this.lbl_GiaTri.Size = new System.Drawing.Size(34, 13);
            this.lbl_GiaTri.TabIndex = 21;
            this.lbl_GiaTri.Text = "Giá trị";
            // 
            // lsv_DanhSachTrongTai
            // 
            this.lsv_DanhSachTrongTai.CheckBoxes = true;
            this.lsv_DanhSachTrongTai.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.GiaTri,
            this.DonVi});
            this.lsv_DanhSachTrongTai.FullRowSelect = true;
            this.lsv_DanhSachTrongTai.GridLines = true;
            this.lsv_DanhSachTrongTai.LabelEdit = true;
            this.lsv_DanhSachTrongTai.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachTrongTai.Name = "lsv_DanhSachTrongTai";
            this.lsv_DanhSachTrongTai.Size = new System.Drawing.Size(193, 203);
            this.lsv_DanhSachTrongTai.TabIndex = 0;
            this.lsv_DanhSachTrongTai.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachTrongTai.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachTrongTai.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachTrongTai_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 54;
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá trị";
            this.GiaTri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaTri.Width = 56;
            // 
            // DonVi
            // 
            this.DonVi.Text = "Đơn vị";
            this.DonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DonVi.Width = 73;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(331, 329);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_TrongTaiHienCo
            // 
            this.grb_TrongTaiHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_TrongTaiHienCo.Controls.Add(this.lsv_DanhSachTrongTai);
            this.grb_TrongTaiHienCo.Location = new System.Drawing.Point(12, 61);
            this.grb_TrongTaiHienCo.Name = "grb_TrongTaiHienCo";
            this.grb_TrongTaiHienCo.Size = new System.Drawing.Size(207, 256);
            this.grb_TrongTaiHienCo.TabIndex = 18;
            this.grb_TrongTaiHienCo.TabStop = false;
            this.grb_TrongTaiHienCo.Text = "Danh sách trọng tải";
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_TimTrongTai);
            this.grb_ThaoTac.Controls.Add(this.btnXoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemTrongTai);
            this.grb_ThaoTac.Location = new System.Drawing.Point(225, 200);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(198, 117);
            this.grb_ThaoTac.TabIndex = 1;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_TimTrongTai
            // 
            this.btn_TimTrongTai.Location = new System.Drawing.Point(16, 29);
            this.btn_TimTrongTai.Name = "btn_TimTrongTai";
            this.btn_TimTrongTai.Size = new System.Drawing.Size(75, 23);
            this.btn_TimTrongTai.TabIndex = 0;
            this.btn_TimTrongTai.Text = "Tìm";
            this.btn_TimTrongTai.UseVisualStyleBackColor = true;
            this.btn_TimTrongTai.Click += new System.EventHandler(this.btn_TimTrongTai_Click);
            // 
            // QuanLyTrongTaiGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 360);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TrongTaiHienCo);
            this.Controls.Add(this.grb_ThaoTac);
            this.MaximizeBox = false;
            this.Name = "QuanLyTrongTaiGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly trong tai";
            this.Load += new System.EventHandler(this.QuanLyTrongTaiGUI_Load);
            this.grb_ThongTin.ResumeLayout(false);
            this.grb_ThongTin.PerformLayout();
            this.grb_TrongTaiHienCo.ResumeLayout(false);
            this.grb_TrongTaiHienCo.PerformLayout();
            this.grb_ThaoTac.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.Button btn_ThemTrongTai;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.ListView lsv_DanhSachTrongTai;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_TrongTaiHienCo;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.ColumnHeader DonVi;
        private System.Windows.Forms.Label lbl_GiaTri;
        private System.Windows.Forms.Label lbl_DonVi;
        private System.Windows.Forms.Button btn_TimTrongTai;
        private System.Windows.Forms.TextBox txt_DonVi;
        private System.Windows.Forms.TextBox txt_GiaTri;
    }
}