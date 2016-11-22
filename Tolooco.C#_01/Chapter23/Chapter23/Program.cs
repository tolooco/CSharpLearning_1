using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter23
{
    /// <summary>
    /// 14 January 2014
    /// Version 1.1.0
    /// Written By Amir Chabok
    /// EMail: Chabok.121@Gmail.com
    /// Homepage: http://www.Cwx121.com
    /// </summary>
    public class Complex
    {
        public int X;
        public int Y;

        public Complex()
        {
        }

        public Complex(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Show()
        {
            System.Console.WriteLine("{0} + {1}i", X, Y);
        }

        // Operators must be defined [static].
        //
        // If you define [+], compiler will overload [+=] automatically.
        // If you define [-], compiler will overload [-=] automatically.
        // If you define [*], compiler will overload [*=] automatically.
        // If you define [/], compiler will overload [/=] automatically.
        public static Complex operator +(Complex m, Complex n) // Operator Overloading!
        {
            Complex oResult = new Complex();

            oResult.X = m.X + n.X;
            oResult.Y = m.Y + n.Y;

            return (oResult);

            // return(new Complex(m.X + n.X, m.Y + n.Y));
        }

        public static Complex operator *(int alpha, Complex m)
        {
            Complex oResult = new Complex();

            oResult.X = alpha * m.X;
            oResult.Y = alpha * m.Y;

            return (oResult);

            // return(new Complex(alpha * m.X, alpha * m.Y));
        }

        // I will tell you about Overriding in next sessions!
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // I will tell you about Overriding in next sessions!
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // If you define [==], You must overload [!=].
        // If you define [<=], You must overload [>=].
        // If you define [<] , You must overload [>].
        //
        // If you want to define [==] or [!=], You must override GetHashCode!
        public static bool operator ==(Complex m, Complex n) // Operator Overloading!
        {
            if ((m.X == n.X) && (m.Y == n.Y))
            {
                return (true);
            }
            else
            {
                return (false);
            }
        }

        public static bool operator !=(Complex m, Complex n) // Operator Overloading!
        {
            if ((m.X == n.X) && (m.Y == n.Y))
            {
                return (false);
            }
            else
            {
                return (true);
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Complex A = new Complex();
            A.X = 1;
            A.Y = 2;
            A.Show();

            Complex B = new Complex(3, 4);
            B.Show();

            System.Console.WriteLine("\n----------");

            Complex C = A + B;
            C.Show();

            System.Console.WriteLine("\n----------");

            C += A;
            C.Show();

            System.Console.WriteLine("\n----------");

            int alpha = 5;
            C = alpha * A;
            C.Show();

            System.Console.WriteLine("\n----------");

            Complex D = new Complex(1, 2);

            if (A == D)
            {
                System.Console.WriteLine("A is equal to D");
            }
            else
            {
                System.Console.WriteLine("A is not equal to D");
            }

            System.Console.WriteLine("\n----------");

            if (A != B)
            {
                System.Console.WriteLine("A is not equal to B");
            }
            else
            {
                System.Console.WriteLine("A is equal to B");
            }

            System.Console.ReadLine();
        }
    }
}
