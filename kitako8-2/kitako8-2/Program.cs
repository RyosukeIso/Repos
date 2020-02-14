using System;

namespace kitako8_2
{
    /// <summary>
    /// 前問の Animal クラスを以下のように変更しなさい。Name、Age を自動実装プロパティにし、
    /// コンストラクタで初期化するようにします。 
    ///それに合わせて、Cat クラスを変更しなさい。 
    /// </summary>
    /// 
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
    class Program
    {
        class Cat :Animal
        {
            public Cat (string name, int age): base(name, age)
            {

            }
            public void Sleep()
            {
                Console.WriteLine("スースー");
            }


        }
        static void Main(string[] args)
        {
            Cat MyCat = new Cat("kasiwagi", 30);
            MyCat.ShowProfile();
            MyCat.Sleep();
        }
    }
}
