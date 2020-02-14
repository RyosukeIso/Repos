using System;

namespace kitako1_10
{
    /// <summary>
    /// int型の変数ⅹに任意の整数を代入し、
    /// ⅹを1乗、2乗、3乗した結果を表示するプログラムを作成しなさい
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine("2の1乗は{0}", x);
            Console.WriteLine("2の2乗は{0}", x * x);
            Console.WriteLine("2の乗は{0}", x * x * x);

        }
    }
}
