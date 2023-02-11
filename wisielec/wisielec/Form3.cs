using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace wisielec
{
    public partial class Form3 : Form
    {
        private Bitmap[] hangImages = {wisielec.Properties.Resources.Hang1, wisielec.Properties.Resources.Hang2,
            wisielec.Properties.Resources.Hang3, wisielec.Properties.Resources.Hang4, wisielec.Properties.Resources.Hang5,
            wisielec.Properties.Resources.Hang6, wisielec.Properties.Resources.Hang7 };

        private int wrongGuesses = 0;
        private string current = "";
        private string copyCurrent = "";
        private string[] words;
        public Form3()
        {
            InitializeComponent();
        }

        private void loadwords()
        {
            char[] delimiterChars = { ',' };
            string[] readText = File.ReadAllLines("Words4.csv");
            words = new string[readText.Length];
            int index = 0;
            foreach (string s in readText)
            {
                string[] line = s.Split(delimiterChars);
                words[index++] = line[1];

            }
        }

        private void setupWordChoice()
        {
            wrongGuesses = 0;
            hangImage.Image = hangImages[wrongGuesses];
            int guessIndex = (new Random()).Next(words.Length);
            current = words[guessIndex];

            copyCurrent = "";
            for (int index = 0; index < current.Length; index++)
            {
                copyCurrent += "_";
            }
            displayCopy();

        }

        private void displayCopy()
        {
            lblShowWord.Text = " ";
            for (int index = 0; index < current.Length; index++)
            {
                lblShowWord.Text += copyCurrent.Substring(index, 1);
                lblShowWord.Text += " ";
            }
        }

        private void updateCopy(char guess)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdA_Click(object sender, EventArgs e)
        {
            Button choice = sender as Button;
            choice.Enabled = false;
            if (current.Contains(choice.Text))
            {
                char[] temp = copyCurrent.ToCharArray();
                char[] find = current.ToCharArray();
                char guessChar = choice.Text.ElementAt(0);

                for (int index = 0; index < find.Length; index++)
                {
                    if (find[index] == guessChar)
                    {
                        temp[index] = guessChar;
                    }
                }
                copyCurrent = new string(temp);
                displayCopy();

            }
            else
            {
                wrongGuesses++;
            }


            if (wrongGuesses < 7)
            {
                hangImage.Image = hangImages[wrongGuesses];
            }
            else
            {
                lblResult.Text = "       PRZEGRAŁEŚ       ";
            }
            if (copyCurrent.Equals(current))
            {                             
                lblResult.Text = "          WYGRAŁEŚ        ";
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            loadwords();
            setupWordChoice();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            MessageBox.Show("W niektórych odpowiedziach trzeba dodać spację, aby ją dodać trzeba kliknąć na pusty przycisk");
        }
    }
}
