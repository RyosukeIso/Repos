using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample6
{/// <summary>
/// 以下のルーの数あてゲームを作りなさい。
/// ①0から10の乱数を1つ発生させ、それを当てるゲーム
/// ②入力が許される回数は３回
/// ③入力した数値が正しければ「正解です！」と出力してゲームを終了する。
/// ④はずれの場合、入力した数字に応じて「大きすぎます。」または「小さすぎます。」と表示する。
/// ⑤３回数値を入力しても正解がでなければ「ゲームオーバー！」と表示し、正解の数値を表示してプログラムを終了する。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数当てゲーム");
            Console.WriteLine("0から10の数値を入力してください。");
            Random rnd = new Random();
            int n = rnd.Next(1, 11);
            int i = 1;
            while(i <= 3)
            {
                Console.WriteLine("{0}回目", i);
                int a = int.Parse(Console.ReadLine());
                if(a > n)
                {
                    Console.WriteLine("大きすぎます。");
                }else if(a < n)
                {
                    Console.WriteLine("小さすぎます。");
                }
                else
                {
                    Console.WriteLine("正解です！");
                }
                i++;
            }
            if(i == 4)
            {
                Console.WriteLine("ゲームオーバー！");
                Console.WriteLine("正解は{0}です。", n);
            }
        }
    }
}
