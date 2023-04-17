using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            

            // 위치는 절대값
            Console.Write("메서드 호출");
            Thread.Sleep(1000);

            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출2");
            Thread.Sleep(1000);

            Console.SetCursorPosition(0, 0);
            Console.Write("메서드 호출3");
        }
    }
}
