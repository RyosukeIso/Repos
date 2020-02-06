using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample1
{/// <summary>
/// 以下の表は、各月の日数です。この表を参考にして、入力した月の日数を表示するプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("月（１～12）を入力して下さい:");
            int a = int.Parse(Console.ReadLine());
            string d = "";
            switch (a)
            {
                case 2:
                    d = "28か29";
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    d = "30";
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    d = "31";
                    break;
                default:
                    Console.WriteLine("適切な値を入力してください");
                    return;
            }
            Console.WriteLine("{0}月の長さは{1}日です。",a,d);
        }
    }
}
