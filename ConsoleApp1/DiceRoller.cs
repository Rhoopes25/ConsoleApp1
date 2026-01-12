using System;
namespace ConsoleApp1;

public class DiceRoller
{
    public int[] RollDice(int rolls)
    {
        
        // dice roll will be between 2-12
        int[] results = new int[13];
        // creats a random number
        Random random = new Random();

        for (int i = 0; i < rolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die2 + die1;
            
            //add count to number of times number was rolled
            results[sum]++;
        }
        return results;
    }
}