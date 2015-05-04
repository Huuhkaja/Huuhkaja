using System.Text;
using Styx.Helpers;
using System.IO;
using Styx;
using Styx.Common;
using System.ComponentModel;
using DefaultValue = Styx.Helpers.DefaultValueAttribute;
using Styx.TreeSharp;
using Styx.WoWInternals.WoWObjects;
using System.Windows.Forms;


namespace Huuhkaja
{
    class HuuhkajaSettings : Settings
    {
        public static readonly HuuhkajaSettings Instance = new HuuhkajaSettings();

        public HuuhkajaSettings() 
            :base(Path.Combine(Utilities.AssemblyDirectory, string.Format(@"Routines/Huuhkaja/Settings.xml")))
        {
        }

        [Setting, DefaultValue(false)]
        public bool AOE { get; set; }

        [Setting, DefaultValue(false)]
        public bool useNaturesVigil { get; set; }

        [Setting, DefaultValue(2)]
        public int starfallTargets { get; set; }

        [Setting, DefaultValue(true)]
        public bool useCA { get; set; }

        [Setting, DefaultValue(2)]
        public int poolStarsurgesCA { get ; set; }

        [Setting, DefaultValue(true)]
        public bool useIncarnation { get; set; }

        [Setting, DefaultValue("Alt")]
        public string aoeKey1 { get; set; }

        [Setting, DefaultValue("Q")]
        public string aoeKey2 { get; set; }

    }
}