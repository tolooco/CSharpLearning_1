using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter09
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

        private int _somePrivateField1;
        int _somePrivateField2; // If you do not write any access modifiers, Default access modifier is Private!

        // We do not have default constructor!
        // So if we write this: Person P = new Person(); We will get an error!

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }


        public void ShowInfo()
        {
            _somePrivateField1 = 20;
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Wrong Usage!
            // Person P = new Person();
            // P.Age = 20;
            // P.FullName = "Ali Reza Alavi";
            // P.ShowInfo();

            Person P = new Person("Sara Ahmadi", 30);
            P.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
