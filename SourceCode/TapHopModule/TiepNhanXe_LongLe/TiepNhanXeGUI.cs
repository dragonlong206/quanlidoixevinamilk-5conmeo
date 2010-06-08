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
    public partial class TiepNhanXeGUI : Form
    {
        public TiepNhanXeGUI()
        {
            InitializeComponent();
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
        //    DTO.XeDTO aXe = NhapXe();
        //    if (aXe == null)
        //        return; //khong lam gi ca.            

        //    String strThongBao = "Loi at TienNhanXeGui.cs/btn_Luu_Click";
        //    if (BUS.XeBUS.GhiXe(aXe))
        //    {
        //        strThongBao = "Tiep nhan xe thanh cong";
        //    }
        //    MessageBox.Show(strThongBao);
            if (!KiemTraNhap())
            {
                //MessageBox.Show("Loi at TiepNhanXeGUI.cs\\NhapXe: KiemTraNhap = false");
                DialogResult luaChon = MessageBox.Show("Dữ liệu nhập chưa đầy đủ\r\n Bạn có muốn tiếp tục",
                    "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (luaChon == DialogResult.No)
                {
                    return;
                }
            }

            XeDTO aXe = NhapXe();

            try
            {
                Boolean blnLaBienSoHopLe = XeBUS.KiemTraBienSoXe(aXe.BienSo);
                if (blnLaBienSoHopLe == true)
                {
                    MessageBox.Show("Xe có biển số " + aXe.BienSo + " đã có trong CSDL");
                    return;
                }
                else
                {
                    Boolean blnDaThemDuoc = XeBUS.ThemXe(aXe);
                    if (blnDaThemDuoc == true)
                    {
                        MessageBox.Show("Thêm xe thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private DTO.XeDTO NhapXe()
        {
            DTO.XeDTO aXe = new DTO.XeDTO();           

            #region Gan gia tri tu giao dienvao aXe
            // Chỗ này thường hiếm khi xảy ra Exception nên khỏi try catch cũng được
            //try
            //{
            aXe.BienSo = txt_BienSo.Text;
            aXe.HieuXe = txt_HieuXe.Text;
            aXe.NgayTiepNhan = DateTime.Parse(dtp_NgayTiepNhan.Text);
            aXe.NgayDangKiem = DateTime.Parse(dtp_NgayDangKiem.Text);
            aXe.NamSanXuat = int.Parse(txt_NamSanXuat.Text);
            aXe.SoKhung = txt_SoKhung.Text;
            aXe.SoMay = txt_SoMay.Text;
            aXe.DungTichBinh = double.Parse(txt_DungTichBinh.Text);
            aXe.DinhMuc = double.Parse(txt_DinhMucNhienLieu.Text);
            //aXe.MaHangXe = BUS.HangXeBUS.GetMaHangXe(cbo_HangXe.Text);                //Sua truy xuat qua CSDL
            //aXe.MaTrongTai = BUS.TrongTaiBUS.GetMaTrongTai(cbo_TrongTai.Text);        //Sua truy xuat qua CSDL
            //aXe.MaLoaiHang = BUS.LoaiHangBUS.GetMaLoaiHang(cbo_LoaiHang.Text);        //Sua truy xuat qua CSDL
            aXe.MaHangXe = this.cbo_HangXe.SelectedIndex;               // index này khi load lên mình sẽ gán
            aXe.MaLoaiHang = this.cbo_LoaiHang.SelectedIndex;
            aXe.MaNhanVienTiepNhan = this.cbo_NhanVienTiepNhan.SelectedIndex;
            aXe.MaTrongTai = this.cbo_TrongTai.SelectedIndex;
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show("Loi at TiepNhanXeGui.cs\\NhapXe " + ex.Message);
            //    return null;
            //}
            #endregion

            return aXe;
        }

        private bool KiemTraNhap()
        {
            bool blnKetQua = true;

            #region Kiem tra tinh hop le.
            blnKetQua &= !String.IsNullOrEmpty(txt_BienSo.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_HieuXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayTiepNhan.Text);
            blnKetQua &= !String.IsNullOrEmpty(dtp_NgayDangKiem.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_NamSanXuat.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoKhung.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_SoMay.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DungTichBinh.Text);
            blnKetQua &= !String.IsNullOrEmpty(txt_DinhMucNhienLieu.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_HangXe.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_TrongTai.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_LoaiHang.Text);
            blnKetQua &= !String.IsNullOrEmpty(cbo_NhanVienTiepNhan.Text);
            #endregion

            #region Kiem tra cac rang buoc.
            if (blnKetQua)
            {
                //RangBuoc01: Chi nhap cac xe trong thoi gian cho phep (vi du 10 nam tro lai):
                int nNamSanXuat = int.Parse(txt_NamSanXuat.Text);
                int nSoNamToiDa = BUS.ThamSoBUS.GetSoNamToiDa();
                blnKetQua &= (DateTime.Today.Year - nNamSanXuat) <= nSoNamToiDa; //Xu ly them cho truy xuat CSDL.
                if (!blnKetQua)
                {
                    MessageBox.Show("Chi tiep nhan cac xe trong vong " + nSoNamToiDa + " nam tro lai.");
                }
            }
            #endregion

            return blnKetQua;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
