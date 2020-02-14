using System;

namespace kitako4_19
{
    /// <summary>
    /// 数値を繰り返して入力し、0 が入力されたら入力を止め、平均値を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            while (true)
            {
                Console.Write("数値を入力：");
                int num = int.Parse(Console.ReadLine());
               
                if (num == 0)
                {
                   
                    break;
                }
                sum += num;
                count++;

            }
            Console.WriteLine("average:{0} ", sum / count);
        }
    }
}
