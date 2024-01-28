using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 클래스 

            Person person = new Person();
            Person person1 = new Person();

            person.name = "홍길동";
            person.gender = "남";

            person.greet();

            person1.name = "홍길순";
            person1.gender = "여";

            person1.greet();
        }
    }

    class Person
    {
        public string name;     // 속성
        public string gender;   // 속성

        public void greet()
        {
            Console.WriteLine("안녕하세요! 저는 {0} 입니다.", name);
        }
    }
}
