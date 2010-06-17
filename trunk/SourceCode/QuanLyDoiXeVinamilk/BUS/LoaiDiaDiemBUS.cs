using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiDiaDiemBUS
    {
        public static int GetMaLoaiDiaDiem(String strLoaiDiaDiem)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch (strLoaiDiaDiem)
            {
                case "Đại Lý":
                    return 1;
                case "Khách Hàng":
                    return 2;
                case "Kho":
                    return 3;
                case "Gara":
                    return 4;
                default:
                    return -1;
            }
        }

        public static String GetTenLoaiDiaDiem(int nMaLoaiDiaDiem)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch (nMaLoaiDiaDiem)
            {
                case 1:
                    return "Đại Lý";
                case 2:
                    return "Khách Hàng";
                case 3:
                    return "Kho";
                case 4:
                    return "Gara";
                default:
                    return "Error!";
            }
        }  

        #region Insert
        public static Boolean ThemLoaiDiaDiem(DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiDiaDiemDAO.ThemLoaiDiaDiem(aLoaiDiaDiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region Delete
        public static Boolean XoaLoaiDiaDiem(DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiDiaDiemDAO.XoaLoaiDiaDiem(aLoaiDiaDiem);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion        

        #region Update
        public static Boolean CapNhatLoaiDiaDiem(DTO.LoaiDiaDiemDTO aLoaiDiaDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiDiaDiemDAO.CapNhatLoaiDiaDiem(aLoaiDiaDiem);                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Select
        public static List<DTO.LoaiDiaDiemDTO> DocDanhSachLoaiDiaDiem(String strTieuChiTimKiem)
        {
            List<DTO.LoaiDiaDiemDTO> lstLoaiDiaDiem = DAO.LoaiDiaDiemDAO.DocDanhSachLoaiDiaDiem(strTieuChiTimKiem);
            return lstLoaiDiaDiem;
        }
        #endregion
    }
}
