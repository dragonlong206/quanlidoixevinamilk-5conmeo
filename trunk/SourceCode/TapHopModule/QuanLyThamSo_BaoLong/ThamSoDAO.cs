using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class ThamSoDAO
    {
        #region 1.Insert
        public static Boolean ThemThamSo(ThamSoDTO ThamSo)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenThamSo", ThamSo.TenThamSo));
                arrParams.Add(new OleDbParameter("@GiaTri", ThamSo.GiaTri));
                String strCommand = @"Insert into THAMSO(TenThamSo, GiaTri)
                                    values (?, ?)";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);

                if (nRecord == 1) // Số dòng insert được
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

        #region 2.Delete
        public static Boolean XoaThamSo(DTO.ThamSoDTO aThamSo)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@Ma", aThamSo.Ma));
                String strCommand = @"Delete from THAMSO
                                      Where Ma = ?";

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

        #region 3.Update
        public static bool CapNhatThamSo(ThamSoDTO ThamSo)
        {
            bool blnDaCapNhat = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();

                arrParams.Add(new OleDbParameter("@TenThamSo", ThamSo.TenThamSo));
                arrParams.Add(new OleDbParameter("@Giatri", ThamSo.GiaTri));
                arrParams.Add(new OleDbParameter("@Ma", ThamSo.Ma));

                String strCommand = @"Update THAMSO
                                     Set TenThamSo = ?, GiaTri = ? 
                                     Where Ma = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);

                if (nRecord == 1)
                {
                    blnDaCapNhat = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return blnDaCapNhat;
        }
        #endregion

        #region 4.Select
        public static DataTable LayThamSo(String strTenThamSo)
        {
            DataTable KetQua = null;

            try
            {
                String strCommand = @"Select GiaTri from ThamSo
                                      where TenThamSo = ?";
                List<OleDbParameter> lstParams = new List<OleDbParameter>();
                lstParams.Add(new OleDbParameter("@TenThamSo", strTenThamSo));

                KetQua = SqlDataAccessHelper.ExcuteQuery(strCommand, lstParams);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return KetQua;
        }

        public static List<ThamSoDTO> DocDanhSachThamSo(String strTieuChiTimKiem)
        {
            List<ThamSoDTO> lstThamSo = new List<ThamSoDTO>();

            String strCommand = "Select * from THAMSO " + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstThamSo.Add(KhoiTao(aDong));
            }

            return lstThamSo;
        }
        public static DTO.ThamSoDTO KhoiTao(DataRow aDong)
        {
            DTO.ThamSoDTO aThamso = new DTO.ThamSoDTO();
            aThamso.Ma = int.Parse(aDong["Ma"].ToString());
            aThamso.TenThamSo = aDong["TenThamSo"].ToString();
            aThamso.GiaTri = aDong["GiaTri"].ToString();
            return aThamso;
        }

        public static List<ThamSoDTO> LayDanhSachTatCaThamSo()
        {
            List<ThamSoDTO> DanhSachThamSo = null;

            try
            {
                string strCommand = "Select * from THAMSO";

                DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);
                if (table.Rows.Count > 0)
                {
                    DanhSachThamSo = new List<ThamSoDTO>();
                    foreach (DataRow aRow in table.Rows)
                    {
                        DanhSachThamSo.Add(KhoiTao(aRow));
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return DanhSachThamSo;
        }
        #endregion
    }
}
