using System;

namespace kitako1_7
{
    /// <summary>
    /// int型の変数x,yに任意の数値を代入し、xの値をｙに、ｙの値をⅹに入れ替えて
    /// ⅹとyの値を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int y = 2;
            int z = x;

            x = y;
            y = z;


            Console.WriteLine("x = {0}, y = {1}", x,y);
        }
    }
}
