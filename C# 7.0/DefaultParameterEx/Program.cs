using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DefaultParameterEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 파라미터의 기본값을 적용하기
            // void aaa(int a = 0, int b = 1) 
            // {
            //     Console.WriteLine(a + b);
            // }
            // aaa(); 의 결과는 콘솔 화면에 1의 값이 출력된다.

            MemberInfo("홍길동");
            MemberInfo("김말똥", "인천");
            MemberInfo(name: "이말똥", addr: "광주");
        }
        static void MemberInfo(string name, string addr="")
        {
            Console.WriteLine("이름 : {0}, 주소 : {1}", name, addr);
        }
    }
}
