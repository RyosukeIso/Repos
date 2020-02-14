using System;

namespace kitako1_6
{
    /// <summary>
    /// 次のプログラムを作成しなさい。
    /// ①int型の変数ⅹに数値７をする。
    /// ②変数ⅹの値を３倍にする。
    /// ③変数ⅹの値を表示する。
    /// ④変数ⅹの値を半分にする。
    /// ⑤変数ⅹの値を表示する。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x =  7;
            x *= 3;
            Console.WriteLine("x = " + x);
            x /= 2;
            Console.WriteLine("x = " + x);
        }
    }
}
