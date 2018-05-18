using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
namespace Course_Work.Models
{
    public class Matrix
    {
       public static int amount_ver = 0;
    public   static  int amount_dependency = 0;
    public static List<List<int>> incendent = new List<List<int>>();
    public static List<List<int>> ves = new List<List<int>>();
     public static List<int> row = new List<int>();
     public static  List<List<double>> road_l = new List<List<double>>();
    public  static List<double> row_l = new List<double>();
    public static List<int> row_v = new List<int>();
   public static List<int> VersionFirst = new List<int>();
  public  static List<int> VersionSecond = new List<int>();
   public static int amountVersionInFirstPD = 0;

      public static void Incedent(int a, int b)
       { for (int i=0; i<amount_ver; i++)
           for (int j = 0; j < amount_ver; j++)
           {
               if (i == (a-1) && j==b-1)  
               {
                   incendent[i][j] = 1;

                   incendent[j][i] = 1;
               }
             
           }
       }
      public static void zero_v()
      {
          for (int i = 0; i < amount_ver; i++)
          {
              row_v = new List<int>();
              for (int j = 0; j < amount_ver; j++)
                  row_v.Add(0);
          }
      }
      public static void Matrix_v(int a, int b,int c)
      {
          for (int i = 0; i < amount_ver; i++)
              for (int j = 0; j < amount_ver; j++)
              {
                  if (i == (a - 1) && j == b - 1)
                  {
                      ves[i][j] = c;

                      ves[j][i] = c;
                  }

              }
      }
     public  static void zero_matr()
       {
           for (int i = 0; i < amount_ver; i++)
           {
               row_l = new List<double>();
               for (int j = 0; j < amount_ver; j++) row_l.Add(0);
               road_l.Add(row_l);

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
                    
                    if (first ==0)
                    {
                        amount_ver = Int32.Parse(columns[0]);
                        first++;
                        amount_dependency = Int32.Parse(columns[1]);
                        for (int i=0; i<amount_ver; i++)
       {
           row = new List<int>();
           for (int j = 0; j < amount_ver; j++) row.Add(0);
           incendent.Add(row);




       }


                    }
                    else
                    {                        
                         //   Console.WriteLine(columns[0]);


                        Incedent(Int32.Parse(columns[0]),Int32.Parse(columns[1]));
                       // Matrix_v(Int32.Parse(columns[0]), Int32.Parse(columns[1]), Int32.Parse(columns[2]));
                        
                    }
                                     
                }



            }
        }
       public static int ob_versh(int a, int b)
        {
            int amount_ob=0;
            int kol_a = 0;
            int kol_b = 0;
            List<int> one_a = new List<int>();
             List<int> one_b = new List<int>();
            for (int i=0; i<amount_ver; i++)
            {
                if (incendent[a][i] == 1)
                {
                    one_a.Add(i+1);
                    kol_a++;
                }
                if (incendent[b][i] == 1)
                {
                    one_b.Add(i+1);
                    kol_b++;
                }
               
            }

            for (int i = 0; i < kol_a; i++)
                for (int j = 0; j < kol_b; j++)
                {
                    if (one_a[i] == one_b[j])
                    {
                        amount_ob++;
                    }
                }
                    return amount_ob;
        }
      public  static int all_versh(int a, int b)
        {  
            int amount_all=0;            
            int kol_a = 0;
            int kol_b = 0;
            List<int> one_a = new List<int>();
            List<int> one_b = new List<int>();
            for (int i = 0; i < amount_ver; i++)
            {
                if (incendent[a][i] == 1)
                {
                    one_a.Add(i);
                    kol_a++;
                }
                if (incendent[b][i] == 1)
                {
                    one_b.Add(i);
                    kol_b++;
                }


            }
            amount_all = kol_a + kol_b;

            for (int i = 0; i < kol_a; i++)
                for (int j = 0; j < kol_b; j++)
                {    
                    if (one_a[i] == one_b[j])
                    {
                        amount_all--;
                    }
                }

            return amount_all;
        }
        //static void Main(string[] args)
        //{
            
        //    ReadFile();
        //    zero_matr();
        //    for (int i = 0; i < amount_ver; i++)
        //        for (int j = 0; j < amount_ver; j++)
        //        {
        //            if (i != j)
        //            {


        //                double kfhb = (all_versh(i, j) - ob_versh(i, j)) / (all_versh(i, j) + ob_versh(i, j));
        //                double kdfudsu = all_versh(i, j) - ob_versh(i, j);
        //                double ksauhawiud = all_versh(i, j) + ob_versh(i, j);
        //                double sdufhaieush = kdfudsu / ksauhawiud;
        //                road_l[i][j] = sdufhaieush;
        //            }
        //        }


        //    for (int i = 0; i < amount_ver; i++)
        //    {
        //        for (int j = 0; j < amount_ver; j++)
        //        {
        //            Console.Write(road_l[i][j] + " ");
        //        }
        //        Console.WriteLine();

        //    }
    
            }
        }
