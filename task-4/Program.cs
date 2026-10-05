using System;

class Program
{
    static void Main()
    {
        int[] favoriteNumbers = { 7, 3, 9, 1, 5 };
        
        Array.Sort(favoriteNumbers);

        Console.WriteLine("Array after sorting:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        Array.Reverse(favoriteNumbers);

        Console.WriteLine("\nArray after reversing:");
        for (int i = 0; i < favoriteNumbers.Length; i++)
        {
            Console.WriteLine(favoriteNumbers[i]);
        }

        int numberToFind = 5;
        int position = Array.IndexOf(favoriteNumbers, numberToFind);

        Console.WriteLine($"\nPosition of {numberToFind}: {position}");
    }
}