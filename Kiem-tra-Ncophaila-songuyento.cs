using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
         int N;
            Console.Write("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            bool laSoNguyenTo = true;
            if (N < 2)
            {
                laSoNguyenTo = false;
            }
            else
            {
                int i = 2;
                while (i <= Math.Sqrt(N))
                {
                    if (N % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                    i = i + 1;
                }
            }
            if (laSoNguyenTo)
            {
                Console.WriteLine($"{N} la so nguyen to");
            }
            else
            {
                Console.WriteLine($"{N} khong phai la so nguyen to");
            }
            Console.ReadLine();
        }
    }
}
