using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class LoaiNhanVienBUS
    {        
        public static String GetTenLoaiNhanVien(int nMaLoaiNhanVien)
        {
            switch(nMaLoaiNhanVien)
            {
                case 2:
                    return "Quản lý";                    
                case 3:
                    return "Tài xế";
                default:
                    return "Erorr!";                    
            }
        }

        #region Insert
        public static Boolean ThemLoaiNhanVien(DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiNhanVienDAO.ThemLoaiNhanVien(aLoaiNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region Delete
        public static Boolean XoaLoaiNhanVien(DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiNhanVienDAO.XoaLoaiNhanVien(aLoaiNhanVien);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Update
        public static Boolean CapNhatLoaiNhanVien(DTO.LoaiNhanVienDTO aLoaiNhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiNhanVienDAO.CapNhatLoaiNhanVien(aLoaiNhanVien);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Select
        public static List<DTO.LoaiNhanVienDTO> DocDanhSachLoaiNhanVien(String strTieuChiTimKiem)
        {
            List<DTO.LoaiNhanVienDTO> lstLoaiNhanVien = DAO.LoaiNhanVienDAO.DocDanhSachLoaiNhanVien(strTieuChiTimKiem);
            return lstLoaiNhanVien;
        }
        #endregion
    }
}
