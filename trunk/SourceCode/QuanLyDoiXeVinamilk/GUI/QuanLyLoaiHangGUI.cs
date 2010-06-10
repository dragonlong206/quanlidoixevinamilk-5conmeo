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
    public partial class QuanLyLoaiHangGUI : Form
    {
        public QuanLyLoaiHangGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin LoaiHang.
        private void QuanLyLoaiHangGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.LoaiHangDTO> lstLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(String.Empty);
                XuatDanhSachLoaiHang(lstLoaiHang);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachLoaiHang(List<DTO.LoaiHangDTO> lstLoaiHang)
        {
            if (lstLoaiHang == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachLoaiHang.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.LoaiHangDTO aLoaiHangTemp in lstLoaiHang)
            {
                lsv_DanhSachLoaiHang.Items.Add(TheHienListItem(nSoThuTu, aLoaiHangTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.LoaiHangDTO aLoaiHang)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aLoaiHang.TenLoaiHang.ToString());            
            itemKetQua.SubItems.Add(aLoaiHang.MaLoaiHang.ToString());
            itemKetQua.Tag = aLoaiHang;

            return itemKetQua;
        }

        private void lsv_DanhSachLoaiHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiHang.SelectedItems.Count > 0)
            {
                ListViewItem itemLoaiHang = lsv_DanhSachLoaiHang.SelectedItems[0];
                DTO.LoaiHangDTO aLoaiHang = (DTO.LoaiHangDTO)itemLoaiHang.Tag;
                XuatChiTietLoaiHang(aLoaiHang);
            }
        }

        private void XuatChiTietLoaiHang(DTO.LoaiHangDTO aLoaiHang)
        {
            txt_TenLoaiHang.Text = aLoaiHang.TenLoaiHang.ToString();            
        }

        #endregion                

        #region Them thong tin LoaiHang.
        private void btn_ThemLoaiHang_Click(object sender, EventArgs e)
        {
            DTO.LoaiHangDTO aLoaiHang = NhapLoaiHang();
            if (aLoaiHang == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.LoaiHangBUS.ThemLoaihang(aLoaiHang))
                {
                    QuanLyLoaiHangGUI_Load(sender, e);
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

        private DTO.LoaiHangDTO NhapLoaiHang()
        {
            DTO.LoaiHangDTO aLoaiHang = new DTO.LoaiHangDTO();
            if (!KiemTraNhap())
                return null;

            aLoaiHang.TenLoaiHang = txt_TenLoaiHang.Text;              
           
            return aLoaiHang;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_TenLoaiHang.Text);            
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        #endregion

        #region Xoa thong tin LoaiHang.

        private void btn_XoaLoaiHang_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiHang.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemLoaiHang in lsv_DanhSachLoaiHang.CheckedItems)
                    {
                        DTO.LoaiHangDTO aLoaiHang = (DTO.LoaiHangDTO)itemLoaiHang.Tag;
                        if (BUS.LoaiHangBUS.XoaLoaiHang(aLoaiHang))
                        {
                            lsv_DanhSachLoaiHang.Items.Remove(itemLoaiHang);
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
                if (lsv_DanhSachLoaiHang.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemLoaiHang in lsv_DanhSachLoaiHang.SelectedItems)
                        {
                            DTO.LoaiHangDTO aLoaiHang = (DTO.LoaiHangDTO)itemLoaiHang.Tag;
                            if (BUS.LoaiHangBUS.XoaLoaiHang(aLoaiHang))
                            {
                                lsv_DanhSachLoaiHang.Items.Remove(itemLoaiHang);
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

        #endregion

        #region Sua thong tin LoaiHang.

        private void btn_SuaLoaiHang_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiHang.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemLoaiHang = lsv_DanhSachLoaiHang.SelectedItems[0];
                    DTO.LoaiHangDTO aLoaiHangTam = (DTO.LoaiHangDTO)itemLoaiHang.Tag;
                    DTO.LoaiHangDTO aLoaiHang = NhapLoaiHang();
                    if (aLoaiHang == null)
                        return; //khong lam gi ca.                                        
                    aLoaiHang.MaLoaiHang = aLoaiHangTam.MaLoaiHang;

                    if (BUS.LoaiHangBUS.CapNhatLoaiHang(aLoaiHang))
                    {
                        QuanLyLoaiHangGUI_Load(sender, e);
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

        #endregion

        #region Tra cuu thong tin LoaiHang
        private void btn_TimLoaiHang_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.LoaiHangDTO> lstLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(strTieuChiTimKiem);
                XuatDanhSachLoaiHang(lstLoaiHang);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }  
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;
            
            if (txt_TenLoaiHang.Text != String.Empty)
            {
                strTieuChiTimKiem += " Where TenLoai Like '%" + txt_TenLoaiHang.Text + "%'";                
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
