using System;

namespace kitako3_4
{
    /// <summary>
    /// int 型の変数 x、y にそれぞれ数値を入力し、
    /// x が y より大きい場合には“xはyより大きい”、x が y より小さい場合には“xはyより小さい”、
    /// x と y が等しい場合には“xとyは等しい”と表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値xを入力：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("整数値yを入力：");
            int y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("xはyより大きい");
            }else if(x < y)
            {
                Console.WriteLine("yはxより大きい");
            }
            else
            {
                Console.WriteLine("xとyは等しい");
            }
        }
    }
}
