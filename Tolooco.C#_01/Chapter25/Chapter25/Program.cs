using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter25
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
        public int Age;
        public string FullName;

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] aryintNumbers = new int[2];
            aryintNumbers[0] = 5;
            aryintNumbers[1] = 10;

            Person[] oPersons = new Person[2];

            // Wrong Usage!
            // You must first make a new person in array!
            //
            // oPersons[0].Age = 5;
            // oPersons[0].FullName = "Ali Reza Alavi";

            //#####################
            //### Solution (1) ####
            //#####################
            oPersons[0] = new Person();
            oPersons[1] = new Person();
            //#####################
            //### /Solution (1) ####
            //#####################

            //#####################
            //### Solution (2) ####
            //#####################
            for (int intIndex = 0; intIndex <= oPersons.Length - 1; intIndex++)
            {
                oPersons[intIndex] = new Person();
            }
            //#####################
            //### /Solution (2) ####
            //#####################

            oPersons[0].Age = 5;
            oPersons[0].FullName = "Ali Reza Alavi";
            oPersons[0].ShowInfo();

            int[,] RectangularArray = new int[2, 3]; // Rectangular Array!

            RectangularArray[0, 0] = 1;
            RectangularArray[0, 1] = 2;
            RectangularArray[0, 2] = 3;

            RectangularArray[1, 0] = 1;
            RectangularArray[1, 1] = 2;
            RectangularArray[1, 2] = 3;

            foreach (int A in RectangularArray)
            {
                Console.WriteLine(A.ToString());
            }

            int[][] JaggedArray = new int[3][]; // Jagged Array!

            JaggedArray[0] = new int[2];
            JaggedArray[1] = new int[5];
            JaggedArray[2] = new int[3];

            JaggedArray[0][0] = 1;
            JaggedArray[0][1] = 2;

            JaggedArray[1][0] = 3;
            JaggedArray[1][1] = 4;
            JaggedArray[1][2] = 5;
            JaggedArray[1][3] = 6;

            JaggedArray[2][0] = 3;
            JaggedArray[2][1] = 4;
            JaggedArray[2][2] = 5;

            System.Console.ReadLine();
        }
    }
}
