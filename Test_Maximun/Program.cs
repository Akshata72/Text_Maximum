namespace TestMaximum
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a Three Numbers to Cheak Maximum Number:");
            MaxIntNumber maxintnum = new MaxIntNumber();
            Console.WriteLine("Enter a 1st Number : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 2nd Number : ");
            int Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a 3rd Number : ");
            int Num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(maxintnum.NumberMax(Num1, Num2, Num3));
        }
    }
}