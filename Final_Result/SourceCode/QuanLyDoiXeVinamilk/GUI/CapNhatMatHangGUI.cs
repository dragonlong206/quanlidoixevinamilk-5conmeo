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
    public partial class CapNhatMatHangGUI : Form
    {
        public CapNhatMatHangGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin MatHang.
        private void CapNhatMatHangGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.MatHangDTO> lstMatHang = MatHangBUS.DocDanhSachMatHang(String.Empty);
                XuatDanhSachMatHang(lstMatHang);

                // Load danh sach LoaiHang.
                List<DTO.LoaiHangDTO> DanhSachLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(string.Empty);
                if (DanhSachLoaiHang.Count > 0)
                {
                    this.cbo_LoaiHang.DataSource = DanhSachLoaiHang;
                    this.cbo_LoaiHang.DisplayMember = "TenLoaiHang";
                    this.cbo_LoaiHang.ValueMember = "MaLoaiHang";
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachMatHang(List<MatHangDTO> lstMatHang)
        {
            lsv_DanhSachMatHang.Items.Clear();
            int nSoThuTu = 1;
            foreach (MatHangDTO aMatHang in lstMatHang)
            {
                lsv_DanhSachMatHang.Items.Add(TheHienListItem(nSoThuTu, aMatHang));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, MatHangDTO aMatHang)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aMatHang.TenMatHang);
            itemKetQua.SubItems.Add(aMatHang.SoLuong.ToString());
            itemKetQua.SubItems.Add(aMatHang.DonViTinh);
            itemKetQua.SubItems.Add(BUS.LoaiHangBUS.GetTenLoaiHang(aMatHang.MaLoai));
            itemKetQua.Tag = aMatHang;

            return itemKetQua;
        }

        private void lsv_DanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachMatHang.SelectedItems.Count > 0)
            {
                ListViewItem itemMatHang = lsv_DanhSachMatHang.SelectedItems[0];
                DTO.MatHangDTO aMatHang = (DTO.MatHangDTO)itemMatHang.Tag;
                XuatChiTietMatHang(aMatHang);
            }
        }

        private void XuatChiTietMatHang(DTO.MatHangDTO aMatHang)
        {
            txt_TenMatHang.Text = aMatHang.TenMatHang;
            txt_SoLuong.Text = aMatHang.SoLuong.ToString();
            txt_DonViTinh.Text = aMatHang.DonViTinh;
            cbo_LoaiHang.Text = BUS.LoaiHangBUS.GetTenLoaiHang(aMatHang.MaLoai);
        }
        #endregion

        #region Cap nhat MatHang.
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachMatHang.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemMatHang = lsv_DanhSachMatHang.SelectedItems[0];
                    DTO.MatHangDTO aMatHangTam = (DTO.MatHangDTO)itemMatHang.Tag;
                    DTO.MatHangDTO aMatHang = NhapMatHang();
                    if (aMatHang == null)
                        return; //khong lam gi ca.                                        
                    aMatHang.MaMatHang = aMatHangTam.MaMatHang;

                    if (BUS.MatHangBUS.CapNhatMatHang(aMatHang))
                    {
                        CapNhatMatHangGUI_Load(sender, e);
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

        private MatHangDTO NhapMatHang()
        {
            MatHangDTO aMatHang = new MatHangDTO();
            if (!KiemTraNhap())
                return null;

            #region Gan gia tri tu giao dien vao aMatHang
            aMatHang.TenMatHang = txt_TenMatHang.Text;
            aMatHang.SoLuong = int.Parse(txt_SoLuong.Text);
            aMatHang.DonViTinh = txt_DonViTinh.Text;
            aMatHang.MaLoai = int.Parse(cbo_LoaiHang.SelectedValue.ToString());
            #endregion

            return aMatHang;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_TenMatHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoLuong.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DonViTinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            #endregion

            return blnKetQua;
        }
        #endregion

        #region Tra cuu MatHang.
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<MatHangDTO> lstMatHang = MatHangBUS.DocDanhSachMatHang(strTieuChiTimKiem);
                XuatDanhSachMatHang(lstMatHang);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txt_TenMatHang_TimKiem.Text != String.Empty)
            {
                if (chk_TimChinhXac.CheckState == CheckState.Checked)
                    strTieuChiTimKiem = " Where TenMatHang = '" + txt_TenMatHang_TimKiem.Text + "'";
                else
                    strTieuChiTimKiem += " Where TenMatHang Like '%" + txt_TenMatHang_TimKiem.Text + "%'";
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
