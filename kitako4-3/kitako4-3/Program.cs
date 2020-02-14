using System;

namespace kitako4_3
{
    /// <summary>
    /// 2 の 1 乗から 8 乗までを計算し表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            for(int i = 1; i <= 8; i++)
            {
                x *= 2;
                Console.WriteLine(" 2の{0}乗 = {1,3:d}", i , x );
            }
        }
    }
}
