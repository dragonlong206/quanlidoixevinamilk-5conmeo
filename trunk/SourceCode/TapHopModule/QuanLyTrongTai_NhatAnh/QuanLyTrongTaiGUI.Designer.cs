namespace GUI
{
    partial class frm_QuanLyTrongTai
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
            this.btnThemTrongTai = new System.Windows.Forms.Button();
            this.txt_MaTrongTai = new System.Windows.Forms.TextBox();
            this.grb_ThongTin = new System.Windows.Forms.GroupBox();
            this.txt_DonVi = new System.Windows.Forms.TextBox();
            this.lbl_DonVi = new System.Windows.Forms.Label();
            this.txt_GiaTri = new System.Windows.Forms.TextBox();
            this.lbl_GiaTri = new System.Windows.Forms.Label();
            this.lbl_MaTrongTai = new System.Windows.Forms.Label();
            this.lsv_DanhSachHienCo = new System.Windows.Forms.ListView();
            this.MaTrongTai = new System.Windows.Forms.ColumnHeader();
            this.GiaTri = new System.Windows.Forms.ColumnHeader();
            this.DonVi = new System.Windows.Forms.ColumnHeader();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_TrongTaiHienCo = new System.Windows.Forms.GroupBox();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
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
            this.lbl_Title.Location = new System.Drawing.Point(134, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 25);
            this.lbl_Title.TabIndex = 17;
            this.lbl_Title.Text = "QUẢN LÝ TRỌNG TẢI";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(44, 73);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(168, 23);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa các loại trọng tải đã chọn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(111, 30);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(143, 23);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa trọng tải đã chọn";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
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
            // btnThemTrongTai
            // 
            this.btnThemTrongTai.Location = new System.Drawing.Point(6, 30);
            this.btnThemTrongTai.Name = "btnThemTrongTai";
            this.btnThemTrongTai.Size = new System.Drawing.Size(99, 23);
            this.btnThemTrongTai.TabIndex = 0;
            this.btnThemTrongTai.Text = "Thêm trọng tải";
            this.btnThemTrongTai.UseVisualStyleBackColor = true;
            this.btnThemTrongTai.Click += new System.EventHandler(this.btnThemTrongTai_Click);
            // 
            // txt_MaTrongTai
            // 
            this.txt_MaTrongTai.Location = new System.Drawing.Point(123, 20);
            this.txt_MaTrongTai.Multiline = true;
            this.txt_MaTrongTai.Name = "txt_MaTrongTai";
            this.txt_MaTrongTai.Size = new System.Drawing.Size(78, 25);
            this.txt_MaTrongTai.TabIndex = 0;
            // 
            // grb_ThongTin
            // 
            this.grb_ThongTin.Controls.Add(this.txt_DonVi);
            this.grb_ThongTin.Controls.Add(this.lbl_DonVi);
            this.grb_ThongTin.Controls.Add(this.txt_GiaTri);
            this.grb_ThongTin.Controls.Add(this.lbl_GiaTri);
            this.grb_ThongTin.Controls.Add(this.lbl_MaTrongTai);
            this.grb_ThongTin.Controls.Add(this.txt_MaTrongTai);
            this.grb_ThongTin.Location = new System.Drawing.Point(248, 39);
            this.grb_ThongTin.Name = "grb_ThongTin";
            this.grb_ThongTin.Size = new System.Drawing.Size(260, 163);
            this.grb_ThongTin.TabIndex = 21;
            this.grb_ThongTin.TabStop = false;
            this.grb_ThongTin.Text = "Thông tin cần thêm";
            // 
            // txt_DonVi
            // 
            this.txt_DonVi.Location = new System.Drawing.Point(123, 118);
            this.txt_DonVi.Multiline = true;
            this.txt_DonVi.Name = "txt_DonVi";
            this.txt_DonVi.ReadOnly = true;
            this.txt_DonVi.Size = new System.Drawing.Size(78, 25);
            this.txt_DonVi.TabIndex = 24;
            this.txt_DonVi.Text = "TẤN";
            // 
            // lbl_DonVi
            // 
            this.lbl_DonVi.AutoSize = true;
            this.lbl_DonVi.Location = new System.Drawing.Point(28, 130);
            this.lbl_DonVi.Name = "lbl_DonVi";
            this.lbl_DonVi.Size = new System.Drawing.Size(38, 13);
            this.lbl_DonVi.TabIndex = 23;
            this.lbl_DonVi.Text = "Đơn vị";
            // 
            // txt_GiaTri
            // 
            this.txt_GiaTri.Location = new System.Drawing.Point(123, 64);
            this.txt_GiaTri.Multiline = true;
            this.txt_GiaTri.Name = "txt_GiaTri";
            this.txt_GiaTri.Size = new System.Drawing.Size(78, 25);
            this.txt_GiaTri.TabIndex = 22;
            // 
            // lbl_GiaTri
            // 
            this.lbl_GiaTri.AutoSize = true;
            this.lbl_GiaTri.Location = new System.Drawing.Point(28, 76);
            this.lbl_GiaTri.Name = "lbl_GiaTri";
            this.lbl_GiaTri.Size = new System.Drawing.Size(34, 13);
            this.lbl_GiaTri.TabIndex = 21;
            this.lbl_GiaTri.Text = "Giá trị";
            this.lbl_GiaTri.Click += new System.EventHandler(this.lbl_GiaTri_Click);
            // 
            // lbl_MaTrongTai
            // 
            this.lbl_MaTrongTai.AutoSize = true;
            this.lbl_MaTrongTai.Location = new System.Drawing.Point(28, 32);
            this.lbl_MaTrongTai.Name = "lbl_MaTrongTai";
            this.lbl_MaTrongTai.Size = new System.Drawing.Size(63, 13);
            this.lbl_MaTrongTai.TabIndex = 20;
            this.lbl_MaTrongTai.Text = "Mã trọng tải";
            // 
            // lsv_DanhSachHienCo
            // 
            this.lsv_DanhSachHienCo.CheckBoxes = true;
            this.lsv_DanhSachHienCo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaTrongTai,
            this.GiaTri,
            this.DonVi});
            this.lsv_DanhSachHienCo.LabelEdit = true;
            this.lsv_DanhSachHienCo.Location = new System.Drawing.Point(7, 20);
            this.lsv_DanhSachHienCo.Name = "lsv_DanhSachHienCo";
            this.lsv_DanhSachHienCo.Size = new System.Drawing.Size(216, 266);
            this.lsv_DanhSachHienCo.TabIndex = 0;
            this.lsv_DanhSachHienCo.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachHienCo.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachHienCo.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachHienCo_SelectedIndexChanged);
            // 
            // MaTrongTai
            // 
            this.MaTrongTai.Text = "Mã trọng tải";
            this.MaTrongTai.Width = 89;
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
            this.DonVi.Width = 67;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(433, 339);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 20;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_TrongTaiHienCo
            // 
            this.grb_TrongTaiHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_TrongTaiHienCo.Controls.Add(this.lsv_DanhSachHienCo);
            this.grb_TrongTaiHienCo.Location = new System.Drawing.Point(12, 39);
            this.grb_TrongTaiHienCo.Name = "grb_TrongTaiHienCo";
            this.grb_TrongTaiHienCo.Size = new System.Drawing.Size(229, 323);
            this.grb_TrongTaiHienCo.TabIndex = 18;
            this.grb_TrongTaiHienCo.TabStop = false;
            this.grb_TrongTaiHienCo.Text = "Các loại trọng tải hiện có";
            this.grb_TrongTaiHienCo.Enter += new System.EventHandler(this.grb_TrongTaiHienCo_Enter);
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btnXoa);
            this.grb_ThaoTac.Controls.Add(this.btn_Sua);
            this.grb_ThaoTac.Controls.Add(this.btnThemTrongTai);
            this.grb_ThaoTac.Location = new System.Drawing.Point(248, 208);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(261, 117);
            this.grb_ThaoTac.TabIndex = 19;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // frm_QuanLyTrongTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 372);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.grb_ThongTin);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TrongTaiHienCo);
            this.Controls.Add(this.grb_ThaoTac);
            this.MaximizeBox = false;
            this.Name = "frm_QuanLyTrongTai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quan ly trong tai";
            this.Load += new System.EventHandler(this.frm_QuanLyTrongTai_Load);
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
        private System.Windows.Forms.Button btnThemTrongTai;
        private System.Windows.Forms.TextBox txt_MaTrongTai;
        private System.Windows.Forms.GroupBox grb_ThongTin;
        private System.Windows.Forms.ListView lsv_DanhSachHienCo;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_TrongTaiHienCo;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.ColumnHeader MaTrongTai;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.ColumnHeader DonVi;
        private System.Windows.Forms.Label lbl_GiaTri;
        private System.Windows.Forms.Label lbl_MaTrongTai;
        private System.Windows.Forms.TextBox txt_GiaTri;
        private System.Windows.Forms.TextBox txt_DonVi;
        private System.Windows.Forms.Label lbl_DonVi;
    }
}