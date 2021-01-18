using System;

namespace _02_Uppgift_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string binString = "11101010";
            Console.WriteLine($"{binString} = {BinToDec(binString)}");
        }

        static int BinToDec(string binString)
        {
            int length = binString.Length;
            int[] intArray = new int[length];
            // från höger till vänster i binString, lägg till ett int element i intArray som är 2^(i)
            int index = 0;
            int sum = 0;
            char[] charArr = binString.ToCharArray();

            for (int i = length - 1; i >= 0; i--)
            {
                intArray[i] = (int)Math.Pow(2, index);
                index++;
                if (charArr[i] == '1')
                {
                    sum += intArray[i];
                }
            }
            return sum;
        }
    }
}
