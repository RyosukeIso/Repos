using System;

namespace kitako4_8
{
    /// <summary>
    /// 自然数（正の整数）を 10 回入力し、最大値を求めるプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            for( int i = 1; i < 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if(max < num)
                {
                    max = num;
                }
            }
            Console.WriteLine("最大値：{0} ", max);
        }
    }
}
