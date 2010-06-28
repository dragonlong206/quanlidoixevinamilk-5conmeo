using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DTO;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class TenMienEmailDAO
    {
        public static List<TenMienEmailDTO> LayDanhSachTenMien()
        {
            List<TenMienEmailDTO> KetQua = null;

            try
            {
                String strCommand = "Select * from Ten_Mien_Email";

                DataTable DanhSachTenMien = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
                if (DanhSachTenMien.Rows.Count > 0)
                {
                    KetQua = new List<TenMienEmailDTO>();
                    foreach (DataRow aDong in DanhSachTenMien.Rows)
                    {
                        KetQua.Add(TaoDoiTuongDTO(aDong));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static TenMienEmailDTO TaoDoiTuongDTO(DataRow aDong)
        {
            TenMienEmailDTO aTenMien = new TenMienEmailDTO();
            aTenMien.Ma = int.Parse(aDong["Ma"].ToString());
            aTenMien.TenMien = aDong["TenMien"].ToString();
            return aTenMien;
        }
    }
}
