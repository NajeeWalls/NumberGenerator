namespace NumberGenerator
{
    partial class CoinFlipForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoinFlipForm));
            this.flipButton = new System.Windows.Forms.Button();
            this.pictureBoxheads = new System.Windows.Forms.PictureBox();
            this.pictureBoxtails = new System.Windows.Forms.PictureBox();
            this.counterBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tailTextBox = new System.Windows.Forms.TextBox();
            this.headTextBox = new System.Windows.Forms.TextBox();
            this.flipPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxheads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtails)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flipPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(118, 205);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 0;
            this.flipButton.Text = "Flip the coin";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // pictureBoxheads
            // 
            this.pictureBoxheads.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxheads.Image")));
            this.pictureBoxheads.Location = new System.Drawing.Point(12, 99);
            this.pictureBoxheads.Name = "pictureBoxheads";
            this.pictureBoxheads.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxheads.TabIndex = 1;
            this.pictureBoxheads.TabStop = false;
            this.pictureBoxheads.Visible = false;
            // 
            // pictureBoxtails
            // 
            this.pictureBoxtails.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxtails.Image")));
            this.pictureBoxtails.Location = new System.Drawing.Point(12, 99);
            this.pictureBoxtails.Name = "pictureBoxtails";
            this.pictureBoxtails.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxtails.TabIndex = 2;
            this.pictureBoxtails.TabStop = false;
            this.pictureBoxtails.Visible = false;
            // 
            // counterBox
            // 
            this.counterBox.Location = new System.Drawing.Point(50, 103);
            this.counterBox.Name = "counterBox";
            this.counterBox.Size = new System.Drawing.Size(100, 20);
            this.counterBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tailTextBox);
            this.groupBox1.Controls.Add(this.headTextBox);
            this.groupBox1.Controls.Add(this.counterBox);
            this.groupBox1.Location = new System.Drawing.Point(234, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 187);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tails:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Heads:";
            // 
            // tailTextBox
            // 
            this.tailTextBox.Location = new System.Drawing.Point(52, 63);
            this.tailTextBox.Name = "tailTextBox";
            this.tailTextBox.Size = new System.Drawing.Size(100, 20);
            this.tailTextBox.TabIndex = 5;
            // 
            // headTextBox
            // 
            this.headTextBox.Location = new System.Drawing.Point(52, 36);
            this.headTextBox.Name = "headTextBox";
            this.headTextBox.Size = new System.Drawing.Size(100, 20);
            this.headTextBox.TabIndex = 4;
            // 
            // flipPictureBox
            // 
            this.flipPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flipPictureBox.Image")));
            this.flipPictureBox.Location = new System.Drawing.Point(118, 71);
            this.flipPictureBox.Name = "flipPictureBox";
            this.flipPictureBox.Size = new System.Drawing.Size(109, 128);
            this.flipPictureBox.TabIndex = 5;
            this.flipPictureBox.TabStop = false;
            this.flipPictureBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "+10";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "+100";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 235);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Options";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CoinFlipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 337);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flipPictureBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxtails);
            this.Controls.Add(this.pictureBoxheads);
            this.Controls.Add(this.flipButton);
            this.Name = "CoinFlipForm";
            this.Text = "CoinFlipForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxheads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxtails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flipPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.PictureBox pictureBoxheads;
        private System.Windows.Forms.PictureBox pictureBoxtails;
        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tailTextBox;
        private System.Windows.Forms.TextBox headTextBox;
        private System.Windows.Forms.PictureBox flipPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}