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
    public partial class CapNhatThongTinNhanVienGUI : Form
    {
        public CapNhatThongTinNhanVienGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin NhanVien.
        private void CapNhatThongTinNhanVienGUI_Load(object sender, EventArgs e)
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

        private void lsv_DanhSachNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem itemNhanVien = lsv_DanhSachNhanVien.SelectedItems[0];
                DTO.NhanVienDTO aNhanVien = (DTO.NhanVienDTO)itemNhanVien.Tag;
                XuatChiTietNhanVien(aNhanVien);
            }
        }        

        private void XuatChiTietNhanVien(DTO.NhanVienDTO aNhanVien)
        {
            txt_TenNhanVien.Text = aNhanVien.TenNhanVien;
            cbo_LoaiNhanVien.Text = BUS.LoaiNhanVienBUS.GetTenLoaiNhanVien(aNhanVien.MaLoaiNhanVien);
            txt_DienThoai.Text = aNhanVien.SoDienThoai;
            dtp_NgayVaoCongTy.Text = aNhanVien.NgayVaoCongTy.ToString();
        }
        #endregion        

        #region Cap nhat thong tin NhanVien.
        private void btn_CapNhatNhanVien_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachNhanVien.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemNhanVien = lsv_DanhSachNhanVien.SelectedItems[0];
                    DTO.NhanVienDTO aNhanVienTam = (DTO.NhanVienDTO)itemNhanVien.Tag;
                    DTO.NhanVienDTO aNhanVien = NhapNhanVien();
                    if (aNhanVien == null)
                        return; //khong lam gi ca.                                        
                    aNhanVien.MaNhanVien = aNhanVienTam.MaNhanVien;

                    if (BUS.NhanVienBUS.CapNhatNhanVien(aNhanVien))
                    {
                        CapNhatThongTinNhanVienGUI_Load(sender, e);
                        ClearForm();
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co du lieu nao dc chon");
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

        private void ClearForm()
        {
            txt_TenNhanVien.Text = String.Empty;
            cbo_LoaiNhanVien.Text = String.Empty;
            txt_DienThoai.Text = String.Empty;
            dtp_NgayVaoCongTy.Text = String.Empty;
        }
        #endregion

        #region Tra cuu NhanVien.
        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.NhanVienDTO> lstNhanVien = BUS.NhanVienBUS.DocDanhSachNhanVien(strTieuChiTimKiem);
                XuatDanhSachNhanVien(lstNhanVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txt_TenNhanVien_TimKiem.Text != String.Empty)
            {
                if (chk_TimChinhXac.CheckState == CheckState.Checked)
                    strTieuChiTimKiem += " Where TenNhanVien = '" + txt_TenNhanVien_TimKiem.Text + "'";
                else
                    strTieuChiTimKiem += " Where TenNhanVien Like '%" + txt_TenNhanVien_TimKiem.Text + "%'";
            }

            return strTieuChiTimKiem;
        }

        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }                
    }
}
