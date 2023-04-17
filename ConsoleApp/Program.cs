using System;
using System.Threading;
namespace ConsoleApp
{
    class Program
    {

        private static readonly int SnakeStateTotal = 3;
        private const int SnakeState1 = 0;
        private const int SnakeState2 = 1;
        private const int SnakeState3 = 2;
        private static readonly int SnakeMoveCount= 50;
        private static readonly int SnakeRow = 5;
        private static readonly int SnakeSleepTime;

        static void Main(string[] args)
        {
            int x = SnakeState1;
            while (x< SnakeMoveCount)
            {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeRow);

                switch(x % SnakeStateTotal)
                {
                    case SnakeState1:
                        Console.WriteLine("__@");
                        break;
                    case SnakeState2:
                        Console.WriteLine("_^@");
                        break;
                    case SnakeState3:
                        Console.WriteLine("@_^");
                        break;
                }
                // 100밀리초 정지하고 x 증가
                Thread.Sleep(SnakeSleepTime);
                x++;
            }
        }
    }
}
