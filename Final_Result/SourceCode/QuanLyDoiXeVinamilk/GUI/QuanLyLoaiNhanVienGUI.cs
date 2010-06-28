using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class LoaiNhanVienGUI : Form
    {
        public LoaiNhanVienGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin LoaiNhanVien
        private void LoaiNhanVienGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.LoaiNhanVienDTO> lstLoaiNhanVien = LoaiNhanVienBUS.DocDanhSachLoaiNhanVien(String.Empty);
                XuatDanhSachLoaiNhanVien(lstLoaiNhanVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }      

        private void XuatDanhSachLoaiNhanVien(List<DTO.LoaiNhanVienDTO> lstLoaiNhanVien)
        {
            lsv_DanhSachLoaiNhanVien.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.LoaiNhanVienDTO aLoaiNhanVienTemp in lstLoaiNhanVien)
            {
                lsv_DanhSachLoaiNhanVien.Items.Add(TheHienListItem(nSoThuTu, aLoaiNhanVienTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aLoaiNhanVien.TenLoai.ToString());
            itemKetQua.SubItems.Add(aLoaiNhanVien.MaLoai.ToString());
            itemKetQua.Tag = aLoaiNhanVien;

            return itemKetQua;
        }

        private void lsv_DanhSachLoaiNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem itemLoaiNhanVien = lsv_DanhSachLoaiNhanVien.SelectedItems[0];
                DTO.LoaiNhanVienDTO aLoaiNhanVien = (DTO.LoaiNhanVienDTO)itemLoaiNhanVien.Tag;
                XuatChiTietLoaiNhanVien(aLoaiNhanVien);
            }
        }

        private void XuatChiTietLoaiNhanVien(DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            txt_TenLoaiNhanVien.Text = aLoaiNhanVien.TenLoai;
        }
        #endregion

        #region Them thong tin LoaiNhanVien.
        private void btn_ThemLoaiNhanVien_Click(object sender, EventArgs e)
        {
            DTO.LoaiNhanVienDTO aLoaiNhanVien = NhapLoaiNhanVien();
            if (aLoaiNhanVien == null)
                return; //khong lam gi ca.   

            try
            {
                if (BUS.LoaiNhanVienBUS.ThemLoaiNhanVien(aLoaiNhanVien))
                {
                    LoaiNhanVienGUI_Load(sender, e);
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

        private DTO.LoaiNhanVienDTO NhapLoaiNhanVien()
        {
            DTO.LoaiNhanVienDTO aLoaiNhanVien = new DTO.LoaiNhanVienDTO();
            if (!KiemTraNhap())
                return null;

            aLoaiNhanVien.TenLoai = txt_TenLoaiNhanVien.Text;
            return aLoaiNhanVien;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_TenLoaiNhanVien.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            return blnKetQua;
        }
        #endregion

        #region Xoa thong tin LoaiNhanVien
        private void btn_XoaLoaiNhanVien_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiNhanVien.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemLoaiNhanVien in lsv_DanhSachLoaiNhanVien.CheckedItems)
                    {
                        DTO.LoaiNhanVienDTO aLoaiNhanVien = (DTO.LoaiNhanVienDTO)itemLoaiNhanVien.Tag;
                        if (BUS.LoaiNhanVienBUS.XoaLoaiNhanVien(aLoaiNhanVien))
                        {
                            lsv_DanhSachLoaiNhanVien.Items.Remove(itemLoaiNhanVien);
                        }
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                if (lsv_DanhSachLoaiNhanVien.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemLoaiNhanVien in lsv_DanhSachLoaiNhanVien.SelectedItems)
                        {
                            DTO.LoaiNhanVienDTO aLoaiNhanVien = (DTO.LoaiNhanVienDTO)itemLoaiNhanVien.Tag;
                            if (BUS.LoaiNhanVienBUS.XoaLoaiNhanVien(aLoaiNhanVien))
                            {
                                lsv_DanhSachLoaiNhanVien.Items.Remove(itemLoaiNhanVien);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co du lieu nao duoc chon");
            }
        }

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemLoaiNhanVien in lsv_DanhSachLoaiNhanVien.Items)
                {
                    itemLoaiNhanVien.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemLoaiNhanVien in lsv_DanhSachLoaiNhanVien.Items)
                {
                    itemLoaiNhanVien.Checked = false;
                }
            }
        }           
        #endregion

        #region Cap nhat thong tin LoaiNhanVien
        private void btn_SuaLoaiNhanVien_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiNhanVien.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemLoaiNhanVien = lsv_DanhSachLoaiNhanVien.SelectedItems[0];
                    DTO.LoaiNhanVienDTO aLoaiNhanVienTam = (DTO.LoaiNhanVienDTO)itemLoaiNhanVien.Tag;
                    DTO.LoaiNhanVienDTO aLoaiNhanVien = NhapLoaiNhanVien();
                    if (aLoaiNhanVien == null)
                        return; //khong lam gi ca.                                        
                    aLoaiNhanVien.MaLoai = aLoaiNhanVienTam.MaLoai;

                    if (BUS.LoaiNhanVienBUS.CapNhatLoaiNhanVien(aLoaiNhanVien))
                    {
                        LoaiNhanVienGUI_Load(sender, e);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co loai nhan vien nao dc chon");
            }
        }
        #endregion

        #region Tra cuu LoaiNhanVien
        private void btn_TimLoaiNhanVien_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.LoaiNhanVienDTO> lstLoaiNhanVien = BUS.LoaiNhanVienBUS.DocDanhSachLoaiNhanVien(strTieuChiTimKiem);
                XuatDanhSachLoaiNhanVien(lstLoaiNhanVien);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txt_TenLoaiNhanVien.Text != String.Empty)
            {
                strTieuChiTimKiem += " Where TenLoai Like '%" + txt_TenLoaiNhanVien.Text + "%'";
            }

            return strTieuChiTimKiem;
        }
        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }                

        #region Thoat
        
        #endregion
    
    }
}
