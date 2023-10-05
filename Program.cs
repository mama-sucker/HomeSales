// Module 4.2 HomeSales
// By Addison Roy

using System;
class HomeSales
{
    static void Main()
    {
        double totalD = 0;
        double totalE = 0;
        double totalF = 0;

        char initial;
        double saleAmount;

        do
        {
            Console.Write("Homesales program for D,E,and F \n");
            Console.Write("Enter a salesperson initial (D, E, F) or Z to show totals: ");
            initial = char.ToUpper(Console.ReadKey().KeyChar);

            if (initial == 'Z')
            {
                break;
            }

            Console.WriteLine();

            if (initial == 'D' || initial == 'E' || initial == 'F')
            {
                Console.Write($"Enter the sale amount for {initial}: ");
                if (double.TryParse(Console.ReadLine(), out saleAmount) && saleAmount >= 0)
                {
                    switch (initial)
                    {
                        case 'D':
                            totalD += saleAmount;
                            break;
                        case 'E':
                            totalE += saleAmount;
                            break;
                        case 'F':
                            totalF += saleAmount;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid enter a number!");
                }
            }
            else
            {
                Console.WriteLine("enter a letter!");
            }

            Console.WriteLine();
        } while (true);

        double grandTotal = totalD + totalE + totalF;

        Console.WriteLine("\nSales Report:");
        Console.WriteLine($"Total sales for D: {totalD}");
        Console.WriteLine($"Total sales for E: {totalE}");
        Console.WriteLine($"Total sales for F: {totalF}");
        Console.WriteLine($"Grand Total: {grandTotal}");

        char highestSalesperson = ' ';
        double highestTotal = 0;

        if (totalD > highestTotal)
        {
            highestTotal = totalD;
            highestSalesperson = 'D';
        }

        if (totalE > highestTotal)
        {
            highestTotal = totalE;
            highestSalesperson = 'E';
        }

        if (totalF > highestTotal)
        {
            highestTotal = totalF;
            highestSalesperson = 'F';
        }

        Console.WriteLine($"Salesperson with highest revenue: {highestSalesperson}");
    }
}
