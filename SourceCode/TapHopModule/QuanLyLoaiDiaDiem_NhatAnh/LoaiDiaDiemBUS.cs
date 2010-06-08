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
        #region Load
        public static List<DTO.LoaiDiaDiemDTO> DocDanhSachLoaiDD()
        {
            List<DTO.LoaiDiaDiemDTO> lstLoaiDD = DAO.LoaiDiaDiemDAO.DocDanhSachLoaiDD();
            return lstLoaiDD;
        }
        #endregion

        #region Delete
        public static Boolean XoaLoaiDD(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiDiaDiemDAO.XoaLoaiDD(aLoaiDD);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Insert
        public static Boolean ThemLoaiDD(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = DAO.LoaiDiaDiemDAO.ThemLoaiDD(aLoaiDD);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }
        #endregion

        #region Update
        public static Boolean CapNhatLoaiDD(DTO.LoaiDiaDiemDTO aLoaiDD)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.LoaiDiaDiemDAO.CapNhatLoaiDD(aLoaiDD);
                //if (LoaiDiaDiemDAO.KiemTraMaLoaiDD(aLoaiDD.MaLoai))
               // {
                 //   return LoaiDiaDiemDAO.CapNhatLoaiDD(aLoaiDD);
               // }
               // return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion
    }
}
