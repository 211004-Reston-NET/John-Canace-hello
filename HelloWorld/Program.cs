using System;
using HouseFunction;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            House Stephen = new House();
            Stephen.MiceName = "Jerry";
            Console.WriteLine(Stephen.MiceName);
        }
    }
}
