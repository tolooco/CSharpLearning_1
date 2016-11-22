using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter13
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    // Note: Utility, Globals, Publics
    //public static class Utility
    //{
    //    private Utility()
    //    {
    //    }
    //}
    // Note: Utility, Globals, Publics
    public static class Utility
    {
        public static string Author;
        public static string Support;
        public static string Version;
        public static string Homepage;

        static Utility()
        {
            Version = "1.2.1";
            Author = "Amir Chabok";
            Support = "Chabok.121@Gmail.com";
            Homepage = "http://www.Cwx121.com";
        }

        public static void ShowApplicationInfo()
        {
            System.Console.WriteLine("\n: -----\n: Author: {0}\n: Support: {1}\n: Homepage: {2}\n: Version: {3}\n: -----", Author, Support, Homepage, Version);
        }

        public static int Sum(int a, int b)
        {
            //int intResult;
            //intResult = a + b;
            //return (intResult);

            //int intResult = a + b;
            //return (intResult);

            return (a + b);
        }

        public static int Sum(int a, int b, int c)
        {
            return (a + b + c);
        }

        public static float Sum(float a, float b)
        {
            return (a + b);
        }

        public static int Sum(int[] numbers)
        {
            int intResult = 0;

            //foreach (int intNumber in numbers)
            //{
            //    intResult += intNumber;
            //}

            for (int intIndex = 0; intIndex <= numbers.Length - 1; intIndex++)
            {
                intResult += numbers[intIndex];
            }

            return (intResult);
        }

        public static void Swap(ref int a, ref int b)
        {
            int intTemp = a;
            a = b;
            b = intTemp;
        }

        public static int SomeFunction(int a, int b, out int c)
        {
            c = a * b;

            return (a + b);
        }

        //public static int SomeFunction1(int inParam)
        //{
        //    switch (inParam)
        //    {
        //        case 1:
        //        {
        //            return (10);

        //            // Note: Do not write below code. Unreachable code!
        //            // break;
        //        }

        //        case 2:
        //        {
        //            return (20);

        //            // Note: Do not write below code. Unreachable code!
        //            // break;
        //        }
        //    }
        //}

        public static int SomeFunction2(int inParam)
        {
            switch (inParam)
            {
                case 1:
                    {
                        return (10);

                        // Note: Do not write below code. Unreachable code!
                        // break;
                    }

                case 2:
                    {
                        return (20);

                        // Note: Do not write below code. Unreachable code!
                        // break;
                    }

                default:
                    {
                        return (0);

                        // Note: Do not write below code. Unreachable code!
                        // break;
                    }
            }
        }

        public static int SomeFunction3(int inParam)
        {
            int intResult = 0;

            switch (inParam)
            {
                case 1:
                    {
                        intResult = 10;
                        break;
                    }

                case 2:
                    {
                        intResult = 20;
                        break;
                    }
            }

            return (intResult);
        }

        //public static void SomeFunction4(int inParam, out int outParam)
        //{
        //    switch (inParam)
        //    {
        //        case 1:
        //        {
        //            outParam = 10;
        //            break;
        //        }

        //        case 2:
        //        {
        //            outParam = 20;
        //            break;
        //        }
        //    }
        //}

        public static void SomeFunction5(int inParam, out int outParam)
        {
            switch (inParam)
            {
                case 1:
                    {
                        outParam = 10;
                        break;
                    }

                case 2:
                    {
                        outParam = 20;
                        break;
                    }

                default:
                    {
                        outParam = 0;
                        break;
                    }
            }
        }

        public static void SomeFunction6(int param, out int outParam)
        {
            outParam = 0;

            switch (param)
            {
                case 1:
                    {
                        outParam = 10;
                        break;
                    }

                case 2:
                    {
                        outParam = 20;
                        break;
                    }
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                // Globals oGlobals = new Globals();

                Utility.Version = "1.2.1";
                Utility.ShowApplicationInfo();

                System.Console.WriteLine("\n");

                int A = 5, B = 10, C;
                C = Utility.Sum(A, B);
                System.Console.WriteLine("Sum of {0} and {1} is {2}", A, B, C);

                System.Console.WriteLine("\n");

                int intSum;
                int[] aryintNumbers = { 1, 2, 3, 4, 5 };
                intSum = Utility.Sum(aryintNumbers);
                System.Console.WriteLine("Sum of numbers is {0}", intSum);

                System.Console.WriteLine("\n");

                int M = 5, N = 10;
                System.Console.WriteLine("M: {0}, N: {1}", M, N);
                Utility.Swap(ref M, ref N);
                System.Console.WriteLine("M: {0}, N: {1}", M, N);

                // Wrong Usage!
                // You must initilize variables if you want to pass them by ref!
                // int P, Q;
                // Globals.Swap(ref P, ref Q);

                int X = 5, Y = 10, Add, Mul;
                Add = Utility.SomeFunction(X, Y, out Mul);

                int Temp = Mul + 1;

                System.Console.WriteLine("\n");

                //X = 5;
                //Y = 10;
                //int Z;
                //Utility.Sum(X, Y, Z); // Z should be initialize or not!
                //System.Console.WriteLine("Sum of {0} and {1} is {2}", X, Y, Z);

                int intOutParam;
                int intInParam = 10;
                Utility.SomeFunction6(intInParam, out intOutParam);

                System.Console.ReadLine();
            }
        }
    }

