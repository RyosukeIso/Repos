using System;

namespace kitako4_16
{
    /// <summary>
    /// 入力された数が素数かどうかを判定するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("数を入力：");
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            for(int i = 2; i <= num; i++)
            {
                if(num % i == 0)
                {
                    count++;
                }
               
            }
            if (count == 1)
            {
                Console.WriteLine("{0}は素数です。", num);
            }
            else
            {
                Console.WriteLine("{0}は素数ではありません。", num);
            }
        }
    }
}
