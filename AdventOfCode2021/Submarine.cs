using System;

namespace AdventOfCode2021
{
    public class Submarine
    {
        private int position = 0;
        private int depth = 0;
        private int aim = 0;

        public int Position => position;
        public int Depth => depth;

        public void MakeMoves(string[] moves)
        {
            foreach (string s in moves)
                Move( s );
        }

        private void Move(string movement)
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

        public void MakeMovesWithAim(string[] moves)
        {
            foreach (string s in moves)
                MoveWithAim( s );
        }

        private void MoveWithAim(string movement)
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