using System;

namespace kitako1_9
{
    /// <summary>
    /// int型の変数ⅹに任意の整数を代入し、
    /// ⅹを2倍、3倍、4倍した結果を表示するプログラムを作成しなさい
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            for(int i = 2; i <= 4; i++)
            {
                Console.WriteLine(" x ×　{0} = {1}", i , x * i);
            }
        }
    }
}
