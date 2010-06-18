﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using DTO;

namespace DAO
{
    public class NhanVienDAO
    {
        #region 1.Insert
        public static Boolean ThemNhanVien(NhanVienDTO NhanVien)
        {
            Boolean blnKetQua = false;
            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenNhanVien", NhanVien.TenNhanVien));
                arrParams.Add(new OleDbParameter("@MaLoaiNhanVien", NhanVien.MaLoaiNhanVien));
                arrParams.Add(new OleDbParameter("@SoDienThoai", NhanVien.SoDienThoai));
                arrParams.Add(new OleDbParameter("@NgayVaoCongTy", NhanVien.NgayVaoCongTy));
                String strCommand = @"Insert into NHAN_VIEN(TenNhanVien, MaLoaiNhanVien, SoDienThoai, NgayVaoCongTy)
                                      Values(?,?,?,?)";

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

        #region 2.Delete
        public static Boolean XoaNhanVien(NhanVienDTO aNV)
        {
            Boolean blnKetQua = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@MaNhanVien", aNV.MaNhanVien));
                String strCommand = @"Delete from Nhan_Vien 
                                      Where MaNhanVien = ?";

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
        public static Boolean CapNhatNhanVien(NhanVienDTO aNhanVien)
        {
            Boolean blnDaUpdate = false;

            try
            {
                List<OleDbParameter> arrParams = new List<OleDbParameter>();
                arrParams.Add(new OleDbParameter("@TenNhanVien", aNhanVien.TenNhanVien));
                arrParams.Add(new OleDbParameter("@MaLoaiNhanVien", aNhanVien.MaLoaiNhanVien));
                arrParams.Add(new OleDbParameter("@SoDienThoai", aNhanVien.SoDienThoai));
                arrParams.Add(new OleDbParameter("@NgayVaoCongTy", aNhanVien.NgayVaoCongTy));
                arrParams.Add(new OleDbParameter("@MaNhanVien", aNhanVien.MaNhanVien));

                String strCommand = @"Update NHAN_VIEN
                                     Set TenNhanVien = ?, MaLoaiNhanVien = ?, SoDienThoai = ?, NgayVaoCongTy = ?
                                     Where MaNhanVien = ?";

                int nRecord = SqlDataAccessHelper.ExcuteNonQuery(strCommand, arrParams);
                if (nRecord == 1)
                {
                    return blnDaUpdate = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blnDaUpdate;
        }
        #endregion

        #region 4.Select
        public static List<NhanVienDTO> DocDanhSachNhanVien(String strTieuChiTimKiem)
        {
            List<NhanVienDTO> lstNhanVien = new List<NhanVienDTO>();

            String strCommand = "Select * from NHAN_VIEN" + strTieuChiTimKiem;
            DataTable table = SqlDataAccessHelper.ExcuteQuery(strCommand, null);

            foreach (DataRow aDong in table.Rows)
            {
                lstNhanVien.Add(KhoiTao(aDong));
            }

            return lstNhanVien;              
        }

        public static DTO.NhanVienDTO KhoiTao(DataRow aDong)
        {
            DTO.NhanVienDTO aNhanVien = new DTO.NhanVienDTO();

            aNhanVien.MaNhanVien = int.Parse(aDong["MaNhanVien"].ToString());
            aNhanVien.TenNhanVien = aDong["TenNhanVien"].ToString();
            aNhanVien.MaLoaiNhanVien = int.Parse(aDong["MaLoaiNhanVien"].ToString());
            aNhanVien.SoDienThoai = aDong["SoDienThoai"].ToString();
            aNhanVien.NgayVaoCongTy = DateTime.Parse(aDong["NgayVaoCongTy"].ToString());
             
            return aNhanVien;
        }        
        #endregion
    }
}