namespace GUI
{
    partial class LoaiNhanVienGUI
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.grb_ThaoTac = new System.Windows.Forms.GroupBox();
            this.btn_TimLoaiNhanVien = new System.Windows.Forms.Button();
            this.btn_XoaLoaiNhanVien = new System.Windows.Forms.Button();
            this.txt_TenLoaiNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_SuaLoaiNhanVien = new System.Windows.Forms.Button();
            this.btn_ThemLoaiNhanVien = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.grb_TrongTaiHienCo = new System.Windows.Forms.GroupBox();
            this.lsv_DanhSachLoaiNhanVien = new System.Windows.Forms.ListView();
            this.STT = new System.Windows.Forms.ColumnHeader();
            this.tenloainhanvien = new System.Windows.Forms.ColumnHeader();
            this.chk_ChonTatCa = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.db_QuanLyDoiXeVinamilkDataSet = new GUI.Db_QuanLyDoiXeVinamilkDataSet();
            this.lOAINHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAI_NHAN_VIENTableAdapter = new GUI.Db_QuanLyDoiXeVinamilkDataSetTableAdapters.LOAI_NHAN_VIENTableAdapter();
            this.grb_ThaoTac.SuspendLayout();
            this.grb_TrongTaiHienCo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyDoiXeVinamilkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAINHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Title.Location = new System.Drawing.Point(103, -29);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(241, 25);
            this.lbl_Title.TabIndex = 25;
            this.lbl_Title.Text = "QUẢN LÝ LOẠI HÀNG";
            // 
            // grb_ThaoTac
            // 
            this.grb_ThaoTac.Controls.Add(this.btn_TimLoaiNhanVien);
            this.grb_ThaoTac.Controls.Add(this.btn_XoaLoaiNhanVien);
            this.grb_ThaoTac.Controls.Add(this.txt_TenLoaiNhanVien);
            this.grb_ThaoTac.Controls.Add(this.label2);
            this.grb_ThaoTac.Controls.Add(this.btn_SuaLoaiNhanVien);
            this.grb_ThaoTac.Controls.Add(this.btn_ThemLoaiNhanVien);
            this.grb_ThaoTac.Location = new System.Drawing.Point(236, 58);
            this.grb_ThaoTac.Name = "grb_ThaoTac";
            this.grb_ThaoTac.Size = new System.Drawing.Size(207, 228);
            this.grb_ThaoTac.TabIndex = 28;
            this.grb_ThaoTac.TabStop = false;
            this.grb_ThaoTac.Text = "Thao tác";
            // 
            // btn_TimLoaiNhanVien
            // 
            this.btn_TimLoaiNhanVien.Location = new System.Drawing.Point(16, 134);
            this.btn_TimLoaiNhanVien.Name = "btn_TimLoaiNhanVien";
            this.btn_TimLoaiNhanVien.Size = new System.Drawing.Size(82, 23);
            this.btn_TimLoaiNhanVien.TabIndex = 20;
            this.btn_TimLoaiNhanVien.Text = "Tìm";
            this.btn_TimLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btn_TimLoaiNhanVien.Click += new System.EventHandler(this.btn_TimLoaiNhanVien_Click);
            // 
            // btn_XoaLoaiNhanVien
            // 
            this.btn_XoaLoaiNhanVien.Location = new System.Drawing.Point(16, 182);
            this.btn_XoaLoaiNhanVien.Name = "btn_XoaLoaiNhanVien";
            this.btn_XoaLoaiNhanVien.Size = new System.Drawing.Size(82, 23);
            this.btn_XoaLoaiNhanVien.TabIndex = 2;
            this.btn_XoaLoaiNhanVien.Text = "Xóa";
            this.btn_XoaLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btn_XoaLoaiNhanVien.Click += new System.EventHandler(this.btn_XoaLoaiNhanVien_Click);
            // 
            // txt_TenLoaiNhanVien
            // 
            this.txt_TenLoaiNhanVien.Location = new System.Drawing.Point(17, 71);
            this.txt_TenLoaiNhanVien.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenLoaiNhanVien.Name = "txt_TenLoaiNhanVien";
            this.txt_TenLoaiNhanVien.Size = new System.Drawing.Size(127, 20);
            this.txt_TenLoaiNhanVien.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên loại nhân viên";
            // 
            // btn_SuaLoaiNhanVien
            // 
            this.btn_SuaLoaiNhanVien.Location = new System.Drawing.Point(118, 182);
            this.btn_SuaLoaiNhanVien.Name = "btn_SuaLoaiNhanVien";
            this.btn_SuaLoaiNhanVien.Size = new System.Drawing.Size(82, 23);
            this.btn_SuaLoaiNhanVien.TabIndex = 1;
            this.btn_SuaLoaiNhanVien.Text = "Sửa";
            this.btn_SuaLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btn_SuaLoaiNhanVien.Click += new System.EventHandler(this.btn_SuaLoaiNhanVien_Click);
            // 
            // btn_ThemLoaiNhanVien
            // 
            this.btn_ThemLoaiNhanVien.Location = new System.Drawing.Point(118, 134);
            this.btn_ThemLoaiNhanVien.Name = "btn_ThemLoaiNhanVien";
            this.btn_ThemLoaiNhanVien.Size = new System.Drawing.Size(82, 23);
            this.btn_ThemLoaiNhanVien.TabIndex = 0;
            this.btn_ThemLoaiNhanVien.Text = "Thêm";
            this.btn_ThemLoaiNhanVien.UseVisualStyleBackColor = true;
            this.btn_ThemLoaiNhanVien.Click += new System.EventHandler(this.btn_ThemLoaiNhanVien_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(361, 292);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(82, 23);
            this.btn_Thoat.TabIndex = 29;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // grb_TrongTaiHienCo
            // 
            this.grb_TrongTaiHienCo.Controls.Add(this.lsv_DanhSachLoaiNhanVien);
            this.grb_TrongTaiHienCo.Controls.Add(this.chk_ChonTatCa);
            this.grb_TrongTaiHienCo.Location = new System.Drawing.Point(12, 58);
            this.grb_TrongTaiHienCo.Name = "grb_TrongTaiHienCo";
            this.grb_TrongTaiHienCo.Size = new System.Drawing.Size(194, 228);
            this.grb_TrongTaiHienCo.TabIndex = 27;
            this.grb_TrongTaiHienCo.TabStop = false;
            this.grb_TrongTaiHienCo.Text = "Danh sách loại nhân viên";
            // 
            // lsv_DanhSachLoaiNhanVien
            // 
            this.lsv_DanhSachLoaiNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.tenloainhanvien});
            this.lsv_DanhSachLoaiNhanVien.GridLines = true;
            this.lsv_DanhSachLoaiNhanVien.Location = new System.Drawing.Point(7, 19);
            this.lsv_DanhSachLoaiNhanVien.Name = "lsv_DanhSachLoaiNhanVien";
            this.lsv_DanhSachLoaiNhanVien.Size = new System.Drawing.Size(172, 180);
            this.lsv_DanhSachLoaiNhanVien.TabIndex = 2;
            this.lsv_DanhSachLoaiNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsv_DanhSachLoaiNhanVien.View = System.Windows.Forms.View.Details;
            this.lsv_DanhSachLoaiNhanVien.SelectedIndexChanged += new System.EventHandler(this.lsv_DanhSachLoaiNhanVien_SelectedIndexChanged);
            // 
            // STT
            // 
            this.STT.Text = "STT";
            this.STT.Width = 47;
            // 
            // tenloainhanvien
            // 
            this.tenloainhanvien.Text = "Ten Loai Nhan Vien";
            this.tenloainhanvien.Width = 121;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(103, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "QUẢN LÝ LOẠI NHÂN VIÊN";
            // 
            // db_QuanLyDoiXeVinamilkDataSet
            // 
            this.db_QuanLyDoiXeVinamilkDataSet.DataSetName = "Db_QuanLyDoiXeVinamilkDataSet";
            this.db_QuanLyDoiXeVinamilkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOAINHANVIENBindingSource
            // 
            this.lOAINHANVIENBindingSource.DataMember = "LOAI_NHAN_VIEN";
            this.lOAINHANVIENBindingSource.DataSource = this.db_QuanLyDoiXeVinamilkDataSet;
            // 
            // lOAI_NHAN_VIENTableAdapter
            // 
            this.lOAI_NHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // LoaiNhanVienGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 326);
            this.Controls.Add(this.grb_ThaoTac);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.grb_TrongTaiHienCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Title);
            this.Name = "LoaiNhanVienGUI";
            this.Text = "quanlyloainhanvienGUI";
            this.grb_ThaoTac.ResumeLayout(false);
            this.grb_ThaoTac.PerformLayout();
            this.grb_TrongTaiHienCo.ResumeLayout(false);
            this.grb_TrongTaiHienCo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_QuanLyDoiXeVinamilkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAINHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox grb_ThaoTac;
        private System.Windows.Forms.Button btn_TimLoaiNhanVien;
        private System.Windows.Forms.Button btn_XoaLoaiNhanVien;
        private System.Windows.Forms.TextBox txt_TenLoaiNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_SuaLoaiNhanVien;
        private System.Windows.Forms.Button btn_ThemLoaiNhanVien;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox grb_TrongTaiHienCo;
        private System.Windows.Forms.CheckBox chk_ChonTatCa;
        private System.Windows.Forms.Label label1;
        private Db_QuanLyDoiXeVinamilkDataSet db_QuanLyDoiXeVinamilkDataSet;
        private System.Windows.Forms.BindingSource lOAINHANVIENBindingSource;
        private GUI.Db_QuanLyDoiXeVinamilkDataSetTableAdapters.LOAI_NHAN_VIENTableAdapter lOAI_NHAN_VIENTableAdapter;
        private System.Windows.Forms.ListView lsv_DanhSachLoaiNhanVien;
        private System.Windows.Forms.ColumnHeader STT;
        private System.Windows.Forms.ColumnHeader tenloainhanvien;
    }
}