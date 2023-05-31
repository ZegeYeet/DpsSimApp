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
            statsDict.Add("Weapon Damage", 14f);
            statsDict.Add("Crit Chance", 0.01f);
            statsDict.Add("Haste", 0.1f);
            statsDict.Add("Brutal Power", 63.8f);
            statsDict.Add("Dextrous Power", 34f);
            statsDict.Add("Spell Power", 6f);
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



    }
}
