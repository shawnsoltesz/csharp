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

            //                      **Math Operations**

            //Use this to determin Min or Max of two numbers hidden in variables
            var MathMin = (Math.Min(numMinus, numPlus));
            Console.WriteLine($"Min of Num++ and Num--: {MathMin}");

            var MathMax = (Math.Max(numMinus, numPlus));
            Console.WriteLine($"Max of Num++ and Num--: {MathMax}");

            //math functions
            var MathSqrt = (Math.Sqrt(64));
            Console.WriteLine($"Square Root of 64: Math.Sqrt (64): {MathSqrt}");
            var IntMin = (Math.Min(22, 1));
            Console.WriteLine("Min of two integers: Math.Min (22, 1): {IntMin}");
            var MathRound = Math.Round(4.6);
            Console.WriteLine($"Rounding 4.6: {MathRound}");
















        }







    }

}

