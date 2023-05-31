using System.Diagnostics;
using System;
using System.Runtime.InteropServices;

//responsible for handling how long until an ability is able to be returned to the queue



namespace DpsSimulator
{
    class SimuCooldownManager
    {
        Stats stats;

        float gcdTime = 0f;
        bool gcdActive = false;

        List<int> abilitiesOnCooldown = new List<int>();
        List<float> abilityCooldowns = new List<float>();
        List<SimuAbilityManager> abilityQueues = new List<SimuAbilityManager>();

        public SimuCooldownManager(Stats newStats)
        {
            stats = newStats;
        }

        public void ReduceCooldowns(float baseCooldownTime)
        {
            float effectiveCDTime = baseCooldownTime * (1 + stats.GetStatValue("Haste"));
            List<int> removeCDsList = new List<int>();
            var cdSpan = CollectionsMarshal.AsSpan(abilityCooldowns);
            for(int i = cdSpan.Length-1; i >= 0; i--)
            {
                cdSpan[i] -= effectiveCDTime;

                if(abilityCooldowns[i] <= 0)
                {
                    abilityQueues[i].AddAbilityToQueue(abilitiesOnCooldown[i]);
                    abilitiesOnCooldown.RemoveAt(i);
                    abilityCooldowns.RemoveAt(i);
                    abilityQueues.RemoveAt(i);
                }
            }

            //reduce gcd
            float effectiveGCDTime = baseCooldownTime * (1 + (stats.GetStatValue("Haste")*0.5f));
            gcdTime -= effectiveGCDTime;

            if (gcdTime <= 0f)
            {
                gcdActive = false;
                gcdTime = 0f;
            }
        }

        public void AddCooldownToQueue(int abilityID, float abilityGCD, float abilityCooldown, SimuAbilityManager newAbiQueue)
        {
            abilitiesOnCooldown.Insert(0, abilityID);
            abilityCooldowns.Insert(0, abilityCooldown);
            abilityQueues.Insert(0, newAbiQueue);
            
            if (abilityGCD > 0f)
            {
                gcdTime = abilityGCD;
                gcdActive = true;
            }
        }

        //true means gcd is active an can't use other abilities
        public bool CheckForGCD()
        {
            return gcdActive;
        }
    }
}
