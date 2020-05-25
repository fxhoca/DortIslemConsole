using System;
using System.Collections.Generic;
using System.Text;

namespace DortIslemConsole
{
    public class Method
    {
        public static int Topla(int sayi1, int sayi2)
        {
            int result = sayi1 + sayi2;
            return result;
        }
        public static int Cikart(int sayi1, int sayi2)
        {
            int result = sayi1 - sayi2;
            return result;
        }
        public static int Bol(int sayi1, int sayi2)
        {
            int result = sayi1 / sayi2;
            return result;
        }
        public static int Carp(int sayi1, int sayi2)
        {
            int result = sayi1 * sayi2;
            return result;
        }

         


        public static bool IsInt(string sVal)
        {
            int number;
            if (!Int32.TryParse(sVal, out number))
            {
                return false;
            }
            return true;
        }


        public static bool IsOp(string sVal)
        {
            if (sVal.Equals("+") || sVal.Equals("-") || sVal.Equals("/") || sVal.Equals("*"))
            {
                return true;
            }
            return false;
        }


    }
}
