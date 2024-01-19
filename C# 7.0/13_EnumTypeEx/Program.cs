using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_EnumTypeEx
{
    internal class Program
    {        enum City { Seoul = 02, Incheon = 032, Daegu = 032, Daejeon }
        static void Main(string[] args)
        {
            // enum은 열거형 상수(constant)를 표현하기 위한 것
            // 선언 형식:
            // enum 열거형식명 : 자료형 { 상수1, 상수2, 상수3 }
            // 위에서 자료형은 정수형 자료형만 사용된다.
            // 정수형 자료형 (byte, sbyte, short, ushort, int, uint, long, ulong, char)
            // 자료형을 생략해서 사용하는 경우가 많은데 생략했을 경우에는 int형으로 설정된다.

            // enum City { Seoul, Incheon, Daegu }  // 숫자를 설정하지 않은 경우 0, 1, 2 ...
            // 열거형식 안에 선언된 상수들이 어떤 값도 할당되지 않았을 경우에는 
            // 첫번째 상수 요소에는 0이 할당된다. 그리고, 그 다음 요소에는 1, 그 다음 요소에는 2가 할당된다.
            // 컴파일러가 자동으로 1씩 추가해서 할당한다.


            Console.WriteLine((int)City.Seoul);
            Console.WriteLine((int)City.Incheon);
            Console.WriteLine((int)City.Daegu);
            Console.WriteLine((int)City.Daejeon);

            City sel = City.Seoul;
            Console.WriteLine(sel == City.Seoul);
            Console.WriteLine(sel == City.Daejeon);
        }
    }
}
