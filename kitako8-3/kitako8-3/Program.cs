using System;

namespace kitako8_3
{
    /// <summary>
    /// 前問に加え Animal クラスを継承したクラス、Dog を作成しなさい。
    /// Dog はメンバー・メソッド Run を持つ。
    ///Run を実行すると“トコトコ”という文字列を表示する。
    ///次のプログラムを作成しなさい。
    ///Cat クラスと Dog クラスのインスタンスを作成する。
    ///それぞれの ShowProfile を実行する。
    ///Cat のインスタンスの Sleep を実行する。
    ///Dog のインスタンスの Run を実行する。
    /// </summary>
    class Animal
    {
        public string Name { get; private set; }    // 名前
        public int Age { get; private set; }        // 年齢

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void ShowProfile()
        {
            Console.WriteLine(Name + "," + Age + "歳");
        }
    }

    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {

        }
        public void Sleep()
        {
            Console.WriteLine("スースー");
        }
    }

    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {

        }
        public void Run()
        {
            Console.WriteLine("トコトコ");
        }


    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Cat MyCat = new Cat("kasiwagi", 30);
            MyCat.ShowProfile();
            MyCat.Sleep();
            Dog MyDog = new Dog("makino", 31);
            MyDog.ShowProfile();
            MyDog.Run();
        }
    }
}
