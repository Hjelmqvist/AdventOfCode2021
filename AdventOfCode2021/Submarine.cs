using System;
using System.IO;

namespace AdventOfCode2021
{
    public static class Submarine
    {
        public static int position = 0;
        public static int depth = 0;
        public static int aim = 0;

        public static void Reset()
        {
            position = 0;
            depth = 0;
            aim = 0;
        }

        public static string[] GetInputs()
        {
            return File.ReadAllLines( @"D:\Desktop\FutureGames\AdventOfCode2021\AdventOfCode2021\Day2Input.txt" );
        }

        public static void MakeMoves(string[] moves)
        {
            foreach (string s in moves)
                Move( s );
        }

        private static void Move(string movement)
        {
            string[] input = movement.Split( ' ' );
            string command = input[0];
            int value = Convert.ToInt32( input[1] );

            switch (command)
            {
                case "forward":
                    position += value;
                    break;
                case "down":
                    depth += value;
                    break;
                case "up":
                    depth -= value;
                    break;
                default:
                    break;
            }
        }

        public static void MakeMovesWithAim(string[] moves)
        {
            foreach (string s in moves)
                MoveWithAim( s );
        }

        private static void MoveWithAim(string movement)
        {
            string[] input = movement.Split( ' ' );
            string command = input[0];
            int value = Convert.ToInt32( input[1] );

            switch (command)
            {
                case "forward":
                    position += value;
                    depth += aim * value;
                    break;
                case "down":
                    aim += value;
                    break;
                case "up":
                    aim -= value;
                    break;
                default:
                    break;
            }
        }
    }
}