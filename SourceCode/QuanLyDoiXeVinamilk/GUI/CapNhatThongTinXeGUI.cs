﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class CapNhatThongTinXeGUI : Form
    {
        public CapNhatThongTinXeGUI()
        {
            InitializeComponent();
        }        

        #region XuatThongTinXe

        private void CapNhatThongTinXeGUI_Load(object sender, EventArgs e)
        {
            try
            {                
                List<DTO.XeDTO> lstXe = BUS.XeBUS.DocDanhSachXe(String.Empty);                
                XuatDanhSachXe(lstXe);

                // Load tên hãng xe
                List<DTO.HangXeDTO> DanhSachHangXe = BUS.HangXeBUS.DocDanhSachHangXe(string.Empty);
                if (DanhSachHangXe.Count > 0)
                {
                    this.cbo_HangXe.DataSource = DanhSachHangXe;
                    this.cbo_HangXe.DisplayMember = "TenHang";
                    this.cbo_HangXe.ValueMember = "MaHang";
                }

                // Load loại hàng
                List<DTO.LoaiHangDTO> DanhSachLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(string.Empty);
                if (DanhSachLoaiHang.Count > 0)
                {
                    this.cbo_LoaiHang.DataSource = DanhSachLoaiHang;
                    this.cbo_LoaiHang.DisplayMember = "TenLoaiHang";
                    this.cbo_LoaiHang.ValueMember = "MaLoaiHang";
                }

                // Load nhân viên tiếp nhận
                List<DTO.NhanVienDTO> DanhSachNhanVien = BUS.NhanVienBUS.DocDanhSachNhanVien(String.Empty);
                if (DanhSachNhanVien.Count > 0)
                {
                    this.cbo_NhanVienTiepNhan.DataSource = DanhSachNhanVien;
                    this.cbo_NhanVienTiepNhan.DisplayMember = "TenNhanVien";
                    this.cbo_NhanVienTiepNhan.ValueMember = "MaNhanVien";
                }

                // Load loại trọng tải
                List<DTO.TrongTaiDTO> DanhSachTrongTai = BUS.TrongTaiBUS.DocDanhSachTrongTai(string.Empty);
                if (DanhSachTrongTai.Count > 0)
                {
                    this.cbo_TrongTai.DataSource = DanhSachTrongTai;
                    this.cbo_TrongTai.DisplayMember = "GiaTri";
                    this.cbo_TrongTai.ValueMember = "MaTrongTai";
                } 
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachXe(List<DTO.XeDTO> lstXe)
        {
            if (lstXe == null)
                return;     //khong lam gi ca.
            
            lsv_DanhSachXe.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.XeDTO aXeTam in lstXe)
            {
                lsv_DanhSachXe.Items.Add(TheHienListItem(nSoThuTu, aXeTam));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThucTu, DTO.XeDTO aXe)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThucTu.ToString());
            itemKetQua.SubItems.Add(aXe.BienSo);
            itemKetQua.SubItems.Add(BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe));
            itemKetQua.SubItems.Add(aXe.HieuXe);
            itemKetQua.SubItems.Add(BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang));
            itemKetQua.SubItems.Add(BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai));
            itemKetQua.SubItems.Add(BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan));
            itemKetQua.SubItems.Add(aXe.DinhMuc.ToString());
            itemKetQua.SubItems.Add(aXe.NgayTiepNhan.ToString());
            itemKetQua.SubItems.Add(aXe.NgayDangKiem.ToString());
            itemKetQua.SubItems.Add(aXe.NamSanXuat.ToString());            
            itemKetQua.SubItems.Add(aXe.DungTichBinh.ToString());            
            itemKetQua.SubItems.Add(aXe.SoKhung);
            itemKetQua.SubItems.Add(aXe.SoMay);                                                

            itemKetQua.Tag = aXe;

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
            cbo_HangXe.Text = BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe);
            cbo_LoaiHang.Text = BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang);
            cbo_TrongTai.Text = BUS.TrongTaiBUS.GetTrongTai(aXe.MaTrongTai).ToString();
            cbo_NhanVienTiepNhan.Text = BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan);
            dtp_NgayDangKiem.Text = aXe.NgayDangKiem.ToString();
            dtp_NgayTiepNhan.Text = aXe.NgayTiepNhan.ToString();
            txt_DungTichBinh.Text = aXe.DungTichBinh.ToString();            
            txt_DinhMucNhienLieu.Text = aXe.DinhMuc.ToString();            
            txt_HieuXe.Text = aXe.HieuXe;            
            txt_NamSanXuat.Text = aXe.NamSanXuat.ToString();                        
            txt_SoKhung.Text = aXe.SoKhung;
            txt_SoMay.Text = aXe.SoMay;            
        }

        #endregion       

        #region Luu Thong Tin Xe

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            DTO.XeDTO aXe = NhapXe();
            if (aXe == null)
                return; //khong lam gi ca.            

            try
            {                
                if (BUS.XeBUS.CapNhatXe(aXe))
                {                    
                    CapNhatThongTinXeGUI_Load(sender, e);
                    
                }                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }
        }

        private DTO.XeDTO NhapXe()
        {
            DTO.XeDTO aXe = new DTO.XeDTO();
            if (!KiemTraNhap())  //Cac dong thong bao cu the duoc thuc hien trong KiemTraNhap()                          
                return null;

            #region Gan gia tri tu giao dienvao aXe
            try
            {
                aXe.BienSo = txt_BienSo.Text;
                aXe.HieuXe = txt_HieuXe.Text;
                aXe.NgayTiepNhan = DateTime.Parse(dtp_NgayTiepNhan.Text);
                aXe.NgayDangKiem = DateTime.Parse(dtp_NgayDangKiem.Text);
                aXe.NamSanXuat = int.Parse(txt_NamSanXuat.Text);
                aXe.SoKhung = txt_SoKhung.Text;
                aXe.SoMay = txt_SoMay.Text;
                aXe.DungTichBinh = float.Parse(txt_DungTichBinh.Text);
                aXe.DinhMuc = float.Parse(txt_DinhMucNhienLieu.Text);
                aXe.MaHangXe = int.Parse(cbo_HangXe.SelectedValue.ToString());
                aXe.MaLoaiHang = int.Parse(cbo_LoaiHang.SelectedValue.ToString());
                aXe.MaNhanVienTiepNhan = int.Parse(cbo_NhanVienTiepNhan.SelectedValue.ToString());
                aXe.MaTrongTai = int.Parse(cbo_TrongTai.SelectedValue.ToString());
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return null;
            }
            #endregion

            return aXe;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_BienSo.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_HieuXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayTiepNhan.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayDangKiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_NamSanXuat.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoKhung.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoMay.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DungTichBinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DinhMucNhienLieu.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_HangXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_TrongTai.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_NhanVienTiepNhan.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            //KiemTra02: NgayDangKiem va NgayTiepNhan khong duoc vuot qua ngay hien tai.
            blnKetQua &= DateTime.Parse(dtp_NgayDangKiem.Text) <= DateTime.Today;
            blnKetQua &= DateTime.Parse(dtp_NgayTiepNhan.Text) <= DateTime.Today;
            if (!blnKetQua)
            {
                MessageBox.Show("Ngay Dang Kiem hoac Ngay Tiep Nhan vuot qua ngay hien tai");
                return blnKetQua;
            }
            #endregion

            #region Kiem tra cac rang buoc.
            //RangBuoc01: Chi nhap cac xe trong thoi gian cho phep (vi du 10 nam tro lai):
            int nNamSanXuat = int.Parse(txt_NamSanXuat.Text);
            int nSoNamToiDa = BUS.ThamSoBUS.GetSoNamToiDa();
            blnKetQua &= (DateTime.Today.Year - nNamSanXuat) <= nSoNamToiDa;
            if (!blnKetQua)
            {
                MessageBox.Show("Chi tiep nhan cac xe trong vong " + nSoNamToiDa + " nam tro lai.");
                return blnKetQua;
            }
            //RangBuoc02: DinhMucNhienLieu phai nho hon hoac bang Dung Tich Binh.
            blnKetQua &= float.Parse(txt_DinhMucNhienLieu.Text) <= float.Parse(txt_DungTichBinh.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Dinh Muc Nhien Lieu phai nho hon hoac bang Dung Tich Binh");
                return blnKetQua;
            }

            //RangBuoc03: NgayDangKiem phai nho hon hoac bang NgayTiepNhan.            
            blnKetQua &= DateTime.Parse(dtp_NgayDangKiem.Text) <= DateTime.Parse(dtp_NgayTiepNhan.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Ngay Dang Kiem phai nho hon hoac bang Ngay Tiep Nhan");
                return blnKetQua;
            }

            //RangBuoc04: Chi cho phep chon cac HangXe,NhanVien,... tu comboBox => Xy ly ve giao dien.            
            #endregion

            return blnKetQua;
        }

        #endregion

        #region Tra Cuu Xe

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
    }
}
