using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxUnBoxEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Boxing과 UnBoxing의 개념

            object obj1 = 111;
            위 코드에서 111은 int형 값이고 obj1은 object형의 참조형식의 변수이다.
            이 경우 111은 스택, 힙 중에 어디에 저장될까?

            111은 Boxing기능을 통해서 힙에 저장된다.
            
            UnBoxing은 Boxing 되어 있는 값을 꺼내 값형식(Value Type) 변수에
            저장하는 과정을 의미한다.
            */

            int x = 111;

            object obj1 = (object)x;    // x에 담겨있는 값을 박싱해서 힙에 저장
            int y = (int)obj1;          // UnBoxing 후에 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(obj1);
            Console.WriteLine(y);

            double xx = 2.1212121222;
            // object 형식에 저장할 때에는 형변환 연산자를 사용하지 않아도 
            // 자동으로(묵시적으로) 형변환이 이루어진다.
            object yy = xx;
            double zz = (double)yy;

            Console.WriteLine(xx);
            Console.WriteLine(yy);
            Console.WriteLine(zz);

            Console.ReadKey();
        }
    }
}
