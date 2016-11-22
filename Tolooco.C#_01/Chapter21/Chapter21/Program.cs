using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter21
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
        public int X;

        // Default Constructor!
        public Person()
        {
        }

        // Constructor Overloading!
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            LastName = lastName;
            FirstName = firstName;

            //_age = age;
            //_lastName = lastName;
            //_firstName = firstName;
        }

        private int _age;

        // Property!
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
                if ((value >= 0) && (value <= 99))
                {
                    _age = value;
                }
            }
        }

        private string _firstName;

        // Property!
        public string FirstName
        {
            get
            {
                return (_firstName);
            }
            set
            {
                _firstName = value;
            }
        }

        private string _lastName;

        // Property!
        public string LastName
        {
            get
            {
                return (_lastName);
            }
            set
            {
                _lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                // return ((_firstName + " " + _lastName).Trim()));
                return ((FirstName + " " + LastName).Trim());
            }
        }

        // Method!
        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person P0 = new Person();
            P0.Age = 20;
            System.Console.WriteLine("Age: {0}", P0.Age);

            Person P1 = new Person();
            P1.Age = 20;
            P1.FirstName = "Ali Reza";
            P1.LastName = "Ahmadi";
            P1.ShowInfo();

            Person P2 = new Person("Sara", "Ahmadi", 30);
            Console.WriteLine(P2.FullName);

            System.Console.ReadLine();
        }
    }
}
