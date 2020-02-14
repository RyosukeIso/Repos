using System;

namespace kitako3_2
{
    /// <summary>
    /// 2つの整数値を入力し、大きい方の数を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力①：");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("整数値を入力②：");
            int num2 = int.Parse(Console.ReadLine());

            if( num1 > num2)
            {
                Console.WriteLine(num1);
            }
            if (num1 < num2)
            {
                Console.WriteLine(num2);
            }
        }
    }
}
