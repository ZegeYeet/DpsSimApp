namespace DpsSimApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            leftNavPanel = new Panel();
            panelCurrentBtnBorder = new Panel();
            classBtnRanger = new Button();
            ClassBtnFrostMage = new Button();
            classBtnJuggernaut = new Button();
            panel2 = new Panel();
            specSelectComboBox = new ComboBox();
            currentClassLabel = new Label();
            currentClassIcon = new PictureBox();
            classIconImageList = new ImageList(components);
            simSettingBackgroundPanel = new Panel();
            statsPanelBorder = new Panel();
            statsPanel = new Panel();
            brutalPowerBox = new TextBox();
            hasteBox = new TextBox();
            CritChanceBox = new TextBox();
            WeaponDamageBox = new TextBox();
            hasteLabel = new Label();
            brutalPowerLabel = new Label();
            critChanceLabel = new Label();
            weaponDamageLabel = new Label();
            button1 = new Button();
            targetCountTextBox = new TextBox();
            fightDurationTextBox = new TextBox();
            TargetCountLabel = new Label();
            fightDurationLabel = new Label();
            simResultsBackgroundPanel = new Panel();
            totalDamageLabel = new Label();
            generalResultsOutlinePanel = new Panel();
            panel1 = new Panel();
            dpsLabel = new Label();
            damageOverviewLabel = new Label();
            leftNavPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentClassIcon).BeginInit();
            simSettingBackgroundPanel.SuspendLayout();
            statsPanelBorder.SuspendLayout();
            statsPanel.SuspendLayout();
            simResultsBackgroundPanel.SuspendLayout();
            generalResultsOutlinePanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // leftNavPanel
            // 
            leftNavPanel.BackColor = Color.FromArgb(60, 60, 60);
            leftNavPanel.Controls.Add(panelCurrentBtnBorder);
            leftNavPanel.Controls.Add(classBtnRanger);
            leftNavPanel.Controls.Add(ClassBtnFrostMage);
            leftNavPanel.Controls.Add(classBtnJuggernaut);
            leftNavPanel.Controls.Add(panel2);
            leftNavPanel.Dock = DockStyle.Left;
            leftNavPanel.Location = new Point(0, 0);
            leftNavPanel.Name = "leftNavPanel";
            leftNavPanel.Size = new Size(200, 560);
            leftNavPanel.TabIndex = 0;
            // 
            // panelCurrentBtnBorder
            // 
            panelCurrentBtnBorder.BackColor = Color.FromArgb(207, 207, 207);
            panelCurrentBtnBorder.Location = new Point(0, 152);
            panelCurrentBtnBorder.Name = "panelCurrentBtnBorder";
            panelCurrentBtnBorder.Size = new Size(3, 100);
            panelCurrentBtnBorder.TabIndex = 2;
            // 
            // classBtnRanger
            // 
            classBtnRanger.BackgroundImage = Properties.Resources.emerald_arrowhead_icon;
            classBtnRanger.BackgroundImageLayout = ImageLayout.None;
            classBtnRanger.Dock = DockStyle.Top;
            classBtnRanger.FlatAppearance.BorderSize = 0;
            classBtnRanger.FlatStyle = FlatStyle.Flat;
            classBtnRanger.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            classBtnRanger.ForeColor = Color.FromArgb(87, 204, 86);
            classBtnRanger.Location = new Point(0, 226);
            classBtnRanger.Name = "classBtnRanger";
            classBtnRanger.Size = new Size(200, 40);
            classBtnRanger.TabIndex = 1;
            classBtnRanger.Text = "Ranger";
            classBtnRanger.TextImageRelation = TextImageRelation.TextBeforeImage;
            classBtnRanger.UseVisualStyleBackColor = true;
            classBtnRanger.Click += ClassButton_Click;
            // 
            // ClassBtnFrostMage
            // 
            ClassBtnFrostMage.BackgroundImage = Properties.Resources.enchanted_crystal;
            ClassBtnFrostMage.BackgroundImageLayout = ImageLayout.None;
            ClassBtnFrostMage.Dock = DockStyle.Top;
            ClassBtnFrostMage.FlatAppearance.BorderSize = 0;
            ClassBtnFrostMage.FlatStyle = FlatStyle.Flat;
            ClassBtnFrostMage.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            ClassBtnFrostMage.ForeColor = Color.FromArgb(74, 186, 226);
            ClassBtnFrostMage.Location = new Point(0, 186);
            ClassBtnFrostMage.Name = "ClassBtnFrostMage";
            ClassBtnFrostMage.Size = new Size(200, 40);
            ClassBtnFrostMage.TabIndex = 1;
            ClassBtnFrostMage.Text = "Frost Mage";
            ClassBtnFrostMage.TextImageRelation = TextImageRelation.TextBeforeImage;
            ClassBtnFrostMage.UseVisualStyleBackColor = true;
            ClassBtnFrostMage.Click += ClassButton_Click;
            // 
            // classBtnJuggernaut
            // 
            classBtnJuggernaut.BackgroundImage = Properties.Resources.cleave_ability_icon_2;
            classBtnJuggernaut.BackgroundImageLayout = ImageLayout.None;
            classBtnJuggernaut.Dock = DockStyle.Top;
            classBtnJuggernaut.FlatAppearance.BorderSize = 0;
            classBtnJuggernaut.FlatStyle = FlatStyle.Flat;
            classBtnJuggernaut.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            classBtnJuggernaut.ForeColor = Color.FromArgb(176, 36, 0);
            classBtnJuggernaut.Location = new Point(0, 146);
            classBtnJuggernaut.Name = "classBtnJuggernaut";
            classBtnJuggernaut.Size = new Size(200, 40);
            classBtnJuggernaut.TabIndex = 1;
            classBtnJuggernaut.Text = "Juggernaut";
            classBtnJuggernaut.TextImageRelation = TextImageRelation.TextBeforeImage;
            classBtnJuggernaut.UseVisualStyleBackColor = true;
            classBtnJuggernaut.Click += ClassButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(specSelectComboBox);
            panel2.Controls.Add(currentClassLabel);
            panel2.Controls.Add(currentClassIcon);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 146);
            panel2.TabIndex = 0;
            // 
            // specSelectComboBox
            // 
            specSelectComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            specSelectComboBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            specSelectComboBox.FormattingEnabled = true;
            specSelectComboBox.Items.AddRange(new object[] { "Dreadnought", "Weapon Master", "Battle Lord" });
            specSelectComboBox.Location = new Point(35, 108);
            specSelectComboBox.MaxDropDownItems = 3;
            specSelectComboBox.Name = "specSelectComboBox";
            specSelectComboBox.Size = new Size(130, 23);
            specSelectComboBox.TabIndex = 2;
            specSelectComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // currentClassLabel
            // 
            currentClassLabel.AutoSize = true;
            currentClassLabel.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            currentClassLabel.ForeColor = Color.FromArgb(176, 36, 0);
            currentClassLabel.Location = new Point(58, 88);
            currentClassLabel.Name = "currentClassLabel";
            currentClassLabel.Size = new Size(84, 16);
            currentClassLabel.TabIndex = 1;
            currentClassLabel.Text = "Juggernaut";
            currentClassLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // currentClassIcon
            // 
            currentClassIcon.BackgroundImage = Properties.Resources.cleave_ability_icon_2;
            currentClassIcon.Image = Properties.Resources.cleave_ability_icon_2;
            currentClassIcon.Location = new Point(70, 18);
            currentClassIcon.Name = "currentClassIcon";
            currentClassIcon.Size = new Size(60, 60);
            currentClassIcon.SizeMode = PictureBoxSizeMode.Zoom;
            currentClassIcon.TabIndex = 0;
            currentClassIcon.TabStop = false;
            // 
            // classIconImageList
            // 
            classIconImageList.ColorDepth = ColorDepth.Depth32Bit;
            classIconImageList.ImageStream = (ImageListStreamer)resources.GetObject("classIconImageList.ImageStream");
            classIconImageList.TransparentColor = Color.Transparent;
            classIconImageList.Images.SetKeyName(0, "cleave ability icon 2.png");
            classIconImageList.Images.SetKeyName(1, "enchanted crystal.png");
            classIconImageList.Images.SetKeyName(2, "emerald arrowhead icon.png");
            // 
            // simSettingBackgroundPanel
            // 
            simSettingBackgroundPanel.BackColor = Color.FromArgb(86, 86, 86);
            simSettingBackgroundPanel.Controls.Add(statsPanelBorder);
            simSettingBackgroundPanel.Controls.Add(button1);
            simSettingBackgroundPanel.Controls.Add(targetCountTextBox);
            simSettingBackgroundPanel.Controls.Add(fightDurationTextBox);
            simSettingBackgroundPanel.Controls.Add(TargetCountLabel);
            simSettingBackgroundPanel.Controls.Add(fightDurationLabel);
            simSettingBackgroundPanel.Location = new Point(200, 0);
            simSettingBackgroundPanel.Name = "simSettingBackgroundPanel";
            simSettingBackgroundPanel.Size = new Size(750, 210);
            simSettingBackgroundPanel.TabIndex = 1;
            // 
            // statsPanelBorder
            // 
            statsPanelBorder.BackColor = Color.Black;
            statsPanelBorder.Controls.Add(statsPanel);
            statsPanelBorder.Location = new Point(10, 10);
            statsPanelBorder.Name = "statsPanelBorder";
            statsPanelBorder.Size = new Size(730, 144);
            statsPanelBorder.TabIndex = 3;
            // 
            // statsPanel
            // 
            statsPanel.BackColor = Color.FromArgb(86, 86, 86);
            statsPanel.Controls.Add(brutalPowerBox);
            statsPanel.Controls.Add(hasteBox);
            statsPanel.Controls.Add(CritChanceBox);
            statsPanel.Controls.Add(WeaponDamageBox);
            statsPanel.Controls.Add(hasteLabel);
            statsPanel.Controls.Add(brutalPowerLabel);
            statsPanel.Controls.Add(critChanceLabel);
            statsPanel.Controls.Add(weaponDamageLabel);
            statsPanel.Location = new Point(2, 2);
            statsPanel.Name = "statsPanel";
            statsPanel.Size = new Size(726, 140);
            statsPanel.TabIndex = 0;
            // 
            // brutalPowerBox
            // 
            brutalPowerBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            brutalPowerBox.Location = new Point(147, 67);
            brutalPowerBox.Name = "brutalPowerBox";
            brutalPowerBox.Size = new Size(100, 25);
            brutalPowerBox.TabIndex = 1;
            brutalPowerBox.Text = "63.8";
            brutalPowerBox.KeyPress += TextBoxKeyPress;
            // 
            // hasteBox
            // 
            hasteBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hasteBox.Location = new Point(357, 67);
            hasteBox.Name = "hasteBox";
            hasteBox.Size = new Size(100, 25);
            hasteBox.TabIndex = 1;
            hasteBox.Text = "0";
            hasteBox.KeyPress += TextBoxKeyPress;
            // 
            // CritChanceBox
            // 
            CritChanceBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CritChanceBox.Location = new Point(357, 19);
            CritChanceBox.Name = "CritChanceBox";
            CritChanceBox.Size = new Size(100, 25);
            CritChanceBox.TabIndex = 1;
            CritChanceBox.Text = "0.01";
            CritChanceBox.KeyPress += TextBoxKeyPress;
            // 
            // WeaponDamageBox
            // 
            WeaponDamageBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WeaponDamageBox.Location = new Point(147, 19);
            WeaponDamageBox.Name = "WeaponDamageBox";
            WeaponDamageBox.Size = new Size(100, 25);
            WeaponDamageBox.TabIndex = 1;
            WeaponDamageBox.Text = "14";
            WeaponDamageBox.KeyPress += TextBoxKeyPress;
            // 
            // hasteLabel
            // 
            hasteLabel.AutoSize = true;
            hasteLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            hasteLabel.Location = new Point(304, 69);
            hasteLabel.Name = "hasteLabel";
            hasteLabel.Size = new Size(47, 18);
            hasteLabel.TabIndex = 0;
            hasteLabel.Text = "Haste";
            // 
            // brutalPowerLabel
            // 
            brutalPowerLabel.AutoSize = true;
            brutalPowerLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            brutalPowerLabel.Location = new Point(48, 69);
            brutalPowerLabel.Name = "brutalPowerLabel";
            brutalPowerLabel.Size = new Size(93, 18);
            brutalPowerLabel.TabIndex = 0;
            brutalPowerLabel.Text = "Brutal Power";
            // 
            // critChanceLabel
            // 
            critChanceLabel.AutoSize = true;
            critChanceLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            critChanceLabel.Location = new Point(265, 21);
            critChanceLabel.Name = "critChanceLabel";
            critChanceLabel.Size = new Size(86, 18);
            critChanceLabel.TabIndex = 0;
            critChanceLabel.Text = "Crit Chance";
            // 
            // weaponDamageLabel
            // 
            weaponDamageLabel.AutoSize = true;
            weaponDamageLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            weaponDamageLabel.Location = new Point(17, 21);
            weaponDamageLabel.Name = "weaponDamageLabel";
            weaponDamageLabel.Size = new Size(124, 18);
            weaponDamageLabel.TabIndex = 0;
            weaponDamageLabel.Text = "Weapon Damage";
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(499, 161);
            button1.Name = "button1";
            button1.Size = new Size(200, 40);
            button1.TabIndex = 2;
            button1.Text = "Begin";
            button1.TextImageRelation = TextImageRelation.TextBeforeImage;
            button1.UseVisualStyleBackColor = true;
            button1.Click += BeginSims;
            // 
            // targetCountTextBox
            // 
            targetCountTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            targetCountTextBox.Location = new Point(352, 171);
            targetCountTextBox.Name = "targetCountTextBox";
            targetCountTextBox.Size = new Size(100, 25);
            targetCountTextBox.TabIndex = 1;
            targetCountTextBox.Text = "1";
            targetCountTextBox.KeyPress += TextBoxKeyPress;
            // 
            // fightDurationTextBox
            // 
            fightDurationTextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fightDurationTextBox.Location = new Point(175, 171);
            fightDurationTextBox.Name = "fightDurationTextBox";
            fightDurationTextBox.Size = new Size(100, 25);
            fightDurationTextBox.TabIndex = 1;
            fightDurationTextBox.Text = "300";
            fightDurationTextBox.KeyPress += TextBoxKeyPress;
            // 
            // TargetCountLabel
            // 
            TargetCountLabel.AutoSize = true;
            TargetCountLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            TargetCountLabel.Location = new Point(290, 173);
            TargetCountLabel.Name = "TargetCountLabel";
            TargetCountLabel.Size = new Size(58, 18);
            TargetCountLabel.TabIndex = 0;
            TargetCountLabel.Text = "Targets";
            // 
            // fightDurationLabel
            // 
            fightDurationLabel.AutoSize = true;
            fightDurationLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            fightDurationLabel.Location = new Point(32, 173);
            fightDurationLabel.Name = "fightDurationLabel";
            fightDurationLabel.Size = new Size(137, 18);
            fightDurationLabel.TabIndex = 0;
            fightDurationLabel.Text = "Duration (Seconds)";
            // 
            // simResultsBackgroundPanel
            // 
            simResultsBackgroundPanel.BackColor = Color.FromArgb(86, 86, 86);
            simResultsBackgroundPanel.Controls.Add(generalResultsOutlinePanel);
            simResultsBackgroundPanel.Location = new Point(200, 220);
            simResultsBackgroundPanel.Name = "simResultsBackgroundPanel";
            simResultsBackgroundPanel.Size = new Size(750, 340);
            simResultsBackgroundPanel.TabIndex = 1;
            // 
            // totalDamageLabel
            // 
            totalDamageLabel.AutoSize = true;
            totalDamageLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            totalDamageLabel.Location = new Point(20, 20);
            totalDamageLabel.Name = "totalDamageLabel";
            totalDamageLabel.Size = new Size(116, 19);
            totalDamageLabel.TabIndex = 0;
            totalDamageLabel.Text = "Total Damage: 73";
            // 
            // generalResultsOutlinePanel
            // 
            generalResultsOutlinePanel.BackColor = Color.Black;
            generalResultsOutlinePanel.Controls.Add(panel1);
            generalResultsOutlinePanel.Location = new Point(10, 10);
            generalResultsOutlinePanel.Name = "generalResultsOutlinePanel";
            generalResultsOutlinePanel.Size = new Size(300, 320);
            generalResultsOutlinePanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(86, 86, 86);
            panel1.Controls.Add(damageOverviewLabel);
            panel1.Controls.Add(dpsLabel);
            panel1.Controls.Add(totalDamageLabel);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 316);
            panel1.TabIndex = 0;
            // 
            // dpsLabel
            // 
            dpsLabel.AutoSize = true;
            dpsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dpsLabel.Location = new Point(20, 44);
            dpsLabel.Name = "dpsLabel";
            dpsLabel.Size = new Size(41, 19);
            dpsLabel.TabIndex = 1;
            dpsLabel.Text = "DPS: ";
            // 
            // damageOverviewLabel
            // 
            damageOverviewLabel.AutoSize = true;
            damageOverviewLabel.Location = new Point(20, 68);
            damageOverviewLabel.Name = "damageOverviewLabel";
            damageOverviewLabel.Size = new Size(97, 45);
            damageOverviewLabel.TabIndex = 1;
            damageOverviewLabel.Text = "abi 1 = 123 (5%)\r\nabi 2 = 235 (12%)\r\nabi 3 = 274 (34%)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(950, 560);
            Controls.Add(simResultsBackgroundPanel);
            Controls.Add(simSettingBackgroundPanel);
            Controls.Add(leftNavPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            leftNavPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentClassIcon).EndInit();
            simSettingBackgroundPanel.ResumeLayout(false);
            simSettingBackgroundPanel.PerformLayout();
            statsPanelBorder.ResumeLayout(false);
            statsPanel.ResumeLayout(false);
            statsPanel.PerformLayout();
            simResultsBackgroundPanel.ResumeLayout(false);
            generalResultsOutlinePanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel leftNavPanel;
        private Panel panel2;
        private PictureBox currentClassIcon;
        private Label currentClassLabel;
        private ComboBox specSelectComboBox;
        private Button classBtnJuggernaut;
        private Button classBtnRanger;
        private Button ClassBtnFrostMage;
        private Panel panelCurrentBtnBorder;
        private ImageList classIconImageList;
        private Panel simSettingBackgroundPanel;
        private Panel simResultsBackgroundPanel;
        private TextBox fightDurationTextBox;
        private Label fightDurationLabel;
        private TextBox targetCountTextBox;
        private Label TargetCountLabel;
        private Button button1;
        private Panel statsPanelBorder;
        private Panel statsPanel;
        private TextBox brutalPowerBox;
        private TextBox hasteBox;
        private TextBox CritChanceBox;
        private TextBox WeaponDamageBox;
        private Label hasteLabel;
        private Label brutalPowerLabel;
        private Label critChanceLabel;
        private Label weaponDamageLabel;
        private Label totalDamageLabel;
        private Panel generalResultsOutlinePanel;
        private Panel panel1;
        private Label damageOverviewLabel;
        private Label dpsLabel;
    }
}