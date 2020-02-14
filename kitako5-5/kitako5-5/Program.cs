using System;

namespace kitako5_5
{
    /// <summary>
    /// 次のコードに追加し、九九表を表示するプログラムを完成させなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] kuku = new int[9, 9];

            // 配列 kuku に値を代入する
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    kuku[i, j] = (i + 1) * (j + 1);
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    Console.Write(" {0,2}", kuku[i, j]);

                Console.WriteLine();
            }

        }
    }
}
