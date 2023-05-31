using System;


namespace DpsSimulator
{
    //stores results from damage calculation
    class DamageResult
    {
        public string damageName = "";
        public float damageAmount = 0f;
        public bool criticalStrike = false;

        public bool dodged = false;
        public bool parried = false;
        public bool blocked = false;


    }
}