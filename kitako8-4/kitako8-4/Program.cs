using System;

namespace kitako8_4
{
    /// <summary>
    /// 前問の Animal クラスに以下の仮想メソッドを追加しなさい。
    /// Dog クラス、Cat クラスに Speak メソッドをオーバーライドするメソッドを追加しなさい。
    /// Dog では“ワンワン”、Cat では“ニャー”という文字列を表示します。
    ///次のプログラムを作成しなさい。
    ///Cat クラスと Dog クラスのインスタンスを作成する。
    ///それぞれの ShowProfile を実行する。
    ///それぞれの Speak を実行する。
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
        public virtual void Speak()
        {
            Console.WriteLine("......");
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

        public override void Speak()
        {
            Console.WriteLine("ニャー");
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
        public override void Speak()
        {
            Console.WriteLine("ワンワン");
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Cat MyCat = new Cat("kasiwagi", 30);
            MyCat.ShowProfile();
            MyCat.Sleep();
            MyCat.Speak();
            Dog MyDog = new Dog("makino", 31);
            MyDog.ShowProfile();
            MyDog.Run();
            MyDog.Speak();
        }
    }
}
