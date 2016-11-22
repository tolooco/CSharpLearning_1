using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Person // It's a Class!
    {
        public int Age; // It's a Field!, It's a member!
        public string FullName; // It's a Field!, It's a member!

        public void ShowInfo() // It's a Method!, It's a member!
        {
            System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Wrong Usage!
            // Person P;
            // P.Age = 20;
            // P.FullName = "Ali Reza Alavi";
            // P.ShowInfo();

            Person P1;
            P1 = new Person();
            P1.Age = 20;
            P1.FullName = "Ali Reza Alavi";
            P1.ShowInfo();

            System.Console.WriteLine("\n");

            Person P2 = new Person();
            P2.Age = 30;
            P2.FullName = "Sara Ahmadi";
            P2.ShowInfo();

            System.Console.WriteLine("\n");

            Person P3;
            P3 = P1;
            P3.ShowInfo();

            System.Console.WriteLine("\n");

            Person P4 = P2;
            P4.ShowInfo();

            System.Console.WriteLine("\n");

            Person P5 = P1;
            P5.Age = 21;
            P5.ShowInfo();
            P1.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
