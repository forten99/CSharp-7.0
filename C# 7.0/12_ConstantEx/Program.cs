using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ConstantEx
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            // 변수 : 담고 있는 데이터를 얼마든지 변경할 수 있는 메모리공간
            // 상수 : 담고 있는 데이터를 절대 바꿀 수 없는 메모리 공간

            // 상수는 const라고 하는 키워드를 사용한다.
            // const type명 상수명;

            const int AAA = 10000;
            Console.WriteLine(AAA);


            Console.ReadKey();
            
        }
        
    }
}
