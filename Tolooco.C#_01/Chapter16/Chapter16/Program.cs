using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter16
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Utility
    {
        // Wrong Usage!
        // public const int a;
        public const int a = 10;

        public int b;
        public readonly int c;
        public readonly int d = 2;
        public readonly int e = 7;

        public Utility()
        {
            c = 1;
        }

        public Utility(int constant1, int constant2)
        {
            c = constant1;
            e = constant2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int intNumber;
            Utility SomeObject = new Utility();

            // Wrong Usage!
            // Utilities.a = 2;
            intNumber = Utility.a;

            // Wrong Usage!
            // SomeObject.a = 2;
            // int intNumber = SomeObject.a;

            SomeObject.b = 1;
            intNumber = SomeObject.b;

            // Wrong Usage!
            // SomeObject.c = 2; // [c] field is ReadOnly!, So you should not change it!
            intNumber = SomeObject.c;

            System.Console.ReadLine();
        }
    }
}
