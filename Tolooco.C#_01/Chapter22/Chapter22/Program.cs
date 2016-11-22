using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter22
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
        public int E;
        public readonly int F;

        private int _a;
        public int A // Property <-> Read And Write Property!
        {
            get
            {
                return (_a);
            }
            set
            {
                _a = value;
            }
        }

        private int _b;
        public int B // Write Only Property!
        {
            set
            {
                _b = value;
            }
        }

        private int _c;
        public int C // Read Only Property!
        {
            get
            {
                return (_c);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int intTemp = 0;
            SomeClass obj = new SomeClass();

            obj.A = 1;
            intTemp = obj.A;

            obj.B = 2;
            // Wrong Usage!
            // intTemp = object1.B;

            // Wrong Usage!
            // object1.C = 3;
            intTemp = obj.C;

            obj.E = 4;
            intTemp = obj.E;

            // Wrong Usage!
            // object1.F = 5;
            
            intTemp = obj.F;

            Console.WriteLine(obj.F.ToString());
            System.Console.ReadLine();
        }
    }
}
