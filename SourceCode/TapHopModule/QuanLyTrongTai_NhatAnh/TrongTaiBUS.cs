using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class TrongTaiBUS
    {
       //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaTrongTai(String strTrongTai)
        {
            switch(strTrongTai)
            {
                case "1 Tấn":
                    return 1;
                case "2 Tấn":
                    return 2;
                case "3 Tấn":
                    return 3;
                case "5 Tấn":
                    return 4;
                default:
                    return -1;
            }
        }

        public static String GetTenTrongTai(int nMaTrongTai)
        {
            switch(nMaTrongTai)
            {
                case 1:
                    return "1 Tấn";
                case 2:
                    return "2 Tấn";
                case 3:
                    return "3 Tấn";
                case 4:
                    return "5 Tấn";
                default:
                    return "error!";
            }
        }

        public static Boolean ThemTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnDaThemDuoc = false;
            try
            {
                blnDaThemDuoc = DAO.TrongTaiDAO.ThemTrongTai(aTrongTai);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
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

        public static List<DTO.TrongTaiDTO> DocDanhSachTrongTai()
        {
            List<DTO.TrongTaiDTO> lstTrongTai = DAO.TrongTaiDAO.DocDanhSachTrongTai();
            return lstTrongTai;
        }
    }
}
