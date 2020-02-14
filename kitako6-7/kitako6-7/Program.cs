using System;

namespace kitako6_7
{
    /// <summary>
    /// ある数が素数かどうかを判定するメソッドを作成しなさい。
    /// このメソッドを使用して 1000 未満の素数をすべて表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int n = 1; n <1000; n++)
            {
               if(IsPrimeNumber(n))
                {
                    Console.Write(n + " ");
                }
            }
        }

         static bool IsPrimeNumber(int num)
        {
           if(num <= 3)
            {
                return true;
            }

           for(int i = 2; i < (num / 2); i++)
            {
                if((num % i) == 0)
                {
                    return false;
                }
                

            }
            return true;

        }
    }
}
