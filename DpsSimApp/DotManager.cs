using System;
using System.Runtime.InteropServices;


namespace DpsSimulator
{
    class DotManager
    {
        DamageEvents damageEvents;
        List<ActiveDot> activeDots = new List<ActiveDot>();

        public DotManager(DamageEvents newEvents)
        {
            damageEvents = newEvents;
        }

        //creates a new dot to tick/damage for the sim and adds it to the current active dots list
        public void AddDot(DamageResult dmgResult, int newTicks, float newTime)
        {
            activeDots.Add(new ActiveDot(this, damageEvents, dmgResult, newTicks, newTime));
        }

        
        public void ReduceDotTime(float timeReduced)
        {
            var dotSpan = CollectionsMarshal.AsSpan(activeDots);
            for (int i = dotSpan.Length - 1; i >= 0; i--)
            {
                bool dotExpired = dotSpan[i].ReduceTimeTilTick(timeReduced);
                if (dotExpired)
                {
                    activeDots.RemoveAt(i);
                }
            }
        }


        public void DisplayDots()
        {
            Console.WriteLine("Active DoTs: ");
            foreach (var dot in activeDots)
            {
                Console.WriteLine(dot.dmgResult.damageName);
            }
        }

        public ActiveDot GetDot(string dotSearchName)
        {
            var dotSpan = CollectionsMarshal.AsSpan(activeDots);
            for (int i = 0; i < dotSpan.Length; i++)
            {
                if (dotSpan[i].dmgResult.damageName == dotSearchName)
                {
                    return dotSpan[i];
                }
            }

            return null;
        }
    }
}
