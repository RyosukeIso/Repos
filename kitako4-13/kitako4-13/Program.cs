using System;

namespace kitako4_13
{
    /// <summary>
    /// ストライク・カウントを数えるプログラムを作成しなさい。
    ///１球ごとにストライクかボールかを入力する。
    ///３ストライクまたは４ボールになったら入力を止め、ストライクとボールのカウントを表示する。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int str = 0;
            int bor = 0;
            for(int i = 0; i <= 5; i++)
            {
                Console.WriteLine("ストライクなら１、ボールなら２");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    str++ ;
                }
                else if (num == 2)
                {
                    bor++ ;
                }
                else if (str == 3 || bor == 4)
                {
                    break;
                }
            }
            Console.WriteLine("ストライク: {0}, ボール: {1}", str , bor);
        }
    }
}
