using System;

namespace kitako2_6
{
    /// <summary>
    /// 年齢を訊ね、生まれてから現在までの、おおよその日数を表示するプログラムを作成しなさい。
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("何歳ですか？: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("生まれてから現在までのおおよその日数：{0}", age * 365);
        }
    }
}
