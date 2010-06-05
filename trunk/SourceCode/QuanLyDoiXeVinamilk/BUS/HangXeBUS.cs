using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class HangXeBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaHangXe(String strTenHangXe)
        {
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
    }
}
