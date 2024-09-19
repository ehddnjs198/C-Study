using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    delegate int FuncDelegate(int Num1, int Num2);


    class DelegateStudy
    {
        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            FuncDelegate plusDelegate = Plus;
            FuncDelegate minusDelegate = Minus;


            Console.WriteLine(plusDelegate(5,10));
            Console.WriteLine(minusDelegate(10, 5));
            Console.ReadLine();
        }
    }
}
