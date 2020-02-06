using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample12
{/// <summary>
/// コンソールで英単語を入力したとき、その単語の文字数、大文字のみに変換したもの、小文字のみに変換したもの、
/// を表示しなさい。その際、処理にはStringクラスのメソッドを用いて行うこと。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("英文を入力してください:");
            string str = Console.ReadLine();
            Console.WriteLine("大文字：{0}", str.ToUpper());
            Console.WriteLine("小文字:{0}", str.ToLower());

        }
    }
}
