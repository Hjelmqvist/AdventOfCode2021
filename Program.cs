using System;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
            Day2();
        }

        private static void Day1()
        {
            Console.WriteLine( "Day 1" );
            int[] numbers = Sonar.GetNumbers();
            Console.WriteLine( Sonar.GetIncreasedCount( numbers ) );
            Console.WriteLine( Sonar.GetIncreasedCount( Sonar.GetTripletSums( numbers ) ) );
            Console.WriteLine();
        }

        private static void Day2()
        {
            Console.WriteLine( "Day 2" );

            string[] input = Submarine.GetInputs();
            Submarine.MakeMoves( input );
            Console.WriteLine( Submarine.position * Submarine.depth );

            Submarine.Reset();
            Submarine.MakeMovesWithAim( input );
            Console.WriteLine( Submarine.position * Submarine.depth );
            Console.ReadLine();
        }
    }
}