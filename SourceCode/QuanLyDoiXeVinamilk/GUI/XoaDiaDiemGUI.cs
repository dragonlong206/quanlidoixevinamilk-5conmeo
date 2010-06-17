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
    public partial class XoaDiaDiemGUI : Form
    {
        public XoaDiaDiemGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin DiaDiem.
        private void XoaDiaDiemGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.DiaDiemDTO> lstDiaDiem = BUS.DiaDiemBUS.DocDanhSachDiaDiem(String.Empty);
                XuatDanhSachDiaDiem(lstDiaDiem);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }        

        private void XuatDanhSachDiaDiem(List<DTO.DiaDiemDTO> lstDiaDiem)
        {
            if (lstDiaDiem == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachDiaDiem.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.DiaDiemDTO aDiaDiemTemp in lstDiaDiem)
            {
                lsv_DanhSachDiaDiem.Items.Add(TheHienListItem(nSoThuTu, aDiaDiemTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.DiaDiemDTO aDiaDiem)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aDiaDiem.TenDiaDiem);
            itemKetQua.SubItems.Add(BUS.LoaiDiaDiemBUS.GetTenLoaiDiaDiem(aDiaDiem.MaLoaiDiaDiem));
            itemKetQua.SubItems.Add(aDiaDiem.DienThoai);
            itemKetQua.SubItems.Add(aDiaDiem.DiaChi);

            itemKetQua.SubItems.Add(aDiaDiem.NguoiLienHe);
            itemKetQua.SubItems.Add(aDiaDiem.Email);
            itemKetQua.SubItems.Add(aDiaDiem.ToaDo);
            itemKetQua.SubItems.Add(aDiaDiem.MaDiaDiem.ToString());
            itemKetQua.Tag = aDiaDiem;

            return itemKetQua;
        }       
        #endregion                                             

        #region Xoa DiaDiem duoc chon.
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachDiaDiem.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemDiaDiem in lsv_DanhSachDiaDiem.CheckedItems)
                    {
                        DiaDiemDTO aDiaDiem = (DiaDiemDTO)itemDiaDiem.Tag;
                        if (DiaDiemBUS.XoaDiaDiem(aDiaDiem))
                        {
                            lsv_DanhSachDiaDiem.Items.Remove(itemDiaDiem);
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
                if (lsv_DanhSachDiaDiem.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemDiaDiem in lsv_DanhSachDiaDiem.SelectedItems)
                        {
                            DiaDiemDTO aDiaDiem = (DiaDiemDTO)itemDiaDiem.Tag;
                            if (DiaDiemBUS.XoaDiaDiem(aDiaDiem))
                            {
                                lsv_DanhSachDiaDiem.Items.Remove(itemDiaDiem);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co dia diem nao duoc chon");
            }
        }

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemDiaDiem in lsv_DanhSachDiaDiem.Items)
                {
                    itemDiaDiem.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemDiaDiem in lsv_DanhSachDiaDiem.Items)
                {
                    itemDiaDiem.Checked = false;
                }
            }
        }         
        #endregion

        #region Tra cuu thong tin DiaDiem
        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.DiaDiemDTO> lstDiaDiem = BUS.DiaDiemBUS.DocDanhSachDiaDiem(strTieuChiTimKiem);
                XuatDanhSachDiaDiem(lstDiaDiem);
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
            if (txt_TenDiaDiem_TimKiem.Text != String.Empty)
            {
                if (chk_TimChinhXac.CheckState == CheckState.Checked)
                    strTieuChiTimKiem += " TenDiaDiem = '" + txt_TenDiaDiem_TimKiem.Text + "'";
                else
                    strTieuChiTimKiem += " TenDiaDiem Like '%" + txt_TenDiaDiem_TimKiem.Text + "%'";
                blnKiemTra = true;
            }
            if (txt_DiaChi_TimKiem.Text != String.Empty)
            {
                if (blnKiemTra)
                    strTieuChiTimKiem += " And";
                if (chk_TimChinhXac.CheckState == CheckState.Checked)
                    strTieuChiTimKiem += " DiaChi = '" + txt_DiaChi_TimKiem.Text + "'";
                else
                    strTieuChiTimKiem += " DiaChi Like '%" + txt_DiaChi_TimKiem.Text + "%'";
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
