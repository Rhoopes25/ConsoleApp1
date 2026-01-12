using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine();
        System.Console.Write("How many dice rolls would you like to simulate? ");
        int rolls = int.Parse(System.Console.ReadLine());
        
        //where we pass number of times to roll into diceRoller and get dice rolls back
        DiceRoller diceRoller = new DiceRoller();
        
        // get the array of dice roll results
        int[] results = diceRoller.RollDice(rolls);
        
        Console.WriteLine();
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + rolls + ".");

        for (int i = 2; i < 13; i++)
        {
            double percentage = (double)results[i] / rolls * 100;
            
            // get number of rolls to print
            int stars = (int)percentage;
            
            // print dice rolls
            Console.Write(i + ": ");

            for (int j = 0; j < stars; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");

    }
}