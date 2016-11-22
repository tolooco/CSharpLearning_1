using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter17
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public struct Person
    {
        // Wrong Usage!
        // public int Age = 20;
        // In Struct, You should not initialize fields!

        public int Age;
        public string FullName;

        // Wrong Usage!
        // In Struct, We should not define Default Constructor!
        // public Person()
        // {
        // }

        // Wrong Usage!
        // You must define some Constructor that initialize all of fields!
        // public Person(string fullName)
        // {
        //     FullName = fullName;
        // }

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void ShowFullName()
        {
            System.Console.WriteLine("\n: Full Name: {0}", FullName);
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\n: Full Name: {0}, Age: {1}", FullName, Age);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person();
            P1.Age = 20;
            P1.FullName = "Ali Reza Alavi";
            P1.ShowInfo();
            P1.ShowFullName();

            System.Console.WriteLine("\n----------");

            Person P2 = new Person("Sara Ahmadi", 30);
            P2.ShowInfo();
            P2.ShowFullName();

            System.Console.WriteLine("\n----------");

            Person P3 = new Person();
            P3.FullName = "Sanaz Samimi";
            P3.ShowInfo();
            P3.ShowFullName();

            System.Console.WriteLine("\n----------");

            // If you do not make a new Struct with this syntax:
            // Person P3 = new Person();
            // If you want to use some methods, You must initialize all of fields value!
            Person P4;
            P4.Age = 30;
            P4.FullName = "Sanaz Samimi";
            System.Console.WriteLine("\n: Age: {0}", P4.Age);
            System.Console.WriteLine(": Full Name: {0}", P4.FullName);
            P4.ShowInfo();
            P4.ShowFullName();

            System.Console.WriteLine("\n----------");

            Person P5;
            P5.FullName = "Akbar Abedini";
            // Wrong Usage!
            // System.Console.WriteLine("\n: Age: {0}", P5.Age);
            System.Console.WriteLine("\n: Full Name: {0}", P5.FullName);
            // Wrong Usage!
            // P5.ShowInfo();
            // P5.ShowFullName(); // Note: ShowFullName does not use Age field, But you will see an error!

            System.Console.WriteLine("\n----------");

            Person P6 = P4; // P6 is a copy of P4!
            P6.FullName = "Fatemeh Asgari";
            System.Console.WriteLine("\n: P5 Full Name: {0}", P5.FullName);
            System.Console.WriteLine(": P6 Full Name: {0}", P6.FullName);

            System.Console.WriteLine("\n----------");

            // Wrong Usage!
            // Because all of P5 fields did not initialized!
            // Person P7 = P5;


            System.Console.ReadLine();
        }
    }
}
