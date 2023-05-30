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
            panel1 = new Panel();
            panelCurrentBtnBorder = new Panel();
            classBtnRanger = new Button();
            ClassBtnFrostMage = new Button();
            classBtnJuggernaut = new Button();
            panel2 = new Panel();
            specSelectComboBox = new ComboBox();
            currentClassLabel = new Label();
            currentClassIcon = new PictureBox();
            classIconImageList = new ImageList(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)currentClassIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.Controls.Add(panelCurrentBtnBorder);
            panel1.Controls.Add(classBtnRanger);
            panel1.Controls.Add(ClassBtnFrostMage);
            panel1.Controls.Add(classBtnJuggernaut);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 560);
            panel1.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(950, 560);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)currentClassIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox currentClassIcon;
        private Label currentClassLabel;
        private ComboBox specSelectComboBox;
        private Button classBtnJuggernaut;
        private Button classBtnRanger;
        private Button ClassBtnFrostMage;
        private Panel panelCurrentBtnBorder;
        private ImageList classIconImageList;
    }
}