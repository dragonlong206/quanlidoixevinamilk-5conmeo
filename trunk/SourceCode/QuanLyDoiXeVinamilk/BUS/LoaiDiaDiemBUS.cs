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
