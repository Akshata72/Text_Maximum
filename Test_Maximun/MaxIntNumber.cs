using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Maximun
{
    internal class MaxIntNumber
    {
        public int NumberMax(int Num1, int Num2, int Num3)
        {
            Console.WriteLine("Three numbers are Num1 = {0} , Num2 = {1} , Num3 = {2} ", Num1, Num2, Num3);

            if (Num1.CompareTo(Num2) > 0 && Num1.CompareTo(Num3) > 0)
            {
                Console.WriteLine("Maximum = ");
                return Num1;
            }
            else if (Num2.CompareTo(Num3) > 0 && Num2.CompareTo(Num1) > 0)
            {
                Console.WriteLine("Maximum = ");
                return Num2;
            }
            else if (Num3.CompareTo(Num1) > 0 && Num3.CompareTo(Num2) > 0)
            {
                Console.WriteLine("Maximum = ");
                return Num3;
            }
            else
            {
                Console.WriteLine("all numbers are equal");
            }
            return 0;
        }
    }
}
