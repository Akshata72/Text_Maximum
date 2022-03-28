using System;

namespace FindMaxUsingGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            MaxGeneric<int> maxGenericInt = new MaxGeneric<int>();
            maxGenericInt.MaxLength(15, 15, 15);

            MaxGeneric<float> maxGenericFloat = new MaxGeneric<float>();
            maxGenericFloat.MaxLength(45.4f, 85.5f, 94.4f);

            MaxGeneric<string> maxGenericString = new MaxGeneric<string>();
            maxGenericString.MaxLength("Apple", "Peach", "Banana"); 
        }
    }
}