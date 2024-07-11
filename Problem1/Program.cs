using System;
using System.Linq;

namespace Problem1
{
    internal class Program
    {
        /*
         Scrieti o secventa de cod ce sorteaza un array de siruri de caractere
         crescator dupa lungime, apoi alfabetic (despartite prin ",")
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements of the array separated by ',':");
            
            string elem = Console.ReadLine();
            string[] myArray = elem.Split(',');

            Array arr = myArray; 
            Array.Sort(arr); 

            Console.WriteLine("Alphabetical sorted array: ");
            int contor = 0;
            foreach(var s in arr)
            {
                contor++;
                Console.WriteLine(contor + " - " + "{0}" + ",", s);
            }

            Console.WriteLine("\n-------------------------------------------\n");
            Console.WriteLine("Array sorted by length: ");
            //Array sorted by length with LINQ (Language Integrated Query)
            var sortArraybyLenght = from x in myArray 
                                    orderby x.Length 
                                    select x;
            contor = 0;
            foreach(var s in sortArraybyLenght)
            {
                contor++;
                Console.WriteLine(contor + " - " + "{0}" + ",", s);
            }

            Console.ReadKey();
        }
    }
}
