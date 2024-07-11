using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifrePrime
{
    internal class Program
    {
        /// <summary>
        /// To do: optimizare
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Introdu un numar : ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //List cu cifrele unui numar
            List<int> nrCifreList = new List<int>();
            List<int> lstcifrelePrimeDinNumar = new List<int>();
            //Cifrele unui numar:
            int uc = 0;
            int nrCifre = 0, cNrDiv = 0, cNrPrime = 0 ;
            bool isNrPrim = false;
            int copie = number;
            
            while(copie > 0)
            {
                uc = copie % 10;
                //Console.Write("{0} ", uc);
                if (uc > 0) {
                    //int div = 1;
                    int div;
                    cNrDiv = 0;
                    //while (div <= uc)
                    //{
                    //    if(uc %  div == 0)
                    //    {
                    //        cNrDiv++;
                    //    }                        
                    //    div++;
                    //}
                    for(div =1; div <= uc; div++)
                    {
                        if(uc % div == 0)
                        {
                            cNrDiv++; //nr de devizori ai numarului
                        }
                    }
                    //Daca are numar = 2 de divizori (daca se imaprte la 1 si la el insuri atunci este prim)
                    if (cNrDiv == 2)
                    {
                        isNrPrim = true;
                        cNrPrime++;
                        lstcifrelePrimeDinNumar.Add(uc);
                        lstcifrelePrimeDinNumar.Sort();
                    }
                }
                nrCifreList.Add(uc);
                nrCifre++;
                copie = copie / 10; //eliminam ultima cifra, trunchiem numarul.
            }
            Console.WriteLine("\nNumarul {0} are {1} cifre ", number, nrCifre);

            Console.Write("\nCifrele numarului sunt: ");
            foreach(var item in nrCifreList)
            {
                Console.Write(item + " ");
            }

            if (isNrPrim)
            {
                Console.WriteLine($"\nNumarul {number} are {cNrPrime} cifre prime!");
            }

            Console.Write($"\nCifrele prime ale numarului {number} sunt: ");
            foreach (var cifrePrime in lstcifrelePrimeDinNumar)
            {
                Console.Write(cifrePrime + " ");
            }
            Console.ReadKey();
        }
    }
}
