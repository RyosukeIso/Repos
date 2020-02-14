using System;

namespace kitako6_2
{
    /// <summary>
    /// ２つの整数の平均を計算するメソッドを作成しなさい。２つの int 型引数を取り、結果を int 型の戻り値として返すこと。
    /// また、メソッドの動作を検証できるようにプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3と9の平均＝" + average(3, 9));
        }
        static int average(int n, int m)
        {
            return (n + m) / 2;
        }
    }
}
