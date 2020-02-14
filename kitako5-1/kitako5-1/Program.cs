using System;

namespace kitako5_1
{
    /// <summary>
    /// 次のプログラムを作成しなさい。
    /// 10 個の数値を入力する。
    /// 入力された各々の数値を 2 倍にして表示する。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                num[i] = int.Parse(Console.ReadLine());


              
                Console.WriteLine(num[i] * 2);
                Console.WriteLine();
            }
             
        }
    }
}
