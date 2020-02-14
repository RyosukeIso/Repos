using System;

namespace kitako7_5
{
    /// <summary>
    /// 硬貨の入れ物のようなクラス、CoinCase を作成しなさい。
    ///500 円、100 円、50 円、10 円、5 円、1 円が、それぞれ何枚あるかを管理する。
    ///AddCoins メソッドで硬貨を追加する。
    ///引数は硬貨の種類（ int ）と枚数（ int ）。
    ///GetCount メソッドで、指定した硬貨が何枚あるかを取得する。
    ///引数は硬貨の種類（ int ）、戻り値は枚数（ int ）。
    ///GetAmount メソッドで、硬貨の総額を取得する。
    ///引数はなし、戻り値は硬貨の総額（ int ）。
    ///CoinCase クラスを使用して次のプログラムを作成しなさい。
    ///CoinCase クラスのインスタンスを作成する。
    ///種類と枚数を入力し、AddCoins メソッドで硬貨を追加することを 10 回繰り返す。
    ///各硬貨の枚数を表示する。
    ///硬貨の総額を表示する。
    /// </summary>
    class Program
    {
        class CoinCace
        {
            private int Yen500 = 0;
            private int Yen100 = 0;
            private int Yen50 = 0;
            private int Yen10 = 0;
            private int Yen5 = 0;
            private int Yen1 = 0;

            public void AddCoins(int kind, int count)
            {
                switch (kind)
                {
                    case 500:
                        Yen500 += count;
                        break;
                    case 100:
                        Yen100 += count;
                        break;
                    case 50:
                        Yen50 += count;
                        break;
                    case 10:
                        Yen10 += count;
                        break;
                    case 5:
                        Yen5 += count;
                        break;
                    case 1:
                        Yen1 += count;
                        break;
                }
            }

            public int GetCount(int kind)
            {
                switch (kind)
                {
                    case 500:
                        return Yen500;
                    case 100:
                        return Yen100;
                    case 50:
                        return Yen50;
                    case 10:
                        return Yen10;
                    case 5:
                        return Yen5;
                    case 1:
                        return Yen1;

                }
                return 0;
            }

            public int GetAmount()
            {
                return (Yen500 * 500 + Yen100 * 100 + Yen50 * 50 + Yen10 * 10 + Yen5 * 5 + Yen1 * 1);
            }
        }
        static void Main(string[] args)
        {
            CoinCace cace = new CoinCace();
          for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("コインの種類は？：");
                int kind = int.Parse(Console.ReadLine());
                Console.WriteLine("何枚？：");
                int count = int.Parse(Console.ReadLine());

                cace.AddCoins(kind, count);

            }

            Console.WriteLine("500円は{0}枚です。",cace.GetCount(500));
            Console.WriteLine("100円は{0}枚です。", cace.GetCount(100));
            Console.WriteLine("50円は{0}枚です。", cace.GetCount(50));
            Console.WriteLine("10円は{0}枚です。", cace.GetCount(10));
            Console.WriteLine("5円は{0}枚です。", cace.GetCount(5));
            Console.WriteLine("1円は{0}枚です。", cace.GetCount(1));
            Console.WriteLine("総額は{0}円です。", cace.GetAmount());

        }
    }
}
