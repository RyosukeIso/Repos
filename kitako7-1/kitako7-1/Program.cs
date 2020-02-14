using System;

namespace kitako7_1
{
    /// <summary>
    /// 以下の Dog クラスを使用して、次のプログラムを作成しなさい。
    /// Dog クラスのインスタンスを作成する。
    /// Name プロパティで名前を設定する。
    /// ShowProfile メソッドで名前を表示する。
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {
            Dog d1;
            d1 = new Dog();
            d1.Name = "稲葉";
            d1.ShowProfile();

        }

        class Dog
        {
            private string mName = "";    // 名前

            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }

            public void ShowProfile()
            {
                Console.WriteLine(mName);
            }
        }
    }
}
