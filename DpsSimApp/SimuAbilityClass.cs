using System;

//bare bones of an ability class

namespace DpsSimulator
{
    class SimuAbilityClass
    {
        DotManager dotManager;
        DebuffManager debuffManager;
        CombatResourceManager combatResourceManager;

        int abilityID = -1;
        string abilityName = "";
        float abiBaseDamage = 0f;
        float abilityGCD = 1f;//if > 0 triggers global cooldown when used
        float abilityCastTime = 0f;
        float abilityCooldown = 5f;

        float abiWeaponScaling = 0f;
        float abiBrutalScaling = 0f;
        float abiDextrousScaling = 0f;
        float abiSpellScaling = 0f;

        //resources
        bool usesResources = false;
        int abiResourceCost = 0;
        int abiResourceGeneration = 0;

        //dot specific
        bool isDot = false;
        int dotTicks = 0;
        float timePerTick = 0f;

        //debuff specific
        bool isDebuff = false;
        float debuffTime;
        float refreshTime;
        string[] debuffStatNames;
        float[] debuffStatValues;

        public SimuAbilityClass(DotManager newDotM, DebuffManager newDebuffM, CombatResourceManager newCombatM)
        {
            dotManager = newDotM;
            debuffManager = newDebuffM;
            combatResourceManager = newCombatM;

            debuffStatNames = new string[0]{};
            debuffStatValues = new float[0]{};
        }
        public void SetBasics(int newID, string newName, float newDamage, float newGCD, float newCastTime, float newCooldown)
        {
            abilityID = newID;
            abilityName = newName;
            abiBaseDamage = newDamage;
            abilityGCD = newGCD;
            abilityCastTime = newCastTime;
            abilityCooldown = newCooldown;
        }

        public void SetScaling(float newWeapon, float newBrut, float newDext, float newSpell)
        {
            abiWeaponScaling = newWeapon;
            abiBrutalScaling = newBrut;
            abiDextrousScaling = newDext;
            abiSpellScaling = newSpell;
        }

        public void SetAsDot(int newTicks, float newTime)
        {
            isDot = true;
            dotTicks = newTicks;
            timePerTick = newTime;
        }

        public void SetAsDebuff(float newTime, float newRefresh, string[] newNames, float[] newValues)
        {
            isDebuff = true;
            debuffTime = newTime;
            refreshTime = newRefresh;
            debuffStatNames = newNames;
            debuffStatValues = newValues;
        }

        public void StartAbility(DamageEvents damageEvents, Stats attackerStatSheet, Stats targetStatSheet,  float abilityUseTime)
        {   
            //calc damage
            DamageResult dmgResult = DamageCalculator.CalculateDamage(attackerStatSheet, targetStatSheet, abiBaseDamage, abiWeaponScaling, abiBrutalScaling, abiDextrousScaling, abiSpellScaling);
            dmgResult.damageName = abilityName;

            if (usesResources)
            {
                combatResourceManager.SpendCombatResources(abiResourceCost);
                combatResourceManager.GainCombatResources(abiResourceGeneration);
            }

            if (isDebuff)
            {
                debuffManager.AddDebuff(abilityName, debuffTime, refreshTime, debuffStatNames, debuffStatValues);
            }

            if (isDot)
            {
                dmgResult.damageAmount = dmgResult.damageAmount/dotTicks;
                dotManager.AddDot(dmgResult, dotTicks, timePerTick);
                return;
            }

            
            
            damageEvents.DealDamage(dmgResult);
            //Console.WriteLine(abilityName + " was used at: " + abilityUseTime + "s");          
        }

        public void SetAbiResources(int newCost, int newGeneration)
        {
            usesResources = true;
            abiResourceCost = newCost;
            abiResourceGeneration = newGeneration;
        }

        public int GetAbilityID()
        {
            return abilityID;
        }

        public string GetAbilityName()
        {
            return abilityName;
        }

        public float GetGCD()
        {
            return abilityGCD;
        }

        public float GetCastTime()
        {
            return abilityCastTime;
        }

        public float GetCooldown()
        {
            return abilityCooldown;
        }

        public int GetResourceCost()
        {
            return abiResourceCost;
        }

    }
}
