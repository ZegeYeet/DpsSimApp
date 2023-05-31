using System.Text;
using System;
using System.Runtime.InteropServices;


namespace DpsSimulator
{
    class DebuffManager
    {
        Stats targetStats;
        List<ActiveDebuff> currentActiveDebuffs = new List<ActiveDebuff>();

        public DebuffManager(Stats newStats)
        {
            targetStats = newStats;
        }

        //creates a new debuff to update target stats for the sim and adds it to the current active debuffs list
        public void AddDebuff(string newDeName, float newTime, float newRefresh, string[] newNames, float[] newValues)
        {
            //if debuff already exist then refresh and return before adding it again
            foreach (var debuff in currentActiveDebuffs)
            {
                if (debuff.debuffName == newDeName)
                {
                    debuff.RefreshDebuff();
                    return;
                }
            }

            currentActiveDebuffs.Add(new ActiveDebuff(this, targetStats, newDeName, newTime, newRefresh, newNames, newValues));
        }

        
        public void ReduceDebuffTime(float timeReduced)
        {
            var debuffSpan = CollectionsMarshal.AsSpan(currentActiveDebuffs);
            for (int i = debuffSpan.Length -1; i >= 0; i--)
            {
                bool debuffExpired = debuffSpan[i].ReduceDebuffTime(timeReduced);
                if (debuffExpired)
                {
                    currentActiveDebuffs.RemoveAt(i);
                }
            }
        }


        public void DisplayDebuffs()
        {
            StringBuilder debuffsString = new StringBuilder();
            debuffsString.Append("Active Debuffs: \n");
            foreach (var debuff in currentActiveDebuffs)
            {
                debuffsString.Append($"{ debuff.debuffName } time left: { debuff.GetRemainingTime() }\n");
            }
            Console.Write(debuffsString);
        }

        public ActiveDebuff GetDot(string debuffSearchName)
        {
            var debuffSpan = CollectionsMarshal.AsSpan(currentActiveDebuffs);
            for (int i = 0; i < debuffSpan.Length; i++)
            {
                if (debuffSpan[i].debuffName == debuffSearchName)
                {
                    return debuffSpan[i];
                }
            }

            return null;
        }

    }
}