using System.Text;
using System;
using System.Diagnostics;

namespace DpsSimulator
{
    class SimuMain
    {

        public void RunSim(CombatLogger combatLogger, float simDuration)
        {
            Stopwatch simRealTime = new Stopwatch();
            simRealTime.Start();

            Stats playerStats = new Stats();
            Stats enemyStats = new Stats();

            DamageEvents damageEvents = new DamageEvents(combatLogger);
            DotManager dotManager = new DotManager(damageEvents);
            DebuffManager debuffManager = new DebuffManager(enemyStats);
            CombatResourceManager cmbResourceManager = new CombatResourceManager(60);
            AbilitiesContainer abilitiesContainer = new AbilitiesContainer(damageEvents, dotManager, debuffManager, cmbResourceManager, playerStats, enemyStats);
            SimuAbilityManager nongcdAbilityManager = new SimuAbilityManager(100, abilitiesContainer, cmbResourceManager, new int[1]{0});//100 is just a temp arbitrary value greater than the number of abilities the player would have
            SimuAbilityManager spenderAbilityManager = new SimuAbilityManager(100, abilitiesContainer, cmbResourceManager, new int[2]{2, 3});//100 is just a temp arbitrary value greater than the number of abilities the player would have
            spenderAbilityManager.SetForCost();
            SimuAbilityManager noCostAbilityManager = new SimuAbilityManager(100, abilitiesContainer, cmbResourceManager, new int[1]{1});//100 is just a temp arbitrary value greater than the number of abilities the player would have
            SimuCooldownManager cooldownManager = new SimuCooldownManager(playerStats);
            
            float currentSimTime = 0;
            float loopTime = 0.01f;//1 loop = 10 ms
            while(currentSimTime < simDuration)//mimics a 5 minute sim (300 seconds)
            {
                cooldownManager.ReduceCooldowns(loopTime);//reduces ability cooldowns and gcd
                dotManager.ReduceDotTime(loopTime);
                debuffManager.ReduceDebuffTime(loopTime);
                
                if (cooldownManager.CheckForGCD())//if in the middle of gcd then can't use gcd abilities so return
                {
                    nongcdAbilityManager.CallForAbility(cooldownManager, currentSimTime);
                    currentSimTime += loopTime;
                    continue;
                }
                
                spenderAbilityManager.CallForAbility(cooldownManager, currentSimTime);
                noCostAbilityManager.CallForAbility(cooldownManager, currentSimTime);
                

                currentSimTime+= loopTime;
            }

            
            simRealTime.Stop();
            //Console.WriteLine($"Total damage dealt is { (int)combatLogger.GetTotalDamage() } damage.");
            //Console.WriteLine($"DPS is { combatLogger.GetTotalDamage()/currentSimTime } damage.");
            /*StringBuilder abilityDamagesString = new StringBuilder();
            foreach (KeyValuePair<string, AbilityResults> ability in combatLogger.GetAbilityDamages())
            {
                abilityDamagesString.Append($"{ability.Key } count is: { ability.Value.abilityHits}, damage is: { (int)ability.Value.totalAbilityDamage } ({ MathF.Round((ability.Value.totalAbilityDamage/combatLogger.GetTotalDamage()) * 100, 2) }%)\n");
            }*/
            //Console.Write(abilityDamagesString);
            //Console.WriteLine($"Sim Done in: { simRealTime.Elapsed }s");
        }


    }

    
}