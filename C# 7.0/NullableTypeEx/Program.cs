using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NULL : 어떤 변수가 데이터를 가지고 있지 않을 때 표현방법
            // 즉, 메모리상에 어떤 데이터도 갖고 있지 않을 때 사용하는 키워드이다.

            // NULL을 가질 수 있는 데이터 타입(Reference 타입)이 있는데, 대표적으로 String 타입은
            // NULL을 가질 수 있는 타입이다.
            // NULL을 가질 수 없는 타입은 Value 타입(int, DateTime...)

            // 정수(int)나 날짜(DateTime) 같은 Value Type은 일반적으로 NULL을 가질 수 없다.
            
            // Nullable 형식을 적용하면 정수 같은 Value Type도 null값을 가질 수 있다.
            // 즉, 값이 비어있는 Nullable Type의 변수를 선언할 수 있다.

            // Nullable 선언할 때는 "?"를 이용한다.
            // 형식은 다음과 같다.
            // 데이터형식? 변수명;
            int? a=null;
            int? b=null;
            int? c=null;

            // 위의 변수들은 null 초기화한 변수들, 값이 없는 비워둔 변수들이다.

            // int a;는 a가 null값을 갖는다는 의미가 아니다.

            // Nullable 타입은 HasValue와 Value 속성을 가지고 있다.
            

            Console.WriteLine(a);
            Console.WriteLine(a.HasValue);

            a = 200;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a.Value);

            Console.WriteLine(a != null);
            Console.WriteLine(b != null);

            //string str1;
            //str1 = null;
            //Console.WriteLine(str1);
            Console.ReadKey();
        }
    }
}
