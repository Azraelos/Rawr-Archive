﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rawr.DK
{
    /// <summary>
    /// This class is the implmentation of the Frost Fever Ability based on the AbilityDK_Base class.
    /// </summary>
    class AbilityDK_FrostFever : AbilityDK_Base
    {
        /// <summary>
        /// A disease dealing [0 + AP * 0.055 * 1.15] Frost damage every 3 sec and reducing the target's melee and ranged attack speed by 20% for 21 sec.  Caused by Icy Touch and other spells.
        /// Base damage 0
        /// Bonus from attack power [AP * 0.055 * 1.15]
        /// </summary>
        /// <param name="Epidemic">How many points into Epidemic?</param>
        public AbilityDK_FrostFever(CombatState CS)
        {
            this.CState = CS;
            this.szName = "Frost Fever";
            this.tDamageType = ItemDamageType.Frost;
            this.uTickRate = 3 * 1000;
            this.uBaseDamage = 0;
            this.bTriggersGCD = false;
            this.Cooldown = 0;
            this.CastTime = 0;
            this.AbilityIndex = (int)DKability.FrostFever;
            this.uDuration = 30000;
            uRange = 0;
            UpdateCombatState(CS);
        }

        public override void UpdateCombatState(CombatState CS)
        {
            // TODO: Implement Chilblains:  (Currently there's no useful model for this)
            // Victims of your Frost Fever disease are Chilled, reducing movement speed by 50% for 10 sec, and your Chains of Ice immobilizes targets for 3 sec.
            base.UpdateCombatState(CS);
        }


        /// <summary>
        /// Setup the modifier formula for a given ability.
        /// </summary>
        public override int DamageAdditiveModifer {
            get {
                //[AP * 0.055 * 1.15]
                if (CState.m_Stats != null)
                    return (int)(this.CState.m_Stats.AttackPower * 0.055f * 1.15f);
                return base.DamageAdditiveModifer;
            }
        }

        private float _DamageMultiplierModifier;
        public override float DamageMultiplierModifer
        {
            get
            {
                if (CState.m_Stats != null)
                    _DamageMultiplierModifier = CState.m_Stats.BonusDiseaseDamageMultiplier + base.DamageMultiplierModifer + (CState.m_Talents.GlyphofIcyTouch ? .3f : 0);
                return _DamageMultiplierModifier;
            }
        }
    }
}
