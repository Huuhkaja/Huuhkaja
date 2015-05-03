﻿using System;
using System.Threading.Tasks;
using CommonBehaviors.Actions;
using Styx;
using Styx.Common;
using Styx.CommonBot;
using Styx.CommonBot.Coroutines;
using Styx.CommonBot.Routines;
using Styx.TreeSharp;
using Styx.WoWInternals.WoWObjects;


using Huuhkaja.Managers;
using Huuhkaja.Helpers;


namespace Huuhkaja
{
    public class Huuhkaja : CombatRoutine
    {
        public override WoWClass Class { get { return StyxWoW.Me.Specialization == WoWSpec.DruidBalance ? WoWClass.Druid : WoWClass.None; } }
        public override string Name { get { return "Huuhkaja - Balance Druid 0.1"; } }

        public override Composite CombatBehavior { get { return new ActionRunCoroutine(ctx => CombatCoroutine()); } }
        public override Composite PreCombatBuffBehavior { get { return new ActionRunCoroutine(ctx => PreCombatCoroutine()); } }

        public static bool hasCADoT = false;
        public static int starsurgePoolLunar = 0;
        public static int starsurgePoolSolar = 1;
        public static int starsurgePoolLunarCA = 2;

        #region Behaviors


        private static async Task<bool> PreCombatCoroutine()
        {
            if (StyxWoW.Me.IsCasting || SpellManager.GlobalCooldown || !StyxWoW.Me.IsAlive || StyxWoW.Me.Mounted || StyxWoW.Me.IsOnTransport)
                return true;

            if (!StyxWoW.Me.HasAura("Mark of the Wild") && await SpellCast("Mark of the Wild")) return true;
            
            return false;
        }


        private static async Task<bool> CombatCoroutine()
        {

            if (StyxWoW.Me.IsCasting || SpellManager.GlobalCooldown)
                return true;

            // Pulse
            EclipseManager.Pulse();

            if (StyxWoW.Me.IsMoving)
            {
                if (Spell.GetCharges("Starsurge") > starsurgePoolLunar && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Lunar && !StyxWoW.Me.HasAura("Lunar Empowerment")
                     || Spell.GetCharges("Starsurge") > starsurgePoolSolar && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Solar && !StyxWoW.Me.HasAura("Solar Empowerment"))
                {
                    return await SpellCast("Starsurge");
                }
                if (EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Lunar) await SpellCast("Moonfire");
                if (EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Solar) await SpellCast("Sunfire");
            }

            // CDs
            //if CA is ready soon, pool starsurge to 2
            starsurgePoolLunar = (Spell.GetSpellCooldown("Celestial Alignment") < TimeSpan.FromSeconds(30)) ? starsurgePoolLunarCA : 0;
            if (SpellManager.CanCast("Incarnation: Chosen of Elune")) await SpellCast("Incarnation: Chosen of Elune");
            if (SpellManager.CanCast("Celestial Alignment")) await SpellCast("Celestial Alignment");

            // Basic DoTs
            if (!StyxWoW.Me.CurrentTarget.HasAura("Moonfire") && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Lunar) await SpellCast("Moonfire");
            if (!StyxWoW.Me.CurrentTarget.HasAura("Sunfire") && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Solar) await SpellCast("Sunfire");

            // Peak DoTs
            if (StyxWoW.Me.HasAura("Lunar Peak"))
            {
                if (StyxWoW.Me.CurrentTarget.HasAura("Moonfire") && StyxWoW.Me.CurrentTarget.GetAuraByName("Moonfire").TimeLeft < TimeSpan.FromSeconds(20))
                await SpellCast("Moonfire");
            }
            if (StyxWoW.Me.HasAura("Solar Peak")) await SpellCast("Sunfire");

            // Celestial Alignment Aura Logic
            if (StyxWoW.Me.HasAura("Celestial Alignment"))
            {
                if (StyxWoW.Me.GetAuraByName("Celestial Alignment").TimeLeft < TimeSpan.FromSeconds(3) && !hasCADoT)
                {
                    hasCADoT = true;
                    await SpellCast("Moonfire");
                }
                if (!StyxWoW.Me.CurrentTarget.HasAura("Moonfire")) return await SpellCast("Moonfire");
                if (StyxWoW.Me.HasAura("Lunar Empowerment")) return await SpellCast("Starfire");
                return await SpellCast("Starsurge");
            }
            hasCADoT = false;

            // Starsurge Logic
            if (   Spell.GetCharges("Starsurge") > starsurgePoolLunar && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Lunar && !StyxWoW.Me.HasAura("Lunar Empowerment")
                || Spell.GetCharges("Starsurge") > starsurgePoolSolar && EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Solar && !StyxWoW.Me.HasAura("Solar Empowerment"))
            {
                return await SpellCast("Starsurge");
            }

            // Filler: Starfire / Wrath
            if ((EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Lunar && EclipseManager.TimeToZeroEnergy() > SpellManager.Spells["Starfire"].CastTime)
                || (EclipseManager.AciveEclipse() == EclipseManager.EclipseType.Solar && EclipseManager.TimeToZeroEnergy() < SpellManager.Spells["Wrath"].CastTime))
            {
                return await SpellCast("Starfire");
            }
            else
            {
                return await SpellCast("Wrath");
            }

        }

        #endregion


        #region Casting Tasks
        private static async Task<bool> SpellCast(string spell, WoWUnit target)
        {
            // Return false if we can't cast the spell
            if (!SpellManager.CanCast(spell))
                return false;


            // Cast spell, return false if it fails to cast
            if (!SpellManager.Cast(spell, target))
                return false;


            //Logging.WriteDiagnostic("[Huuhkaja] Cast {0} on {1}", spell, target.SafeName);


            // Wait for lag
            await CommonCoroutines.SleepForLagDuration();


            // return true - we've cast the spell successfully.
            return true;
        }


        private static async Task<bool> SpellCast(string spell)
        {
            return await SpellCast(spell, StyxWoW.Me.CurrentTarget);
        }
        #endregion


    }
}