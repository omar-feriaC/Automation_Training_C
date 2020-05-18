using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace M10Exercise_BrendaL
{
    class Program
    {
        static void Main(string[] args)
        {

            ////1 . Print the length of a string from an array of strings. 
            #region 

            // string[] arr1 = new string[] { "Brenda", "Exercise", "Automation", "LINQ", "yes" };
            //// int n, i; not used since i and n doesn't explain what they're doing

            // Console.Write("\nLINQ : Print the lenght of the strings in the array : ");
            // Console.Write("\n------------------------------------------------------\n");

            // var lenghtString = from selectLenghts in arr1
            //                    select selectLenghts;

            // foreach (string element in lenghtString)
            // { 
            //     Console.WriteLine($"Selected File: {element}. \tThe lenght of the string is: {element.Length}"); 
            // }
            #endregion

            ////2. Print the size of a file in bytes in a directory using LINQ. 
            #region

            //string[] dirfiles = Directory.GetFiles("C:/Test");
            //// there are three files in the directory abcd are :             
            //// abcd.txt, simple_file.txt and xyz.txt 

            //Console.Write("\nLINQ : Calculate the Size of File : ");
            //Console.Write("\n------------------------------------\n");

            //var filesList = from selectFiles in dirfiles
            //                select selectFiles;

            //foreach (string element in filesList)
            //{ 
            //    Console.WriteLine($"Selected File: {element}.\tThe size of the file is: {element.Length} bites");
            //}
            #endregion

            ////3. Shows how the three parts of a query operation execute. 
            #region  
                        
            //int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.Write("\nBasic structure of LINQ : ");
            //Console.Write("\n---------------------------");

            //var values = from num in n1
            //             where num == 5
            //             select num;
            
            //Console.WriteLine("\nQuery:\tvar values = from num in n1");
            //Console.WriteLine("      \twhere num == 5");
            //Console.WriteLine("      \tselect num;");
            //Console.WriteLine("\n\"var values\": as the name of the variable that will allocate the results of the query.");
            //Console.WriteLine("Part 1: \"from num in n1\": num is the variable of the items, meaning from items and in n1 means is from the array n1");
            //Console.WriteLine("Part 2: \"where num == 5\": where means that the condition is that the item equals 5");
            //Console.WriteLine("Part 3: \"select num\": then the items that match the condition will be in values");
            //Console.WriteLine($"\nSince the array has the following numbers in it (0, 1, 2, 3, 4, 5, 6, 7, 8, 9). The only one that matches the condition is: {values}");

            #endregion

            ////4. Display the name of the days of a week. 
            #region  

            //string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            //Console.Write("\nLINQ : Display the name of the days of a week : "); 
            //Console.Write("\n------------------------------------------------\n");

            //var daysString = from selectDays in dayWeek
            //                 select selectDays;

            //foreach (string element in daysString)
            //{
            //    Console.WriteLine($"\t{element}.");
            //}       

            #endregion

            //5. print the number and its square from an array. 
            #region

            //var arrNumbers = new[] { 3, 9, 2, 8, 6, 5 };

            //Console.Write("\nLINQ : Print the number and its square from an array: "); 
            //Console.Write("\n------------------------------------------------------------------------\n");

            //var numsString = from selectNums in arrNumbers
            //                 select selectNums;

            //foreach (int num in numsString)
            //{                               
            //    Console.WriteLine($"\tThe square of {num} is: {num* num}.");
            //}

            #endregion

            Console.ReadLine();
        }
    }
}



