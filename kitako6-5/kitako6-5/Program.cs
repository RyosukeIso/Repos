using System;

namespace kitako6_5
{
    /// <summary>
    /// サイズを示す数値と、表示する文字を引数とし、三角形を表示するメソッドを作成しなさい。
    ///このメソッドを使用して、サイズと文字の異なる３つの三角形を表示しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(3, '%');
            Console.WriteLine();
            DrawTriangle(66, '+');
            Console.WriteLine();
            DrawTriangle(4, '#');

        }

        static void DrawTriangle(int size, char ch)
        {
            for(int i = 0; i < size; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        } 
    }
}
