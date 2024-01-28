using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunEx
{
    internal class Program
    {
        static string ToLowerStr(string input)
        {
            var arr = input.ToCharArray();

            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] +32);
                
            }
            //return input.ToLower();
            return new string(arr);
        }
        static void Main(string[] args)
        {
            // var 키워드 : 데이터 형식을 알아서 C# 컴파일러가 지정한다.

            var a = "Hello";
            Console.WriteLine(a.GetType());

            var aa = 100;
            Console.WriteLine(aa.GetType());

            var f = 3.12121;
            Console.WriteLine(f.GetType());

            var arr = new int[] { 1, 2, 3 };
            Console.WriteLine(arr.GetType());

            // 로컬 함수 : 메소드 안에서 선언된 특별 함수
            //              메소드 안에서 선언되었기 때문에 클래스 멤버가 아니다. 따라서, 함수라고 부른다.

            string str = "HelLo";
            Console.WriteLine(ToLowerStr(str));
            Console.WriteLine(ToLowerStr("GOOD"));
            Console.WriteLine(ToLowerStr("MORNING"));

        }
    }
}
