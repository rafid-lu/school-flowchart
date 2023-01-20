using System;

class Calculation
{
    static void Main(string[] args)
    {
        double x = 1;
        while (x != 0)
        {
            Console.Write("Enter the value of x: ");
            x = double.Parse(Console.ReadLine());
            if (x == 0) break;
            if (x >= 1)
            {
                Console.WriteLine("Invalid input. x should be less than 1.");
                continue;
            }
            double n = (x * x) / (1 - x);
            Console.WriteLine("n = " + n);
            Console.WriteLine("x = " + x);
        }
    }
}
