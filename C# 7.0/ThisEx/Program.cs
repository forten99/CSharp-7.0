﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisEx
{
    internal class Program
    {
        class Student
        {
            private string name;
            private string grade;

            public void SetName(string name)
            {
                this.name = name;
            }
            public string GetName()
            {
                return this.name;
            }
            public void SetGrade(string grade)
            {
                this.grade = grade;
            }
            public string GetGrade()
            {
                return this.grade;
            }
        }
        static void Main(string[] args)
        {
            // this : 객체가 자신을 지칭할 때 사용하는 키워드 입니다.
            Student kim = new Student();
            kim.SetName("김말똥");
            kim.SetGrade("2학년");

            Console.WriteLine($"{kim.GetName()} {kim.GetGrade()}");

            Student lee = new Student();
            lee.SetName("이길동");
            lee.SetGrade("3학년");
            Console.WriteLine($"{lee.GetName()} {lee.GetGrade()}");
        }
    }
}
