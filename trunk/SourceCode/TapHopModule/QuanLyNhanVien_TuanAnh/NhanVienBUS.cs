using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
using System.Data.OleDb;
using System.Data;


namespace BUS
{
    public class NhanVienBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaNhanVien(String strTenNhanVien)
        {
            switch(strTenNhanVien)
            {
                case "Bùi Kim Hoa":
                    return 1;
                case "Nguyễn Anh":
                    return 2;
                case "Nguyễn Khuyến":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenNhanVien(int nMaNhanVien)
        {
            switch(nMaNhanVien)
            {
                case 1:
                    return "Bùi Kim Hoa";
                case 2:
                    return "Nguyễn Anh";
                case 3:
                    return "Nguyễn Khuyến";
                default:
                    return "Erorr!";
            }
        }
        public static Boolean ThemNhanVien(NhanVienDTO NhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = NhanVienDAO.ThemNhanVien(NhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;

        }
        public static Boolean XoaNhanVien(NhanVienDTO NhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = NhanVienDAO.XoaNhanVien(NhanVien);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        public static List<NhanVienDTO> DocDanhSachNhanVien(String strTieuChiTimKiem)
        {
            List<NhanVienDTO> lstNV =NhanVienDAO.DocDanhSachNV(strTieuChiTimKiem);
            return lstNV;
        }     

            
    }
}
