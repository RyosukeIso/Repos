using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample13
{/// <summary>
/// 正の整数を入力し、その数から０までカウントダウンするプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("正の整数を入力：");
            int a = int.Parse(Console.ReadLine());
            for(int i = a; 0< i; i--)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}
