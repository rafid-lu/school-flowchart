using System;

class TaxCalculator
{
    static void Main(string[] args)
    {
        int numberOfHouses = 5000;
        double tax = 0;
        for (int i = 0; i < numberOfHouses; i++)
        {
            Console.Write("Enter the value of the house: ");
            double houseValue = double.Parse(Console.ReadLine());

            if (houseValue > 200000)
                tax += (houseValue * 0.02);
            else if (houseValue > 100000)
                tax += (houseValue * 0.015);
            else if (houseValue > 50000)
                tax += (houseValue * 0.01);
        }

        Console.WriteLine("Total tax to be collected: $" + tax);
    }
}
