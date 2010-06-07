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
    public partial class frm_QuanLyTrongTai : Form
    {
        public frm_QuanLyTrongTai()
        {
            InitializeComponent();
        }
        #region Them Trong Tai
        private void btnThemTrongTai_Click(object sender, EventArgs e)
        {
            DTO.TrongTaiDTO aTrongTai = NhapTrongTai();
            if (aTrongTai == null)
                return; //khong lam gi ca.    
            try
            {
                String strThongBao = "Bi loi ghi du lieu: vui long kiem tra du lieu nhap";
                if (BUS.TrongTaiBUS.ThemTrongTai(aTrongTai))
                {
                    strThongBao = "Them trong tai moi thanh cong";
                }
                MessageBox.Show(strThongBao);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }

        }

        private DTO.TrongTaiDTO NhapTrongTai()
        {
            DTO.TrongTaiDTO aTrongTai = new DTO.TrongTaiDTO();
            if (!KiemTraNhap())  //Cac dong thong bao cu the duoc thuc hien trong KiemTraNhap()                          
                return null;

            try
            {
                aTrongTai.MaTrongTai = int.Parse(txt_MaTrongTai.Text);
                aTrongTai.GiaTri = int.Parse(txt_GiaTri.Text);
                aTrongTai.DonVi = txt_DonVi.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return null;
            }
            return aTrongTai;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_MaTrongTai.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_GiaTri.Text);
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
            if (lsv_DanhSachHienCo.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemTrongTai in lsv_DanhSachHienCo.CheckedItems)
                    {
                        DTO.TrongTaiDTO aTrongTai = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                        if (BUS.TrongTaiBUS.XoaTrongTai(aTrongTai))
                        {
                            lsv_DanhSachHienCo.Items.Remove(itemTrongTai);
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
                MessageBox.Show("Chua co trong tai nao duoc chon");
            }
        }
        #endregion

        #region Thoat
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Load: Xuat thong tin TrongTai
        private void frm_QuanLyTrongTai_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.TrongTaiDTO> lstTrongTai = TrongTaiBUS.DocDanhSachTrongTai();
                XuatDanhSachTrongTai(lstTrongTai);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachTrongTai(List<DTO.TrongTaiDTO> lstTrongTai)
        {
            DTO.TrongTaiDTO aTrongTai = lstTrongTai[0];
            if (aTrongTai != null)
            {
              //  XuatChiTietTrongTai(aTrongTai);
            }

            lsv_DanhSachHienCo.Items.Clear();
           foreach (DTO.TrongTaiDTO aTrongTaiTemp in lstTrongTai)
           {
                lsv_DanhSachHienCo.Items.Add(TheHienListItem(aTrongTaiTemp));
           }
        }
        private ListViewItem TheHienListItem(DTO.TrongTaiDTO aTrongTai)
        {
            ListViewItem itemKetQua = new ListViewItem(aTrongTai.MaTrongTai.ToString());
            itemKetQua.SubItems.Add(aTrongTai.GiaTri.ToString());
            itemKetQua.SubItems.Add(aTrongTai.DonVi.ToString());
            itemKetQua.Tag = aTrongTai;

            return itemKetQua;
        }

        private void lsv_DanhSachHienCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachHienCo.SelectedItems.Count > 0)
            {
                ListViewItem itemTrongTai = lsv_DanhSachHienCo.SelectedItems[0];
                DTO.TrongTaiDTO aTrongTai = (DTO.TrongTaiDTO)itemTrongTai.Tag;
                XuatChiTietTrongTai(aTrongTai);
            }
        }
        private void XuatChiTietTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            txt_MaTrongTai.Text = aTrongTai.MaTrongTai.ToString();
            txt_GiaTri.Text = aTrongTai.GiaTri.ToString();
            txt_DonVi.Text = aTrongTai.DonVi;
        }

        private void lbl_GiaTri_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void grb_TrongTaiHienCo_Enter(object sender, EventArgs e)
        {

        }

        #region Cap Nhat Trong Tai
        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }
        #endregion



    }
}
