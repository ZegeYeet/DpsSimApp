using DpsSimApp.Properties;
using System.Runtime.InteropServices;

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

        public Form1()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            ClassButton_Click(classBtnJuggernaut, new EventArgs());
            //SetClassButtonImageSizes();
        }

        /*private void SetClassButtonImageSizes()
        {
            classBtnJuggernaut.Image = (Image)(new Bitmap(classBtnJuggernaut.Image, new Size(35, 35)));
            ClassBtnFrostMage.Image = (Image)(new Bitmap(ClassBtnFrostMage.Image, new Size(35, 35)));
            classBtnRanger.Image = (Image)(new Bitmap(classBtnRanger.Image, new Size(35, 35)));
        }*/

        private void ClassButton_Click(object sender, EventArgs e)
        {
            ButtonLeave(currentButton);
            currentButton = sender as Button;

            panelCurrentBtnBorder.Height = currentButton.Height;
            panelCurrentBtnBorder.Top = currentButton.Top;
            panelCurrentBtnBorder.Left = currentButton.Left;
            currentButton.BackColor = Color.FromArgb(168, 168, 168);

            specSelectComboBox.SelectedIndex = 0;
            currentClassIcon.Image = currentButton.BackgroundImage;
        }


        private void ButtonLeave(Button leftBtn)
        {
            if (leftBtn != null)
            {
                leftBtn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}