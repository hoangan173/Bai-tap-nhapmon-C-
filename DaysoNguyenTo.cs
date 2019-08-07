using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Day so nguyen to: ");
            int a = 2;
            while (a <= N)
            {
                bool laSoNguyenTo = true;
                if (a < 2)
                    {
                    laSoNguyenTo = false;
                } 
                else
                {
                int i = 2;
                while (i <= Math.Sqrt(a))
                {
                    if (a % i == 0)
                    {
                        laSoNguyenTo = false;
                        break;
                    }
                    i = i + 1;
                }
                }
                if (laSoNguyenTo)
                {
                Console.WriteLine($"{a} ");
                }
            a = a + 1;
            }
            Console.ReadLine();
        }
    }
}
