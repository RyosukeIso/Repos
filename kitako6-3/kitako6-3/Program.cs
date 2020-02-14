using System;

namespace kitako6_3
{
    /// <summary>
    /// ２つの整数の大きい方を選ぶメソッドを作成しなさい。
    /// ２つの int 型引数を取り、大きい方の数値を戻り値として返すこと。
    ///また、このメソッドを使用して、int 型の変数 x、y、z にそれぞれ数値を入力し、
    ///最も大きい数値を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxValue(x, MaxValue(y, z)));

        }

        static int MaxValue(int num1, int num2)
        {
            if(num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
    }
}
