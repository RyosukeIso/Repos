using System;

namespace kitako8_1
{
    /// <summary>
    /// 以下の Animal クラスを継承したクラス（派生クラス）、Cat を作成しなさい。
    /// Cat は メンバー・メソッド Sleep を持つ。
    ///Sleep を実行すると“スースー”という文字列を表示する。
    ///次のプログラムを作成しなさい。
    ///Cat クラスのインスタンスを作成する。
    ///変数 Name、Age に名前と年齢を設定する。
    ///ShowProfile を実行する。
    ///Sleep を実行する。
    /// </summary>
    class Program
    {
        class Animal
        {
            public string Name = "";    // 名前
            public int Age = 0;         // 年齢

            public void ShowProfile()
            {
                Console.WriteLine(Name + "," + Age + "歳");
            }
        }

        class Cat : Animal
        {
            public void Sleep()
            {
                Console.WriteLine("スースー");
            }


        }
        static void Main(string[] args)
        {
            Cat MyCat = new Cat();
            MyCat.Name = "kasiwagi";
            MyCat.Age = 30;
            MyCat.ShowProfile();
            MyCat.Sleep();
        }
    }
}
