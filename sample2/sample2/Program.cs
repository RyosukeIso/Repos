using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample2
{/// <summary>
/// コンソールから文字列を入力し、「Hello」と入力された場合は「Helloが入力されました。」と表示し、それ以外の文字列
/// が入力された場合は、「Helloと入力してください。」と表示するプログラムを作成しなさい。
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("文字列を入力：");
            string a = Console.ReadLine();
            if(a == "Hello")
            {
                Console.WriteLine("Helloが入力されました。");
            }
            else
            {
                Console.WriteLine("Helloと入力してください。");
            }
        }
    }
}
