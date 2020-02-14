using System;

namespace kitako5_4
{
    /// <summary>
    /// 数値を繰り返して入力し、合計が 100 を超えた場合、または入力が 10 回行われた場合、
    /// 入力を止め入力された数値をすべて表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            int cnt, sum;
            for(cnt = 0, sum = 0; cnt < 10 && sum <= 100; cnt++)
            {
                nums[cnt] = int.Parse(Console.ReadLine());
                sum += nums[cnt];
            }
            for (int i = 0; i < cnt; i++)
            {
                Console.Write(nums[i] );
            }
          
               
        }
    }
}
