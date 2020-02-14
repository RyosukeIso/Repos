using System;

namespace kitako6_1
{
    /// <summary>
    /// 整数の 2 乗を計算するメソッドを作成しなさい。１つの int 型引数を取り、結果を int 型の戻り値として返すこと。
    /// また、メソッドの動作を検証できるようにプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(pow2(3));
        }
        static int pow2 (int n)
        {
            return n * n;
        }
    }
}
