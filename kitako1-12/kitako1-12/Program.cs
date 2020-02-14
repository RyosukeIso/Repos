using System;

namespace kitako1_12
{
    /// <summary>
    /// int型の変数ⅹに任意の数値を代入し、インクリメント演算子、デクリメント演算子を
    /// 適用して結果を表示することにより演算子の効果を確認するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            x++;
            Console.WriteLine(x);
            x--;
            x--;
            Console.WriteLine(x);
        }
    }
}
