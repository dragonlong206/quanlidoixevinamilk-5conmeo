using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace BUS
{
    public class XeBUS
    {        
        public static bool GhiXe(DTO.XeDTO aXe)
        {
            bool blnKetQua = true;

            #region Doc DuLieu tu bang XE
            String strChuoiLoc = "Select * From XE ";
            strChuoiLoc += "Where BIENSO = " + aXe.BienSo;
            DataTable tblBang = DAO.XeDAO.Doc(strChuoiLoc);
            
            DataRow rowDong;
            if (tblBang.Rows.Count == 1)
            {
                rowDong = tblBang.Rows[0];
            }
            else
            {
                rowDong = tblBang.NewRow();
                tblBang.Rows.Add(rowDong);
            }
            return false;
            #endregion

            #region Cap nhat DuLieu vao bang
            rowDong["BIENSO"] = aXe.BienSo;
            rowDong["NGAYTIEPNHAN"] = aXe.NgayTiepNhan;
            rowDong["NGAYDANGKIEM"] = aXe.NgayDangKiem;
            rowDong["NAMSANXUAT"] = aXe.NamSanXuat;
            rowDong["HIEUXE"] = aXe.HieuXe;
            rowDong["SOKHUNG"] = aXe.SoKhung;
            rowDong["SOMAY"] = aXe.SoMay;
            //rowDong["DUNGTICHBINH"] = aXe.DungTichBinh;   //CSDL chua co.
            //rowDong["DINHMUC"] = aXe.DinhMuc;             //CSDL chua co.
            rowDong["MAHANGXE"] = aXe.MaHangXe;                     //Chua co du lieu nhap
            rowDong["MATRONGTAI"] = aXe.MaTrongTai;                 //Chua co du lieu nhap
            rowDong["MALOAIHANG"] = aXe.MaLoaiHang;                 //Chua co du lieu nhap
            rowDong["MANHANVIENTIEPNHAN"] = aXe.MaNhanVienTiepNhan; //Chua co du lieu nhap

            blnKetQua = DAO.XeDAO.Ghi(tblBang, "XE");
            #endregion

            return blnKetQua;
        }
    }
}
