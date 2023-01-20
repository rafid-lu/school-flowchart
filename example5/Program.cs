using System;

class StockChecker
{
    static void Main(string[] args)
    {
        int numberOfBooks = 0;
        int numberOfMaps = 0;
        int numberOfMagazines = 0;
        while (true)
        {
            Console.Write("Enter the code for the item: ");
            int code = int.Parse(Console.ReadLine());
            if (code == 9999) break;
            int firstDigit = code / 1000;
            if (firstDigit == 1)
                numberOfBooks++;
            else if (firstDigit == 2)
                numberOfMaps++;
            else if (firstDigit == 3)
                numberOfMagazines++;
            else
                Console.WriteLine("Invalid code. Please enter a code starting with 1, 2 or 3.");
        }
        Console.WriteLine("Number of books: " + numberOfBooks);
        Console.WriteLine("Number of maps: " + numberOfMaps);
        Console.WriteLine("Number of magazines: " + numberOfMagazines);
    }
}
