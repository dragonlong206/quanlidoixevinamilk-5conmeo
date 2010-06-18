using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class TrongTaiBUS
    {      
        public static int GetTrongTai(int nMaTrongTai)
        {
            String strTieuChiTimKiem = " Where MaTrongTai = " + nMaTrongTai;
            List<DTO.TrongTaiDTO> lstTrongTai = DocDanhSachTrongTai(strTieuChiTimKiem);

            int nTrongTai = -1;
            if (lstTrongTai.Count > 0)
            {
                nTrongTai = lstTrongTai[0].GiaTri;
            }
            return nTrongTai;
        }

        public static String GetTenTrongTai(int nMaTrongTai)
        {
            String strTieuChiTimKiem = " Where MaTrongTai = " + nMaTrongTai;
            List<DTO.TrongTaiDTO> lstTrongTai = DocDanhSachTrongTai(strTieuChiTimKiem);

            String strTenTrongTai = "Không có";
            if (lstTrongTai.Count > 0)
            {
                strTenTrongTai = lstTrongTai[0].GiaTri.ToString() + " " + lstTrongTai[0].DonVi;                
            }
            return strTenTrongTai;
        }

        public static Boolean ThemTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.TrongTaiDAO.ThemTrongTai(aTrongTai);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static Boolean XoaTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.TrongTaiDAO.XoaTrongTai(aTrongTai);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.TrongTaiDAO.CapNhatTrongTai(aTrongTai);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<DTO.TrongTaiDTO> DocDanhSachTrongTai(String strTieuChiTimKiem)
        {
            List<DTO.TrongTaiDTO> lstTrongTai = DAO.TrongTaiDAO.DocDanhSachTrongTai(strTieuChiTimKiem);
            return lstTrongTai;
        }
    }
}
