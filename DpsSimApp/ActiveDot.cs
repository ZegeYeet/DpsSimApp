using System;


namespace DpsSimulator
{
    class ActiveDot
    {
        DotManager dotManager;
        DamageEvents dmgEvents;
        public DamageResult dmgResult {get; private set;}

        
        int ticksRemaining = 0;
        float timePerTick = 0f;
        float currentTimeTilTick = 0f;

        public ActiveDot(DotManager newManager, DamageEvents newDmgEvents, DamageResult newResult, int newTicks, float newTime)
        {
            dotManager = newManager;
            dmgEvents = newDmgEvents;
            dmgResult = newResult;
            ticksRemaining = newTicks;
            timePerTick = newTime;
            currentTimeTilTick = timePerTick;
        }

        void DealDamage()
        {
            dmgEvents.DealDotDamage(dmgResult);
            ReduceTicks();            
        }

        public bool ReduceTimeTilTick(float timeReduced)
        {
            currentTimeTilTick -= timeReduced;
            if (currentTimeTilTick <= 0f)
            {
                DealDamage();
            }

            if (ticksRemaining < 1)//aka dot out of ticks so return to be removed
            {
                return true;
            }
            return false;
        }
        void ReduceTicks()
        {
            currentTimeTilTick = timePerTick;
            ticksRemaining--;
        }
    }
}
