using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class ThamSoBUS
    {
        public static int GetSoNamToiDa()
        {
            return 10;
        }

        public static DataTable LayThamSo(String strTenThamSo)
        {
            DataTable KetQua = null;

            try
            {
                KetQua = ThamSoDAO.LayThamSo(strTenThamSo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        #region Insert
        public static Boolean ThemThamSo(DTO.ThamSoDTO aThamSo)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ThamSoDAO.ThemThamSo(aThamSo);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region Delete
        public static Boolean XoaThamSo(DTO.ThamSoDTO aThamSo)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ThamSoDAO.XoaThamSo(aThamSo);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Update
        public static Boolean CapNhatThamSo(DTO.ThamSoDTO aThamSo)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.ThamSoDAO.CapNhatThamSo(aThamSo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }
        #endregion

        #region Select
        public static List<DTO.ThamSoDTO> DocDanhSachThamSo(String strTieuChiTimKiem)
        {
            List<DTO.ThamSoDTO> lstThamSo = DAO.ThamSoDAO.DocDanhSachThamSo(strTieuChiTimKiem);
            return lstThamSo;
        }       
        #endregion
    }
}
