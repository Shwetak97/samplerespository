using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            long Total = 0;
            for (int count = 0; count < 5; count++)
            {
                Console.WriteLine("Enter Mark" + count);
                int mark = Convert.ToInt32(Console.ReadLine());
                Total = Total + mark;
            }
            Console.WriteLine("Total Marks:" + Total);
            Console.ReadLine();

        }
    }
}
