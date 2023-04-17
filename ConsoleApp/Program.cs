using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int SnakeStateTotal = 3;
        private const int SnakeState1 = 0;
        private const int SnakeState2 = 1;
        private const int SnakeState3 = 2;
        private static readonly int SnakeMoveCount = 50;
        private static readonly int SnakeRow = 5;
        private static readonly int SnakeSleeptime = 1000;
        static void Main(string[] args)
        {
            int x = SnakeState1;
            while (x < SnakeMoveCount)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeMoveCount);

                // switch
                if(x%SnakeStateTotal == SnakeState1) Console.WriteLine("__@");
                else if(x% SnakeStateTotal == SnakeState2) Console.WriteLine("_^@");
                else  Console.WriteLine("^_@");

                Thread.Sleep(SnakeSleeptime);
                x++;
            }
        }
    }
}
