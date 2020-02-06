using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample4
{/// <summary>
/// キーボードから整数値を入力させ、その数だけ★マークを表示するプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("★の数を入力:");
            int a = int.Parse(Console.ReadLine());
            for(int i = 0;i < a; i++)
            {
                Console.WriteLine("★");

            }
            Console.WriteLine();
        }
    }
}
