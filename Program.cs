using System;

namespace csharp
{
    class Program
    {

        //Methods


        static void Main(string[] args)
        {
            //Console.WriteLine(5 % 2); //Modulus
            //Console.WriteLine(5 / 2.0); //Division

            Console.WriteLine();

            int numPlus = 12;
            numPlus++; //adds 1 to the number
            Console.WriteLine($"Num++ {numPlus}");

            int num = 12;
            Console.WriteLine($"Number: {num}");

            int numMinus = 12;
            numMinus--; //subtracts 1 from the number
            Console.WriteLine($"Num-- {numMinus}");
            Console.WriteLine();
            //Math Operations

            Console.WriteLine($"Square Root of 64: Math.Sqrt(64)");//math functions

            Console.WriteLine($"Min of Num++ and Num--: {Math.Min}({numMinus},{numPlus})");
            //Use this to determin Min or Max of two numbers hidden in variables
            Console.WriteLine($"Max of Num++ and Num--: {Math.Max}({numMinus},{numPlus})");

            Console.WriteLine("Min of two integers: Math.Min(22, 1)");







        }







    }

}

