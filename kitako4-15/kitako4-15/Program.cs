using System;

namespace kitako4_15
{
    /// <summary>
    /// 2 以上の数値を入力し、素因数分解した結果を表示しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int x = 2; n > 1; x++)
            {
                while ((n % x) == 0)
                {
                    Console.Write("{0} ", x);
                    n /= x;
                }
            }



        }
    }
}
