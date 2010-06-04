using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class NhanVienBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaNhanVien(String strTenNhanVien)
        {
            switch(strTenNhanVien)
            {
                case "BÙI KIM HOA":
                    return 1;
                case "NGUYỄN ANH":
                    return 2;
                case "NGUYỄN KHUYẾN":
                    return 3;
                default:
                    return -1;
            }
        }
    }
}
