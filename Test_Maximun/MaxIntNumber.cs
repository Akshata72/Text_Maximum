using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    internal class MaxIntNumber
    {
        public int NumberMax(int Num_1, int Num_2, int Num_3)
        {
            Console.WriteLine("Three Integer numbers are : Num1 = {0} , Num2 = {1} , Num3 = {2} ", Num_1, Num_2, Num_3);

            if (Num_1.CompareTo(Num_2) > 0 && Num_1.CompareTo(Num_3) > 0)
            {
                Console.Write("Max Integer Number = ");
                return Num_1;
            }
            else if (Num_2.CompareTo(Num_3) > 0 && Num_2.CompareTo(Num_1) > 0)
            {
                Console.Write("Max Integer Number = ");
                return Num_2;
            }
            else if (Num_3.CompareTo(Num_1) > 0 && Num_3.CompareTo(Num_2) > 0)
            {
                Console.Write("Max Integer Number = ");
                return Num_3;
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }
            return 0;
        }
    }
}