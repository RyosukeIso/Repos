using System;

namespace kitako3_10
{
    /// <summary>
    /// 整数値 x, y を入力し、以下の条件に該当する場合、そうであることを示す文を表示しなさい。
    /// x は y より小さく、かつ、x と y は共に偶数である。
    /// x と y は等しく、かつ、負の数である。
    /// x は y より小さい、または、x は偶数である。
    /// x は 10 以下または 100 以上で、かつ、y は 10 以上かつ 100 以下である。
    /// x も y も負の数である、ではない。（ x も y も負の数である、の否定）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x > y && (x % 2 == 0 && y % 2 == 0))
            {
                Console.WriteLine("x は y より小さく、かつ、x と y は共に偶数である。");
            }else if(x == y && (x < 0 && y < 0))
            {
                Console.WriteLine("x と y は等しく、かつ、負の数である。");
            }else if (x < y || x % 2 == 0)
            {
                Console.WriteLine("x は y より小さい、または、x は偶数である。");
            }else if ((x <= 10 && x >= 100) && (y >= 10 && y <= 100))
            {
                Console.WriteLine("x は 10 以下または 100 以上で、かつ、y は 10 以上かつ 100 以下である。");
            }else if(!(x < 0 && y < 0))
            {
                Console.WriteLine(" x も y も負の数である、ではない。");
            }
        }
    }
}
