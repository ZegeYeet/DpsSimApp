using System;


namespace DpsSimulator
{
    class ActiveDebuff
    {
        DebuffManager debuffManager;
        Stats targetStats;

        public string debuffName {get; private set;}
        float defaultLength;
        float debuffTimeRemaining;
        float maxRefreshTime;
        string[] statNames;
        float[] statValues;


        public ActiveDebuff(DebuffManager newManager, Stats newStats, string newDeName, float newRemaining, float newRefresh, string[] newNames, float[] newValues)
        {
            debuffManager = newManager;
            targetStats = newStats;
            debuffName = newDeName;
            debuffTimeRemaining = newRemaining;
            defaultLength = newRemaining;
            maxRefreshTime = debuffTimeRemaining + newRefresh;
            statNames = newNames;
            statValues = newValues;

            ReduceStats();
        }

        void ReduceStats()
        {
            for (int i = 0; i < statNames.Length; i++)
            {
                targetStats.UpdateStats(statNames[i], -statValues[i]);
            }
              
        }

        void RestoreStats()
        {
            for (int i = 0; i < statNames.Length; i++)
            {
                targetStats.UpdateStats(statNames[i], statValues[i]);
            }
        }

        public bool ReduceDebuffTime(float timeReduced)
        {
            debuffTimeRemaining -= timeReduced;
            if (debuffTimeRemaining <= 0f)
            {
                RestoreStats();
                return true;
            }
            return false;
        }

        public void RefreshDebuff()
        {
            debuffTimeRemaining += defaultLength;
            if (debuffTimeRemaining > maxRefreshTime)
            {
                debuffTimeRemaining = maxRefreshTime;
            }
        }

        public float GetRemainingTime()
        {
            return debuffTimeRemaining;
        }

    }
}