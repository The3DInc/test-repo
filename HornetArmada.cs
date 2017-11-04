using System;
using System.Collections.Generic;
using System.Linq;

class HornetArmada
{
    public static void Main(string[] args)
    {
        Dictionary<string,int> activityLegion = new Dictionary<string,int>();
        
        Dictionary<string,Dictionary<string,int>> legionSoldierCount = 
            new Dictionary<string, Dictionary<string, int>>();

        int inputCount = int.Parse(Console.ReadLine());
        int tmp = inputCount;
        for (int i = 0; i < tmp; i++)
        {
            string[] input = Console.ReadLine()
                .Split(new[] {@"=", @"->", @":"}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            

            int activity = int.Parse(input[0]);            // naming variables
            string legion = input[1];
            string soldierType = input[2];
            int soldierCount = int.Parse(input[3]);
            
            
            
            if (input.Length < 4)// possible error
            {
                tmp++;
                continue;
            }
            
            if (!activityLegion.ContainsKey(legion)) // check if database contains legion
                activityLegion[legion] = 0;
            
            
            if (activityLegion[legion] < activity)    // check if activity is bigger
                activityLegion[legion] = activity;
            
            if (!legionSoldierCount.ContainsKey(legion))    // check if second database contains legion
            legionSoldierCount[legion] = new Dictionary<string, int>();
            
            
            
            if (!legionSoldierCount[legion].ContainsKey(soldierType)) // check if contains soldier type
                legionSoldierCount[legion][soldierType] = 0;
            
            
            legionSoldierCount[legion][soldierType] += soldierCount;
        }

        string[] outputData = Console.ReadLine()
            .Split(new[] {@"\"}, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        if (outputData.Length == 1)
        {

        }
        else
        {
            
        }

    }
}
