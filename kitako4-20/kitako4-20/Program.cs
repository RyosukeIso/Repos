using System;

namespace kitako4_20
{
    /// <summary>
    /// サイズを示す数値を入力し、何等かの文字で例のような三角形を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("put number");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine();
            }
        }
    }
}
