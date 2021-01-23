using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_projekt
{
    class Public
    {
        public static int id = 0;

        public static string datum;
        public static string lokacija;
        public static double znesek;
        public static int idP;
        public static void Change(int a)
        {
            id = a; 
        }

        public static void Change2(string a, string b, double c)
        {
            datum = a;
            lokacija = b;
            znesek = c;
        }
    }
}
