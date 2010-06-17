using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using DAO;

namespace BUS
{
    public class TenMienEmailBUS
    {
        public static List<TenMienEmailDTO> LayDanhSachTenMien()
        {
            List<TenMienEmailDTO> KetQua = null;

            try
            {
                KetQua = TenMienEmailDAO.LayDanhSachTenMien();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }
    }
}
