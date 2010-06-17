using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiNhanVienBUS
    {
        public static int GetmaLoaiNhanVien(String strLoaiNhanVien)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch (strLoaiNhanVien)
            {
                case "Quản lý":
                    return 1;
                case "Tài xế":
                    return 2;
                default:
                    return -1;
            }
        }
        
        public static String GettenLoaiNhanVien(int nmaLoaiNhanVien)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch (nmaLoaiNhanVien)
            {
                case 1:
                    return "Quản lý";
                case 2:
                    return "Tài xế";
                
                default:
                    return "Error!";
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
                blnKetQua = DAO.LoaiNhanVienDAO.ThemLoaiNhanVien(aLoaiNhanVien);
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
                blnKetQua = DAO.LoaiNhanVienDAO.ThemLoaiNhanVien(aLoaiNhanVien);
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
