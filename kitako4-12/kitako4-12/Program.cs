using System;

namespace kitako4_12
{
    /// <summary>
    /// 数値を繰り返し入力し、合計が 100 を超えたら入力を止めて合計を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            while(sum < 100)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("合計：{0}", sum);
        }
    }
}
