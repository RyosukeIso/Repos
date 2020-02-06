using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample14
{/// <summary>
/// 正の整数を入力し、その数以下の２の倍数、３の倍数、５の倍数をすべて表示するプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("2の倍数");
            for (int i = 2; i <= a; i+=2)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
               
            Console.WriteLine("3の倍数");
            for(int i = 3; i <=a; i+=3)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
               
            Console.WriteLine("5の倍数");
            for (int i = 5; i <= a; i+=5)
            {
                Console.Write("{0} ", i);
            
            }
        }
    }
}
