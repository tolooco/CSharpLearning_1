using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter02
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
            // Primitive (Value) Types will created in Stack!

			// Integer Types:
			sbyte sbytNumber = 10; // [byte]: 8Bits.
			short shrNumber = 300; // [short]: 16Bits.
			int intNumber = 32000; // [int]: 32Bits.
			long lngNumber = 2000000; // [long]: 64Bits.

			// Integer Types:
			byte bytNumber = 10; // [byte]: 8Bits.
			ushort ushrNumber = 300; // [short]: 16Bits.
			uint uintNumber = 32000; // [int]: 32Bits.
			ulong ulngNumber = 2000000; // [long]: 64Bits.


            //#################################################

            //#################################################

			// What We Should Do or Do Not!
			int a = 10; // OK
			long b = 10; // OK - Implicit Casting

			b = a; // OK - Implicit Casting

			// a = b; // Compile Error!
			a = (int)b; // OK - Explicit Casting

            //#################################################

            //#################################################


			// Decimal Types:
			double dblNumber = 123.456; // [double]: 64Bits. Value will be rounded!

			float fltNumber1 = (float)3.14; // [float]: 32Bits. You must CAST your value!
			float fltNumber2 = 3.14f; // If you do not want to make CASTING!

			decimal decNumber1 = (decimal)123.456; // [decimal]: 64Bits. Value will not be rounded! You must CAST your value!
			decimal decNumber2 = 123.456m; // [decimal]: 64Bits. Value will not be rounded! You must CAST your value!

			// int m;
			// int p = f(m);
			// int n = m + 1; // You should not use of unassigned local variable!

			// int m;
			// m = 1;
			// int p = f(m);
			// int n = m + 1;

			int m = 1;
			int n = m + 1;

			int intResult = 10;

			// +, -, *, /, %

			//SomeVariable = Operand1 (Operator) Operan2;

			// SomeVariable = SomeVariable (Operator) OtherVariable;
			// SomeVariable (Operator)= OtherVariable;

			intResult = intResult - 1;
			intResult -= 1;
			intResult--;
			--intResult;

			intResult = intResult + 1;
			intResult += 1;
			intResult++;
			++intResult;

			int p1;
			int q1;
			p1 = 1;
			q1 = p1++;

			int p2;
			int q2;
			p2 = 1;
			q2 = ++p2;

			bool blnResult = true; // false

			char chrResult1 = 'A'; // 65

			// Note: 'A' is not "A"!

			// if(Condition) Do Something;

			// if(Condition)
			//     Do Something;

			// Note: It's better!
			//if (Condition)
			//{
			//     Do Something;
			//}

			// if(Condition)
			// {
			//     Do Something;
			//     Do Something;
			// }

			// if(Condition)
			// {
			// }
			// else
			// {
			// }

			int intNumber1 = 5;
			int intNumber2 = 7;
			int intMax = (intNumber1 < intNumber2) ? intNumber2 : intNumber1; // Inline Condition = شرط خطی
			int intMin = (intNumber1 > intNumber2) ? intNumber2 : intNumber1;

			// while(Condition) Do Something;

			// while(Condition)
			//     Do Something;

			// Note: It's better!
			//while (Condition)
			//{
			//    Do Something;
			//}

			// while(Condition)
			// {
			//     Do Something;
			//     Do Something;
			// }

			// do Do Something;
			// while(Condition); // Note: (;)

			// do
			//     Do Something;
			// while(Condition); // Note: (;)

			// Note: It's better!
			//do
			 //{
			 //    Do Something;
			 //}
			 //while(Condition); // Note: (;)

			// do
			// {
			//     Do Something;
			//     Do Something;
			// }
			// while(Condition); // Note: (;)

			// for(A; B; C)
			// {
			//     D;
			// }
			// A, B, D, C, B, D, C, B, D, C, ...

			// for(int intIndex = 1; intIndex <= 10; intIndex++) Do Something;

			// for(int intIndex = 1; intIndex <= 10; intIndex++)
			//     Do Something;

			// Note: It's better!
			//for (int intIndex = 1; intIndex <= 10; intIndex++)
			//{
			//    Do Something;
			//}

			// for(int intIndex = 1; intIndex <= 10; intIndex++)
			// {
			//     Do Something;
			//     Do Something;
			// }

			// Condition Rules:
			//          : >
			//          : <
			//          : >= ( Note: Not => )
			//          : <=
			// Equal    : == ( Note: Not = )
			// Not Equal: != ( Note: Not <>)

			// And      : &&
			// Or       : ||
			// Not      : !

			// In conditions, You must use ( and )!

			// if (!(((A == 5) && (B == 6)) || (C == 7)))
			//{
			//}

			// If we have two functions checking in our condition such as (f() || g()),
			// If result of f() was true, Compiler never run function g()!

			// If we have two functions checking in our condition such as (f() && g()),
			// If result of f() was false, Compiler never run function g()!

			
			// bool blnResult1 = f();
			// bool blnResult2 = g();
			// if(blnResult1 || blnResult2)
			// OR
			// if(blnResult1 && blnResult2)
			


			for (int intTemp = 0; intTemp <= 10; intTemp++)
			{
				System.Console.WriteLine("intTemp: {0}", intTemp);

				if (intTemp == 3)
				{
					intTemp = 5;
					continue;
				}

				if (intTemp == 8)
				{
					break;
				}
			}
			// Result: 0, 1, 2, 3, 6, 7, 8

			// Reference Type
			string strFirstName = "Ali Reza";
			string strLastName = "Alavi";
			string strFullName = strFirstName + " " + strLastName;

			if (strFirstName == "Ali Reza")
			{
				System.Console.WriteLine("Your first name is Ali Reza!");
			}
			else
			{
				System.Console.WriteLine("Your first name is not Ali Reza!");
			}

			System.Console.ReadLine();
		}
        }
    }


