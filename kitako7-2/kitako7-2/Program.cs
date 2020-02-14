using System;

namespace kitako7_2
{
    /// <summary>
    /// 前問の Dog クラスに、次の内容を追加しなさい。
    ///年齢を保持する int 型のメンバー変数。
    ///年齢を取得、設定するプロパティ、Age。
    ///ShowProfile メソッドで名前と年齢を表示するようにする。
    ///修正した Dog クラスを使用して次のプログラムを作成しなさい。
    ///Dog クラスのインスタンスを作成する。
    ///名前と年齢を設定する。
    ///プロフィールを表示する。
    /// </summary>
    class Program
    {
        class Dog
        {
            private string mName = "";
            private int mAge;

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
                Console.WriteLine(mName + mAge +"歳");
            }
        }
        static void Main(string[] args)
        {
            Dog MyDog = new Dog();
            MyDog.Name = "Messi";
            MyDog.Age = 7897;
            MyDog.ShowProfile();
        }
    }
}
