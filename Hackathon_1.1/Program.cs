using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            for(int i=1;i<101;i++)
            {
                string s = i.ToString();
                s = s.Replace("3", "A").Replace("5","B").Replace("9","C").Replace("0","D");
                Console.WriteLine(s + "");
            }
            Console.ReadLine();
        }
    }
}
