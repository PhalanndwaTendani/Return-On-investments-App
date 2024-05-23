using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnOnInvestments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Initial amount (R): ");
            //decimal mAmount = decimal.Parse(Console.ReadLine());

            //Console.Write("Period of investment: ");
            //int iPeriod = int.Parse(Console.ReadLine());

            //Console.Write("Interest rate per period (%): ");
            //double dRate = double.Parse(Console.ReadLine()) / 100;

            //mAmount += mAmount * (decimal)dRate;

            //int i = 1;

            //while (i <=iPeriod)
            //{
            //    mAmount += mAmount * (decimal)dRate;
            //    i++;
            //}

            /*REPEATING NUMBERS/
             */

            //int i =0;

            //while (i<10)
            //{
            //    Console.WriteLine("Number : " + i);
            //    i++;
            //}

            Console.Write("N = ");
            int iN =  int.Parse(Console.ReadLine());

            int iNum = 1;
            int iSum = 1;

            Console.Write("The sum 1");
            
            while (iNum < iN)
            {
                iNum++;
                Console.Write(" + " + iNum);
                iSum = iSum + iNum;
            }

            Console.WriteLine(" = " + iSum);

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
