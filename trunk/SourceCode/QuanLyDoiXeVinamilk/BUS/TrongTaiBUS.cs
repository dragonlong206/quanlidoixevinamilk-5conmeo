using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BUS
{
    public class TrongTaiBUS
    {
        //Tam thoi dung ham nay: chinh sua truy xuat CSDL sau.
        public static int GetMaTrongTai(String strTrongTai)
        {
            switch(strTrongTai)
            {
                case "1 Tấn":
                    return 1;
                case "2 Tấn":
                    return 2;
                case "3 Tấn":
                    return 3;
                case "5 Tấn":
                    return 4;
                default:
                    return -1;
            }
        }

        public static String GetTenTrongTai(int nMaTrongTai)
        {
            switch(nMaTrongTai)
            {
                case 1:
                    return "1 Tấn";
                case 2:
                    return "2 Tấn";
                case 3:
                    return "3 Tấn";
                case 4:
                    return "5 Tấn";
                default:
                    return "erorr!";
            }
        }
    }
}
