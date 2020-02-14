using System;

namespace kitako7_4
{
    /// <summary>
    /// 前問の Dog クラスに、次の内容を追加しなさい。
    /// 犬種を保持する string 型のメンバー変数。
    ///犬種を設定する引数（ string ）を持つコンストラクタ。
    ///ShowProfile メソッドで、犬種、名前、年齢、を表示するようにする。
    ///修正した Dog クラスを使用して次のプログラムを作成しなさい。///
    ///犬種を指定して Dog クラスのインスタンスを作成する。
    ///名前と年齢を設定する。
    ///プロフィールを表示する。
    /// </summary>
    class Program
    {
        class Dog
        {
            private string mName = "";    // 名前
            private int mAge = 0;　　　　 // 年齢
            private string mValue = "";   // 犬種

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

            public string Value
            {
                get { return mValue; }
                set { mValue = value; }
            }


            public void ShowProfile()
            {
                Console.WriteLine(mName + "," + mAge + "歳 ," + mValue);
            }
        }
        static void Main(string[] args)
        {
            Dog d1 = new Dog();
            d1.Name = "興梠慎三";
            d1.Age = 33;
            d1.Value = "FW";
            d1.ShowProfile();
        }
    }
}
