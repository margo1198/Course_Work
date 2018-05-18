using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace Course_Work.Models
{
    public class Sumroz
    {
        public static int amount_ver = 0;
        public static List<List<int>> ves = new List<List<int>>();
        public static List<int> row = new List<int>();
        public static int sum = 0;
        public static void Matrix_v(int a, int b, int c)
        {
            for (int i = 0; i <amount_ver; i++)
                for (int j = 0; j <amount_ver; j++)
                {
                    if (i == (a - 1) && j == b - 1)
                    {
                        ves[i][j] = c;

                        ves[j][i] = c;
                    }

                }
        }
        public static void zero_v()
        {
            for (int i = 0; i < amount_ver; i++)
                for (int j = 0; j < amount_ver; j++)
                {
                    ves[i][j] = 0;
                }
        }
        public static void ReadFile()
        {
            using (var stream = File.OpenText("C:/Users/User/Desktop/Course_Work/Course_Work/App_start/App_Data/graf.txt"))
            {
                string line;
                int first = 0;
                while ((line = stream.ReadLine()) != null)
                {
                    var columns = line.Split(' ');

                    if (first == 0)
                    {
                        amount_ver = Int32.Parse(columns[0]);
                        first++;
                        for (int i = 0; i < amount_ver; i++)
                        {
                            row = new List<int>();
                            for (int j = 0; j <amount_ver; j++) row.Add(0);
                            ves.Add(row);
                        } zero_v();


                    }
                    else
                    {
                        Matrix_v(Int32.Parse(columns[0]), Int32.Parse(columns[1]), Int32.Parse(columns[2]));

                    }

                }



            }
        }
    }
}