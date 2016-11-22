using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter03
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
            goto MyLable;

        MyLable:
            System.Console.WriteLine("Hello World!");

            int intNumber1 = 10;
            switch (intNumber1)
            {
                case 1: // Fixed Value/Const/Enum | You can not use some variables!
                    {
                        // Do Something!
                        break;
                    }

                case 2:
                    {
                        // Do Something!
                        break;
                    }
            }

            int intNumber2 = 10;
            switch (intNumber2)
            {
                case 1:
                    {
                        // Do Something!
                        break;
                    }

                case 2:
                    {
                        // Do Something!
                        break;
                    }

                default:
                    {
                        // Do Something!
                        break;
                    }
            }

            int intNumber3 = 10;
            switch (intNumber3)
            {
                case 1:
                    {
                        // Do Something!
                        goto case 3;
                    }

                case 2:
                    {
                        // Do Something!
                        goto case 6;
                    }

                case 3:
                    {
                        // Do Something!
                        break;
                    }

                case 4:
                case 5:
                    {
                        // Do Something!
                        break;
                    }

                case 6:
                    {
                        // Do Something!
                        break;
                    }

                default:
                    {
                        // Do Something!
                        break;
                    }
            }

            // [Visual Basic]
            // Select Case intNumber
            //		Case 2, 5, 9, 10, 20 to 30

            // [C#]
            // Select Case intNumber
            //		Case 2:
            //		Case 5:
            //		Case 9:
            //		Case 10:
            //		Case 20:
            //		Case 21:
            //		Case 22:
            //		Case 23:
            //		Case 24:
            //		Case 25:
            //		Case 26:
            //		Case 27:
            //		Case 28:
            //		Case 29:
            //		Case 30:

            //#################################################

            int intA = 10;
            int intB = 20;
            int intC = 30;

            //#################################################

            //#################################################

            string strMessage1 = "A = " + intA + ", B = " + intB + ", C = " + intC;
            System.Console.WriteLine(strMessage1);

            //#################################################

            //#################################################

            string strMessage2 =
                "A = " + intA + ", B = " + intB + ", C = " + intC;

            System.Console.WriteLine(strMessage2);

            //#################################################

            //#################################################

            string strMessage3 =
                string.Format("A = {0}, B = {1}, C = {2}", intA, intB, intC);

            System.Console.WriteLine(strMessage3);

            //#################################################

            //#################################################

            string strMessage4 =
                string.Format("A = {1}, B = {2}, C = {1}", intA, intB, intC);

            System.Console.WriteLine(strMessage4);

            //#################################################

            //#################################################

            System.Console.WriteLine("A = {1}, B = {2}, C = {1}", intA, intB, intC);

            //#################################################

            //#################################################

            // Array declares in Stack and
            // will be created in Heap!

            //int[] intNumbers;
            //intNumbers = new int[5]; // Zero Based!

            //int[] intNumbers = new int[5]; // Zero Based!

            int[] intNumbers1 = new int[5]; // Zero Based!
            intNumbers1[0] = 10;
            intNumbers1[1] = 20;
            //intNumbers1[2] = 0; // Default: 0
            //intNumbers1[3] = 0; // Default: 0
            intNumbers1[4] = 50;

            int[] intNumbers2 = { 10, 20, 30, 40, 50 };

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= 4; intIndex++)
            {
                System.Console.WriteLine
                    ("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################

            //#################################################

            int intNumberCount = 5;

            int[] intNumbers3 = new int[intNumberCount];

            intNumbers3[0] = 10;
            intNumbers3[1] = 20;
            intNumbers3[2] = 30;
            intNumbers3[3] = 40;
            intNumbers3[4] = 50;

            System.Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= intNumberCount - 1; intIndex++)
            {
                System.Console.WriteLine
                    ("Array[{0}]: {1}", intIndex, intNumbers3[intIndex]);
            }

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            for (int intIndex = 0; intIndex <= intNumbers2.Length - 1; intIndex++)
            {
                System.Console.WriteLine
                    ("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            for (int intIndex = intNumbers2.Length - 1; intIndex >= 0; intIndex--)
            {
                System.Console.WriteLine
                    ("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            for (int intIndex = intNumbers2.Length - 1; intIndex >= 0; intIndex--)
            {
                intNumbers2[intIndex]++;
                System.Console.WriteLine
                    ("Array[{0}]: {1}", intIndex, intNumbers2[intIndex]);
            }

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            foreach (int intNumber in intNumbers2) // intNumber is ReadOnly!
            {
                System.Console.WriteLine
                    ("Array Value is {0}", intNumber);
            }

            //#################################################

            //#################################################

            System.Console.WriteLine("\n");
            foreach (int intNumber in intNumbers2) // intNumber is ReadOnly!
            {
                //intNumber++;
                System.Console.WriteLine("Array Value is {0}", intNumber);
            }

            //#################################################

            //#################################################

            System.Console.ReadLine();

            //#################################################

            //#################################################

        }
    }
}

