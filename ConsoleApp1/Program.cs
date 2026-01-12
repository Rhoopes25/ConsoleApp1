using System;
using ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Welcome to the dice throwing simulator!");
        System.Console.Write("How many dice rolls would you like to simulate? ");
        int rolls = int.Parse(System.Console.ReadLine());
        
        //where we pass number of times to roll into diceRoller and get dice rolls back
        DiceRoller diceRoller = new DiceRoller();
        
        // get the array of dice roll results
        int[] results = diceRoller.RollDice(rolls);

            // get the array of dice rolls
            // print dice rolls
    }
}