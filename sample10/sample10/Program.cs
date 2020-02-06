using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample10
{/// <summary>
/// 1から99までの乱数を10個発生させ、0以上10未満、10以上20未満、、、といったように、
/// 10刻みでそれぞれの範囲に該当する数をすべてプログラムを作成しなさい。
/// なお、発生させた乱数は重複しても構わないものとする。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] a = new int[10];
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(1, 100);
                Console.WriteLine("{0}",a[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < 100; i += 10)
            {
                Console.WriteLine("{0}以上{1}未満:",i,i + 10);
                foreach(int n in a)
                {
                    if(n >= i && n < i + 10)
                    {
                        Console.Write("{0}", n);

                    }

                }
                Console.WriteLine();
            }
        }
    }
}
