using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter07
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
        // Note: Fields have Default Value
        // For example:
        // public int Age; is similar to public int Age = 0;
        // OR
        // public string FullName; is similar to public string FullName = null; (FullName is Reference Type!)
        // But I told you that Variables in some blocks do not have Default Values!
        public int Age;
        public string FullName;

        // Default Constructor!
        /// <summary>
        /// سازنده پیش فرض
        /// </summary>
        public Person() // Constructors do not have any return value!
        {
            Age = 20;
            FullName = "";
        }

        /// <summary>
        /// سازنده با دو ورودی
        /// </summary>
        /// <param name="age"></param>
        /// <param name="fullName"></param>
        public Person(int age,string fullName)
        {
            this.Age = age;
            this.FullName = fullName;
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
            P0.ShowInfo();

            Person P = new Person();
           
            P.FullName = "Ali Reza Alavi";
            P.ShowInfo();

            Person oPerson = new Person(21, "Amir Chabok");
            oPerson.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
