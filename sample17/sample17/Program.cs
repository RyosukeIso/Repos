using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample17
{/// <summary>
/// 月の数を表す１～１２の数値を入力させ、その数字に対応する月の名前を英語で表示するプログラムを作成しなさい。
/// このとき月の名前はString型の配列monthに代入しておくこと。
/// なお、範囲外の数値を入力した場合、「適切な値を入力してください。」というメッセージを表示し、プログラム
/// を終了すること。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string[] month = {"January","February","March","April","May","June","July","August","September","October"
            ,"November","December"};
            Console.WriteLine("月（1～12）を入力してください：");
            int a = int.Parse(Console.ReadLine());
            if (a >= 1&& a <= month.Length)
            {
                Console.WriteLine("{0}月は英語で{1}です。", a, month[a - 1]);
            }
            else
            {
                Console.WriteLine("適切な値を入力してください。");
            }
        }
    }
}
