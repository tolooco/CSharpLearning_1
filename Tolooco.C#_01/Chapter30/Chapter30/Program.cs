using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter30
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public sealed class Supervisor // Singletone Pattern
    {
        private static Supervisor _instance = null;
        public static Supervisor GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Supervisor();
            }
            return (_instance);
        }

        private Supervisor()
        {
        }

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
            //Supervisor S = new Supervisor();

            Supervisor od = Supervisor.GetInstance();

            od.Age = 21;
            od.FullName = "aa";
            od.ShowInfo();


            Supervisor.GetInstance().Age = 20;
            Supervisor.GetInstance().FullName = "Ali Reza Alavi";
            Supervisor.GetInstance().ShowInfo();

            Supervisor S = Supervisor.GetInstance();

            

            S.Age = 25;
            S.ShowInfo();
            od.ShowInfo();

            System.Console.ReadLine();
        }
    }
}
