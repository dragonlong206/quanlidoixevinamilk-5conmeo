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
    public partial class frm_XoaMatHang : Form
    {
        public frm_XoaMatHang()
        {
            InitializeComponent();
        }

        private void frm_XoaMatHang_Load(object sender, EventArgs e)
        {

        }
          private String NhapThamSoTimKiem()
        {
            String strTieuChiTimKiem = String.Empty;

            Boolean blnKiemTra = false;
            if (txt_TenMatHang_TimKiem.Text != String.Empty)
            {
                strTieuChiTimKiem += " TenMatHang Like '%" + txt_TenMatHang_TimKiem.Text + "%'";

                blnKiemTra = true;
            }
           
            if (blnKiemTra)
                strTieuChiTimKiem = " Where" + strTieuChiTimKiem;

            return strTieuChiTimKiem;
        }

          private void btn_TimKiem_Click(object sender, EventArgs e)
          {
             
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<MatHangDTO> lstMH =MatHangBUS.DocDanhSachMatHang(strTieuChiTimKiem);
                XuatDanhSachMatHang(lstMH);
                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }   
       

          }
          private void XuatDanhSachMatHang(List<MatHangDTO> lstMH)
          {
              MatHangDTO aMH = lstMH[0];
              

              lsv_DanhSachMatHang.Items.Clear();
              int nSoThuTu = 1;
              foreach (MatHangDTO aMHTam in lstMH)
              {
                  lsv_DanhSachMatHang.Items.Add(TheHienListItem(nSoThuTu, aMHTam));
                  nSoThuTu++;
              }
          }
        private ListViewItem TheHienListItem(int nSoThuTu, MatHangDTO aMH)
        {
            ListViewItem itemKetQua = new ListViewItem(nSoThuTu.ToString());
            itemKetQua.SubItems.Add(aMH.TenMatHang);            
            itemKetQua.Tag = aMH;

            //Cac truong sau khong the hien ra, nhung luu lai vao ListView
            //De tien cho viec the hien thong tin chi tiet o cac TextBox.            
            return itemKetQua;
        }


       

        private void lsv_DanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
        if (lsv_DanhSachMatHang.SelectedItems.Count > 0)
            {
                ListViewItem itemMH = lsv_DanhSachMatHang.SelectedItems[0];
               MatHangDTO aMH = (MatHangDTO)itemMH.Tag;
               
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if(lsv_DanhSachMatHang.CheckedItems.Count>0)
           
            {
                try
                {
                    foreach (ListViewItem itemMH in lsv_DanhSachMatHang.CheckedItems)
                    {
                        MatHangDTO aMH = (MatHangDTO)itemMH.Tag;
                        if (MatHangBUS.XoaMatHang(aMH))
                        {
                            lsv_DanhSachMatHang.Items.Remove(itemMH);
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
                MessageBox.Show("Chua co mat hang nao duoc chon");
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

     
    }
}
