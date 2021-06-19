using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n'yi girin : ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write("r'yi girin : ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Sonuç = " + Permutasyon(n, r));
            Console.ReadKey();
        }

        public static int Permutasyon(int n, int r)
        {
            if (r == 0)
                return 1;

            return n * Permutasyon(n - 1, r - 1);
        }
    }
}
