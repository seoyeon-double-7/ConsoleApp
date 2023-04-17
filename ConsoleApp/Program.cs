using System;
using System.Threading;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x<50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                switch(x % 3)
                {
                    case 0:
                        Console.WriteLine("__@");
                        break;
                    case 1:
                        Console.WriteLine("_^@");
                        break;
                    case 2:
                        Console.WriteLine("@_^");
                        break;
                }
                // 100밀리초 정지하고 x 증가
                Thread.Sleep(100);
                x++;
            }
        }
    }
}
