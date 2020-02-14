using System;

namespace kitako4_22
{
    /// <summary>
    /// フィボナッチ数列を表示するプログラムを作成しなさい。
    /// 最初の 2 つの項を 0、1 とし、1000 まで（ 1000 以下の項）を表示するものとします。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int num3 = num1 + num2;

            while(num1 < 1000)
            {
                Console.WriteLine(num1);

                num1 = num2;
                num2 = num3;
                num3 = num1 + num2;
            }
        }
    }
}
