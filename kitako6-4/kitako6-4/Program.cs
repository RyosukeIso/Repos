using System;

namespace kitako6_4
{
    /// <summary>
    /// サイズを示す数値（ int 型）を引数とし、何等かの文字で例のような三角形を表示するメソッドを作成しなさい。
    ///また、このメソッドを使用してサイズ 3、4、5 の３つの三角形を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DrawTriangle(3);
            Console.WriteLine();
            DrawTriangle(4);
            Console.WriteLine();
            DrawTriangle(5);
            Console.WriteLine();
        }

        static void DrawTriangle(int size)
        {
            for(int i = 0; i <  size; i++)
            {
                for(int j = 0; j <=  i; j++)
                {
                    Console.Write("$");
                  
                }
                Console.WriteLine();
            }
            
        }
    }
}
