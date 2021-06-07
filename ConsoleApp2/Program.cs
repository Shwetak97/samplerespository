using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int goodNum1 = 0;
            int goodNum2 = 0;
        CollectNumber1:
            Console.WriteLine("Enter Number1");
            var Num1 = Console.ReadLine();
            if (Num1 == "")
            {
                Console.WriteLine("Hi User please Enter a value again");
                goto CollectNumber1;
            }
            else
            {
                goodNum1 = Convert.ToInt32(Num1);
            }
        GetNumber2:
            Console.WriteLine("Enter Number2");
            var Num2 = Console.ReadLine();
            if(Num2=="")
            {
                Console.WriteLine("Hi User please enter a value again");
                goto GetNumber2;
            }
            else
            {
                goodNum2 = Convert.ToInt32(Num2);
            }

            var res = goodNum1 + goodNum2;
            Console.WriteLine(res);
            Console.ReadLine();

        }
    }
}
