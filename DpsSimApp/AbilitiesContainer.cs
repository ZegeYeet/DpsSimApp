using System;


//handles logic for starting ability use

namespace DpsSimulator
{
    class AbilitiesContainer
    {
        DamageEvents damageEvents;
        DotManager dotManager;
        DebuffManager debuffManager;
        CombatResourceManager combatResourceManager;
        Stats attackerStatSheet;
        Stats targetStatSheet;
        public SimuAbilityClass[] abilityArray {get; private set;}

        public AbilitiesContainer(DamageEvents newDamEvents, DotManager newDotManager, DebuffManager newDebuffManager, CombatResourceManager newResourceManager, Stats newAtkSheet, Stats newTargSheet)
        {
            damageEvents = newDamEvents;
            dotManager = newDotManager;
            debuffManager = newDebuffManager;
            combatResourceManager = newResourceManager;
            attackerStatSheet = newAtkSheet;
            targetStatSheet = newTargSheet;

            //cooldowns listed in seconds
            SimuAbilityClass mhAbiClass = new SimuAbilityClass(dotManager, debuffManager, combatResourceManager);
            mhAbiClass.SetBasics(0, "MH Auto Attack", 1f, 0f, 0f, 3f);
            mhAbiClass.SetScaling(1f, 0.1f, 0f, 0f);
            mhAbiClass.SetAbiResources(0, 4);

            SimuAbilityClass abiClassOne = new SimuAbilityClass(dotManager, debuffManager, combatResourceManager);
            abiClassOne.SetBasics(1, "Strike", 3f, 1f, 0f, 5f);
            abiClassOne.SetScaling(1f, 0.3f, 0f, 0f);
            abiClassOne.SetAbiResources(0, 9);
            SimuAbilityClass abiClassDot = new SimuAbilityClass(dotManager, debuffManager, combatResourceManager);
            abiClassDot.SetBasics(2, "Gore", 8f, 1f, 0f, 4f);
            abiClassDot.SetScaling(1.1f, 0.6f, 0f, 0f);
            abiClassDot.SetAsDot(10, 1f);
            abiClassDot.SetAbiResources(10, 0);
            SimuAbilityClass abiClassBreak = new SimuAbilityClass(dotManager, debuffManager, combatResourceManager);
            abiClassBreak.SetBasics(3, "Break", 5f, 1f, 0f, 30f);
            abiClassBreak.SetScaling(0.5f, 0.2f, 0f, 0f);
            abiClassBreak.SetAsDebuff(90f, 20f, new string[1]{"Physical Armor"}, new float[1]{60});
            abiClassBreak.SetAbiResources(15, 0);

            abilityArray = new SimuAbilityClass[4]{mhAbiClass, abiClassOne, abiClassDot, abiClassBreak};

            Console.WriteLine("new abilities initialized.");
        }
        

        public int GetNumberOfAbilities()
        {
            return abilityArray.Length;
        }

        public void UseAbility(int abiID, float abilityCalledMs)
        {

            if (abiID >= abilityArray.Length || abiID < 0)
            {
                Console.WriteLine("use ability requires valid ability id.");
            }

            abilityArray[abiID].StartAbility(damageEvents, attackerStatSheet, targetStatSheet, abilityCalledMs);


        }

        public float GetAbilityGCD(int abiID)
        {
            if (abiID >= abilityArray.Length || abiID < 0)
            {
                Console.WriteLine("use ability requires valid ability id.");
            }

            return abilityArray[abiID].GetGCD();
        }

        public float GetAbilityCastTime(int abiID)
        {
            if (abiID >= abilityArray.Length || abiID < 0)
            {
                Console.WriteLine("use ability requires valid ability id.");
            }

            return abilityArray[abiID].GetCastTime();
        }

        public float GetAbilityCooldown(int abiID)
        {
            if (abiID >= abilityArray.Length || abiID < 0)
            {
                Console.WriteLine("use ability requires valid ability id.");
            }

            return abilityArray[abiID].GetCooldown();
        }

        public int GetAbilityCost(int abiID)
        {
            if (abiID >= abilityArray.Length || abiID < 0)
            {
                Console.WriteLine("use ability requires valid ability id.");
            }

            return abilityArray[abiID].GetResourceCost();
        }

    }
}

