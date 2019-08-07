using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tongdaysonguyento
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.Write("Nhap N: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Tong cua day so nguyen To: ");
            int a = 2;
            int S = 0;
            int dem = 0;
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
                    S = S + a;
                    dem = dem + 1;
                }
                a = a + 1;
            }
            Console.WriteLine($"Tong cua day so nguyen to la: {S}");
            if (dem > 0)
            {
                Console.WriteLine($" Trung binh cong cua day so nguyen to la: {1.0 * S/dem}");
            }
            Console.ReadLine();
        }
    }
}
