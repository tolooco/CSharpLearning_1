using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter20
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
        public static void IncrementValues1(SomeClass myObject)
        {
            myObject.x++;
            myObject.y++;
        }

        public static void IncrementValues2(SomeStruct myType)
        {
            myType.x++;
            myType.y++;
        }

        public static void IncrementValues3(ref SomeStruct myType)
        {
            myType.x++;
            myType.y++;
        }
    }

    public class SomeClass
    {
        public int x;
        public int y;

        public void ShowValues()
        {
            System.Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }

    public struct SomeStruct
    {
        public int x;
        public int y;

        public void ShowValues()
        {
            System.Console.WriteLine("X: {0}, Y: {1}", x, y);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SomeClass object1 = new SomeClass();
            
            object1.y = 10;object1.x = 5;
            object1.ShowValues();

            Utility.IncrementValues1(object1);
            object1.ShowValues();

            System.Console.WriteLine("\n----------");

            SomeStruct type1;
            type1.x = 5;
            type1.y = 10;
            type1.ShowValues();

            Utility.IncrementValues2(type1);
            type1.ShowValues();

            Utility.IncrementValues3(ref type1);
            type1.ShowValues();

            System.Console.ReadLine();
        }
    }
}
