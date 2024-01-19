using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTypeEx4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            부동 소수점과 정수형 사이의 형변환
             */

            //float f = 4.72134f;
            //int aa = (int)f;

            //Console.WriteLine(aa);

            // 문자열과 숫자 사이의 형변환
            int aa = 343434;
            string bb = aa.ToString();
            Console.WriteLine(bb);

            string strTest = Convert.ToString(aa);
            Console.WriteLine(strTest);

            float ff = 1.1212f;
            Console.WriteLine(ff);  
            string cc = ff.ToString();
            Console.WriteLine(cc);

            string str1 = "121212";
            int aaa = int.Parse(str1);
            Console.WriteLine(aaa);

            string str2 = "1.1234562";      // 끝 부분에서 반올림 처리가 됨 flaot은 7자리 표현.
            float h = float.Parse(str2);   
            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
