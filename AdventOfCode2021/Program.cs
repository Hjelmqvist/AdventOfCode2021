using System;
using System.IO;

namespace AdventOfCode2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
            Day2();
            Console.ReadLine();
        }

        private static void Day1()
        {
            Console.WriteLine( "Day 1" );

            string[] input = File.ReadAllLines( @"..\..\Day1Input.txt" );

            int[] numbers = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
                numbers[i] = Convert.ToInt32( input[i] );

            Console.WriteLine( Sonar.GetIncreasedCount( numbers ) );
            Console.WriteLine( Sonar.GetIncreasedCount( Sonar.GetTripletSums( numbers ) ) );
            Console.WriteLine();
        }

        private static void Day2()
        {
            Console.WriteLine( "Day 2" );

            string[] input = File.ReadAllLines( @"..\..\Day2Input.txt" );
            Submarine sub = new Submarine();
            sub.MakeMoves( input );
            Console.WriteLine( sub.Position * sub.Depth );

            sub = new Submarine();
            sub.MakeMovesWithAim( input );
            Console.WriteLine( sub.Position * sub.Depth );
            Console.WriteLine();
        }
    }
}