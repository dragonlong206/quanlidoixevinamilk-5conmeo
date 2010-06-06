using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class HangXeBUS
    {        
        public static int GetMaHangXe(String strTenHangXe)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(strTenHangXe)
            {
                case "TOYOTA":
                    return 1;
                case "HONDA":
                    return 2;
                case "MERCIDES":
                    return 3;
                default:
                    return -1;
            }
        }

        public static String GetTenHangXe(int nMaHangXe)
        {
            //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
            switch(nMaHangXe)
            {
                case 1:
                    return "TOYOTA";
                case 2:
                    return "HONDA";
                case 3:
                    return "MERCIDES";
                default:
                    return "ERORR!";
            }
        }
    }
}
