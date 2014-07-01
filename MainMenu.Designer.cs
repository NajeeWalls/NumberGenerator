namespace NumberGenerator
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diceRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playingCardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coinFlipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iExplainationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.simulationsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // simulationsToolStripMenuItem
            // 
            this.simulationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rawNumbersToolStripMenuItem,
            this.diceRollToolStripMenuItem,
            this.playingCardsToolStripMenuItem,
            this.coinFlipToolStripMenuItem});
            this.simulationsToolStripMenuItem.Name = "simulationsToolStripMenuItem";
            this.simulationsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.simulationsToolStripMenuItem.Text = "Simulations";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.iExplainationsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // rawNumbersToolStripMenuItem
            // 
            this.rawNumbersToolStripMenuItem.Name = "rawNumbersToolStripMenuItem";
            this.rawNumbersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rawNumbersToolStripMenuItem.Text = "Raw Numbers";
            this.rawNumbersToolStripMenuItem.Click += new System.EventHandler(this.rawNumbersToolStripMenuItem_Click);
            // 
            // diceRollToolStripMenuItem
            // 
            this.diceRollToolStripMenuItem.Name = "diceRollToolStripMenuItem";
            this.diceRollToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.diceRollToolStripMenuItem.Text = "Dice Roll";
            // 
            // playingCardsToolStripMenuItem
            // 
            this.playingCardsToolStripMenuItem.Name = "playingCardsToolStripMenuItem";
            this.playingCardsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.playingCardsToolStripMenuItem.Text = "Playing Cards";
            // 
            // coinFlipToolStripMenuItem
            // 
            this.coinFlipToolStripMenuItem.Name = "coinFlipToolStripMenuItem";
            this.coinFlipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.coinFlipToolStripMenuItem.Text = "Coin Flip";
            this.coinFlipToolStripMenuItem.Click += new System.EventHandler(this.coinFlipToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // iExplainationsToolStripMenuItem
            // 
            this.iExplainationsToolStripMenuItem.Name = "iExplainationsToolStripMenuItem";
            this.iExplainationsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.iExplainationsToolStripMenuItem.Text = "IExplainations";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 299);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diceRollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playingCardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coinFlipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iExplainationsToolStripMenuItem;
    }
}