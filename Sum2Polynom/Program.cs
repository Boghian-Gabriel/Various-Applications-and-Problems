namespace Sum2Polynom
{
    internal class Program
    {
        // A utility function to return maximum of two integers
        static int Max(int m, int n)
        {
            return (m > n) ? m : n;
        }

        // A[] represents coefficients of first polynomial
        // B[] represents coefficients of second polynomial
        // m and n are sizes of A[] and B[] respectively
        static int[] Add(int[] A, int[] B, int m, int n)
        {
            int size = Max(m, n);
            int[] sum = new int[size];

            // Initialize the product polynomial
            for (int i = 0; i < m; i++)
            {
                sum[i] = A[i];
            }

            // Take ever term of first polynomial
            for (int i = 0; i < n; i++)
            {
                sum[i] += B[i];
            }

            return sum;
        }

        // A utility function to print a polynomial
        static void PrintPoly(int[] poly, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(poly[i]);
                if (i != 0)
                {
                    Console.Write("x^" + i);
                }
                if (i != n - 1)
                {
                    Console.Write(" + ");
                }
            }
        }

        public static void Main()
        {
            // The following array represents
            // polynomial 5 + 10x^2 + 6x^3
            int[] A = { 3, -5, 4, 0, 1 };

            // The following array represents
            // polynomial 1 + 2x + 4x^2
            int[] B = { -4, -2, 1, 5, 4 };

            int m = A.Length;
            int n = B.Length;

            Console.WriteLine("First polynomial is");
            PrintPoly(A, m);

            Console.WriteLine("\nSecond polynomial is");
            PrintPoly(B, n);

            int[] sum = Add(A, B, m, n);
            int size = Max(m, n);

            Console.WriteLine("\nsum polynomial is");

            PrintPoly(sum, size);

            Console.ReadKey();
        }
    }
}