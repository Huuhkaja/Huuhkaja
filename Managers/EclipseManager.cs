using System;
using Styx.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Styx.WoWInternals.WoWObjects;
using Styx;

namespace Huuhkaja.Managers
{
    public class EclipseManager
    {
        // Solar Peak: 100
        // Lunar Peak: -100
        // Neutral: 0
        // Lunar ||-----------------||Solar
        
        // Without Euphoria:
        //  - 40s Cycle
        //  - 4s Peak
        //  - 80ms per Energy

        public static int timePerEnergy = 40;

        public static EclipseType lastPeak { set; get; }

        public enum EclipseType
        {
            None,
            Solar,
            Lunar
        };

        public static void Pulse()
        {
            // Check for Euphoria
            timePerEnergy = (TalentManager.HasTalent(6,0)) ? 40 : 80;

            //check eclipse peak
            if (StyxWoW.Me.HasAura("Solar Peak")) EclipseManager.lastPeak = EclipseManager.EclipseType.Solar;
            if (StyxWoW.Me.HasAura("Lunar Peak")) EclipseManager.lastPeak = EclipseManager.EclipseType.Lunar;
        }

        public static EclipseType AciveEclipse()
        {
            if (StyxWoW.Me.CurrentEclipse < 0) return EclipseType.Lunar;
            if (StyxWoW.Me.CurrentEclipse > 0) return EclipseType.Solar;
            return EclipseType.Lunar;
        }

        public static EclipseType EclipseDirection()
        {
            if (lastPeak == EclipseType.Lunar) return EclipseType.Solar;
            if (lastPeak == EclipseType.Solar) return EclipseType.Lunar;
            return EclipseType.Lunar;
        }

        public static int TimeToZeroEnergy()
        {
            if (AciveEclipse() != EclipseDirection())
            {
                // Lunar ||___________|____________|| Solar
                //       ||___------->|____________||
                return Math.Abs(StyxWoW.Me.CurrentEclipse) * timePerEnergy;
            } else
            {
                // Lunar ||___________|____________|| Solar
                //       ||___________|_____-------|| 
                //       ||___________|<-----------||
                return (100 - Math.Abs(StyxWoW.Me.CurrentEclipse)) * timePerEnergy + (timePerEnergy * 100);
            }
        }

        public static float TimeToPeak()
        {
            if (lastPeak == AciveEclipse())
            {
                return (Math.Abs(StyxWoW.Me.CurrentEclipse) + 100) * timePerEnergy;
            }
            else
            {
                return (100 - Math.Abs(StyxWoW.Me.CurrentEclipse)) * timePerEnergy;
            }
        }

    }
}
