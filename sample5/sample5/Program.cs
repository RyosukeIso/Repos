using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample5
{/// <summary>
/// キーボードから正の整数を入力させ、その約数をすべて表示させなさい。
/// このとき、入力した数値が0以下の場合は何も表示しないようにしなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("正の整数を入力：");
            int a = int.Parse(Console.ReadLine());
            for (int i = 1; i <= a; i++)
            {
                if(a % i == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}
