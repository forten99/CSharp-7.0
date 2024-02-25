using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideEx
{
    // 오버라이드 : 메소드 재정의

    // virtual : Base(부모)클래스 메소드 앞에 붙는 키워드
    // derived(파생, 자식) 클래스에 의해서 재정의될 수 있다는 의미를 갖는다.

    // override : 자식(derived) 클래스 메소드 앞에 붙는 키워드
    // 부모로부터 받은 메소드를 재정의한다라는 의미
    // 재정의할 때는 부모의 메소드 이름과 같아야 한다.
    // 프로토타입도 일치해야 한다.

    // new : 오버라이딩과는 다른 개념으로 메소드를 숨기는 기능이다.

    class BaseClass
    { 
        public virtual void echo()
        {
            Console.WriteLine("기반 클래스");
        }
    }

    class DerivedClass : BaseClass 
    { 
        public new void echo()
        {
            Console.WriteLine("파생 클래스");
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass derviedClass = new DerivedClass();
            derviedClass.echo();

            BaseClass baseClass = new DerivedClass();
            baseClass.echo();
        }
    }
}
