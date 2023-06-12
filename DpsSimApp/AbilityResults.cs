using System;


//responsbile for holding/organizing data for being held in combat log dictionary

namespace DpsSimulator
{
    class AbilityResults
    {
        public string abilityName { get; private set;}
        public float totalAbilityDamage { get; private set;}
        public float totalCritDamage { get; private set;}
        public int abilityHits { get; private set;}
        public int abilityCrits { get; private set;}

        public AbilityResults(string newName, float newDamage, bool isCrit)
        {
            abilityName = newName;
            totalAbilityDamage = newDamage;
            abilityHits = 1;
            abilityCrits = 0;
            if (isCrit)
            {
                totalCritDamage = newDamage;
                abilityCrits++;
            }
        }

        public void UpdateAbilityResults(float newDamage, bool isCrit)
        {
            totalAbilityDamage += newDamage;
            abilityHits++;
            if (isCrit)
            {
                totalCritDamage += newDamage;
                abilityCrits++;
            }
        }

        public void MergeResults(AbilityResults resultsToAdd)
        {
            totalAbilityDamage += resultsToAdd.totalAbilityDamage;
            totalCritDamage += resultsToAdd.totalCritDamage;
            abilityHits += resultsToAdd.abilityHits;
            abilityCrits += resultsToAdd.abilityCrits;
        }

        public void AverageResults(int avgAmount)
        {
            totalAbilityDamage = totalAbilityDamage / avgAmount;
            totalCritDamage = totalCritDamage / avgAmount;
            abilityHits = abilityHits / avgAmount;
            abilityCrits = abilityCrits / avgAmount;
        }

    }
}
