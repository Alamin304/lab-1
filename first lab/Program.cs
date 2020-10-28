using System;

namespace first_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("alamin");
            Console.WriteLine(10 + 15);
            Console.WriteLine(20 / 2);
            Console.WriteLine(-5 + 8 * 6);
            Console.WriteLine((55 + 9) % 9);
            Console.WriteLine(20 + -3 * 5 / 8);
            Console.WriteLine(5 + 15 / 3 * 2 - 8 % 3);
            int sum, sub, mul, div, rem;
            int a = 10, b = 5;
            sum = a + b; sub = a - b; mul = a * b; div = a / b; rem = a % b;
            Console.WriteLine("sum:" + sum);
            Console.WriteLine("sub:" + sub);
            Console.WriteLine("mul:" + mul);
            Console.WriteLine("div:" + div);
            Console.WriteLine("rem:" + rem);

            double expression = ((25.5 * 3.5 - 3.5 * 3.5) / (40.5 - 4.5));
            Console.WriteLine("result:" + expression);

            
        }
    }
}
