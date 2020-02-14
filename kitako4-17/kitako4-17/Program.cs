using System;

namespace kitako4_17
{
    /// <summary>
    /// 九九表（一の段～九の段）を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("九九の表示");
            for(int i = 1; i <= 9; i++)
            {
                for(int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0}×{1}＝{2,2} ", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
