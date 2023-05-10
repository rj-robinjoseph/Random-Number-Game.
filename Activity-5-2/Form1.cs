using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_5_2
{
    public partial class Form1 : Form
    {
        int randomNumber = new Random().Next(100);
        int guess;
        int guessCount = 0;
        bool crrctGuess = false;
        int counter = 0;
        string[] colorNames = { "Red", "Green", "Blue", "Yellow", "Orange" };


        public Form1()
        {
            InitializeComponent(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "Number of attempt is: ";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (counter == colorNames.Length)
            {
                counter = 0;
            }

            string colorName = colorNames[counter];
            BackColor = Color.FromName(colorName);

            counter++;

            guess = int.Parse(textBox1.Text);
            guessCount++;

            textBox2.AppendText(guessCount.ToString());

            if (guess < randomNumber)
            {
                listBox1.Items.Add(guess + " is Too Low, Try Again");
                label1.Text = "Oops. Try again";
            }
            else if(guess > randomNumber)
            {
                listBox1.Items.Add(guess + " is Too high, Try Again");
                label1.Text = "Oops. Try again";
            }
            else
            {
                listBox1.Items.Add(" ");
                listBox1.Items.Add("Congratulations " + guess + " is the number.");
                listBox1.Items.Add(" ");
                listBox1.Items.Add("You took " + guessCount + " tries");
                label1.Text = "Yeah, Got it";
                crrctGuess = true;
                guessCount = 0;
                randomNumber = new Random().Next(100);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
