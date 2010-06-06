﻿using System;
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
                case "1 tấn":
                    return 1;
                case "2 tấn":
                    return 2;
                case "3 tấn":
                    return 3;
                case "5 tấn":
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
                    return "1 tấn";
                case 2:
                    return "2 tấn";
                case 3:
                    return "3 tấn";
                case 4:
                    return "5 tấn";
                default:
                    return "erorr!";
            }
        }
    }
}
