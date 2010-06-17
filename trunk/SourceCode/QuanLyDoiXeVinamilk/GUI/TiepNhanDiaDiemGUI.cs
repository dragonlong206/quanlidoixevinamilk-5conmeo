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
    public partial class TiepNhanDiaDiemGUI : Form
    {
        public TiepNhanDiaDiemGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin DiaDiem.
        private void TiepNhanDiaDiemGUI_Load(object sender, EventArgs e)
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

        #region Tiep nhan DiaDiem.
        private void btn_ThemDiaDiem_Click(object sender, EventArgs e)
        {
            DTO.DiaDiemDTO aDiaDiem = NhapDiaDiem();
            if (aDiaDiem == null)
                return; //khong lam gi ca.  

            try
            {
                if (BUS.DiaDiemBUS.ThemDiaDiem(aDiaDiem))
                {
                    TiepNhanDiaDiemGUI_Load(sender, e);
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

        private DTO.DiaDiemDTO NhapDiaDiem()
        {
            DTO.DiaDiemDTO aDiaDiem = new DTO.DiaDiemDTO();
            if (!KiemTraNhap())
                return null;

            aDiaDiem.TenDiaDiem = txt_TenDiaDiem.Text;
            aDiaDiem.MaLoaiDiaDiem = BUS.LoaiDiaDiemBUS.GetMaLoaiDiaDiem(cbo_LoaiDiaDiem.Text);
            aDiaDiem.NguoiLienHe = txt_NguoiLienHe.Text;
            aDiaDiem.DiaChi = txt_DiaChi.Text;
            aDiaDiem.Email = String.Concat(txt_Email.Text, "@", cbo_Email.Text);
            aDiaDiem.DienThoai = txt_DienThoai.Text;
            aDiaDiem.ToaDo = BUS.DiaDiemBUS.GetToaDo(int.Parse(txt_ToaDoX.Text), int.Parse(txt_ToaDoY.Text));

            return aDiaDiem;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le
            //1. Kiem tra du lieu nhap phai day du:
            blnKetQua &= !String.IsNullOrEmpty(txt_TenDiaDiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiDiaDiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_NguoiLienHe.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DiaChi.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_Email.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DienThoai.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_ToaDoX.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_ToaDoY.Text);
            if (!blnKetQua)
            {
                MessageBox.Show("Du lieu nhap vao khong day du\r\nVui long kiem tra lai");
                return blnKetQua;
            }            

            //2. So chu so dien thoai phai thuoc pham vi tu 9 - 11 chu so.
            int nNumOfPhone = txt_DienThoai.Text.Length;
            blnKetQua &= (nNumOfPhone >= 9 && nNumOfPhone <= 11);
            if(!blnKetQua)
            {
                MessageBox.Show("So dien thoai chi duoc phep tu 9 - 11 chu so.");
                return blnKetQua;
            }

            //3. Kiem tra toa do thuoc pham vi 0 - 360.
            int nX = int.Parse(txt_ToaDoX.Text);
            int nY = int.Parse(txt_ToaDoY.Text);
            blnKetQua &= (nX >= 0 && nX <= 360);
            blnKetQua &= (nY >= 0 && nY <= 360);
            if(!blnKetQua)
            {
                MessageBox.Show("Toa do chi co gia tri tu 0 - 360");
                return blnKetQua;
            }
            #endregion

            #region Kiem tra rang buoc.
            //1. Kiem tra cac dia diem duoc tiep nhan phai thuoc mien Nam.
            //code here.
            #endregion

            return blnKetQua;
        }
        #endregion

        #region Huy thong tin da nhap.
        private void btn_Huy_Click(object sender, EventArgs e)
        {
            txt_TenDiaDiem.Text = String.Empty;
            cbo_LoaiDiaDiem.Text = String.Empty;
            txt_NguoiLienHe.Text = String.Empty;
            txt_DiaChi.Text = String.Empty;
            txt_Email.Text = String.Empty;
            txt_DienThoai.Text = String.Empty;
            txt_ToaDoX.Text = String.Empty;
            txt_ToaDoY.Text = String.Empty;
        }
        #endregion

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }               
    }
}
