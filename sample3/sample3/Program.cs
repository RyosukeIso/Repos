using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sample3
{/// <summary>
/// 「H2Oの温度：」と表示し、実数の温度をキーボードから入力させ、その値に応じて以下のように
/// 表示しなさい。
/// 100.0度以上の場合は、「気体」と表示
/// 0.0度より大きく100.0度未満の場合「液体」と表示
/// 0.0度以下の場合、「個体」と表示
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("H2Oの温度：");
            double a = double.Parse(Console.ReadLine());
            if(a >= 100.0)
            {
                Console.WriteLine("気体");
            }else if(a >0.0)
            {
                Console.WriteLine("液体");
            }
            else
            {
                Console.WriteLine("個体");
            }
        }
    }
}
