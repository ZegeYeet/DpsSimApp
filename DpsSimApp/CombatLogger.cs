using System;

//responsible for recording and storing combat information

namespace DpsSimulator
{
    class CombatLogger
    {
        Dictionary<string, AbilityResults> abilityDamages = new Dictionary<string, AbilityResults>();
        Dictionary<string, int> abilityCasts = new Dictionary<string, int>();
        float totalDamage = 0f;
        public void IncreaseDamage(string damageName, DamageResult dmgResult)
        {
            if (abilityDamages.ContainsKey(damageName))//if ability is already present then update its results
            {
                abilityDamages[damageName].UpdateAbilityResults(dmgResult.damageAmount, dmgResult.criticalStrike);
            }
            else //else create new results for the ability
            {
                abilityDamages[damageName] = new AbilityResults(damageName, dmgResult.damageAmount, dmgResult.criticalStrike);
            }

            totalDamage += dmgResult.damageAmount;
        }

        public float GetTotalDamage()
        {
            return totalDamage;
        }

        public Dictionary<string, AbilityResults> GetAbilityDamages()
        {
            return abilityDamages;
        }
    }
}

    




