using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhapNhanVienGUI : Form
    {
        public NhapNhanVienGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin NhanVien.
        private void NhapNhanVienGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.NhanVienDTO> lstNhanVien = BUS.NhanVienBUS.DocDanhSachNhanVien(String.Empty);
                XuatDanhSachNhanVien(lstNhanVien);

                // Load danh sach loai nhan vien.
                List<DTO.LoaiNhanVienDTO> DanhSachLoaiNhanVien = BUS.LoaiNhanVienBUS.DocDanhSachLoaiNhanVien(string.Empty);
                if (DanhSachLoaiNhanVien.Count > 0)
                {
                    this.cbo_LoaiNhanVien.DataSource = DanhSachLoaiNhanVien;
                    this.cbo_LoaiNhanVien.DisplayMember = "TenLoai";
                    this.cbo_LoaiNhanVien.ValueMember = "MaLoai";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private void XuatDanhSachNhanVien(List<DTO.NhanVienDTO> lstNhanVien)
        {
            if (lstNhanVien == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachNhanVien.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.NhanVienDTO aNhanVienTemp in lstNhanVien)
            {
                lsv_DanhSachNhanVien.Items.Add(TheHienListItem(nSoThuTu, aNhanVienTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.NhanVienDTO aNhanVien)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aNhanVien.TenNhanVien);
            itemKetQua.SubItems.Add(BUS.LoaiNhanVienBUS.GetTenLoaiNhanVien(aNhanVien.MaLoaiNhanVien));
            itemKetQua.SubItems.Add(aNhanVien.SoDienThoai);
            itemKetQua.SubItems.Add(aNhanVien.NgayVaoCongTy.ToString());
            itemKetQua.Tag = aNhanVien;

            return itemKetQua;
        }
        #endregion                                             

        #region Nhap NhanVien.
        private void btn_NhapNhanVien_Click(object sender, EventArgs e)
        {
            DTO.NhanVienDTO aNhanVien = NhapNhanVien();
            if (aNhanVien == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.NhanVienBUS.ThemNhanVien(aNhanVien))
                {
                    NhapNhanVienGUI_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Vui long kiem tra du lieu nhap");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private DTO.NhanVienDTO NhapNhanVien()
        {
            DTO.NhanVienDTO aNhanVien = new DTO.NhanVienDTO();
            if (!KiemTraNhap())
                return null;

            aNhanVien.TenNhanVien = txt_TenNhanVien.Text;
            aNhanVien.MaLoaiNhanVien = int.Parse(cbo_LoaiNhanVien.SelectedValue.ToString());
            aNhanVien.SoDienThoai = txt_DienThoai.Text;
            aNhanVien.NgayVaoCongTy = DateTime.Parse(dtp_NgayVaoCongTy.Text);

            return aNhanVien;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le
            //Kiem tra du lieu nhap phai day du:
            blnKetQua &= !String.IsNullOrEmpty(txt_TenNhanVien.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiNhanVien.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DienThoai.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayVaoCongTy.Text);           
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            #endregion

            return blnKetQua;
        }
        #endregion

        #region Huy thong tin da nhap
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenNhanVien.Text = String.Empty;
            cbo_LoaiNhanVien.Text = String.Empty;
            txt_DienThoai.Text = String.Empty;
            dtp_NgayVaoCongTy.Text = String.Empty;
        }
        #endregion

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }              
    }
}
