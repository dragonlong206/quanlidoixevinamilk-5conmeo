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
    public partial class LoaiDiaDiemGUI : Form
    {
        public LoaiDiaDiemGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin LoaiDiaDiem
        private void LoaiDiaDiemGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.LoaiDiaDiemDTO> lstLoaiDiaDiem = LoaiDiaDiemBUS.DocDanhSachLoaiDiaDiem(String.Empty);
                XuatDanhSachLoaiDiaDiem(lstLoaiDiaDiem);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachLoaiDiaDiem(List<DTO.LoaiDiaDiemDTO> lstLoaiDiaDiem)
        {
            lsv_DanhSachLoaiDiaDiem.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.LoaiDiaDiemDTO aLoaiDiaDiemTemp in lstLoaiDiaDiem)
            {
                lsv_DanhSachLoaiDiaDiem.Items.Add(TheHienListItem(nSoThuTu, aLoaiDiaDiemTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aLoaiDiaDiem.TenLoai.ToString());
            itemKetQua.SubItems.Add(aLoaiDiaDiem.MaLoai.ToString());
            itemKetQua.Tag = aLoaiDiaDiem;

            return itemKetQua;
        }

        private void lsv_DanhSachLoaiDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiDiaDiem.SelectedItems.Count > 0)
            {
                ListViewItem itemLoaiDiaDiem = lsv_DanhSachLoaiDiaDiem.SelectedItems[0];
                DTO.LoaiDiaDiemDTO aLoaiDiaDiem = (DTO.LoaiDiaDiemDTO)itemLoaiDiaDiem.Tag;
                XuatChiTietLoaiDiaDiem(aLoaiDiaDiem);
            }
        }

        private void XuatChiTietLoaiDiaDiem(DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            txt_TenLoaiDiaDiem.Text = aLoaiDiaDiem.TenLoai;
        }
        #endregion

        #region Them thong tin LoaiDiaDiem.
        private void btn_ThemLoaiDiaDiem_Click(object sender, EventArgs e)
        {
            DTO.LoaiDiaDiemDTO aLoaiDiaDiem = NhapLoaiDiaDiem();
            if (aLoaiDiaDiem == null)
                return; //khong lam gi ca.   
            
            try
            {
                if (BUS.LoaiDiaDiemBUS.ThemLoaiDiaDiem(aLoaiDiaDiem))
                {
                    LoaiDiaDiemGUI_Load(sender, e);
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

        private DTO.LoaiDiaDiemDTO NhapLoaiDiaDiem()
        {
            DTO.LoaiDiaDiemDTO aLoaiDiaDiem = new DTO.LoaiDiaDiemDTO();
            if (!KiemTraNhap())
                return null;
            
            aLoaiDiaDiem.TenLoai = txt_TenLoaiDiaDiem.Text;
            return aLoaiDiaDiem;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_TenLoaiDiaDiem.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            return blnKetQua;
        }
        #endregion 

        #region Xoa thong tin LoaiDiaDiem
        private void btn_XoaLoaiDiaDiem_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiDiaDiem.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemLoaiDiaDiem in lsv_DanhSachLoaiDiaDiem.CheckedItems)
                    {
                        DTO.LoaiDiaDiemDTO aLoaiDiaDiem = (DTO.LoaiDiaDiemDTO)itemLoaiDiaDiem.Tag;
                        if (BUS.LoaiDiaDiemBUS.XoaLoaiDiaDiem(aLoaiDiaDiem))
                        {
                            lsv_DanhSachLoaiDiaDiem.Items.Remove(itemLoaiDiaDiem);
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
                if (lsv_DanhSachLoaiDiaDiem.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemLoaiDiaDiem in lsv_DanhSachLoaiDiaDiem.SelectedItems)
                        {
                            DTO.LoaiDiaDiemDTO aLoaiDiaDiem = (DTO.LoaiDiaDiemDTO)itemLoaiDiaDiem.Tag;
                            if (BUS.LoaiDiaDiemBUS.XoaLoaiDiaDiem(aLoaiDiaDiem))
                            {
                                lsv_DanhSachLoaiDiaDiem.Items.Remove(itemLoaiDiaDiem);
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

        private void chk_ChonTatCa_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ChonTatCa.CheckState == CheckState.Checked)
            {
                foreach (ListViewItem itemLoaiDiaDiem in lsv_DanhSachLoaiDiaDiem.Items)
                {
                    itemLoaiDiaDiem.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemLoaiDiaDiem in lsv_DanhSachLoaiDiaDiem.Items)
                {
                    itemLoaiDiaDiem.Checked = false;
                }
            }
        }
        #endregion               

        #region Cap nhat thong tin LoaiDiaDiem
        private void btn_SuaLoaiDiaDiem_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachLoaiDiaDiem.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemLoaiDiaDiem = lsv_DanhSachLoaiDiaDiem.SelectedItems[0];
                    DTO.LoaiDiaDiemDTO aLoaiDiaDiemTam = (DTO.LoaiDiaDiemDTO)itemLoaiDiaDiem.Tag;
                    DTO.LoaiDiaDiemDTO aLoaiDiaDiem = NhapLoaiDiaDiem();
                    if (aLoaiDiaDiem == null)
                        return; //khong lam gi ca.                                        
                    aLoaiDiaDiem.MaLoai = aLoaiDiaDiemTam.MaLoai;

                    if (BUS.LoaiDiaDiemBUS.CapNhatLoaiDiaDiem(aLoaiDiaDiem))
                    {
                        LoaiDiaDiemGUI_Load(sender, e);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Chua co loai dia diem nao dc chon");
            }
        }
        #endregion                      

        #region Tra cuu LoaiDiaDiem
        private void btn_TimLoaiDiaDiem_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.LoaiDiaDiemDTO> lstLoaiDiaDiem = BUS.LoaiDiaDiemBUS.DocDanhSachLoaiDiaDiem(strTieuChiTimKiem);
                XuatDanhSachLoaiDiaDiem(lstLoaiDiaDiem);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            } 
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txt_TenLoaiDiaDiem.Text != String.Empty)
            {
                strTieuChiTimKiem += " Where TenLoai Like '%" + txt_TenLoaiDiaDiem.Text + "%'";
            }

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
