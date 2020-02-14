using System;

namespace kitako5_2
{
    /// <summary>
    /// 次のプログラムを作成しなさい。
    /// 10 個の数値を入力する。
    /// 入力された順番と逆の順番で 10 個の数値を表示する。
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
            for (int i = 9; i >= 1; i--)
            {
                Console.WriteLine(num[i]);
            }

        }
    }
}
