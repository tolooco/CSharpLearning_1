using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Person
    {
        public Person(string fullName, int age)
        {
            _age = age;
            _fullName = fullName;
        }

        private int _age;

        public void SetAge(int age)
        {
            _age = age;
        }

        public int GetAge()
        {
            return (_age);
        }

        private string _fullName;

        public void SetFullName(string fullName)
        {
            _fullName = fullName;
        }

        public string GetFullName()
        {
            return (_fullName);
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", _fullName, _age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person("Ali Reza Ahmadi", 20);
            P.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
