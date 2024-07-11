using System;

namespace _2018S2EX5
{
    internal class Program
    {
        /*
         * n=4 => v = [3,5,2,7]
             
             j
             0 1 2 3

        i 0  3 7 3 7
          1  5 2 5 2
          2  2 5 2 5
          3  7 3 7 3
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Exercitiul: 2018S2EX5");

            Console.Write("Enter the n number: ");
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"You entered the {n} number");

            int[]v = new int[n];
            int[] reversArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                try
                {
                    Console.Write("V[" + i + "] = ");
                    v[i] = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exceptie --> " + ex.Message);
                }
            }

            Console.Write("Display elements from array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Display reverse elements from array: ");

            for (int i = 0; i < n; i++)
            {
                reversArray[i] = v[n - i - 1];
                Console.Write(reversArray[i] + " ");
            }

            int[,] mat = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(j % 2 == 0)
                    {
                        mat[i, j] = v[i];
                    }
                    else
                    {
                        mat[i, j] = reversArray[i];
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Display matrix: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }           
            Console.ReadKey();
        }
    }
}
