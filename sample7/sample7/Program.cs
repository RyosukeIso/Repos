using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample7
{/// <summary>
/// 1から100までの乱数を10回発生させ、そのうちの最大値、最小値を表示しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int max = 0;
            int min = 101;
            for(int i = 1;i <= 10; i++)
            {
                int n = rnd.Next(1, 101);
                Console.WriteLine("{0}", n);
                if(n > max)
                {
                    max = n;
                }
                if(n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("最大値：{0}", max);
            Console.WriteLine("最小値：{0}",min);
        }
    }
}
