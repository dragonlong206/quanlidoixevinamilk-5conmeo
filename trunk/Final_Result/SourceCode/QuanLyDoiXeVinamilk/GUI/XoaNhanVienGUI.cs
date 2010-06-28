using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class XoaNhanVienGUI : Form
    {
        public XoaNhanVienGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin NhanVien.
        private void XoaNhanVienGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.NhanVienDTO> lstNhanVien = BUS.NhanVienBUS.DocDanhSachNhanVien(String.Empty);
                XuatDanhSachNhanVien(lstNhanVien);
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

        #region Xoa NhanVien duoc chon.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachNhanVien.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemNhanVien in lsv_DanhSachNhanVien.CheckedItems)
                    {
                        NhanVienDTO aNhanVien = (NhanVienDTO)itemNhanVien.Tag;
                        if (NhanVienBUS.XoaNhanVien(aNhanVien))
                        {
                            lsv_DanhSachNhanVien.Items.Remove(itemNhanVien);
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
                if (lsv_DanhSachNhanVien.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemNhanVien in lsv_DanhSachNhanVien.SelectedItems)
                        {
                            NhanVienDTO aNhanVien = (NhanVienDTO)itemNhanVien.Tag;
                            if (NhanVienBUS.XoaNhanVien(aNhanVien))
                            {
                                lsv_DanhSachNhanVien.Items.Remove(itemNhanVien);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co nhan vien nao duoc chon");
            }
        }

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemNhanVien in lsv_DanhSachNhanVien.Items)
                {
                    itemNhanVien.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemNhanVien in lsv_DanhSachNhanVien.Items)
                {
                    itemNhanVien.Checked = false;
                }
            }
        }          
        #endregion

        #region Tra cuu NhanVien.
        private void btn_TimNhanVien_Click(object sender, EventArgs e)
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
            Close();
        }                                 
    }
}
