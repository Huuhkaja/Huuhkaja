using Styx;
using Styx.Common;
using Styx.WoWInternals;
using Styx.WoWInternals.WoWObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Diagnostics;


using HKM = Huuhkaja.Managers.HotkeyManagers;
using P = Huuhkaja.HuuhkajaSettings;


namespace Huuhkaja.Managers
{
    class HotkeyManagers
    {
        public static LocalPlayer Me { get { return StyxWoW.Me; } }

        public static bool keysRegistered { get; set; }


        private static Keys keyAOEDisable { 
            get {
                return (Keys)Enum.Parse(typeof(Keys), HuuhkajaSettings.Instance.aoeKey2);
            }
        }

        private static ModifierKeys modifKeyAOEDisable { 
            get {
                return (ModifierKeys)Enum.Parse(typeof(ModifierKeys), HuuhkajaSettings.Instance.aoeKey1);
            }
        }

        public static void registerHotKeys()
        {
            if (keysRegistered)
                return;

            HotkeysManager.Register("aoeDisable", keyAOEDisable, modifKeyAOEDisable, ret =>
            {
                HuuhkajaSettings.Instance.AOE = !HuuhkajaSettings.Instance.AOE;

                if (HuuhkajaSettings.Instance.AOE)
                {
                    StyxWoW.Overlay.AddToast(() =>
                    string.Format("AOE Enabled"),
                    TimeSpan.FromSeconds(2),
                    System.Windows.Media.Colors.Lime,
                    System.Windows.Media.Colors.Blue,
                    new System.Windows.Media.FontFamily("Consolas"));
                }
                else
                {
                    StyxWoW.Overlay.AddToast(() =>
                    string.Format("AOE Disabled"),
                    TimeSpan.FromSeconds(2),
                    System.Windows.Media.Colors.Red,
                    System.Windows.Media.Colors.Blue,
                    new System.Windows.Media.FontFamily("Consolas"));
                }
          
            });

            keysRegistered = true;
        }


        public static void removeHotkeys()
        {
            if (!keysRegistered)
                return;

            HotkeysManager.Unregister("aoeDisable");
            keysRegistered = false;

        }

    }
}