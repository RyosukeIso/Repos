using System;

namespace kitako7_3
{
    /// <summary>
    /// 前問の Dog クラスを使用して次のプログラムを作成しなさい。
    /// Dog クラスのインスタンスを２つ作成する。
    ///１つ目のインスタンスに、名前と年齢を設定する。
    ///２つ目のインスタンスに、名前と年齢を設定する。
    ///１つ目のインスタンスの、プロフィールを表示する。
    ///２つ目のインスタンスの、プロフィールを表示する。
    /// </summary>
    class Program
    {
        class Dog
        {
            private string mName = "";    // 名前
            private int mAge = 0;         // 年齢

            public string Name
            {
                get { return mName; }
                set { mName = value; }
            }

            public int Age
            {
                get { return mAge; }
                set { mAge = value; }
            }

            public void ShowProfile()
            {
                Console.WriteLine(mName + "," + mAge + "歳");
            }
        }

        static void Main(string[] args)
        {
            Dog d1, d2;
            d1 = new Dog();
            d2 = new Dog();
            d1.Name = "稲葉";
            d2.Name = "松本";
            d1.Age = 55;
            d2.Age = 59;
            d1.ShowProfile();
            d2.ShowProfile();
        }
    }
}
