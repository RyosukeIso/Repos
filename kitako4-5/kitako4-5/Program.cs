using System;

namespace kitako4_5
{
    class Program
    {
        /// <summary>
        /// 整数を 10 回入力し、平均値を求めるプログラムを作成しなさい。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("平均は = {0}",sum / 10);
        }
    }
}
