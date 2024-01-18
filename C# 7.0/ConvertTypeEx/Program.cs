using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 데이터 형식 변환(Type Conversion)
            // 소괄호 ( ) 컨버전 연산자

            /*
            데이터 형식 변환(형변환) : 변수를 다른 데이터 형식에 옮기는 것을 의미
            
                - 크기가 서로 다른 정수형 사이의 형변환
                - 크기가 서로 다른 부동소수점 사이의 형변환
                - 부호있는 정수형과 부호없는 정수형 사이의 형변환
                - 실수형과 정수형 사이의 형변환
                - 문자열과 숫자 사이의 형변환

            */

            sbyte a = 127;  // 부호있는 1Byte
            Console.Write(sbyte.MinValue);
            Console.Write(" ~ ");
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(a);

            int aa = (int)a;
            Console.WriteLine(aa);

            int x = 128;
            Console.WriteLine(x);
            
            sbyte xx = (sbyte)x;
            Console.WriteLine(xx);
            Console.ReadKey();
        }
    }
}
