using System;



namespace DpsSimulator
{
    class DamageEvents
    {
        CombatLogger cLogs;

        public DamageEvents(CombatLogger newLogs)
        {
            cLogs = newLogs;
        }
        
        //standard single instance of dealing damage
        public void DealDamage(DamageResult dmgResult)
        {
            if (cLogs == null)
            {
                Console.WriteLine("Need a combat logger in order to record damage");
                return;
            }

            cLogs.IncreaseDamage(dmgResult.damageName, dmgResult);
        }

        //added for the purpose of dealing with procs differently later on, also easy to label the damage as a dot here
        public void DealDotDamage(DamageResult dmgResult)//dmg result holds the dmg value for a single tick
        {
            if (cLogs == null)
            {
                Console.WriteLine("Need a combat logger in order to record damage");
                return;
            }

            cLogs.IncreaseDamage(dmgResult.damageName + "(DoT)", dmgResult);
        }
    }
}




