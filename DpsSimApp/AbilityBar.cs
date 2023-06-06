using DpsSimApp.Properties;
using DpsSimulator;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DpsSimApp
{
    class AbilityBar
    {
        public AbilityResults barAbiResults {get; set;}
        public Panel abiPanel { get; set; }

        public AbilityBar(string abilityName, AbilityResults newAbiResults, CombatLogger simLog) 
		{
            barAbiResults = newAbiResults;
            abiPanel = new Panel();

            abiPanel.Height = 24;
            abiPanel.Dock = DockStyle.Top;
            abiPanel.BackColor = Color.FromArgb(60, 60, 60);
            abiPanel.BorderStyle = BorderStyle.None;
            abiPanel.Padding = new Padding(2, 2, 2, 2);

            Label abiNameLabel = new Label();
            abiNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            abiNameLabel.AutoSize = true;
            abiNameLabel.Dock = DockStyle.Left;
            abiNameLabel.Text = abilityName;
            abiNameLabel.Font = new Font("Segoe UI", 10);
            Label abiDmgLabel = new Label();
            abiDmgLabel.TextAlign = ContentAlignment.MiddleRight;
            abiDmgLabel.AutoSize = true;
            abiDmgLabel.Dock = DockStyle.Right;
            abiDmgLabel.Text = ($"{(int)barAbiResults.totalAbilityDamage} ({MathF.Round((barAbiResults.totalAbilityDamage / simLog.GetTotalDamage()) * 100, 2)}%)\n");
            abiDmgLabel.Font = new Font("Segoe UI", 10);

            

            abiPanel.Controls.Add(abiNameLabel);
            abiPanel.Controls.Add(abiDmgLabel);
        }
	}
}
