using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter29
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
        public Factory JobPlace;

        public Person()
        {
        }

        public Person(string fullName, int age)
        {
            Age = age;
            FullName = fullName;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\n--------------------");
            System.Console.WriteLine("Full Name: {0}", FullName);
            System.Console.WriteLine("Age      : {0}", Age);

            if (JobPlace != null)
                JobPlace.ShowInfo();

            System.Console.WriteLine("--------------------");
        }
    }

    public class Factory
    {
        private int _index;
        public string Name;
        public Person[] Persons;

        public Factory(string name, int size)
        {
            _index = -1;
            Name = name;
            Persons = new Person[size];
        }

        public bool Add(Person person)
        {
            bool blnResult = false;

            if (_index < Persons.Length - 1)
            {
                _index++;
                person.JobPlace = this;
                Persons[_index] = person;

                blnResult = true;
            }

            return (blnResult);
        }

        public bool Add(string fullName, int age)
        {
            bool blnResult = false;

            Person oPerson = new Person(fullName, age);

            blnResult = Add(oPerson);

            return (blnResult);
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Factory Name: " + Name);
        }

        public void ShowPersons()
        {
            foreach (Person oPerson in Persons)
            {
                oPerson.ShowInfo();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Factory oFactory = new Factory("Iran Khodro Co.", 3);

            Person P1 = new Person();
            P1.Age = 20;
            P1.FullName = "Ali Reza Alavi";
            P1.ShowInfo();

            oFactory.Add(P1);

            P1.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
