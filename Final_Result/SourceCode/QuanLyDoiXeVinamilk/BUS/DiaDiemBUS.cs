using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class DiaDiemBUS
    {
        public static String GetToaDo(int nX, int nY)
        {
            String strKetQua = "(" + nX.ToString() + "," + nY.ToString() + ")";
            return strKetQua;
        }

        public static Boolean ThemDiaDiem(DTO.DiaDiemDTO DiaDiem)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = DiaDiemDAO.ThemDiaDiem(DiaDiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaThemDuoc;
        }

        public static Boolean XoaDiaDiem(DiaDiemDTO DiaDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DiaDiemDAO.XoaDiaDiem(DiaDiem);
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
            return blnKetQua;
        }

        public static bool CapNhatDiaDiem(DTO.DiaDiemDTO aDiaDiem)
        {
            Boolean blnKetQua = false;
            try
            {
                blnKetQua = DAO.DiaDiemDAO.CapNhatDiaDiem(aDiaDiem);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }

        public static List<DiaDiemDTO> DocDanhSachDiaDiem(String strTieuChiTimKiem)
        {
            List<DiaDiemDTO> lstDiaDiem = DiaDiemDAO.DocDanhSachDiaDiem(strTieuChiTimKiem);
            return lstDiaDiem;
        }
    }
}
