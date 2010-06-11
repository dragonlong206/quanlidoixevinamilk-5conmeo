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
    public partial class XoaMatHangGUI : Form
    {
        public XoaMatHangGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin MatHang.
        private void XoaMatHangGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.MatHangDTO> lstMatHang = MatHangBUS.DocDanhSachMatHang(String.Empty);
                XuatDanhSachMatHang(lstMatHang);
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
        #endregion       

        #region Xoa MatHang duoc chon.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {            
            if (lsv_DanhSachMatHang.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemMatHang in lsv_DanhSachMatHang.CheckedItems)
                    {
                        MatHangDTO aMatHang = (MatHangDTO)itemMatHang.Tag;
                        if (MatHangBUS.XoaMatHang(aMatHang))
                        {
                            lsv_DanhSachMatHang.Items.Remove(itemMatHang);
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
                if (lsv_DanhSachMatHang.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemMatHang in lsv_DanhSachMatHang.SelectedItems)
                        {
                            MatHangDTO aMatHang = (MatHangDTO)itemMatHang.Tag;
                            if (MatHangBUS.XoaMatHang(aMatHang))
                            {
                                lsv_DanhSachMatHang.Items.Remove(itemMatHang);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co mat hang nao duoc chon");
            }
        }

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {            
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemMatHang in lsv_DanhSachMatHang.Items)
                {
                    itemMatHang.Checked = true;
                }                
            }       
            else
            {
                foreach (ListViewItem itemMatHang in lsv_DanhSachMatHang.Items)
                {
                    itemMatHang.Checked = false;
                }                
            }
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
                if(chk_TimChinhXac.CheckState == CheckState.Checked)
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
