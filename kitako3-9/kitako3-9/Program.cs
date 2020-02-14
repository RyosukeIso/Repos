using System;

namespace kitako3_9
{
    /// <summary>
    /// 曜日と、午前、午後、夜間の区別を入力し、病院が開いているか、
    /// 休診であるかを表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" 曜日を選択してください。 ");
            Console.Write(" 0=日曜、1=月曜、2=火曜、3=水曜、4=木曜、5=金曜、6=土曜　：");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine(" 時間を入力してください。");
            Console.Write(" 0=午前、1=午後、2=夜間　：");
            int zone = int.Parse(Console.ReadLine());

            bool bopen = true;

            if(day == 0)
            {
                bopen = false;
            }else if(day == 2 && zone == 0)
            {
                bopen = false;
            }else if(day == 3 && zone == 2)
            {
                bopen = false;
            }else if(day == 5 && zone == 1)
            {
                bopen = false;
            }else if(day == 6 && (zone == 1 && zone == 1))
            {
                bopen = false;
            }

            if (bopen)
            {
                Console.WriteLine(" 診療しています。");
            }
            else
            {
                Console.WriteLine(" 休診中です。");
            }
        }
    }
}
