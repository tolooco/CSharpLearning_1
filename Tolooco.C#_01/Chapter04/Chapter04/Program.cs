using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04
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
            // Array in C# is Zero Based!
            //int[] intNumbers;
            //intNumbers = new int[5];
            //intNumbers[0] = 0; // Note: Does Not Need!
            //intNumbers[1] = 0; // Note: Does Not Need!
            //intNumbers[2] = 0; // Note: Does Not Need!
            //intNumbers[3] = 0; // Note: Does Not Need!
            //intNumbers[4] = 0; // Note: Does Not Need!

            //int[] intNumbers;
            //intNumbers = new int[5];
            //intNumbers[0] = 10;
            //intNumbers[1] = 20;
            //intNumbers[2] = 30;
            //intNumbers[3] = 40;
            //intNumbers[4] = 50;

            //int[] intNumbers = new int[5];
            //intNumbers[0] = 10;
            //intNumbers[1] = 20;
            //intNumbers[2] = 30;
            //intNumbers[3] = 40;
            //intNumbers[4] = 50;

            int[] intNumbers = { 10, 20, 30, 40, 50 };

            int intA = 10;
            int intB = 20;
            int intC = 30;

           
            System.Console.WriteLine("B = {1}, A = {0}, B = {1}", intA, intB, intC);

            for (int intIndex = 0; intIndex <= 4; intIndex++)
            {
                System.Console.WriteLine
                    ("Number of {0} is {1}.", intIndex, intNumbers[intIndex]);
            }

            //for (int intIndex = 0; intIndex <= 4; intIndex++)
            //{
            //    System.Console.WriteLine
            //        ("Number of {0} is {1}.", intIndex + 1, intNumbers[intIndex]);
            //}

            //for (int intIndex = 0; intIndex <= intNumbers.Length - 1; intIndex++)
            //{
            //    System.Console.WriteLine
            //        ("Number of {0} is {1}.", intIndex + 1, intNumbers[intIndex]);
            //}

            //for (int intIndex = intNumbers.Length - 1; intIndex >= 0; intIndex--)
            //{
            //    System.Console.WriteLine
            //        ("Number of {0} is {1}.", intIndex + 1, intNumbers[intIndex]);
            //}

            //for (int intIndex = intNumbers.Length - 1; intIndex >= 0; intIndex--)
            //{
            //    intNumbers[intIndex]++;

            //    System.Console.WriteLine
            //        ("Number of {0} is {1}.", intIndex + 1, intNumbers[intIndex]);
            //}

            //foreach (int intNumber in intNumbers)
            //{
            //    System.Console.WriteLine("" + intNumber);
            //}

            // intNumber in foreach is read only!
            //foreach (int intNumber in intNumbers)
            //{
            //    intNumber++;
            //    System.Console.WriteLine("" + intNumber);
            //}

            System.Console.ReadLine();
        }
    }
}
