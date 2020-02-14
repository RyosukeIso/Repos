using System;

namespace kitako4_7
{
    /// <summary>
    /// 次のプログラムを作成しなさい。
    ///巨人、阪神戦で毎回の得点を入力する。（１回～９回）
    ///入力が終わったら、それぞれの得点とどちらが勝ったかを表示する。
    /// </summary>
    class Program
    {
       
        static void Main(string[] args)
        {
            int gia = 0;
            int tig = 0;
            for ( int i = 1; i <= 9; i++)
            {
                Console.Write("{0}回表、巨人の得点は？: ",i);
                int x = int.Parse(Console.ReadLine());
                gia += x;

                Console.Write("{0}回裏、阪神の得点は？: ",i);
                int y = int.Parse(Console.ReadLine());
                tig += y;
            }
            Console.WriteLine("巨人の得点: {0}, 阪神の得点: {1} ", gia , tig);

            if(gia > tig)
            {
                Console.WriteLine("巨人の勝ち");
            }else if(gia < tig)
            {
                Console.WriteLine("阪神の勝ち");
            }
            else
            {
                Console.WriteLine("引き分け");
            }
        }
    }
}
