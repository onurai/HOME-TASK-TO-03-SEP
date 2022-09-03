using System;
using System.Collections.Generic;
using System.IO;

namespace HOME_TASK_TO_03_SEP
{
    class Program
    {
        static void Main()
        {
            #region 1-ci tapsiriq
            //String DocName = @"hometask.txt";
            //string[] Arrlines;
            //int num, i;

            //Console.WriteLine("\n Create and read the last line of file :\n");
            //Console.WriteLine("------------------------------------------\n");

            //if (File.Exists(DocName)) ;
            //{
            //    File.Delete(DocName);
            //}

            //Console.Write("Input number of lines to write in the file :");
            //num = Convert.ToInt32(Console.ReadLine());
            //Arrlines = new string[num];
            //Console.Write("Input {0} string below : \n", num);

            //for (i = 0; i < num; i++)
            //{
            //    Console.Write("Input line {0} : ", i + 1);
            //    Arrlines[i] = Console.ReadLine();
            //}

            //System.IO.File.WriteAllLines(DocName, Arrlines);
            //Console.Write("\n The content of at least line of the file (0) is : \n", DocName);

            //if (File.Exists(DocName))
            //{
            //    string[] lines = File.ReadAllLines(DocName);
            //    Console.WriteLine(" {0} ", lines[num - 1]);
            //}

            Console.WriteLine();
            #endregion

            #region 5-ci tapsiriq
            //Dictionary<string, bool> myDict = new Dictionary<string, bool>();

            //// Adding key/value pairs in myDict
            //myDict.Add("Luke", true);
            //myDict.Add("Han", false);
            //myDict.Add("Chewbacca", false);

            //// To get count of key/value pairs in myDict
            //Console.WriteLine("Total key/value pairs" +
            //      " in myDict are : " + myDict.Count);

            //// Remove the entry with the specified 
            //// key from the Dictionary
            //myDict.Remove("Han");

            //Console.WriteLine("After remove operation");

            //// To get count of key/value pairs in myDict
            //Console.WriteLine("Total key/value pairs" +
            //      " in myDict are : " + myDict.Count);
            #endregion

            #region 4-cu tapsiriq

            List<string> processToKill = new List<string>(3);

            // adding elements in firstlist

            processToKill.Add("onur");
            processToKill.Add("ruslan");
            processToKill.Add("nicat");


            // Printing the Capacity of firstlist
            Console.WriteLine(string.Format("Capacity {0}", processToKill.Capacity));

            // Printing the Count of firstlist
            Console.WriteLine(string.Format("Count {0}", processToKill.Count));


            foreach(var p in processToKill)
            {
                Console.WriteLine(p);
            }
            #endregion


            //bu nese elave eliyende istiafe olunur. 4-cu tapsiriga aiddir.

            //processToKill.Add("fidan");
            //processToKill.Add("jale");


            //// It will give output 10 as we have
            //// already set the Capacity

            //Console.WriteLine("Capacity Is: " + processToKill.Capacity);


            //Console.WriteLine("Count Is: " + processToKill.Count);


            #region 3-cu tapsiriq

            //    List<MyList> mylist = new List<MyList>();

            //}
            //public class MyList
            //{
            //    public int Count { get; set; }

            //    public void Add()
            //    {
            //        Console.WriteLine();
            //    }

            //    public void Remove()
            //    {
            //        Console.WriteLine();
            //    }

            //    public void Clear()
            //    {
            //        Console.WriteLine();
            //    }

            //    public bool Contain()
            //    {
            //        return true;
            //    }
            #endregion

            #region 2-ci tapsiriq

            DirectoryInfo d = new DirectoryInfo(@"C:\MyDataBase");
            FileInfo [] f = d.GetFiles("*", SearchOption.AllDirectories);
            Console.WriteLine(f.Length.ToString());
            #endregion
        }


    }

    
}