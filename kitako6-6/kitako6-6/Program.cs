using System;

namespace kitako6_6
{
    /// <summary>
    /// 九九のひとつの段を表示するメソッドを作成しなさい。何の段（ 1 ～ 9 ）であるかを引数とします。
    ///このメソッドを使用して、九九表を作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 9; i++)
            {
                kuku(i);
            }
        }

        static void kuku(int num)
        {
            for(int i = 1; i <= 9; i++)
            {
                Console.Write("{0}×{1}＝{2} ", num, i, num * i);
            }
            Console.WriteLine();
        }
    }
}
