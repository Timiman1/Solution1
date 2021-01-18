using System;

namespace _01_Uppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tim");
            Student s2 = new Student("Tim");

           
            Console.WriteLine(s1 == s2);
            s2.Name = "tim";
            Console.WriteLine(s1 != s2);

        }
    }
}
