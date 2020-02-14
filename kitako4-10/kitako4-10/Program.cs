using System;

namespace kitako4_10
{
    /// <summary>
    /// 個数を示す数値を入力し、その個数分だけ‘*’を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Console.WriteLine("*");
            }
        }
    }
}
