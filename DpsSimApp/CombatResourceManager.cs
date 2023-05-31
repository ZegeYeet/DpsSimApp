using System;


namespace DpsSimulator
{
    class CombatResourceManager
    {

        int maxResources;
        int combatResources = 0;
        public CombatResourceManager(int baseResources)
        {
            maxResources = baseResources;
        }

        public bool CheckCombatResources(int resourceAmount)
        {
            if (combatResources >= resourceAmount)
            {
                return true;
            }

            return false;
        }

        public void SpendUpToResources(int resourcesSpent)
        {
            combatResources -= resourcesSpent;

            if (combatResources < 0)
            {
                combatResources = 0;
            }
        }

        public bool SpendCombatResources(int resourcesSpent)
        {
            if (combatResources - resourcesSpent < 0)
            {
                return false;
            }

            combatResources -= resourcesSpent;
            return true;
        }

        public void GainCombatResources(int gainAmt)
        {
            combatResources += gainAmt;

            if (combatResources + gainAmt < maxResources)
            {
                combatResources = maxResources;
            }
        }


    }
}