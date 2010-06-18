using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

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
            String strTieuChiTimKiem = " Where MaNhanVien = " + nMaNhanVien;
            List<DTO.NhanVienDTO> lstNhanVien = DocDanhSachNhanVien(strTieuChiTimKiem);

            String strTenNhanVien = "Không có";
            if (lstNhanVien.Count > 0)
            {                
                strTenNhanVien = lstNhanVien[0].TenNhanVien;                
            }
            return strTenNhanVien; 
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

        public static bool CapNhatNhanVien(DTO.NhanVienDTO aNhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.NhanVienDAO.CapNhatNhanVien(aNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        
        public static List<NhanVienDTO> DocDanhSachNhanVien(String strTieuChiTimKiem)
        {
            List<NhanVienDTO> lstDanhSachNhanVien = null;
            try
            {
                lstDanhSachNhanVien = NhanVienDAO.DocDanhSachNhanVien(strTieuChiTimKiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lstDanhSachNhanVien;
        }        
    }
}
