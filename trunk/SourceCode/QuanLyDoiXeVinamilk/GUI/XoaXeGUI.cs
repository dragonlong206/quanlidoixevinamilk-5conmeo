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
            List<DTO.XeDTO> lstXe = XeBUS.DocDanhSachXe();
            XuatDanhSachXe(lstXe);
        }

        private void XuatDanhSachXe(List<DTO.XeDTO> lstXe)
        {
            DTO.XeDTO aXe = lstXe[0];
            if(aXe != null)
            {
                XuatChiTietXe(aXe);
            }

            lsv_DanhSachXe.Items.Clear();
            foreach(DTO.XeDTO aXeTam in lstXe)
            {
                lsv_DanhSachXe.Items.Add(TheHienListItem(aXeTam));                
            }
        }

        private ListViewItem TheHienListItem(DTO.XeDTO aXe)
        {
            ListViewItem itemKetQua = new ListViewItem(aXe.BienSo);
            itemKetQua.SubItems.Add(aXe.HieuXe);
            itemKetQua.Tag = aXe;   //Chu y neu thieu cai nay se khong xoa duoc.
            return itemKetQua;
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
            if(lsv_DanhSachXe.SelectedItems.Count > 0)
            {            
                try
                {
                    foreach (ListViewItem itemXe in lsv_DanhSachXe.SelectedItems)
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
        } 
        #endregion
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }                       
    }
}
