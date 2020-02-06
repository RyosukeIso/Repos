using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample11
{/// <summary>
/// 以下のフィールドメソッドを持つ長方形を表すRectangleクラスを作り、
/// 例にならって幅、高さをキーボードから入力させ、面積と周の長さを求めるプログラムを作成しなさい。
/// </summary>
    class Rectangle
    {
        public double width;
        public double height;

        public double GetArea()
        {
          return  width* height;
        }
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }
    }
}
