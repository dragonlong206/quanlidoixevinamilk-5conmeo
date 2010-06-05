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

            #region Doc cau truc bang tu DataBase.
            String strChuoiLoc = "Select * From XE ";
            //Khong ro vi sao cho nay ko thu thi duoc.
            //strChuoiLoc += "Where BIENSO=" + aXe.BienSo;  
            DataTable tblBang = DAO.XeDAO.Doc(strChuoiLoc);
            if (tblBang == null)
                return false;
            #endregion

            #region Cap nhat du lieu vao bang.
            DataRow rowDong;
            if (false) //(tblBang.Rows.Count > 0)
            {
                //Truong hop BienSo xe da ton tai => Xu ly them.                
                //return false;
            }
            else
            {
                rowDong = tblBang.NewRow();

                rowDong["BIENSO"] = aXe.BienSo;
                rowDong["NGAYTIEPNHAN"] = aXe.NgayTiepNhan;
                rowDong["NGAYDANGKIEM"] = aXe.NgayDangKiem;
                rowDong["NAMSANXUAT"] = aXe.NamSanXuat;
                rowDong["HIEUXE"] = aXe.HieuXe;
                rowDong["SOKHUNG"] = aXe.SoKhung;
                rowDong["SOMAY"] = aXe.SoMay;
                rowDong["DUNGTICHBINH"] = aXe.DungTichBinh;   
                rowDong["DINHMUC"] = aXe.DinhMuc;             
                rowDong["MAHANGXE"] = aXe.MaHangXe;                     
                rowDong["MATRONGTAI"] = aXe.MaTrongTai;                 
                rowDong["MALOAIHANG"] = aXe.MaLoaiHang;                 
                rowDong["MANHANVIENTIEPNHAN"] = aXe.MaNhanVienTiepNhan; 

                tblBang.Rows.Add(rowDong);
            }                        
            blnKetQua = DAO.XeDAO.Ghi(tblBang, "XE");
            #endregion

            return blnKetQua;
        }
    }
}
