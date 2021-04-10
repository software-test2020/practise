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
            Console.Write("\n\nFunction : To calculate the sum of individual digits of a number: \n");
            Console.Write("-------\n");
            Console.Write("enter a number ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("the sum of digits of the number {0} is {1} \n",x, test(x));


        }

       public static int   test (int x)
        {
            int sum = 0;

            for (int y=x; y!=0;y/=10)

            {

                sum += y % 10;
            }

            return sum;
           



       }
    }
}
