using System;
using System.Collections.Generic;
using System.Linq;

using Styx;
using Styx.WoWInternals;
using System.Drawing;
using Styx.Common;
using Styx.CommonBot;
using Styx.Common.Helpers;
using Styx.CommonBot.Routines;
using Styx.CommonBot.CharacterManagement;
using Styx.WoWInternals;

namespace Huuhkaja.Managers
{
    internal static class TalentManager
    {

        static TalentManager()
        {
        }

        public static bool HasTalent(int row, int col)
        {
            return Lua.GetReturnVal<bool>(string.Format("local t = select(4, GetTalentInfo({0}, {1}, GetActiveSpecGroup())) if t then return 1 end return nil", row + 1, col + 1), 0);
        } 

    }
}