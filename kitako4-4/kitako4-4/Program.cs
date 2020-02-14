using System;

namespace kitako4_4
{
    /// <summary>
    /// 7 の階乗を計算し、表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            for(int i = 6; i >= 2; i--)
            {
                x *= i;
                Console.WriteLine(x);
            }
        }
    }
}
