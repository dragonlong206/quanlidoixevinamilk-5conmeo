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
    public partial class NhapMatHangGUI : Form
    {
        public NhapMatHangGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin MatHang.
        private void NhapMatHangGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.MatHangDTO> lstMatHang = MatHangBUS.DocDanhSachMatHang(String.Empty);
                XuatDanhSachMatHang(lstMatHang);

                // Load danh sach LoaiHang.
                List<DTO.LoaiHangDTO> DanhSachLoaiHang = BUS.LoaiHangBUS.DocDanhSachLoaiHang(string.Empty);
                if (DanhSachLoaiHang.Count > 0)
                {
                    this.cbo_LoaiHang.DataSource = DanhSachLoaiHang;
                    this.cbo_LoaiHang.DisplayMember = "TenLoaiHang";
                    this.cbo_LoaiHang.ValueMember = "MaLoaiHang";
                }
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

        #region Nhap MatHang.
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            MatHangDTO aMatHang = NhapMatHang();
            if (aMatHang == null)
                return; //khong lam gi ca.

            try
            {

                if (MatHangBUS.ThemMatHang(aMatHang))
                {
                    NhapMatHangGUI_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }         

        private MatHangDTO NhapMatHang()
        {
            MatHangDTO aMatHang = new MatHangDTO();
            if (!KiemTraNhap())
                return null;

            #region Gan gia tri tu giao dien vao MatHang.
            aMatHang.TenMatHang = txt_TenMatHang.Text;
            aMatHang.SoLuong = int.Parse(txt_SoLuong.Text);
            aMatHang.DonViTinh = txt_DonViTinh.Text;
            aMatHang.MaLoai = int.Parse(cbo_LoaiHang.SelectedValue.ToString());
            #endregion

            return aMatHang;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            //KiemTra01: Kiem tra du lieu nhap co day du hay khong?
            blnKetQua &= !String.IsNullOrEmpty(txt_TenMatHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoLuong.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DonViTinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);           
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }            
            #endregion            

            return blnKetQua;
        }
        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }                     
    }
}
