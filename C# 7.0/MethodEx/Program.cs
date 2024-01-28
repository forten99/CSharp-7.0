using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 메소드 : 객체지향 언어에서 사용하는 용어(기존에는 function:함수라고 불렸다.)
            /*
             [ 메소드의 선언 형식 ]

                한정자 반환형식 메소드명(매개변수)
                {
                    실행코드;
                    실행코드
                }
             */
            int x, y;

            x = 10;
            y = 11;

            //int xx = x + y;

            //Console.WriteLine(xx);
            //int res = Sum(x, y);    // Sum메소드를 호출하여 리턴값을 받음.
            Sum(x, y);  // Sum 메소드를 호출
            //Console.WriteLine(res);

            Sum(100, 200);

            //x = 100;
            //y = 200;
            //int yy = x + y;
            //Console.WriteLine(yy);

            //x = 1000;
            //y = 2000;
            //int zz = x + y; 
            //Console.WriteLine(zz);  
        }
        static void Sum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
            //return result;
        }
    }
}
