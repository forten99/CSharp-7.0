using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyEx2
{
    // 자동 프로퍼티 기능은 C# 3.0에서 도입된 기능
    // C# 7.0부터는 자동프로퍼티 초기값이 필요할 때 생성자에 초기화 코드를 작성해야하는 불편함을
    // 해소할 수 있도록 초기값을 바로 설정할 수 있다.
    class EmployeeInfo
    {
        private string name;
        private DateTime entryDate;

        public string Name
        {
            //get
            //{ 
            //    return name; 
            //}
            //set 
            //{ 
            //    name = value; 
            //}

            get; set;
        }

        public DateTime EntryDate
        {
            //get
            //{
            //    return entryData;
            //}
            //set
            //{
            //    entryData = value;
            //}
            get; set;
        }

        // 근속 년수
        public int serviceLength
        {
            get
            {
                // 1 Tick(틱) 은 100 나노초(천만분의 1초)를 나타낸다. 1밀리초는 10,000틱
                return new DateTime(DateTime.Now.Subtract(entryDate).Ticks).Year;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeInfo employee = new EmployeeInfo();
            employee.Name = "홍길동";
            employee.EntryDate = new DateTime(2010, 10, 10);

            Console.WriteLine($"이름 : {employee.Name}");
            Console.WriteLine($"입사일 : {employee.EntryDate.ToShortDateString()}");
            Console.WriteLine($"근속년수 : {employee.serviceLength}");

        }
    }
}
