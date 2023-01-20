using System;

class SpeedChecker
{
    static void Main(string[] args)
    {
        int numberOfCars = 5000;
        double fastestSpeed = double.MinValue;
        double slowestSpeed = double.MaxValue;
        double totalSpeed = 0;
        for (int i = 0; i < numberOfCars; i++)
        {
            Console.Write("Enter the top speed of car " + (i+1) + ": ");
            double speed = double.Parse(Console.ReadLine());
            if (speed > fastestSpeed)
                fastestSpeed = speed;
            if (speed < slowestSpeed)
                slowestSpeed = speed;
            totalSpeed += speed;
        }
        double averageSpeed = totalSpeed / numberOfCars;
        Console.WriteLine("Fastest speed: " + fastestSpeed + "km/hr");
        Console.WriteLine("Slowest speed: " + slowestSpeed + "km/hr");
        Console.WriteLine("Average speed: " + averageSpeed + "km/hr");
    }
}
