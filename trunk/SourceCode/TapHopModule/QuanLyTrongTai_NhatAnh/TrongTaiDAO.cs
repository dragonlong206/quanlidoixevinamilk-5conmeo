using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class TrongTaiDAO
    {
        #region select
        public static List<TrongTaiDTO> DocDanhSachTrongTai()
        {
            List<TrongTaiDTO> dsTrongTai = new List<TrongTaiDTO>();

            String strCommand = "Select * from TRONG_TAI";
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                dsTrongTai.Add(KhoiTao(aDong));
            }

            return dsTrongTai;
        }
        public static DTO.TrongTaiDTO KhoiTao(DataRow aDong)
        {
            DTO.TrongTaiDTO aTrongTai = new DTO.TrongTaiDTO();
            aTrongTai.MaTrongTai = int.Parse(aDong["MaTrongTai"].ToString());
            aTrongTai.GiaTri = int.Parse(aDong["GiaTri"].ToString());
            aTrongTai.DonVi = aDong["DonVi"].ToString();
            return aTrongTai;
        }

        public static TrongTaiDTO LayTrongTaiTheoMTT(int nMaTrongTai)
        {
            TrongTaiDTO trongtai = null;

            String strCommand = "Select * from TRONG_TAI where MaTrongTai = ?";
            OleDbParameter param = new OleDbParameter("@MaTrongTai", nMaTrongTai);
            List<OleDbParameter> arrParams = new List<OleDbParameter>();
            arrParams.Add(param);

            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, arrParams);

            if (table.Rows.Count > 0)
            {
                trongtai = new TrongTaiDTO();
                trongtai.MaTrongTai = int.Parse(table.Rows[0]["MaTrongTai"].ToString());
                trongtai.GiaTri = int.Parse(table.Rows[0]["GiaTri"].ToString());
                trongtai.DonVi = table.Rows[0]["DonVi"].ToString();
            }

            return trongtai;
        }

        #endregion

        #region delete
        public static Boolean XoaTrongTai(DTO.TrongTaiDTO aTrongTai)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaTrongTai", aTrongTai.MaTrongTai));
                String strCommand = @"Delete from TRONG_TAI
                                      Where MaTrongTai = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    blnKetQua = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnKetQua;
        }
        #endregion

        #region insert
        public static Boolean ThemTrongTai(TrongTaiDTO trongtai)
        {
            Boolean blnDaThemDuoc = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaTrongTai", trongtai.MaTrongTai));
                arrParams.Add(new OleDbParameter("@GiaTri", trongtai.GiaTri));
                arrParams.Add(new OleDbParameter("@DonVi", trongtai.DonVi));

                String strCommand = @"Insert into TRONG_TAI(MaTrongTai, GiaTri, DonVi)
                                    values (?, ?, ?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1) // Số dòng insert được
                {
                    blnDaThemDuoc = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaThemDuoc;
        }
        #endregion

    }
}
