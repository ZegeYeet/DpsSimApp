using DpsSimApp;
using System;


namespace DpsSimulator
{
    class Stats
    {

        public int combatLevel = 0;

        Dictionary<string, float> statsDict = new Dictionary<string, float>();

        public Stats()
        {
            SetUpInitialStats();
        }

        void SetUpInitialStats()
        {
            statsDict.Add("Weapon Damage", 0f);
            statsDict.Add("Crit Chance", 0f);
            statsDict.Add("Haste", 0f);
            statsDict.Add("Brutal Power", 0f);
            statsDict.Add("Dextrous Power", 0f);
            statsDict.Add("Spell Power", 0f);
            statsDict.Add("Attack Power Multiplier", 1.2f);

            statsDict.Add("Physical Armor", 0f);
            statsDict.Add("Spell Armor", 0f);
            statsDict.Add("Physical Armor Multiplier", 1f);
            statsDict.Add("Spell Armor Multiplier", 1f);
            statsDict.Add("Health Percent", 100f);
            statsDict.Add("Crit Defense", 0f);//reduces chance of being critically struck
        }

        public void UpdateStats(string statName, float statValue)
        {
            if (statsDict.ContainsKey(statName))//if ability is already present then update its results
            {
                statsDict[statName] += statValue;
            }
        }

        public float GetStatValue(string statName)
        {
            if (statsDict.ContainsKey(statName))//if ability is already present then update its results
            {
                return statsDict[statName];
            }

            Console.WriteLine($"Stat named \"{ statName }\" doesn't exist");
            return 0f;
        }

        public void ResetExistingStats()
        {
            statsDict["Weapon Damage"] = 0f;
            statsDict["Crit Chance"] = 0f;
            statsDict["Haste"] = 0f;
            statsDict["Brutal Power"] = 0f;
            statsDict["Dextrous Power"] = 0f;
            statsDict["Spell Power"] = 0f;
            statsDict["Attack Power Multiplier"] = 1.2f;

            statsDict["Physical Armor"] = 0f;
            statsDict["Spell Armor"] = 0f;
            statsDict["Physical Armor Multiplier"] = 1f;
            statsDict["Spell Armor Multiplier"] = 1f;
            statsDict["Health Percent"] = 100f;
            statsDict["Crit Defense"] = 0f;//reduces chance of being critically struck
        }

    }
}
