using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEx
{
    // C#에서는 struct를 사용하면 Value Type을 만들고, class 사용하면 Reference Type
    // int, double, float, bool 타입들을 기본타입(Primitive Type)이라고 하는데, struct로 정의된 Value Type이다.
    // Value Type은 상속될 수 없으며, 주로 간단한 데이터 값을 저장하는데 사용된다.

    // Reference Type은 class를 정의해서 만들고, 상속이 가능하도, 좀 더 복잡한 데이터와 기능들을 정의하는
    // 곳에 많이 사용된다.

    // 구조체 : struct라는 키워드를 이용해서 정의한다. 클래스와 같이 메소드, 속성(프로퍼티) 등 거의 비슷한
    //          구조를 가지고 있지만, 상속을 할 수 없다.
    //          클래스와 마찬가지로 인터페이스(interface) 구현을 할 수 있다. 

    // 구조체는 클래스와 달리 복사를 할 때 DeepCopy가 이루어진다.
    // 구조체 정의하기
    struct MyPoint
    {
        public int x;
        public int y;

        // 구조체는 매개변수가 없는 생성자는 선언할 수 없다.
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 모든 구조체는 System.Object 형식을 상속하는 System.ValueType으로부터 직접 상속받음
        public override string ToString()
        {
            return string.Format($"{x}, {y}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPoint myPoint;
            myPoint.x = 100;
            myPoint.y = 100;
            
            Console.WriteLine(myPoint.ToString());

            MyPoint myPoint2 = new MyPoint(1000, 1000);
            MyPoint myPoint3 = myPoint2;
            myPoint3.y = 1001;

            Console.WriteLine(myPoint2.ToString());

            Console.WriteLine(myPoint3.ToString());
        }
    }
}
