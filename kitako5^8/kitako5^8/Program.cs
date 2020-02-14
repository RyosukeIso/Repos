using System;

namespace kitako5_8
{
    /// <summary>
    /// 整数を 10 回入力し、小さい順に並べ替えて表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];
            for(int i = 0; i < 10; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        int t = nums[i];
                        nums[i] = nums[j];
                        nums[j] = t;
                    }
                }         
            }
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(nums[i]);
            }

        }
    }
}
