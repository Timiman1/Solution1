using System;
using System.Collections.Generic;

namespace TestConsoleApp
{

    public static class ExtensionMethods
    {
        public static int toInt(this string value)
        {
            return int.Parse(value);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Tullgods> gods = new List<Tullgods>() { new Tullgods() { Type = "knark" } };
            Tullgods find = gods.Find(TullInspektör);
            Console.WriteLine(find != null ? "Hittade knark" : "Hittade inget knark");
            Tullgods find2 = gods.Find(godset => godset.Type == "vapen");
            Console.WriteLine(find2 != null ? "Hittade vapen" : "Hittade inga vapen");
            var test = Console.ReadLine().toInt();
            Console.WriteLine(test);
        }

        static bool TullInspektör(Tullgods godset)
        {
            return (godset.Type == "knark");
        }
    }
}
