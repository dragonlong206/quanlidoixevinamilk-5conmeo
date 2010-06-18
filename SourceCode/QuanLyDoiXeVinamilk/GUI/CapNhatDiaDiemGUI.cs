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
    public partial class CapNhatDiaDiemGUI : Form
    {
        public CapNhatDiaDiemGUI()
        {
            InitializeComponent();
        }

        #region Xuat thong tin DiaDiem. 
        private void CapNhatDiaDiemGUI_Load(object sender, EventArgs e)
        {
            try
            {
                List<DTO.DiaDiemDTO> lstDiaDiem = BUS.DiaDiemBUS.DocDanhSachDiaDiem(String.Empty);
                XuatDanhSachDiaDiem(lstDiaDiem);

                // Load loại địa điểm
                List<LoaiDiaDiemDTO> DanhSachDiaDiem = LoaiDiaDiemBUS.LayDanhSachTatCaLoaiDiaDiem();
                if (DanhSachDiaDiem.Count > 0)
                {
                    this.cbo_LoaiDiaDiem.DataSource = DanhSachDiaDiem;
                    this.cbo_LoaiDiaDiem.DisplayMember = "TenLoai";
                    this.cbo_LoaiDiaDiem.ValueMember = "MaLoai";
                }

                // Load tên miền email
                List<TenMienEmailDTO> DanhSachTenMienEmail = TenMienEmailBUS.LayDanhSachTenMien();
                if (DanhSachTenMienEmail.Count > 0)
                {
                    this.cbo_Email.DataSource = DanhSachTenMienEmail;
                    this.cbo_Email.DisplayMember = "TenMien";
                    this.cbo_Email.ValueMember = "Ma";
                }
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

        private void lsv_DanhSachDiaDiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsv_DanhSachDiaDiem.SelectedItems.Count > 0)
            {
                ListViewItem itemDiaDiem = lsv_DanhSachDiaDiem.SelectedItems[0];
                DTO.DiaDiemDTO aDiaDiem = (DTO.DiaDiemDTO)itemDiaDiem.Tag;
                XuatChiTietDiaDiem(aDiaDiem);
            }
        }        

        private void XuatChiTietDiaDiem(DTO.DiaDiemDTO aDiaDiem)
        {
            txt_TenDiaDiem.Text = aDiaDiem.TenDiaDiem.ToString();
            cbo_LoaiDiaDiem.Text = BUS.LoaiDiaDiemBUS.GetTenLoaiDiaDiem(aDiaDiem.MaLoaiDiaDiem);
            txt_NguoiLienHe.Text = aDiaDiem.NguoiLienHe;
            txt_DiaChi.Text = aDiaDiem.DiaChi;
            String[] strEmail = aDiaDiem.Email.Split('@');
            txt_Email.Text = strEmail[0];
            cbo_Email.Text = strEmail[1];
            txt_DienThoai.Text = aDiaDiem.DienThoai;
            String strToaDoTam = aDiaDiem.ToaDo.Trim('(', ')');
            String[] strToaDo = strToaDoTam.Split(',');
            txt_ToaDoX.Text = strToaDo[0];
            txt_ToaDoY.Text = strToaDo[1];
        }
        #endregion                                     

        #region Cap nhat thong tin DiaDiem.
        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (lsv_DanhSachDiaDiem.SelectedItems.Count > 0)
            {
                try
                {
                    ListViewItem itemDiaDiem = lsv_DanhSachDiaDiem.SelectedItems[0];
                    DTO.DiaDiemDTO aDiaDiemTam = (DTO.DiaDiemDTO)itemDiaDiem.Tag;
                    DTO.DiaDiemDTO aDiaDiem = NhapDiaDiem();
                    if (aDiaDiem == null)
                        return; //khong lam gi ca.                                        
                    aDiaDiem.MaDiaDiem = aDiaDiemTam.MaDiaDiem;

                    if (BUS.DiaDiemBUS.CapNhatDiaDiem(aDiaDiem))
                    {
                        CapNhatDiaDiemGUI_Load(sender, e);
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

        private DTO.DiaDiemDTO NhapDiaDiem()
        {
            DTO.DiaDiemDTO aDiaDiem = new DTO.DiaDiemDTO();
            if (!KiemTraNhap())
                return null;

            aDiaDiem.TenDiaDiem = txt_TenDiaDiem.Text;
            aDiaDiem.MaLoaiDiaDiem = int.Parse(cbo_LoaiDiaDiem.SelectedValue.ToString());
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
            if (!blnKetQua)
            {
                MessageBox.Show("So dien thoai chi duoc phep tu 9 - 11 chu so.");
                return blnKetQua;
            }

            //3. Kiem tra toa do thuoc pham vi 0 - 360.
            int nX = int.Parse(txt_ToaDoX.Text);
            int nY = int.Parse(txt_ToaDoY.Text);
            blnKetQua &= (nX >= 0 && nX <= 360);
            blnKetQua &= (nY >= 0 && nY <= 360);
            if (!blnKetQua)
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
