using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhtongUoc
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Nhap N:");
            N = int.Parse(Console.ReadLine());
            int S = 1 + N;
            int i = 2;
            while (i <= N / 2)
            {
                if (N % i == 0)
                {
                    S = S + i;
                }
                i = i + 1;
            }
            Console.Write($"Tong uoc so cua {N} la: {S}");
            Console.ReadLine();
        }
    }
}
