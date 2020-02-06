using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample9
{/// <summary>
/// キーボードから整数値を５回入力させ、その数値をすべて表示し、その中から最大値、最小値を表示させなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            for(int i =0;i < a.Length; i++)
            {
                Console.WriteLine("{0}つ目の数値：",i + 1);
                int b = int.Parse(Console.ReadLine());
                a[i] =  b;
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i] + "");
            }
            Console.WriteLine();
            int max = a[0];
            int min = a[0];

            for(int i =0;i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if(a[i] < min)
                {
                    min = a[i];
                }
            }
            Console.WriteLine("最大値：{0}",max);
            Console.WriteLine("最小値：{0}", min);
        }
    }
}
