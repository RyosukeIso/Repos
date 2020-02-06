using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample8
{/// <summary>
/// for文の二重ループを用いて、以下のような九九の表を作りなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九の表示");
            for(int a =1; a <= 9; a++)
            {
                for(int b = 1; b <= 9; b++)
                {
                    Console.Write("{0}×{1}＝{2,2:d} ", a, b, a * b);
                }
                Console.WriteLine();
            }
        }
    }
}
