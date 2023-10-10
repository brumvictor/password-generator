using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class FormPasswordGenerator : Form
    {
        int currentPasswordLength = 0;
        Random character = new Random();

        private void PassordGenerator(int passwordLength)
        {
            String allCharacters = "ABCDEFGHIJKLMNOPRQSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz!@#$%^&";
            String randomPassword = "";

            for(int i=0; i < passwordLength; i++)
            {
                int randomNum = character.Next(0, allCharacters.Length);
                randomPassword += allCharacters[randomNum];
            }
            passwordLabel.Text = randomPassword;
        }

        public FormPasswordGenerator()
        {
            InitializeComponent();
            PasswordLengthSlider.Minimum = 5;
            PasswordLengthSlider.Maximum = 20;
            PassordGenerator(5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CopyPasswordButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(passwordLabel.Text);
        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            PasswordLengthLabel.Text = "Password Length: " + PasswordLengthSlider.Value.ToString();
            currentPasswordLength = PasswordLengthSlider.Value;
            PassordGenerator(currentPasswordLength);
        }

        private void PasswordLengthLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
