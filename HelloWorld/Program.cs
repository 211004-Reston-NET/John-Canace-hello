using System;
using HouseFunction;

namespace HelloWorld
{
    class Program
    {
     private string Seller;
     
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            House Stephen = new House();
            Stephen.MiceName = "Jerry";
            Console.WriteLine(Stephen.MiceName);

            Console.WriteLine("Who sold you the house?");
            string Seller = Console.ReadLine();
            Console.WriteLine("The house was sold by " + Seller);
        }
    }
}
