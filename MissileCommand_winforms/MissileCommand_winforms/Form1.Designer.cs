namespace MissileCommand_winforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.building1 = new System.Windows.Forms.PictureBox();
            this.building2 = new System.Windows.Forms.PictureBox();
            this.building3 = new System.Windows.Forms.PictureBox();
            this.building4 = new System.Windows.Forms.PictureBox();
            this.building5 = new System.Windows.Forms.PictureBox();
            this.building6 = new System.Windows.Forms.PictureBox();
            this.building8 = new System.Windows.Forms.PictureBox();
            this.building7 = new System.Windows.Forms.PictureBox();
            this.numMissBox = new System.Windows.Forms.TextBox();
            this.numMissLabel = new System.Windows.Forms.Label();
            this.numCitiesLabel = new System.Windows.Forms.Label();
            this.numCitiesBox = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.ListBox();
            this.startGame = new System.Windows.Forms.Button();
            this.highScoreLabel = new System.Windows.Forms.Label();
            this.highScore = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripPause = new System.Windows.Forms.ToolStripButton();
            this.toolStripRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripQuit = new System.Windows.Forms.ToolStripButton();
            this.missRemainingLabel = new System.Windows.Forms.Label();
            this.missRemaining = new System.Windows.Forms.Label();
            this.toolStripHowToPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripDocumentation = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.building1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.building7)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.scoreLabel.Location = new System.Drawing.Point(12, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(37, 39);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "0";
            this.scoreLabel.Visible = false;
            // 
            // levelLabel
            // 
            this.levelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.levelLabel.AutoSize = true;
            this.levelLabel.BackColor = System.Drawing.Color.Transparent;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.Color.Yellow;
            this.levelLabel.Location = new System.Drawing.Point(936, 9);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(134, 39);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "Level 1";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.levelLabel.Visible = false;
            // 
            // building1
            // 
            this.building1.Image = ((System.Drawing.Image)(resources.GetObject("building1.Image")));
            this.building1.Location = new System.Drawing.Point(19, 429);
            this.building1.Name = "building1";
            this.building1.Size = new System.Drawing.Size(75, 150);
            this.building1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building1.TabIndex = 3;
            this.building1.TabStop = false;
            this.building1.Visible = false;
            // 
            // building2
            // 
            this.building2.Image = ((System.Drawing.Image)(resources.GetObject("building2.Image")));
            this.building2.Location = new System.Drawing.Point(138, 429);
            this.building2.Name = "building2";
            this.building2.Size = new System.Drawing.Size(75, 150);
            this.building2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building2.TabIndex = 4;
            this.building2.TabStop = false;
            this.building2.Visible = false;
            // 
            // building3
            // 
            this.building3.Image = ((System.Drawing.Image)(resources.GetObject("building3.Image")));
            this.building3.Location = new System.Drawing.Point(265, 429);
            this.building3.Name = "building3";
            this.building3.Size = new System.Drawing.Size(75, 150);
            this.building3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building3.TabIndex = 5;
            this.building3.TabStop = false;
            this.building3.Visible = false;
            // 
            // building4
            // 
            this.building4.Image = ((System.Drawing.Image)(resources.GetObject("building4.Image")));
            this.building4.Location = new System.Drawing.Point(394, 429);
            this.building4.Name = "building4";
            this.building4.Size = new System.Drawing.Size(75, 150);
            this.building4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building4.TabIndex = 6;
            this.building4.TabStop = false;
            this.building4.Visible = false;
            // 
            // building5
            // 
            this.building5.Image = ((System.Drawing.Image)(resources.GetObject("building5.Image")));
            this.building5.Location = new System.Drawing.Point(624, 429);
            this.building5.Name = "building5";
            this.building5.Size = new System.Drawing.Size(75, 150);
            this.building5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building5.TabIndex = 7;
            this.building5.TabStop = false;
            this.building5.Visible = false;
            // 
            // building6
            // 
            this.building6.Image = ((System.Drawing.Image)(resources.GetObject("building6.Image")));
            this.building6.Location = new System.Drawing.Point(754, 429);
            this.building6.Name = "building6";
            this.building6.Size = new System.Drawing.Size(75, 150);
            this.building6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building6.TabIndex = 8;
            this.building6.TabStop = false;
            this.building6.Visible = false;
            // 
            // building8
            // 
            this.building8.Image = ((System.Drawing.Image)(resources.GetObject("building8.Image")));
            this.building8.Location = new System.Drawing.Point(995, 429);
            this.building8.Name = "building8";
            this.building8.Size = new System.Drawing.Size(75, 150);
            this.building8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building8.TabIndex = 9;
            this.building8.TabStop = false;
            this.building8.Visible = false;
            // 
            // building7
            // 
            this.building7.Image = ((System.Drawing.Image)(resources.GetObject("building7.Image")));
            this.building7.Location = new System.Drawing.Point(880, 429);
            this.building7.Name = "building7";
            this.building7.Size = new System.Drawing.Size(75, 150);
            this.building7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.building7.TabIndex = 10;
            this.building7.TabStop = false;
            this.building7.Visible = false;
            // 
            // numMissBox
            // 
            this.numMissBox.Location = new System.Drawing.Point(333, 98);
            this.numMissBox.Name = "numMissBox";
            this.numMissBox.Size = new System.Drawing.Size(100, 22);
            this.numMissBox.TabIndex = 11;
            // 
            // numMissLabel
            // 
            this.numMissLabel.AutoSize = true;
            this.numMissLabel.ForeColor = System.Drawing.Color.Yellow;
            this.numMissLabel.Location = new System.Drawing.Point(16, 86);
            this.numMissLabel.Name = "numMissLabel";
            this.numMissLabel.Size = new System.Drawing.Size(238, 34);
            this.numMissLabel.TabIndex = 12;
            this.numMissLabel.Text = "Enter number of missiles per enemy \r\nmissile (blank = unlimited)";
            // 
            // numCitiesLabel
            // 
            this.numCitiesLabel.AutoSize = true;
            this.numCitiesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.numCitiesLabel.Location = new System.Drawing.Point(16, 171);
            this.numCitiesLabel.Name = "numCitiesLabel";
            this.numCitiesLabel.Size = new System.Drawing.Size(260, 17);
            this.numCitiesLabel.TabIndex = 13;
            this.numCitiesLabel.Text = "Enter number of cities to defend (1 to 8)";
            // 
            // numCitiesBox
            // 
            this.numCitiesBox.Location = new System.Drawing.Point(333, 171);
            this.numCitiesBox.Name = "numCitiesBox";
            this.numCitiesBox.Size = new System.Drawing.Size(100, 22);
            this.numCitiesBox.TabIndex = 14;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.ForeColor = System.Drawing.Color.Yellow;
            this.speedLabel.Location = new System.Drawing.Point(16, 239);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(243, 17);
            this.speedLabel.TabIndex = 15;
            this.speedLabel.Text = "Choose constant or increasing speed";
            // 
            // speedBox
            // 
            this.speedBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.speedBox.DisplayMember = "Constant";
            this.speedBox.FormattingEnabled = true;
            this.speedBox.ItemHeight = 16;
            this.speedBox.Items.AddRange(new object[] {
            "Increasing",
            "Constant"});
            this.speedBox.Location = new System.Drawing.Point(333, 239);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(100, 36);
            this.speedBox.TabIndex = 16;
            this.speedBox.ValueMember = "Constant";
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.startGame.Location = new System.Drawing.Point(333, 317);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(100, 23);
            this.startGame.TabIndex = 17;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.AutoSize = true;
            this.highScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.highScoreLabel.Location = new System.Drawing.Point(617, 171);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(206, 39);
            this.highScoreLabel.TabIndex = 18;
            this.highScoreLabel.Text = "High Score:";
            // 
            // highScore
            // 
            this.highScore.AutoSize = true;
            this.highScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.ForeColor = System.Drawing.Color.Yellow;
            this.highScore.Location = new System.Drawing.Point(829, 171);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(0, 39);
            this.highScore.TabIndex = 19;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPause,
            this.toolStripRestart,
            this.toolStripQuit,
            this.toolStripHowToPlay,
            this.toolStripDocumentation});
            this.toolStrip1.Location = new System.Drawing.Point(0, 626);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1082, 27);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripPause
            // 
            this.toolStripPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPause.Enabled = false;
            this.toolStripPause.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPause.Image")));
            this.toolStripPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPause.Name = "toolStripPause";
            this.toolStripPause.Size = new System.Drawing.Size(24, 24);
            this.toolStripPause.Text = "toolStripButton1";
            this.toolStripPause.ToolTipText = "Pause the Game";
            this.toolStripPause.Click += new System.EventHandler(this.pause_Click);
            // 
            // toolStripRestart
            // 
            this.toolStripRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripRestart.Enabled = false;
            this.toolStripRestart.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRestart.Image")));
            this.toolStripRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRestart.Name = "toolStripRestart";
            this.toolStripRestart.Size = new System.Drawing.Size(24, 24);
            this.toolStripRestart.Text = "toolStripButton1";
            this.toolStripRestart.ToolTipText = "Restart the Game";
            this.toolStripRestart.Click += new System.EventHandler(this.toolStripRestart_Click);
            // 
            // toolStripQuit
            // 
            this.toolStripQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripQuit.Enabled = false;
            this.toolStripQuit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripQuit.Image")));
            this.toolStripQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripQuit.Name = "toolStripQuit";
            this.toolStripQuit.Size = new System.Drawing.Size(24, 24);
            this.toolStripQuit.Text = "toolStripButton1";
            this.toolStripQuit.ToolTipText = "Quit the Game";
            this.toolStripQuit.Click += new System.EventHandler(this.toolStripQuit_Click);
            // 
            // missRemainingLabel
            // 
            this.missRemainingLabel.AutoSize = true;
            this.missRemainingLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.missRemainingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missRemainingLabel.ForeColor = System.Drawing.Color.Yellow;
            this.missRemainingLabel.Location = new System.Drawing.Point(16, 591);
            this.missRemainingLabel.Name = "missRemainingLabel";
            this.missRemainingLabel.Size = new System.Drawing.Size(202, 17);
            this.missRemainingLabel.TabIndex = 21;
            this.missRemainingLabel.Text = "Player Missiles Remaining:";
            this.missRemainingLabel.Visible = false;
            // 
            // missRemaining
            // 
            this.missRemaining.AutoSize = true;
            this.missRemaining.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.missRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missRemaining.ForeColor = System.Drawing.Color.Yellow;
            this.missRemaining.Location = new System.Drawing.Point(224, 591);
            this.missRemaining.Name = "missRemaining";
            this.missRemaining.Size = new System.Drawing.Size(0, 17);
            this.missRemaining.TabIndex = 22;
            // 
            // toolStripHowToPlay
            // 
            this.toolStripHowToPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripHowToPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHowToPlay.Image")));
            this.toolStripHowToPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripHowToPlay.Name = "toolStripHowToPlay";
            this.toolStripHowToPlay.Size = new System.Drawing.Size(24, 24);
            this.toolStripHowToPlay.Text = "toolStripButton1";
            this.toolStripHowToPlay.ToolTipText = "How to Play";
            this.toolStripHowToPlay.Click += new System.EventHandler(this.toolStripHowToPlay_Click);
            // 
            // toolStripDocumentation
            // 
            this.toolStripDocumentation.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDocumentation.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDocumentation.Image")));
            this.toolStripDocumentation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDocumentation.Name = "toolStripDocumentation";
            this.toolStripDocumentation.Size = new System.Drawing.Size(24, 24);
            this.toolStripDocumentation.Text = "toolStripButton2";
            this.toolStripDocumentation.ToolTipText = "View Documentation";
            this.toolStripDocumentation.Click += new System.EventHandler(this.toolStripDocumentation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.missRemaining);
            this.Controls.Add(this.missRemainingLabel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.numCitiesBox);
            this.Controls.Add(this.numCitiesLabel);
            this.Controls.Add(this.numMissLabel);
            this.Controls.Add(this.numMissBox);
            this.Controls.Add(this.building7);
            this.Controls.Add(this.building8);
            this.Controls.Add(this.building6);
            this.Controls.Add(this.building5);
            this.Controls.Add(this.building4);
            this.Controls.Add(this.building3);
            this.Controls.Add(this.building2);
            this.Controls.Add(this.building1);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.scoreLabel);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1100, 700);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Missile Command";
            ((System.ComponentModel.ISupportInitialize)(this.building1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.building7)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.PictureBox building1;
        private System.Windows.Forms.PictureBox building2;
        private System.Windows.Forms.PictureBox building3;
        private System.Windows.Forms.PictureBox building4;
        private System.Windows.Forms.PictureBox building5;
        private System.Windows.Forms.PictureBox building6;
        private System.Windows.Forms.PictureBox building8;
        private System.Windows.Forms.PictureBox building7;
        private System.Windows.Forms.TextBox numMissBox;
        private System.Windows.Forms.Label numMissLabel;
        private System.Windows.Forms.Label numCitiesLabel;
        private System.Windows.Forms.TextBox numCitiesBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.ListBox speedBox;
        private System.Windows.Forms.Button startGame;
        private System.Windows.Forms.Label highScoreLabel;
        private System.Windows.Forms.Label highScore;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripPause;
        private System.Windows.Forms.ToolStripButton toolStripRestart;
        private System.Windows.Forms.ToolStripButton toolStripQuit;
        private System.Windows.Forms.Label missRemainingLabel;
        private System.Windows.Forms.Label missRemaining;
        private System.Windows.Forms.ToolStripButton toolStripHowToPlay;
        private System.Windows.Forms.ToolStripButton toolStripDocumentation;
    }
}

