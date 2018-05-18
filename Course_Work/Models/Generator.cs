using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course_Work.Models
{
    public class Generator
    {
        public  int amount_ver{ get; set; }
        public  int amount_r { get; set; }
        public static int amount_versh = 0;
        public static int amont_reb = 0;
        public static  int[,] graf = new int[1000000, 3];
        public static void generator(int kol_ver, int kol_r)
        {
            Random rnd = new Random();
            Random vs = new Random();
            for (int i = 0; i < kol_r; i++)
            {
               
                graf[i, 0] = rnd.Next(1, kol_ver);
                graf[i, 1] = rnd.Next(1, kol_ver);
                while (graf[i, 0] == graf[i, 1])
                {
                    graf[i, 1] = rnd.Next(1, kol_ver);
                }
                graf[i, 2] = vs.Next(1, 100);

            }
        }
        //public static bool proverka(int k,int amount)
        //{
        //    for (int i = 0; i < amount; i++)
        //    {
        //        if (graf[k, 0] == graf[i, 0] && graf[k, 1] == graf[i, 1])
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}