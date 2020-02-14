using System;

namespace kitako4_18
{
    /// <summary>
    /// 数値を繰り返して入力し、0 が入力されたら入力を止め、それまでの合計を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if(num == 0)
                {
                    Console.WriteLine("sum:{0}", sum);
                    break;
                }
            }
        }
    }
}
