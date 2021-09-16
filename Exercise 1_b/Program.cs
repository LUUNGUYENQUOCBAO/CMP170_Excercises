using System;

namespace Exercise_1_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y ;
            Console.WriteLine("Input x : ");
            x = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Input y : ");
            y = Convert.ToInt32(Console.ReadLine());
            
            int sum = x + y;
            int subtract = x - y;
            int multiply = x * y;
            int divide = x / y;
            
            
            Console.WriteLine("x + y = " + sum );
            Console.WriteLine("x - y  = " + subtract);
            Console.WriteLine("x * y = " + multiply);
            Console.WriteLine("x / y = " + divide);
            Console.ReadKey();



        }
    }
}
