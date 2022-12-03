using System;

namespace Prettifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your number to be pretified");
            var input = Console.ReadLine();
            var res =NumberManupulation.NumberPrettifier(double.Parse(input));
            Console.WriteLine("Pretified value is :"+res);

        }
    }
}
