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
    public partial class QuanLyHangXeGUI : Form
    {
        public QuanLyHangXeGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin HangXe.

        private void QuanLyHangXeGUI_Load(object sender, EventArgs e)
        {
           try
            {
                List<HangXeDTO> lstHangXe = HangXeBUS.DocDanhSachHangXe(String.Empty);
                XuatDanhSachHangXe(lstHangXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void XuatDanhSachHangXe(List<HangXeDTO> lstHangXe)
        {
            if (lstHangXe == null)
                return;     //khong lam gi ca.
            
            lsv_DanhSachHangXe.Items.Clear();
            int nSoThuTu = 1;
            foreach (HangXeDTO aHangXeTam in lstHangXe)
            {
                lsv_DanhSachHangXe.Items.Add(TheHienListItem(nSoThuTu, aHangXeTam));
                nSoThuTu++;
            }
        }

        private ListViewItem TheHienListItem(int nSoThuTu, HangXeDTO aHangXe)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aHangXe.TenHang);
            itemKetQua.SubItems.Add(aHangXe.MaHang.ToString());
            itemKetQua.Tag = aHangXe;

            return itemKetQua;
        }

        private void lsv_DanhSachHangXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachHangXe.SelectedItems.Count > 0)
            {
                ListViewItem itemHangXe = lsv_DanhSachHangXe.SelectedItems[0];
                DTO.HangXeDTO aHangXe = (DTO.HangXeDTO)itemHangXe.Tag;
                XuatChiTietHangXe(aHangXe);
            }
        }

        private void XuatChiTietHangXe(DTO.HangXeDTO aHangXe)
        {
            txt_TenHang.Text = aHangXe.TenHang;            
        }

        #endregion

        #region Them HangXe

        private void btnThemHangXe_Click(object sender, EventArgs e)
        {
            DTO.HangXeDTO aHangXe = NhapHangXe();
            if (aHangXe == null)
                return; //khong lam gi ca.            

            try
            {                
                if (BUS.HangXeBUS.ThemHangXe(aHangXe))
                {                    
                    QuanLyHangXeGUI_Load(sender, e);
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

        private DTO.HangXeDTO NhapHangXe()
        {
            DTO.HangXeDTO aHangXe = new DTO.HangXeDTO();
            if (!KiemTraNhap())  
                return null;

            aHangXe.TenHang = txt_TenHang.Text;                            

            return aHangXe;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_TenHang.Text);           
            if (!blnKetQua)
            {
                MessageBox.Show("Vui long nhap ten hang xe truoc!");
                return blnKetQua;
            }            
            #endregion

            #region Kiem tra cac rang buoc.
            
            #endregion

            return blnKetQua;
        }

        #endregion

        #region Xoa HangXe

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(lsv_DanhSachHangXe.CheckedItems.Count>0)    
            {
                try
                {
                    foreach (ListViewItem itemHangXe in lsv_DanhSachHangXe.CheckedItems)
                    {
                        HangXeDTO aHangXe =(HangXeDTO) itemHangXe.Tag;
                        if (HangXeBUS.XoaHangXe(aHangXe))
                        {
                            lsv_DanhSachHangXe.Items.Remove(itemHangXe);                          
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
                if(lsv_DanhSachHangXe.SelectedItems.Count > 0)
                {
                    try
                    {
                        foreach (ListViewItem itemHangXe in lsv_DanhSachHangXe.SelectedItems)
                        {
                            HangXeDTO aHangXe = (HangXeDTO)itemHangXe.Tag;
                            if (HangXeBUS.XoaHangXe(aHangXe))
                            {
                                lsv_DanhSachHangXe.Items.Remove(itemHangXe);

                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Exception: " + ex.Message);
                    }
                }
                else
                    MessageBox.Show("Chua co hang xe nao duoc chon");
            }
        }

        #endregion

        #region Cap nhat HangXe.

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachHangXe.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemHangXe = lsv_DanhSachHangXe.SelectedItems[0];
                    HangXeDTO aHangXeTam = (HangXeDTO)itemHangXe.Tag;
                    HangXeDTO aHangXe = NhapHangXe();
                    if (aHangXe == null)
                        return; //khong lam gi ca.
                    aHangXe.MaHang = aHangXeTam.MaHang;

                    if (HangXeBUS.CapNhatHangXe(aHangXe))
                    {                        
                        QuanLyHangXeGUI_Load(sender, e);
                    }                    
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        #endregion

        #region Tra cuu HangXe.

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();            
            
            try
            {
                List<DTO.HangXeDTO> lstHangXe = BUS.HangXeBUS.DocDanhSachHangXe(strTieuChiTimKiem);
                XuatDanhSachHangXe(lstHangXe);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }                            
        }

        private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;
            
            if (txt_TenHang.Text != String.Empty)
            {
                strTieuChiTimKiem += " Where TenHang Like '%" + txt_TenHang.Text + "%'";                
            }            

            return strTieuChiTimKiem;
        }

        #endregion

        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }                       
    }
}
