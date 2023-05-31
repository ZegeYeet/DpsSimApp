using System;






namespace DpsSimulator
{
    static class DamageCalculator
    {


        static public DamageResult CalculateDamage(Stats attackerStatSheet, Stats targetStatSheet, float baseDamage, float weaponScaling, float brutalScaling, float dextrousScaling, float spellScaling)
        {
            DamageResult calculatedDamage = new DamageResult();
            Random chanceRolls = new Random();

            //raw damage calculations
            calculatedDamage.damageAmount = baseDamage;
            calculatedDamage.damageAmount += attackerStatSheet.GetStatValue("Weapon Damage") * weaponScaling;
            calculatedDamage.damageAmount += attackerStatSheet.GetStatValue("Brutal Power") * brutalScaling;
            //calculatedDamage.damageAmount += attackerStatSheet.GetStatValue("Dextrous Power") * dextrousScaling;
            //calculatedDamage.damageAmount += attackerStatSheet.GetStatValue("Spell Power") * spellScaling;

            //critical strikes
            if (chanceRolls.NextDouble() <= (attackerStatSheet.GetStatValue("Crit Chance") - targetStatSheet.GetStatValue("Crit Defense")))
            {
                calculatedDamage.damageAmount = calculatedDamage.damageAmount * 2;
                calculatedDamage.criticalStrike = true;
            }

            //armor

            return calculatedDamage;
        }
    }
}