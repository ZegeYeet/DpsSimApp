using DpsSimApp.Properties;
using DpsSimulator;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DpsSimApp
{
    class AbilityBar : Panel
    {
        public AbilityResults barAbiResults {get; set;}
        public Label abiNameLabel { get; set; }
        public Label abiDmgLabel { get; set; }

        public AbilityBar(string abilityName, AbilityResults newAbiResults, CombatLogger simLog) 
		{
            barAbiResults = newAbiResults;

            this.Height = 24;
            this.Dock = DockStyle.Top;
            this.BackColor = Color.FromArgb(60, 60, 60);
            this.BorderStyle = BorderStyle.None;
            this.Padding = new Padding(2, 2, 2, 2);

            abiNameLabel = new Label();
            abiNameLabel.TextAlign = ContentAlignment.MiddleLeft;
            abiNameLabel.AutoSize = true;
            abiNameLabel.Dock = DockStyle.Left;
            abiNameLabel.Text = abilityName;
            abiNameLabel.Font = new Font("Segoe UI", 10);
            abiDmgLabel = new Label();
            abiDmgLabel.TextAlign = ContentAlignment.MiddleRight;
            abiDmgLabel.AutoSize = true;
            abiDmgLabel.Dock = DockStyle.Right;
            abiDmgLabel.Text = ($"{(int)barAbiResults.totalAbilityDamage} ({MathF.Round((barAbiResults.totalAbilityDamage / simLog.GetTotalDamage()) * 100, 2)}%)\n");
            abiDmgLabel.Font = new Font("Segoe UI", 10);

            

            this.Controls.Add(abiNameLabel);
            this.Controls.Add(abiDmgLabel);
        }


	}
}
