using System;

namespace kitako8_5
{
    /// <summary>
    /// 前問で作成したクラス Animal、Cat、Dog を使用して、次のプログラムを作成しなさい。
    /// Animal クラスの配列を作成する。要素数は 4。
    /// 配列の偶数番目（ 0 と 2 ）には Cat クラスのインスタンス、奇数番目（ 1 と 3 ）には Dog クラスのインスタンスを設定する。
    /// 配列の総ての要素の ShowProfile と Speak メソッドを実行する。
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
            Animal[] animals = new Animal[4];
            animals[0] = new Cat("柏木陽介", 31);
            animals[1] = new Dog("槙野智章", 32);
            animals[2] = new Cat("森脇良太", 33);
            animals[3] = new Dog("西川周作", 33);

            foreach(Animal players in animals)
            {
                players.ShowProfile();
                players.Speak();
            }
            
            
        }
    }
}
