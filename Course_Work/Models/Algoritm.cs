using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course_Work.Models
{
    public class Algoritm
    {
        public int Variables { get; set; }
        public static List<int> VersionFirst = new List<int>();
        public static List<int> VersionSecond = new List<int>();
        public static int amountVersionInFirstPD = 0;
        public static int sum = 0;

        public static void PodgrafTwo()
        {

            // Console.WriteLine("Kol versh in first podgraf : ");
            double MinElemebtOfMatrix = Matrix.road_l[0][1];
            int FirstVi = 0;
            int SecondVi = 0;
            //do
            //{
            //    //Console.WriteLine("Kol versh in first podgraf : ");
            //    //amountVersionInFirstPD = Int32.Parse(ViewBag.Answer);
            //} while (amountVersionInFirstPD > Matrix.amount_ver);
            for (int i = 0; i < Matrix.amount_ver; i++)
            {
                for (int j = 0; j < Matrix.amount_ver; j++)
                {
                    if (MinElemebtOfMatrix > Matrix.road_l[i][j] && i != j)
                    {
                        MinElemebtOfMatrix = Matrix.road_l[i][j];
                        FirstVi = i + 1;
                        SecondVi = j + 1;
                    }
                }


            }
            //  Console.WriteLine(MinElemebtOfMatrix + " " + FirstVi + " " + SecondVi);


            VersionFirst.Add(FirstVi);
            VersionFirst.Add(SecondVi);
            int TempKOLverF = 2;
            while (amountVersionInFirstPD > TempKOLverF)
            {
                int current = SecondVi;
                int temp = SecondVi;
                double versionTemp = Matrix.road_l[SecondVi - 1][FirstValue(TempKOLverF)];
                for (int i = 0; i < Matrix.amount_ver; i++)
                {
                    if (versionTemp > Matrix.road_l[current - 1][i] && SimpleVersion(i + 1, TempKOLverF))
                    {
                        versionTemp = Matrix.road_l[SecondVi - 1][i];
                        current = i + 1;
                        SecondVi = current;
                    }
                    if (i == Matrix.amount_ver-1 && temp == SecondVi)
                    {
                        current = 0 + 1;
                        SecondVi = current;
                    }
                }

                VersionFirst.Add(current);
                TempKOLverF++;
            }

            for (int j = 0; j < Matrix.amount_ver; j++)
            {
                bool test = true;
                for (int i = 0; i < TempKOLverF; i++)
                {
                    if ((j + 1) == VersionFirst[i])
                    {
                        test = false;
                    }
                }
                if (test) VersionSecond.Add(j + 1);

            }







            ////VersionSecond.Add(0);

            //Console.WriteLine();







            //for (int i = 0; i < Matamount_ver; i++)
            //{
            //    for (int j = 0; j < amount_ver; j++)
            //    {
            //        Console.Write(road_l[i][j] + " ");
            //    }
            //    Console.WriteLine();

            //}


        }
        public static int FirstValue(int Amount)
        {
            int temp = 0;
            for (int i = 0; i < Amount; i++)
            {
                for (int j = 0; j < Matrix.amount_ver; j++)
                {

                    if (VersionFirst[i] == j + 1)
                    {
                        continue;
                    }
                    else
                    {
                        temp = j;
                    }
                }
            }
            return temp;
        }
        public static bool SimpleVersion(int j, int Amount)
        {
            for (int i = 0; i < Amount; i++)
            {
                if (j == VersionFirst[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void sumr()
        {
            for(int i=0; i<VersionFirst.Count; i++)
                for (int j = 0; j < VersionSecond.Count; j++)
                {
                    sum += Sumroz.ves[VersionFirst[i] - 1][VersionSecond[j] - 1];
                }
        }
    }
}