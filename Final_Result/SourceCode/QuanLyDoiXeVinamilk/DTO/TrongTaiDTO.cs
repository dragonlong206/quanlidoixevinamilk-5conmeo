using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DTO
{
    public class TrongTaiDTO
    {
        #region ThuocTinh TrongTaiDTO
        private int m_nMaTrongTai;
        private int m_nGiaTri;
        private String m_strDonVi;
        #endregion

        #region Ham KhoiTao TrongTaiDTO
        public TrongTaiDTO()
        {
            m_nMaTrongTai = -1;
            m_nGiaTri = -1;
            m_strDonVi = String.Empty;
        }
        #endregion

        #region PhuongThuc truy xuat TrongTaiDTO
        public int MaTrongTai
        {
            get { return m_nMaTrongTai; }
            set { m_nMaTrongTai = value; }
        }

        public int GiaTri
        {
            get { return m_nGiaTri; }
            set { m_nGiaTri = value; }
        }

        public String DonVi
        {
            get { return m_strDonVi; }
            set { m_strDonVi = value; }
        }
        #endregion
    }
}
