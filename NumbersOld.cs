using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NumberGenerator
{
    public partial class RawForm : Form
    {
        //Declare variables
        Random rand = new Random();
        bool intialvalueset = false;
        int k;
        int c;
        int m;
        int x;
        int xnext;
        int xcurrent;
        int[] lognumberlist;
        int[] compliernumberlist;
        int max;
        int min;
        int counter;
        Modgeneration mod;




        public RawForm()
        {
            InitializeComponent();
            //start the timer.
            timer1.Start();


        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            //Checks if text boxes are filled out. Give a warning message if they're not.
            if (multiTextBox.Text.Trim().Length == 0 || offsetTextBox.Text.Trim().Length == 0 ||
                modTextBox.Text.Trim().Length == 0 || initialTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Make sure all boxes are filled");
            }

            try
            {
                //Parse text Box string to text
                //multiplyer
                k = int.Parse(multiTextBox.Text);
                //offset/increment
                c = int.Parse(offsetTextBox.Text);
                //Modular
                m = int.Parse(modTextBox.Text);
                //Intial value
                x = int.Parse(initialTextBox.Text);
                 mod = new Modgeneration(x,c,k,m);

                //Make textboxes inactive until reset
                 multiTextBox.Enabled = false;
                 offsetTextBox.Enabled = false;
                 modTextBox.Enabled = false;
                 //initialTextBox.Enabled = false;
                

            }

            catch
            {
                MessageBox.Show("Please only use integers for formula variables");
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            //Make textboxes inactive until reset
                 multiTextBox.Enabled = true;
                 offsetTextBox.Enabled = true;
                 modTextBox.Enabled = true;
        }

      //Generate Next Number in sequence.
        private void nextButton1_Click(object sender, EventArgs e)
        {
            try
            {
                generatedTextBox.Text = mod.NextNum().ToString();
            }

            catch
            {
                MessageBox.Show("Sequence not generated");
            }
        }
        //Get compliler/computer to generate it's random number from it's pre-defined random function.
        private void nextButton2_Click(object sender, EventArgs e)
        {
            try
            {
                //Takes number from max number textbox,parses it to integer for random function, 
                //then spits it back out to string into another textbox.
                complieTextBox.Text = rand.Next(int.Parse(maxTextBox.Text)).ToString();
            }

            catch
            {
                MessageBox.Show("Integers only please");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void generateButton2_Click(object sender, EventArgs e)
        {
            int seed;
            decimal y;
            //Parse text Box string to text
            max = int.Parse(modMaxTextBox.Text);
            min = int.Parse(modMinTextBox.Text);
            //Use timer as the seed value.
            mod = new Modgeneration(counter);          
        }

        private void nextButton3_Click(object sender, EventArgs e)
        {
            decimal y;

            //Multiply the output of the number generator by the min, then add the difference;
            y = (mod.NextDecimal() * (max - min)) + min ;
            //round to nearest int
            y = (int)y;

            generatedTextBox2.Text = y.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > 1024)
            {
                counter = 0;
            }

        }

    }
}
