using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter24
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string str1;
            str1 = "Ali";

            string str2 = "Reza";

            str1 = "Reza"; // Reza will be allocated in the other part of heap!

            System.Console.WriteLine("First Character of str1: {0}", str1[0]);
            // Wrong Usage!
            // str1[0] = 'M';

            // Wrong Usage!
            // str1 = "C:\Windows\System32";

            str1 = "C:\\Windows\\System32";
            str1 = @"C:\Windows\System32";

            if (str1 == str2)
            {
                System.Console.WriteLine("Two strings are similar to each other.");
            }

            if (string.Compare(str1, str2, false) == 0) // Case Insensitive!
            {
                System.Console.WriteLine("Two strings are similar to each other.");
            }

            int intTemp;
            bool blnTemp;

            intTemp = str1.Length;

            str1 = str1.Trim();
            str1 = str1.TrimEnd();
            str1 = str1.TrimStart();

            str1 = str1.ToLower();
            str1 = str1.ToUpper();

            blnTemp = str1.Equals(str2);
            intTemp = str1.CompareTo(str2);

            blnTemp = str1.EndsWith("-]");
            blnTemp = str1.StartsWith("[-");

            intTemp = str1.IndexOf("Windows"); // 8 Methods Overloadin!
            intTemp = str1.LastIndexOf("Windows"); // 8 Methods Overloading!

            str1 = str1.Remove(5,3);
            str2 = str1.Substring(5, 3);

            str1 = str1.Replace(" ", "");
            str1 = str1.Insert(5, "Hello");

            while (str1.IndexOf("  ") >= 0)
            {
                str1 = str1.Replace("  ", " ");
            }

            str1 = str1.PadLeft(30, '*');
            str1 = str1.PadRight(40, '!');

            System.Console.WriteLine("\n----------");

            string[] aryStrings;

            str1 = "Hello,How;Are,You";
            aryStrings = str1.Split(',', ';');

            foreach (string str in aryStrings)
            {
                System.Console.WriteLine("{0}", str);
            }

            System.Console.WriteLine("\n----------");

            System.Text.StringBuilder oStringBuilder = new System.Text.StringBuilder();

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length);      // 0
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity);    // 16 Characters
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString());  // ""

            System.Console.WriteLine("\n----------");

            oStringBuilder.Append("Hello");

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 5
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 16
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString()); // "Hello"

            System.Console.WriteLine("\n----------");

            oStringBuilder.Append(", How Are You? My name is Amir Chabok.");

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 48
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 48
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity); // 2GB
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString()); // Hello, How Are You? My name is Amir Chabok.

            System.Console.WriteLine("\n----------");

            oStringBuilder.Remove(0, oStringBuilder.Length);

            System.Console.WriteLine(": Length          : {0}", oStringBuilder.Length); // 0
            System.Console.WriteLine(": Capacity        : {0}", oStringBuilder.Capacity); // 48
            System.Console.WriteLine(": Max. Capacity   : {0}", oStringBuilder.MaxCapacity);
            System.Console.WriteLine(": Value (ToString): {0}", oStringBuilder.ToString());

            System.Console.ReadLine();
        }
    }
}
