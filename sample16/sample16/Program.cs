using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample16
{/// <summary>
/// 文字列を５回入力し、その文字列をすべて表示するプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            for(int i = 0; i < str.Length; i++)
            {
                Console.WriteLine("{0}つ目の数を入力：", (i + 1));
                str[i] = Console.ReadLine();

            }
            foreach(string s in str)
            {
                Console.Write("{0} ", s);
            }
            Console.WriteLine();
        }
    }
}
