using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Styx.Common;

namespace Huuhkaja.GUI
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
            minimumStarfall.Text = HuuhkajaSettings.Instance.starfallTargets.ToString();
            useNaturesVigil.Checked = HuuhkajaSettings.Instance.useNaturesVigil;
            enableAOE.Checked = HuuhkajaSettings.Instance.AOE;
            aoeKey1.SelectedItem = HuuhkajaSettings.Instance.aoeKey1;
            aoeKey2.SelectedItem = HuuhkajaSettings.Instance.aoeKey2;
            useCA.Checked = HuuhkajaSettings.Instance.useCA;
            starsurgePoolCA.Text = HuuhkajaSettings.Instance.poolStarsurgesCA.ToString();
            useInc.Checked = HuuhkajaSettings.Instance.useIncarnation;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.Save();
            this.Close();
        }

        private void minimumStarfall_TextChanged(object sender, EventArgs e)
        {
            int parsedInt = 0;
            if (int.TryParse(minimumStarfall.Text, out parsedInt))
            {
                HuuhkajaSettings.Instance.starfallTargets = parsedInt;
            }
            else
            {
                // Code for if the string was invalid
            }  
        }

        private void useNaturesVigil_CheckedChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.useNaturesVigil = useNaturesVigil.Checked;
        }

        private void enableAOE_CheckedChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.AOE = enableAOE.Checked;
        }

        private void aoeKey1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.aoeKey1 = aoeKey1.SelectedItem.ToString();
            Huuhkaja.Managers.HotkeyManagers.removeHotkeys();
            Huuhkaja.Managers.HotkeyManagers.registerHotKeys();
        }

        private void aoeKey2_SelectedIndexChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.aoeKey2 = aoeKey2.SelectedItem.ToString();
            Huuhkaja.Managers.HotkeyManagers.removeHotkeys();
            Huuhkaja.Managers.HotkeyManagers.registerHotKeys();
        }

        private void useCA_CheckedChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.useCA = useCA.Checked;
        }

        private void useInc_CheckedChanged(object sender, EventArgs e)
        {
            HuuhkajaSettings.Instance.useIncarnation = useCA.Checked;
        }

        private void starsurgePoolCA_TextChanged(object sender, EventArgs e)
        {
            int parsedInt = 0;
            if (int.TryParse(starsurgePoolCA.Text, out parsedInt))
            {
                HuuhkajaSettings.Instance.poolStarsurgesCA = parsedInt;
            }
            else
            {
                // Code for if the string was invalid
            }  
        }
    }
}
