using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Course_Work.Models
{
    public class Algoritm2
    {
        public int Variable1 { get; set; }
        public int Variable2 { get; set; }
        public static List<int> VersionFirst = new List<int>();
        public static List<int> VersionSecond = new List<int>();
        public static List<int> VersionThird = new List<int>();
        public static int amountVersionInFirstPD = 0;
        public static int amountVersionInSecondPD = 0;
        public static int sum2 = 0;

        public static void PodgrafThree()
        {

            double MinElemebtOfMatrix = Matrix.road_l[0][1];
            int FirstVi = 0;
            int SecondVi = 0;

            do
            {
            } while (amountVersionInFirstPD > Matrix.amount_ver);
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

            int TempKOLverS = 0;
                for (int j = 0; j < Matrix.amount_ver; j++)
                {
                    bool test2 = true;
                    for (int i = 0; i < TempKOLverF; i++)
                    {
                        if ((j + 1) == VersionFirst[i])
                        {
                            test2 = false;
                        }
                    }
                    if (test2 && (amountVersionInSecondPD > TempKOLverS))
                    {
                        VersionSecond.Add(j + 1);
                        TempKOLverS++;
                    }
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
                for (int i = 0; i < TempKOLverS; i++)
                {
                    if ((j + 1) == VersionSecond[i])
                    {
                        test = false;
                    }
                }
                if (test) VersionThird.Add(j + 1);

            }
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
            for (int i = 0; i < VersionFirst.Count; i++)
                for (int j = 0; j < VersionSecond.Count; j++)
                {
                    sum2 += Sumroz.ves[VersionFirst[i] - 1][VersionSecond[j] - 1];
                }
            for (int i = 0; i < VersionFirst.Count; i++)
                for (int j = 0; j < VersionThird.Count; j++)
                {
                    sum2 += Sumroz.ves[VersionFirst[i] - 1][VersionThird[j] - 1];
                }
            for(int i=0;i<VersionSecond.Count; i++)
                for (int k = 0; k < VersionThird.Count; k++)
                {
                    sum2 += Sumroz.ves[VersionSecond[i] - 1][VersionThird[k] - 1];
                }
        }
    }
}