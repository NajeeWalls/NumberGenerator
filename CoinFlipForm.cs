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
    public partial class CoinFlipForm : Form
    {
        public CoinFlipForm()
        {
            InitializeComponent();
        }

        private GifImage gifImage = null;
        private string filePath = @"~/Flipping_Coin.gif";


        int headcounter = 0;
        int tailcounter = 0;
        Random rand;
        //When flip button is pressed, if a random number between 0 and 1 is less then .5 then heads shows
        //Else tails shows. Counts of each is tracked.
       
        private void flipButton_Click(object sender, EventArgs e)
        {

            timer1.Start();
            flipPictureBox.Visible = true;
            pictureBoxheads.Visible = false;
            pictureBoxtails.Visible = false;
            
            rand = new Random();
            double x = rand.NextDouble();

            if (x < 0.5)
            {
                pictureBoxheads.Visible = true;
                headcounter++;
            }
            else
            {
                pictureBoxtails.Visible = true;
                tailcounter++;
            }
            headTextBox.Text = headcounter.ToString();
            tailTextBox.Text = tailcounter.ToString();
            counterBox.Text = (headcounter + tailcounter).ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flipPictureBox.Visible = false;
            timer1.Stop();
        }


        /*Refrenced from http://www.java2s.com/Code/CSharp/2D-Graphics/AnimateImage.htm
        private void AnimateFlip()
        {
            try
            {
                animatedImage = new Bitmap("Flipping_coin.gif");
                if (!currentlyAnimating)
                {
                    //Begin the animation only once.
                    ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
                    currentlyAnimating = true;

                }
            }
            catch
            {

            }
        }
        private void OnFrameChanged(object o, EventArgs e)
        {
            //Force a call to the Paint event handler.
            this.Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Begin the animation.
            AnimateFlip();
            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();
            //Draw the next frame in the animation.
            e.Graphics.DrawImage(this.animatedImage, new Point(0, 0));
        }
        */
    }
}
