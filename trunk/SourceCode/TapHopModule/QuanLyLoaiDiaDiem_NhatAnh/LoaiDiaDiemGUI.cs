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
    public partial class frm_LoaiDiaDiem : Form
    {
        public frm_LoaiDiaDiem()
        {
            InitializeComponent();
        }

        #region Load
        private void lsv_DanhSachHienCo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachHienCo.SelectedItems.Count > 0)
            {
                ListViewItem itemLoaiDD = lsv_DanhSachHienCo.SelectedItems[0];
                DTO.LoaiDiaDiemDTO aLoaiDD = (DTO.LoaiDiaDiemDTO)itemLoaiDD.Tag;
                //  XuatChiTietLoaiDD(aLoaiDD);
            }
        }

        private void frm_LoaiDiaDiem_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.LoaiDiaDiemDTO> lstLoaiDD = LoaiDiaDiemBUS.DocDanhSachLoaiDD();
                XuatDanhSachLoaiDD(lstLoaiDD);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachLoaiDD(List<DTO.LoaiDiaDiemDTO> lstLoaiDD)
        {
            DTO.LoaiDiaDiemDTO aLoaiDD = lstLoaiDD[0];
            if (aLoaiDD != null)
            {
                //    XuatChiTietLoaiDD(aLoaiDD);
            }

            lsv_DanhSachHienCo.Items.Clear();
            foreach (DTO.LoaiDiaDiemDTO aLoaiDDTemp in lstLoaiDD)
            {
                lsv_DanhSachHienCo.Items.Add(TheHienListItem(aLoaiDDTemp));
            }
        }

        private ListViewItem TheHienListItem(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            ListViewItem itemKetQua = new ListViewItem(aLoaiDD.MaLoai.ToString());
            itemKetQua.SubItems.Add(aLoaiDD.TenLoai.ToString());

            itemKetQua.Tag = aLoaiDD;

            return itemKetQua;
        }

        private void XuatChiTietLoaiDD(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            txt_MaLoai.Text = aLoaiDD.MaLoai.ToString();
            txt_TenLoai.Text = aLoaiDD.TenLoai;
        }
        #endregion

        #region Delete
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachHienCo.CheckedItems.Count > 0)
            {
                try
                {
                    foreach (ListViewItem itemLoaiDD in lsv_DanhSachHienCo.CheckedItems)
                    {
                        DTO.LoaiDiaDiemDTO aLoaiDD = (DTO.LoaiDiaDiemDTO)itemLoaiDD.Tag;
                        if (BUS.LoaiDiaDiemBUS.XoaLoaiDD(aLoaiDD))
                        {
                            lsv_DanhSachHienCo.Items.Remove(itemLoaiDD);
                            MessageBox.Show("Xoa thanh cong");
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
                MessageBox.Show("Chua co loai dia diem nao duoc chon");
            }
        }
        #endregion

        #region Insert
        private void btn_Them_Click(object sender, EventArgs e)
        {
            DTO.LoaiDiaDiemDTO aLoaiDD = ThemLoaiDD();
            if (aLoaiDD == null)
                return; //khong lam gi ca.    
            try
            {
                String strThongBao = "Bi loi ghi du lieu: vui long kiem tra du lieu nhap";
                if (BUS.LoaiDiaDiemBUS.ThemLoaiDD(aLoaiDD))
                {
                    strThongBao = "Them loai dia diem moi thanh cong";
                }
                MessageBox.Show(strThongBao);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
            }

        }

        private DTO.LoaiDiaDiemDTO ThemLoaiDD()
        {
            DTO.LoaiDiaDiemDTO aLoaiDD = new DTO.LoaiDiaDiemDTO();
            if (!KiemTraNhap())
                return null;

            try
            {
                aLoaiDD.MaLoai = int.Parse(txt_MaLoai.Text);
                aLoaiDD.TenLoai = txt_TenLoai.Text;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                return null;
            }
            return aLoaiDD;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            blnKetQua &= !String.IsNullOrEmpty(txt_MaLoai.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_TenLoai.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }
            return blnKetQua;
        }
         #endregion

        #region Exit
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Update
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachHienCo.CheckedItems.Count > 0)
            {

                try
                {
                    foreach (ListViewItem itemLoaiDD in lsv_DanhSachHienCo.CheckedItems)
                    {
                        DTO.LoaiDiaDiemDTO aLoaiDD = (DTO.LoaiDiaDiemDTO)itemLoaiDD.Tag;
                        //LoaiDiaDiemDTO aLoaiDD = new LoaiDiaDiemDTO();
                        aLoaiDD.MaLoai = int.Parse(this.txt_MaLoai.Text.ToString());
                        aLoaiDD.TenLoai = this.txt_TenLoai.Text;
                        if (BUS.LoaiDiaDiemBUS.CapNhatLoaiDD(aLoaiDD))
                        {
                            MessageBox.Show("Da cap nhat");
                        }
                        else
                        {
                            MessageBox.Show("Fail!\r\nCheck EmployeeID,Please!", "Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch(Exception ex)
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
    }
}
