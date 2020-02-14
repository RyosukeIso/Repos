using System;

namespace kitako4_9
{
    /// <summary>
    /// 整数を 10 回入力し、最大値と最小値を求めるプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            int max = 0;
            int min = 0;
            for ( int i = 0; i < 10; i++)
            {

                int num = int.Parse(Console.ReadLine());
                if(num == 0)
                {
                    max = num;
                    min = num;
                }else if(num > max)
                {
                    max = num;
                }
                else if(min > num)
                {
                    min = num;
                }
            }
            Console.WriteLine("最大値：{0}, 最小値：{1}", max , min);
        }
    }
}
