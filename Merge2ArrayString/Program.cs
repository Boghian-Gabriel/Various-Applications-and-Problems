using System;
using System.Collections.Generic;
using System.Linq;

namespace Merge2ArrayString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number for s1: ");
            int nr1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter string for the first array1 of strings: " + "\n");
            string []s1 = new string[nr1];
            for(int i = 0; i < s1.Length; i++)
            {
                Console.Write($"String [{i}] = ");
                s1[i] = Console.ReadLine();
            }

            Console.Write("\nEnter the number for s2: ");
            int nr2 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter string for the second array2 of strings: " + "\n");
            string[] s2 = new string[nr2];
            for (int i = 0; i < s2.Length; i++)
            {
                Console.Write($"String [{i}] = ");
                s2[i] = Console.ReadLine();
            }

            Console.Write("The elements of the first string is: ");
            foreach(string s in s1)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            Console.Write("The elements of the second string is: ");
            foreach (string s in s2)
            {
                Console.Write(s + " ");
            }

            //Display a single array with UNION the s1 and s2.
            var myList = new List<string>();
            myList.AddRange(s1);
            myList.AddRange(s2);
            string[] arr3 = myList.ToArray();
            Console.WriteLine("\nCombined array elements..");
            foreach (string res in arr3)
            {
                Console.Write(res + " ");
            }
            
            Console.WriteLine();
            List<string> listS1 = new List<string>();
            List<string> listS2 = new List<string>();
            foreach(var itm1 in s1)
            {
                listS1.Add(itm1.ToString());
            }
            foreach (var itm2 in s2)
            {
                listS2.Add(itm2.ToString());
            }

            var newList = listS1.Union(listS2);
            Console.WriteLine("\nThe elements from the first array and the second array are display each only once.");
            foreach (var itm in newList)
            {
                Console.Write(itm.ToString() + " ");
            }
            //Display into single array, byr every element appear one time.
            Console.ReadLine();
        }
    }
}
