using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入幾個包裝可換糖果 : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("請輸入要吃幾個糖果 : ");
            int x = int.Parse(Console.ReadLine());
            int a=0, b=0;
            while (x > 0)
            {
                x--;
                b++;
                a++;
                Console.WriteLine("剩餘" + x + " 要買" + b + " 包裝紙" + a);
                if(a==n)
                {
                    a = 1;
                    x--;
                    Console.WriteLine("剩餘" + x + " 要買" + b + " 包裝紙" + a);
                }
                
            }
            Console.WriteLine("要買" + b + "顆");
            Console.ReadLine();
        }
    }
}
