using DpsSimApp.Properties;
using DpsSimulator;
using System.Runtime.InteropServices;
using System.Text;

namespace DpsSimApp
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

        );

        Button currentButton;
        Dictionary<string, string[]> classSpecDict = new Dictionary<string, string[]>();
        bool currentlySimming = false;

        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();

            SetUpClassSpecs();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ClassButton_Click(classBtnJuggernaut, new EventArgs());
        }

        private void SetUpClassSpecs()
        {
            classSpecDict.Add("Juggernaut", new string[] { "Dreadnought", "Weapon Master", "Battle Lord" });
            classSpecDict.Add("Frost Mage", new string[] { "Hypothermic", "Absolute Zero", "Glacier" });
            classSpecDict.Add("Ranger", new string[] { "Marksman", "Artillery", "Archery" });
        }


        private void ClassButton_Click(object sender, EventArgs e)
        {
            ButtonLeave(currentButton);
            currentButton = sender as Button;

            panelCurrentBtnBorder.Height = currentButton.Height;
            panelCurrentBtnBorder.Top = currentButton.Top;
            panelCurrentBtnBorder.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(168, 168, 168);

            UpdateSpecsFromButton(currentButton);
            currentClassLabel.Text = currentButton.Text;
            currentClassLabel.ForeColor = currentButton.ForeColor;
            currentClassIcon.Image = currentButton.BackgroundImage;
        }

        void UpdateSpecsFromButton(Button classButton)
        {
            specSelectComboBox.Items.Clear();
            foreach (string specialization in classSpecDict[classButton.Text])
            {
                specSelectComboBox.Items.Add(specialization);
            }

            specSelectComboBox.SelectedIndex = 0;
        }

        private void ButtonLeave(Button leftBtn)
        {
            if (leftBtn != null)
            {
                leftBtn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }


        //used for loading dif spec api/abilities/talents
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            //no decimal in target count
            if ((sender as TextBox).Name == "targetCountTextBox" && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }
        }

        private void BeginSims(object sender, EventArgs e)
        {
            if (currentlySimming)
            {
                return;
            }

            float fightDuration;
            if (float.TryParse(fightDurationTextBox.Text, out fightDuration))
            {
                currentlySimming = true;
                SimuMain simuMain = new SimuMain();
                CombatLogger simLog = new CombatLogger();
                simuMain.RunSim(simLog, fightDuration);

                totalDamageLabel.Text = ($"Total damage: {(int)simLog.GetTotalDamage()}");
                dpsLabel.Text = ($"DPS: {MathF.Round((int)simLog.GetTotalDamage() / fightDuration, 2)}");
                StringBuilder abilityDamagesString = new StringBuilder();
                foreach (KeyValuePair<string, AbilityResults> ability in simLog.GetAbilityDamages())
                {
                    abilityDamagesString.Append($"{ability.Key} : {(int)ability.Value.totalAbilityDamage} ({MathF.Round((ability.Value.totalAbilityDamage / simLog.GetTotalDamage()) * 100, 2)}%)\n");
                }
                damageOverviewLabel.Text = abilityDamagesString.ToString();

                currentlySimming = false;
            }
            else
            {
                currentlySimming = false;
            }


        }
    }
}