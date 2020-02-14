using System;

namespace kitako4_11
{
    /// <summary>
    /// 個数を示す数値を入力し、その個数分だけ 0 ～ 9 の数字を表示するプログラムを作成しなさい。
    /// 数字は 0, 1, 2, 3, , の順に表示し、9 の次は 0 に戻るものとします。 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            for( int i = 0, num = 0; i <= count; i++)
            {
                Console.WriteLine(num++);
                if(num > 9)
                {
                    num = 0;
                }
            }
        }
    }
}
