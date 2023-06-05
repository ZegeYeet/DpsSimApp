using DpsSimApp.Properties;
using DpsSimulator;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

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
        List<Panel> abiBarList = new List<Panel>();

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


                foreach (var abiBar in abiBarList)
                {
                    abiBar.Dispose();
                }
                abiBarList = new List<Panel>();
                List<KeyValuePair<string, AbilityResults>> sortedResults = simLog.GetAbilityDamages().ToList();
                sortedResults.Sort((pair1, pair2) => pair1.Value.totalAbilityDamage.CompareTo(pair2.Value.totalAbilityDamage));
                foreach (KeyValuePair<string, AbilityResults> ability in sortedResults)
                {
                    CreateAbilityBar(ability.Key, ability.Value, simLog);
                }


                currentlySimming = false;
            }
            else
            {
                currentlySimming = false;
            }


        }

        private void CreateAbilityBar(string abilityName, AbilityResults currentAbiResults, CombatLogger simLog)
        {

            Panel abiBar = new Panel();
            abiBar.Height = 24;
            abiBar.Dock = DockStyle.Top;
            abiBar.BackColor = Color.FromArgb(60, 60, 60);
            abiBar.BorderStyle = BorderStyle.None;
            abiBar.Padding = new Padding(2, 2, 2, 2);

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
            abiDmgLabel.Text = ($"{(int)currentAbiResults.totalAbilityDamage} ({MathF.Round((currentAbiResults.totalAbilityDamage / simLog.GetTotalDamage()) * 100, 2)}%)\n");
            abiDmgLabel.Font = new Font("Segoe UI", 10);

            abiBar.MouseEnter += new System.EventHandler(EnterAbiBar);
            abiBar.MouseLeave += new System.EventHandler(LeaveAbiBar);

            abiBar.Controls.Add(abiNameLabel);
            abiBar.Controls.Add(abiDmgLabel);
            AbilityBarsOverviewPanel.Controls.Add(abiBar);
            abiBarList.Add(abiBar);

        }

        private void EnterAbiBar(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(55, 55, 55);
        }
        private void LeaveAbiBar(object sender, EventArgs e)
        {
            (sender as Panel).BackColor = Color.FromArgb(60, 60, 60);
        }

        //used for bringing up ability details
        private void ClickAbiBar(Object sender, EventArgs e) 
        { 
            
        }
    }
}