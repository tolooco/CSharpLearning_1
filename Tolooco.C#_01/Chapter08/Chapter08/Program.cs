using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter08
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
        public int Age;
        public string FullName;

        // If you do not write default constructor and do not write any Constructor Overloading,
        // Compiler will create it automaticlly!
        // Default Constructor!
        public Person() // Constructors do not have any return value!
        {
            Age = 20;
            FullName = "";
        }

        // Constructor Overloading!
        public Person(int age) // Constructors do not have any return value!
        {
            Age = age;
            FullName = "";
        }

        // Constructor Overloading!
        public Person(string fullName) // Constructors do not have any return value!
        {
            Age = 20;
            FullName = fullName;
        }

        // Constructor Overloading!
        public Person(string fullName, int age) // Constructors do not have any return value!
        {
            Age = age;
            FullName = fullName;
        }

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
            P0.Age = 40;
            P0.FullName = "Ali Reza Alavi";
            P0.ShowInfo();

            System.Console.WriteLine("\n");

            Person P1 = new Person(30);
            P1.FullName = "Sara Ahmadi";
            P1.ShowInfo();

            System.Console.WriteLine("\n");

            Person P2 = new Person("Sanaz Samimi");
            // P2.Age = 15;
            P2.ShowInfo();

            System.Console.WriteLine("\n");

            Person P3 = new Person("Dariush Tasdighi", 20);

            Person P4 = new Person(age: 23, fullName: "Amir Chabok");
            P3.ShowInfo();
            P4.ShowInfo();

            System.Console.WriteLine("\n");

            System.Console.ReadLine();
        }
    }
}
