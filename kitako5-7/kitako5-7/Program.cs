using System;

namespace kitako5_7
{
    /// <summary>
    /// 1 桁の数値（ 1 ～ 9 に限定）を２つ入力し、その積を表示するプログラムを作成しなさい。
    /// ただし、九九の計算結果が入った配列を予め作成して利用すること。（前問を参考に）
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[,] kuku = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                    kuku[i, j] = (i + 1) * (j + 1);
            }
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(kuku[a - 1, b - 1]);
        }
    }
}
