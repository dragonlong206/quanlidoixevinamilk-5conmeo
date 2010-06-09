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
    public partial class QuanLyTrongTaiGUI : Form
    {
        public QuanLyTrongTaiGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin TrongTai.

        private void QuanLyTrongTaiGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.TrongTaiDTO> lstTrongTai = TrongTaiBUS.DocDanhSachTrongTai(String.Empty);
                XuatDanhSachTrongTai(lstTrongTai);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachTrongTai(List<DTO.TrongTaiDTO> lstTrongTai)
        {
            if (lstTrongTai == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachTrongTai.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.TrongTaiDTO aTrongTaiTemp in lstTrongTai)
            {
                lsv_DanhSachTrongTai.Items.Add(TheHienListItem(nSoThuTu, aTrongTaiTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.TrongTaiDTO aTrongTai)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aTrongTai.GiaTri.ToString());
            itemKetQua.SubItems.Add(aTrongTai.DonVi.ToString());
            itemKetQua.SubItems.Add(aTrongTai.MaTrongTai.ToString());
            itemKetQua.Tag = aTrongTai;

            return itemKetQua;
        }

        private void lsv_DanhSachTrongTai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachTrongTai.SelectedItems.Count > 0)
            {
                ListViewItem itemTrongTai = lsv_DanhSachTrongTai.SelectedItems[0];
                DTO.TrongTaiDTO aTrongTai = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                XuatChiTietTrongTai(aTrongTai);
            }
        }

        private void XuatChiTietTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            txt_GiaTri.Text = aTrongTai.GiaTri.ToString();
            txt_DonVi.Text = aTrongTai.DonVi;
        }        

        #endregion

        #region Them Trong Tai
        private void btnThemTrongTai_Click(object sender, EventArgs e)
        {
            DTO.TrongTaiDTO aTrongTai = NhapTrongTai();
            if (aTrongTai == null)
                return; //khong lam gi ca.  
  
            try
            {                
                if (BUS.TrongTaiBUS.ThemTrongTai(aTrongTai))
                {
                    QuanLyTrongTaiGUI_Load(sender, e);
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

        private DTO.TrongTaiDTO NhapTrongTai()
        {
            DTO.TrongTaiDTO aTrongTai = new DTO.TrongTaiDTO();
            if (!KiemTraNhap())                            
                return null;

            try
            {                
                aTrongTai.GiaTri = int.Parse(txt_GiaTri.Text);
                aTrongTai.DonVi = txt_DonVi.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);                
            }
            return aTrongTai;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;
            
            blnKetQua &= !String.IsNullOrEmpty(txt_GiaTri.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DonVi.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }
        #endregion

        #region Xoa Trong Tai
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachTrongTai.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemTrongTai in lsv_DanhSachTrongTai.CheckedItems)
                    {
                        DTO.TrongTaiDTO aTrongTai = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                        if (BUS.TrongTaiBUS.XoaTrongTai(aTrongTai))
                        {
                            lsv_DanhSachTrongTai.Items.Remove(itemTrongTai);
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
                if (lsv_DanhSachTrongTai.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemTrongTai in lsv_DanhSachTrongTai.SelectedItems)
                        {
                            DTO.TrongTaiDTO aTrongTai = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                            if (BUS.TrongTaiBUS.XoaTrongTai(aTrongTai))
                            {
                                lsv_DanhSachTrongTai.Items.Remove(itemTrongTai);

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

        #region Cap Nhat Trong Tai
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachTrongTai.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemTrongTai = lsv_DanhSachTrongTai.SelectedItems[0];
                    DTO.TrongTaiDTO aTrongTaiTam = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                    DTO.TrongTaiDTO aTrongTai = NhapTrongTai();
                    if (aTrongTai == null)                    
                        return; //khong lam gi ca.                                        
                    aTrongTai.MaTrongTai = aTrongTaiTam.MaTrongTai;

                    if (BUS.TrongTaiBUS.CapNhatTrongTai(aTrongTai))
                    {
                        QuanLyTrongTaiGUI_Load(sender, e);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }
        #endregion

        #region Tra cuu Trong Tai.

        private void btn_TimTrongTai_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.TrongTaiDTO> lstTrongTai = BUS.TrongTaiBUS.DocDanhSachTrongTai(strTieuChiTimKiem);
                XuatDanhSachTrongTai(lstTrongTai);
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
            if (txt_GiaTri.Text != String.Empty)
            {
                strTieuChiTimKiem += " GiaTri = " + txt_GiaTri.Text;
                blnKiemTra = true;
            }
            if (txt_DonVi.Text != String.Empty)
            {
                if (blnKiemTra)
                    strTieuChiTimKiem += " And";
                strTieuChiTimKiem += " DonVi Like '" + txt_DonVi.Text + "%'";
                blnKiemTra = true;
            }
            if (blnKiemTra)
                strTieuChiTimKiem = " Where" + strTieuChiTimKiem;

            return strTieuChiTimKiem;
        }

        #endregion 

        #region Thoat
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion          
    }
}
