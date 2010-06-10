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
    public partial class frm_CapNhatMatHang : Form
    {
        public frm_CapNhatMatHang()
        {
            InitializeComponent();
        }

        private void frm_CapNhatMatHang_Load(object sender, EventArgs e)
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

       
        private void XuatDanhSachMatHang(List<MatHangDTO> lstMH)
        {
            MatHangDTO aMH = lstMH[0];


            lsv_DanhSachMatHang.Items.Clear();
            int nSoThuTu = 1;
            foreach (MatHangDTO aMHTam in lstMH)
            {
                lsv_DanhSachMatHang.Items.Add(TheHienListItem(nSoThuTu,aMHTam));
                nSoThuTu++;
            }
        }
        private ListViewItem TheHienListItem(int STT,MatHangDTO aMH)
        {
            ListViewItem itemKetQua = new ListViewItem(STT.ToString());
            itemKetQua.SubItems.Add(aMH.MaMatHang.ToString());
            itemKetQua.SubItems.Add(aMH.TenMatHang);
            itemKetQua.SubItems.Add(aMH.SoLuong.ToString());
            itemKetQua.SubItems.Add(aMH.DonViTinh);
            itemKetQua.SubItems.Add(aMH.MaLoai.ToString());
            itemKetQua.Tag = aMH;

      
            return itemKetQua;
        }




       


        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            String strTieuChiTimKiem = NhapThamSoTimKiem();

            try
            {
                List<MatHangDTO> lstMH = MatHangBUS.DocDanhSachMatHang(strTieuChiTimKiem);
                XuatDanhSachMatHang(lstMH);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void lsv_DanhSachMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachMatHang.SelectedItems.Count > 0)
            {
                ListViewItem itemMH = lsv_DanhSachMatHang.SelectedItems[0];
                MatHangDTO aMH = (MatHangDTO)itemMH.Tag;

            }
        }



       
    }
}
