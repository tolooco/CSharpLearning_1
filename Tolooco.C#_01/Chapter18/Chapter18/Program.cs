using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter18
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    // Enumeration
    // Note:  Default type of each enumeration is [int]!
    // Note: It's better you define enumeration in Namespace!
    public enum PersonGenders
    {
        Male, // Male = 0,
        Female // Female = 1
    }

    public enum PersonMarriages : byte
    {
        Single = 10,
        Married = 20,
        Divorced = 30
    }

    public enum SomeEnum
    {
        X = 10,
        Y, // Y = 11,
        Z, // Z = 12,
        T  // T = 13
    }

    public class Person
    {
        //public enum Genders
        //{
        //    Male = 0,
        //    Female = 1
        //}

        //public enum Marriages : byte
        //{
        //    Single = 10,
        //    Married = 20,
        //    Divorced = 30
        //}

        public int Age;
        public string FullName;

        public PersonGenders Gender;
        public PersonMarriages Marriage;

        public Person()
        {
        }

        public Person
            (string fullName, int age, PersonGenders gender, PersonMarriages marriage)
        {
            Age = age;
            Gender = gender;
            Marriage = marriage;
            FullName = fullName;
        }

        // Note: Copy Constructor!
        public Person(Person person)
        {
            Age = person.Age;
            Gender = person.Gender;
            Marriage = person.Marriage;
            FullName = person.FullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\n: Full Name: {0}, Age: {1}, Gender: {2}, Marriage: {3}", FullName, Age, Gender, Marriage);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person P0 = new Person();
            P0.Marriage = PersonMarriages.Married;

            Person P1 = new Person("Ali Reza Alavi", 20, PersonGenders.Male, PersonMarriages.Single);
            P1.ShowInfo();

            System.Console.WriteLine("\n----------");

            Person P2 = new Person(P1);
            P2.ShowInfo();

            System.Console.WriteLine("\n----------");

            if (P1.Gender == PersonGenders.Male)
            {
                System.Console.WriteLine("He is male.");
            }
            else
            {
                System.Console.WriteLine("She is female.");
            }

            switch (P1.Marriage)
            {
                case PersonMarriages.Single:
                    {
                        System.Console.WriteLine("Single.");
                        break;
                    }

                case PersonMarriages.Married:
                    {
                        System.Console.WriteLine("Married.");
                        break;
                    }

                case PersonMarriages.Divorced:
                    {
                        System.Console.WriteLine("Divorced.");
                        break;
                    }
            }

            System.Console.ReadLine();
        }
    }
}
