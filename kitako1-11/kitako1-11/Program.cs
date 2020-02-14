using System;

namespace kitako1_11
{
    /// <summary>
    /// int型の変数ⅹに任意の数値を代入し、ⅹをⅹより小さい任意の数値で
    /// 割った商と余りを表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 3;
            Console.WriteLine("商：{0} 余り：{1}", x / y ,x % y);

        }
    }
}
