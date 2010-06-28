using System;
using System.Collections;
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
    public partial class XoaXeGUI : Form
    {
        public XoaXeGUI()
        {
            InitializeComponent();
        }

        #region Load: Xuat thong tin xe.
        private void XoaXeGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.XeDTO> lstXe = XeBUS.DocDanhSachXe(String.Empty);
                XuatDanhSachXe(lstXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachXe(List<DTO.XeDTO> lstXe)
        {
            lsv_DanhSachXe.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.XeDTO aXeTam in lstXe)
            {
                lsv_DanhSachXe.Items.Add(TheHienListItem(nSoThuTu, aXeTam));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.XeDTO aXe)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aXe.BienSo);            
            itemKetQua.Tag = aXe;

            //Cac truong sau khong the hien ra, nhung luu lai vao ListView
            //De tien cho viec the hien thong tin chi tiet o cac TextBox.            
            itemKetQua.SubItems.Add(BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe));
            itemKetQua.SubItems.Add(BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan));
            itemKetQua.SubItems.Add(BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang));
            itemKetQua.SubItems.Add(BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai));
            itemKetQua.SubItems.Add(aXe.HieuXe);
            itemKetQua.SubItems.Add(aXe.NamSanXuat.ToString());
            itemKetQua.SubItems.Add(aXe.DungTichBinh.ToString());
            itemKetQua.SubItems.Add(aXe.DinhMuc.ToString());                     
            itemKetQua.SubItems.Add(aXe.NgayTiepNhan.ToString());
            itemKetQua.SubItems.Add(aXe.NgayDangKiem.ToString());
            itemKetQua.SubItems.Add(aXe.SoKhung);   
            itemKetQua.SubItems.Add(aXe.SoMay);   

            return itemKetQua;
        }

        private void lsv_DanhSachXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachXe.SelectedItems.Count > 0)
            {
                ListViewItem itemXe = lsv_DanhSachXe.SelectedItems[0];
                DTO.XeDTO aXe = (DTO.XeDTO)itemXe.Tag;
                XuatChiTietXe(aXe);
            }
        }

        private void XuatChiTietXe(DTO.XeDTO aXe)
        {
            txt_BienSo.Text = aXe.BienSo;
            txt_HangXe.Text = BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe);
            txt_NhanVien.Text = BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan);
            txt_LoaiHang.Text = BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang);
            txt_TrongTai.Text = BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai);
            txt_HieuXe.Text = aXe.HieuXe.ToString();            
            txt_NamSanXuat.Text = aXe.NamSanXuat.ToString();
            txt_DinhMucNhienLieu.Text = aXe.DinhMuc.ToString();
            txt_DungTichBinh.Text = aXe.DungTichBinh.ToString();                        
            txt_NgayDangKiem.Text = aXe.NgayDangKiem.ToString("MM/dd/yyyy");        
            txt_NgayTiepNhan.Text = aXe.NgayTiepNhan.ToString("MM/dd/yyyy");
            txt_SoKhung.Text = aXe.SoKhung;
            txt_SoMay.Text = aXe.SoMay;            
        }
        #endregion

        #region Xoa xe duoc chon.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachXe.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemXe in lsv_DanhSachXe.CheckedItems)
                    {
                        DTO.XeDTO aXe = (DTO.XeDTO)itemXe.Tag;
                        if (BUS.XeBUS.XoaXe(aXe))
                        {
                            lsv_DanhSachXe.Items.Remove(itemXe);
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
                if (lsv_DanhSachXe.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemXe in lsv_DanhSachXe.SelectedItems)
                        {
                            XeDTO aXe = (XeDTO)itemXe.Tag;
                            if (XeBUS.XoaXe(aXe))
                            {
                                lsv_DanhSachXe.Items.Remove(itemXe);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co xe nao duoc chon");
            }
        }
        #endregion

        #region Tra cuu xe theo BienSo.       

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.XeDTO> lstXe = BUS.XeBUS.DocDanhSachXe(strTieuChiTimKiem);
                XuatDanhSachXe(lstXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }   
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            Boolean blnKiemTra = false;
            if (txt_BienSo_TimKiem.Text != String.Empty)
            {
                strTieuChiTimKiem += " BienSo Like '%" + txt_BienSo_TimKiem.Text + "%'";
                blnKiemTra = true;
            }
            if (txt_HieuXe_TimKiem.Text != String.Empty)
            {
                if (blnKiemTra)
                    strTieuChiTimKiem += " And";
                strTieuChiTimKiem += " HieuXe Like '" + txt_HieuXe_TimKiem.Text + "%'";
                blnKiemTra = true;
            }
            if (cbo_HangXe_TimKiem.Text != String.Empty)
            {
                if (blnKiemTra)
                    strTieuChiTimKiem += " And";
                strTieuChiTimKiem += " MaHangXe = " + cbo_HangXe_TimKiem.SelectedValue.ToString();
                blnKiemTra = true;
            }
            if (blnKiemTra)
                strTieuChiTimKiem = " Where" + strTieuChiTimKiem;

            return strTieuChiTimKiem;
        }

        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemXe in lsv_DanhSachXe.Items)
                {
                    itemXe.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemXe in lsv_DanhSachXe.Items)
                {
                    itemXe.Checked = false;
                }
            }
        }                     
    }
}
