using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap_buoi_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Nhap a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine($"Giai phuong trinh bac 1: {a}x+{b}=0");
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Phuong trinh co vo so nghiem");
                }
                else
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
            }
            else
            {
                Console.WriteLine($"Phuong trinh co nghiem x = {-b / a}");
            }
            Console.ReadLine();
        }
    }
}
