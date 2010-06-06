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

        public static String GetTenNhanVien(int nMaNhanVien)
        {
            switch(nMaNhanVien)
            {
                case 1:
                    return "BÙI KIM HOA";
                case 2:
                    return "NGUYỄN ANH";
                case 3:
                    return "NGUYỄN KHUYẾN";
                default:
                    return "ERORR!";
            }
        }
    }
}
