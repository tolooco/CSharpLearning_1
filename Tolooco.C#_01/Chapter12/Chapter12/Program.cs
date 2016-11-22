using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12
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
        /// <summary>
        /// اين شاخص مربوط به سن شخص می باشد
        /// </summary>
        /// <example>
        /// Person P = new Person();
        /// P.Age = 20;
        /// </example>
        /// <remarks>
        /// Amir Chabok - Date: 1392/02/07 - Version 1.2.1
        /// </remarks>
        public int Age;

        /// <summary>
        /// اين فيلد مربوط به نام خانوادگی شخص می باشد
        /// </summary>
        /// <example>
        /// FullName = "Ali Reza Alavi"
        /// </example>
        public string FullName;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Person()
        {
            Age = 20;
        }

        /// <summary>
        /// Constructor Overloading with Full Name and Age.
        /// </summary>
        /// <param name="fullName">نام و نام خانوادگی</param>
        /// <param name="age">سن</param>
        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        /// <summary>
        /// Constructor Overloading with Full Name.
        /// </summary>
        /// <param name="FullName"></param>
        /// <example>
        /// Person P = new Person("Dariush Tasdighi");
        /// </example>
        public Person(string FullName)
        {
            // Wrong Usage!
            // FullName = FullName;

            this.FullName = FullName;
        }

        /// <summary>
        /// اين تابع مشخصات شخص را چاپ می کند
        /// </summary>
        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // This is a inline comment!

            /*
             * This is a comment.
             * This is a comment.
             * This is a comment.
             */

            Person P1 = new Person();
            P1.ShowInfo();

            System.Console.WriteLine("\n");

            Person P2 = new Person();
            P2.FullName = "Ali Reza Alavi";
            P2.ShowInfo();

            System.Console.WriteLine("\n");

            Person P3 = new Person("Sara Ahmadi");
            P3.ShowInfo();

            System.Console.WriteLine("\n");

            Person P4 = new Person("Sanaz Samimi", 30);
            P4.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
