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
    public partial class QuanLyThamSoGUI : Form
    {
        public QuanLyThamSoGUI()
        {
            InitializeComponent();
        }

        #region Xuat danh sach ThamSo.
        private void QuanLyThamSoGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.ThamSoDTO> lstThamSo = BUS.ThamSoBUS.DocDanhSachThamSo(String.Empty);
                XuatDanhSachThamSo(lstThamSo);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }       

        private void XuatDanhSachThamSo(List<DTO.ThamSoDTO> lstThamSo)
        {
            if (lstThamSo == null)
                return;     //khong lam gi ca.          

            lsv_DanhSachThamSo.Items.Clear();
            int nSoThuTu = 1;
            foreach (DTO.ThamSoDTO aThamSoTemp in lstThamSo)
            {
                lsv_DanhSachThamSo.Items.Add(TheHienListItem(nSoThuTu, aThamSoTemp));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, DTO.ThamSoDTO aThamSo)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aThamSo.TenThamSo);
            itemKetQua.SubItems.Add(aThamSo.GiaTri);
            itemKetQua.SubItems.Add(aThamSo.Ma.ToString());
            itemKetQua.Tag = aThamSo;

            return itemKetQua;
        }

        private void lsv_DanhSachThamSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachThamSo.SelectedItems.Count > 0)
            {
                ListViewItem itemThamSo = lsv_DanhSachThamSo.SelectedItems[0];
                DTO.ThamSoDTO aThamSo = (DTO.ThamSoDTO)itemThamSo.Tag;
                XuatChiTietThamSo(aThamSo);
            }
        }
       
        private void XuatChiTietThamSo(DTO.ThamSoDTO aThamSo)
        {
            txt_TenThamSo.Text = aThamSo.TenThamSo;
            txt_GiaTriThamSo.Text = aThamSo.GiaTri;
        }

        #endregion                              

        #region Them rang buoc (tham so).
        private void btn_ThemThamSo_Click(object sender, EventArgs e)
        {
            DTO.ThamSoDTO aThamSo = NhapThamSo();
            if (aThamSo == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.ThamSoBUS.ThemThamSo(aThamSo))
                {
                    QuanLyThamSoGUI_Load(sender, e);
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

        private DTO.ThamSoDTO NhapThamSo()
        {
            DTO.ThamSoDTO aThamSo = new DTO.ThamSoDTO();
            if (!KiemTraNhap())
                return null;

            aThamSo.TenThamSo = txt_TenThamSo.Text;
            aThamSo.GiaTri = txt_GiaTriThamSo.Text;

            return aThamSo;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_TenThamSo.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_GiaTriThamSo.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }

            return blnKetQua;
        }

        #endregion

        #region Xoa rang buoc.
        private void btn_XoaThamSo_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachThamSo.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemThamSo in lsv_DanhSachThamSo.CheckedItems)
                    {
                        DTO.ThamSoDTO aThamSo = (DTO.ThamSoDTO)itemThamSo.Tag;
                        if (BUS.ThamSoBUS.XoaThamSo(aThamSo))
                        {
                            lsv_DanhSachThamSo.Items.Remove(itemThamSo);
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
                if (lsv_DanhSachThamSo.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemThamSo in lsv_DanhSachThamSo.SelectedItems)
                        {
                            DTO.ThamSoDTO aThamSo = (DTO.ThamSoDTO)itemThamSo.Tag;
                            if (BUS.ThamSoBUS.XoaThamSo(aThamSo))
                            {
                                lsv_DanhSachThamSo.Items.Remove(itemThamSo);
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
                foreach (ListViewItem itemThamSo in lsv_DanhSachThamSo.Items)
                {
                    itemThamSo.Checked = true;
                }
            }
            else
            {
                foreach (ListViewItem itemThamSo in lsv_DanhSachThamSo.Items)
                {
                    itemThamSo.Checked = false;
                }
            }
        } 
       
        #endregion

        #region Sua thong tin rang buoc.
        private void btn_SuaThamSo_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachThamSo.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemThamSo = lsv_DanhSachThamSo.SelectedItems[0];
                    DTO.ThamSoDTO aThamSoTam = (DTO.ThamSoDTO)itemThamSo.Tag;
                    DTO.ThamSoDTO aThamSo = NhapThamSo();
                    if (aThamSo == null)
                        return; //khong lam gi ca.                                        
                    aThamSo.Ma = aThamSoTam.Ma;

                    if (BUS.ThamSoBUS.CapNhatThamSo(aThamSo))
                    {
                        QuanLyThamSoGUI_Load(sender, e);
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

        #region Tra cuu rang buoc.
        private void btn_TimThamSo_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<DTO.ThamSoDTO> lstThamSo = BUS.ThamSoBUS.DocDanhSachThamSo(strTieuChiTimKiem);
                XuatDanhSachThamSo(lstThamSo);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }         

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            if (txt_TenThamSo.Text != String.Empty)
            {
                strTieuChiTimKiem += " Where TenThamSo Like '%" + txt_TenThamSo.Text + "%'";
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
