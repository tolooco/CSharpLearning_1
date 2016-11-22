using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter27
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
        private int _age;
        public int Age
        {
            get
            {
                return (_age);
            }
            set
            {
                if ((value >= 1) && (value <= 99))
                {
                    _age = value;
                }
            }
        }

        private string _fullName;
        public string FullName
        {
            get
            {
                return (_fullName);
            }
            set
            {
                _fullName = value;
            }
        }

        private Factory _jobPlace;
        public Factory JobPlace
        {
            get
            {
                return (_jobPlace);
            }
            set
            {
                _jobPlace = value;
            }
        }

        public Person(string fullName)
        {
            FullName = fullName;

            //_fullName = fullName;
        }

        // public Person(string fullName, int age)
        // {
        // 	Age = age;
        // 	FullName = fullName;
        // }

        public Person(string fullName, int age)
            : this(fullName)
        {
            Age = age;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("\n--------------------");
            System.Console.WriteLine("Full Name: {0}", FullName);
            System.Console.WriteLine("Age      : {0}", Age);

            if (JobPlace != null)
            {
                System.Console.WriteLine("Job Place: {0}", JobPlace.Name);
            }

            System.Console.WriteLine("--------------------");
        }
    }

    public class Factory
    {
        private string _name;
        public string Name
        {
            get
            {
                return (_name);
            }
            set
            {
                _name = value;
            }
        }

        private Person _manager;
        public Person Manager
        {
            get
            {
                return (_manager);
            }
            set
            {
                _manager = value;
                _manager.JobPlace = this;
            }
        }

        public Factory(string name)
        {
            Name = name;
        }

        public Factory(string name, Person manager)
        {
            Name = name;
            Manager = manager;
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Factory Name: " + Name);

            if (Manager != null)
            {
                Manager.ShowInfo();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\n----------");

            Person oManager = new Person("Ali Reza Alavi", 30);
            oManager.ShowInfo();

            Factory oFactory = new Factory("Iran Khodro Co.", oManager);

            oManager.ShowInfo();

            System.Console.WriteLine("\n----------");

            System.Console.ReadLine();
        }
    }
}
