using System;

class TemperatureChecker
{
    static void Main(string[] args)
    {
        int below20 = 0;
        int above20 = 0;
        for (int i = 0; i < 100; i++)
        {
            Console.Write("Enter the temperature for day " + (i+1) + ": ");
            double temperature = double.Parse(Console.ReadLine());
            if (temperature < 20)
                below20++;
            else
                above20++;
        }
        Console.WriteLine("Number of days below 20C: " + below20);
        Console.WriteLine("Number of days 20C and above: " + above20);
    }
}
