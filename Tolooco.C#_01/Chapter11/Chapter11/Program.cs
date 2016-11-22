using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{

    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Father
    {
        public int Age;
        public string FullName;

        // Solution (1)
        //public bool Angry = false;
        //private int _criticalAmount = 5000;
        // /Solution (1)

        // Solution (2) [It's better!]
        public bool Angry;
        private int _criticalAmount;

        public Father()
        {
            Angry = false;
            _criticalAmount = 5000;
        }
        // /Solution (2) [It's better!]

        public void GiveMeMoney(int amount)
        {
            if (amount >= _criticalAmount)
            {
                // عصبانی می شود
                Angry = true;
            }
            else
            {
                // عصبانی نمی شود
                Angry = false;
            }
        }

        public void ShowInfo()
        {
            System.Console.WriteLine("Full Name: {0}, Age: {1}", FullName, Age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Father F1 = new Father();
            F1.Age = 20;
            F1.FullName = "Ali Reza Alavi";

            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);
            F1.GiveMeMoney(1000);
            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);
            F1.GiveMeMoney(5500);
            System.Console.WriteLine("F1 is angry. {0}", F1.Angry);

            System.Console.ReadLine();
        }
    }
}
