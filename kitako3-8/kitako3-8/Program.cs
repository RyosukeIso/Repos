using System;

namespace kitako3_8
{
    /// <summary>
    /// 中間試験と、期末試験の点数（それぞれ 0 ～ 100 点）を入力し、
    /// 次の条件に従って合格、不合格を判定するプログラムを作成しなさい。
    ///  両方とも60点以上の場合、合格
    ///  合計が130点以上の場合、合格
    ///  合計が100点以上で、どちらかの試験が90点以上であれば合格
    ///  上記以外は不合格
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("中間試験の点数：");
            int x = int.Parse(Console.ReadLine());
            Console.Write("期末試験の点数：");
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;

            if (x >= 60 && y >= 60)
            {
                Console.WriteLine("合格");
            }
            else if (sum >= 130)
            {
                Console.WriteLine("合格");
            }
            else if ((sum >= 100) && (x >= 90 || y >= 90))
            {
               
                    Console.WriteLine("合格");
                
            }
            else
            {
                Console.WriteLine("不合格");
            }

           
        }
    }
}
