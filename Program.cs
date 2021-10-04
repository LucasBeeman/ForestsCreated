using System;

namespace StaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Forest num1 = new Forest("asdf");
            Console.WriteLine(Forest.ForestsCreated);
            Forest num2 = new Forest("fdsa");
            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}