using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*C# 데이터 타입
             * 
             * .NET 프로그래밍 언어는 .NET 공용 타입 형식을 사용한다.
             * 
             * 
             * int, double, string 키워드로 데이터 타입을 표현
             * 
             * System.Int32, System.Double, System.String(.NET의 클래스로 데이터 타입을 표현)
             * 
             * ---- 논리형 -------
             * bool : True or False
             * 
             * ---- 정수형 --------
             * byte : 8bit unsigned 정수형(integer) 
             * sbyte : 8bit signed 정수형
             * (u)short : 16bit (un)signed 정숳여
             * (u)int : 32bit (un)signed 정수형
             * (u)long : 64bit (un)signed 정수형
             * 
             * ---- 실수형 -------
             * float : 32bit 실수형    // 데이터 손실의 우려
             * double : 64bit 실수형   // 사용 권장
             * decimal : 128bit 실수형 (float, double 보다 더 정밀한 소수를 다룬다.)
             *
             *
             * ---- 문자열 형 ------
             * char : 16bit 유니코드 문자
             * string : 유니코드 문자열
             *
             * 
             *
             *
             *
             *
             */

            /*
            // 변수 선언
            int x;
            // 변수의 초기화
            x = 1000;

            // 선언과 초기화를 동시에
            int y = 2000;

            // 여러개의 변수를 동시에 선언하기
            int a, b, c;
            
            a = 1000;
            b = 2000;
            c = 3000;

            // 여러 개의 변수 선언과 초기화 동시에 하기
            double z = 12.1, kk = 11.11, zz = 22.22;
            */

            char a = 'H';
            char b = 'e';
            char c = 'l';
            char d = 'l';
            char e = 'o';

            //Console.Write(a);
            //Console.Write(b);
            //Console.Write(c);
            //Console.Write(d);
            //Console.Write(e);

            string str = "Hello";
            Console.WriteLine(str);
            

            // 리터럴 데이터 : 123, True, "AGC" 와 같은 값들을 리터럴 (Literal)이라 한다.
            // 리터럴의 형식 (타입)
            // 123 (int 리터럴), 11.11 (double 리터럴), "B" (string 리터럴), 'b' (char 리터럴), True (bool 리터럴)

            // C# 컴파일러는 int, double, char, string, bool 데이터 타입에 기본적으로
            // 그에 해당하는 값을 할당한다.

            // 데이터 타입별 접미사(Suffix)를 사용해서 특정 데이터 타입을 지정할 수 있다.
            // [ 접미어 ]
            // L : long형, U: Uint, UL:Ulong, F:float, D:double, M:decimal

            long l = 12322L;

            // int 형의 최대 수치
            int aa = int.MaxValue;
            int aa_ = int.MinValue;
            
            Console.WriteLine(aa_+" ~ "+aa);
            Console.WriteLine();
            
            long bb_ = long.MinValue;
            long bb = long.MaxValue;
            Console.WriteLine(bb_ + " ~ " + bb);
            Console.WriteLine();

            float f_ = float.MinValue;
            float f = float.MaxValue;
            Console.WriteLine(f_ + " ~ " + f);
            Console.ReadKey();

        }
    }
}
