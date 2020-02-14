using System;

namespace kitako4_2
{
    /// <summary>
    /// 九九、三の段（ 3 ～ 27 の 3 の倍数）を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                Console.WriteLine(" 3 × {0} = {1,2:d} " , i , 3 * i);
            }
        }
    }
}
