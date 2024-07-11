using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzWithList
{
    internal class Program
    {
        private static List<int> lFizzBuzz = new List<int>();

        //Create a function that return a list of first 100 numbers.
        public static List<int> GetInteger()
        {
            const int numberOfIntegers = 100;
            List<int> listOfIntegeres = new List<int>();

            for(int i = 1; i <=numberOfIntegers; i++)
            {
                listOfIntegeres.Add(i);
            }
            return listOfIntegeres;
        }

        //Create a function that reutrn a list number.
        //The number of numbers is enterig by the keyboard.
        public static List<int>GetInteger2(int n)
        {
            List<int> listOfIntegeres = new List<int>();
            for(int i = 1; i <=n; i++)
            {
                listOfIntegeres.Add(i);
            }
            return listOfIntegeres;
        }

        /// <summary>
        /// To do update lFizzBuzz not display from here, 
        /// </summary>
        /// <param name="list"></param>
        private static void FizzBuzz(List<int> list)
        {
            string result;
            lFizzBuzz = new List<int>();

            foreach (var item in list)
            {
                if (item % 3 == 0 && item % 5 == 0)
                {
                    result = "FizzBuzz";
                    lFizzBuzz.Add(item);
                }
                else if (item % 3 == 0) result = "Fizz";
                else if (item % 5 == 0) result = "Buzz";
                else result = item.ToString();

                Console.WriteLine(result);

                //if (item % 3 == 0 && item % 5 == 0)
                //{
                //    Console.Write("This list will display only FizzBuzz numbers: ");
                //    foreach (var f in lFizzBuzz)
                //    {
                //        Console.WriteLine(f);
                //    }
                //    Console.WriteLine();
                //}
            }
        }

        private static Dictionary<int,string> CreateDictWithFizzBuzz(List<int> list)
        {
            Dictionary<int, string> dictFizzBuzz = new Dictionary<int, string>();

            if (list != null)
            {                
                foreach (var item in list)
                {
                    if (!dictFizzBuzz.ContainsKey(item))
                    {
                        dictFizzBuzz.Add(item, "FizzBuzz");
                    }
                }
            }
            return dictFizzBuzz;
        }

        private static void DisplayFizzBuzzItems(Dictionary<int, string> dictItems)
        {
            if (dictItems != null)
            {
                Console.WriteLine();
                Console.Write("Total number from dictionary:" + dictItems.Count);
                foreach (var item in dictItems)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }

        static void Main(string[] args)
        {
            //Declare another list can hold all 100 numbers.
            List<int> list = GetInteger();
            //Calling the function FizzBuzz.
            FizzBuzz(list);
            Console.WriteLine();
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            //declare another list with n number of numbers
            List<int> list2 = GetInteger2(num);
            FizzBuzz(list2);

            //Display only fizzbuzz items
            
            var dict = CreateDictWithFizzBuzz(lFizzBuzz);
            DisplayFizzBuzzItems(dict);
            Console.ReadLine();
        }
    }
}