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
    public partial class MainMenu : Form
    {

        RawForm NumbersSim;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void rawNumbersToolStripMenuItem_Click(object sender, EventArgs e)

        {
            NumbersSim = new RawForm();
            NumbersSim.ShowDialog();
        }

        private void coinFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CoinFlipForm coinflip = new CoinFlipForm();
            coinflip.ShowDialog();
        }
    }
}
