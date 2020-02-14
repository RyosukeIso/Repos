using System;

namespace kitako4_6
{
    /// <summary>
    /// 整数、0 か 1 を 10 回入力する。
    /// これを対戦成績と考え、0 を負け、1 を勝ちとして、勝ちの総数、負けの総数
    /// を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lose = 0;
            for( int i = 1; i <= 10; i++)
            {
                Console.WriteLine("0か1を入力してください。: ");
                int num = int.Parse(Console.ReadLine());

                if(num == 0)
                {
                    lose += 1;
                }else if(num == 1)
                {
                    win += 1;
                }
               
            }
            Console.WriteLine(" 勝ち数 : {0}, 負け数 : {1} ", win, lose);
        }
    }
}
