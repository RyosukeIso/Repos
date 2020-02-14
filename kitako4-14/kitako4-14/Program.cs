using System;

namespace kitako4_14
{
    /// <summary>
    /// 前の問題に次の修正を加えなさい。
    ///１球ごとにストライク、ボール、ファウルの何れかを入力する。（残念ながらヒットにはなりません）
    ///ファウルの場合、２ストライクまではストライクにカウントするが、３ストライクにはならない。
    ///３ストライクまたは４ボールになったら入力を止め、ストライクとボールのカウントを表示する。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int str = 0;
            int bor = 0;
            int fau = 0;

            while (str < 3 && bor < 4)
            {
                Console.WriteLine("strike 1, bowl 2, faul 3");
                int num = int.Parse(Console.ReadLine());

                if(num == 1 || (num == 3 && str < 2))
                {
                    str++;
                }else if(num == 2)
                {
                    bor++;
                }

            }
            Console.WriteLine("{0}ストライク {1}ボール",str ,bor);
        }
    }
}
