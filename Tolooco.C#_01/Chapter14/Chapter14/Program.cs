using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter14
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class SomeClass
    {
        public int X;
        private int _y;

        public static int M;
        private static int _n;
    }


    class Program
    {
        static void Main(string[] args)
        {
            SomeClass.M = 10;
            // SomeClass._n = 20; // Wrong Usage!

            SomeClass obj = new SomeClass();
            obj.X = 10;
            // obj._y = 10; // Wrong Usage!

            System.Console.ReadLine();
        }
    }
}
