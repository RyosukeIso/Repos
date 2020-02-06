using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample15
{
    class Program
    {/// <summary>
    /// 1から100までの間の素数をすべて表示するプログラムを作成しなさい。
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            for(int i = 2; i <= 100; i++)
            {
                int count = 0;
                for(int n = 1;n <= i; n++)
                {
                    if(i % n == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    Console.Write("{0} ", i);
                }
            }
            Console.WriteLine();
        }
    }
}
