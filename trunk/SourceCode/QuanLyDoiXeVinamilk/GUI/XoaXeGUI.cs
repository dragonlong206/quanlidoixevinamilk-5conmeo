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
                List<DTO.XeDTO> lstXe = XeBUS.DocDanhSachXe();
                XuatDanhSachXe(lstXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }

        }

        private void XuatDanhSachXe(List<DTO.XeDTO> lstXe)
        {
            DTO.XeDTO aXe = lstXe[0];
            if (aXe != null)
            {
                XuatChiTietXe(aXe);
            }

            lsv_DanhSachXe.Items.Clear();
            foreach (DTO.XeDTO aXeTam in lstXe)
            {
                lsv_DanhSachXe.Items.Add(TheHienListItem(aXeTam));
            }
        }

        private ListViewItem TheHienListItem(DTO.XeDTO aXe)
        {
            ListViewItem itemKetQua = new ListViewItem(aXe.BienSo);
            itemKetQua.SubItems.Add(aXe.HieuXe);
            itemKetQua.Tag = aXe;

            //Cac truong sau khong the hien ra, nhung luu lai vao ListView
            //De tien cho viec the hien thong tin chi tiet o cac TextBox.
            itemKetQua.SubItems.Add(aXe.NgayTiepNhan.ToString());
            itemKetQua.SubItems.Add(aXe.NamSanXuat.ToString());
            itemKetQua.SubItems.Add(aXe.NgayDangKiem.ToString());
            itemKetQua.SubItems.Add(aXe.DungTichBinh.ToString());
            itemKetQua.SubItems.Add(aXe.DinhMuc.ToString());
            itemKetQua.SubItems.Add(aXe.SoKhung);
            itemKetQua.SubItems.Add(aXe.SoMay);
            itemKetQua.SubItems.Add(BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe));
            itemKetQua.SubItems.Add(BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang));
            itemKetQua.SubItems.Add(BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai));
            itemKetQua.SubItems.Add(BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan));

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
            txt_DinhMucNhienLieu.Text = aXe.DinhMuc.ToString();
            txt_DungTichBinh.Text = aXe.DungTichBinh.ToString();
            txt_HangXe.Text = BUS.HangXeBUS.GetTenHangXe(aXe.MaHangXe);
            txt_HieuXe.Text = aXe.HieuXe;
            txt_LoaiHang.Text = BUS.LoaiHangBUS.GetTenLoaiHang(aXe.MaLoaiHang);
            txt_NamSanXuat.Text = aXe.NamSanXuat.ToString();
            txt_NgayDangKiem.Text = aXe.NgayDangKiem.ToString();
            txt_NhanVien.Text = BUS.NhanVienBUS.GetTenNhanVien(aXe.MaNhanVienTiepNhan);
            txt_SoKhung.Text = aXe.SoKhung;
            txt_SoMay.Text = aXe.SoMay;
            txt_TrongTai.Text = BUS.TrongTaiBUS.GetTenTrongTai(aXe.MaTrongTai);
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
                MessageBox.Show("Chua co xe nao duoc chon");
            }
        }
        #endregion
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
