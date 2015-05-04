using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Styx.WoWInternals;
using Styx.CommonBot;

namespace Huuhkaja.Helpers
{
    class Spell
    {
        public static double GetCastTime(WoWSpell spell)
        {
            double time = Lua.GetReturnVal<double>(string.Format("return GetSpellInfo({0})", spell.Id), 3);  
            return time;
        }

        public static double GetCastTime(string name)
        {
            SpellFindResults sfr;
            if (SpellManager.FindSpell(name, out sfr))
            {
                WoWSpell spell = sfr.Override ?? sfr.Original;
                return GetCastTime(spell);
            }
            return 0;
        }

        public static int GetCharges(WoWSpell spell)
        {
            int charges = Lua.GetReturnVal<int>("return GetSpellCharges(" + spell.Id.ToString() + ")", 0);
            return charges;
        }

        public static int GetCharges(string name)
        {
            SpellFindResults sfr;
            if (SpellManager.FindSpell(name, out sfr))
            {
                WoWSpell spell = sfr.Override ?? sfr.Original;
                return GetCharges(spell);
            }
            return 0;
        }

        public static TimeSpan GetSpellCooldown(string spell)
        {
            SpellFindResults sfr;
            if (SpellManager.FindSpell(spell, out sfr))
                return (sfr.Override ?? sfr.Original).CooldownTimeLeft;

            return TimeSpan.FromSeconds(999);
        }

    }
}
