using System;

namespace kitako5_3
{
    /// <summary>
    /// 次のプログラムを作成しなさい。
    /// 10 個の数値を入力する。
    /// 入力された数値を偶数と奇数に分類して表示する。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            for (int i = 1; i < 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());


            }
            Console.WriteLine();
            
                Console.WriteLine("偶数: ");
            for (int i = 1; i < 10; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine(num[i]);
                }
            }
                Console.WriteLine("奇数: ");
            for (int i = 1; i < 10; i++)
            {
                if (num[i] % 2 != 0)
                {
                    Console.WriteLine(num[i]);

                }

            }
        }
    }
}
