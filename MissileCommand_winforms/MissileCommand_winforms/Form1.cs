/*
 * Andrew Robinson
 * This form class provides functionality for the missile command game. It keeps track of the
 * state of the game through its private fields, and handles events from the user and the timer
 * to make the game operate
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MissileCommand_winforms
{
    public partial class Form1 : Form
    {
        private System.Timers.Timer timer;
        private int level, missilesDropped, missilesStopped, missilesMissed, tickCount, ticksBetweenMissiles,
            playerMissiles;
        private List<Missile> missiles;
        private List<Explosion> explosions;
        private List<PictureBox> buildings;
        private List<MissileShape> missileBase;
        private bool gameInProgress, increasingSpeed, unlimitedMissiles, baseDestroyed;
        public Form1()
        {
            InitializeComponent();
            //MessageBox.Show(this.ClientSize.Width + " " + this.ClientSize.Height);
            DoubleBuffered = true;
            try
            {
                using (StreamReader sr = new StreamReader("highscore.txt"))
                {
                    highScore.Text = sr.ReadToEnd();
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("High score file could not be found for reading");
            }
        }

        public void timer_Elapsed(object sender, EventArgs e)
        {
            tickCount++;
            if (tickCount % ticksBetweenMissiles == 0 && missilesDropped < level * 10)
                AddMissile();
            Invalidate();
        }

        private void AddMissile()
        {
            Random rand = new Random();
            if(increasingSpeed)
                missiles.Add(new Missile(this.ClientSize.Width, this.ClientSize.Height, level, rand));
            else
                missiles.Add(new Missile(this.ClientSize.Width, this.ClientSize.Height, 1, rand));
            missilesDropped++;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Press OK to continue game", "Game Paused");
            timer.Start();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            if (ValidInput())
            {
                if (numMissBox.Text.Length == 0)
                {
                    playerMissiles = 0;
                    unlimitedMissiles = true;
                    missRemaining.Text = "UNLIMITED";
                }
                else
                {
                    unlimitedMissiles = false;
                    playerMissiles = int.Parse(numMissBox.Text) * 10;
                    missRemaining.Text = playerMissiles.ToString();
                }
                increasingSpeed = speedBox.Text == "Increasing";
                missilesDropped = missilesStopped = missilesMissed = tickCount = 0;
                ticksBetweenMissiles = 35;
                level = 1;
                missileBase = new List<MissileShape>();
                PlaceMissiles();
                buildings = new List<PictureBox>();
                ChooseBuildings();
                missiles = new List<Missile>();
                explosions = new List<Explosion>();
                startGame.Visible = false;
                numCitiesBox.Visible = false;
                numCitiesLabel.Visible = false;
                numMissBox.Visible = false;
                numMissLabel.Visible = false;
                speedBox.Visible = false;
                speedLabel.Visible = false;
                highScore.Visible = false;
                highScoreLabel.Visible = false;
                foreach (PictureBox pb in buildings)
                    pb.Visible = true;
                scoreLabel.Visible = true;
                levelLabel.Visible = true;
                missRemainingLabel.Visible = true;
                missRemaining.Visible = true;
                toolStripPause.Enabled = true;
                toolStripRestart.Enabled = true;
                toolStripQuit.Enabled = true;
                gameInProgress = true;
                timer = new System.Timers.Timer();
                timer.Interval = 35;
                timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
                timer.Start();
            }
        }

        private void PlaceMissiles()
        {
            for (int i = 0; i < 11; i++)
                missileBase.Add(new MissileShape(new Point(360 + i * 10, 427)));
        }

        private void ChooseBuildings()
        {
            int numBuildings = int.Parse(numCitiesBox.Text);
            if (buildings.Count < numBuildings)
                buildings.Add(building4);
            if (buildings.Count < numBuildings)
                buildings.Add(building5);
            if (buildings.Count < numBuildings)
                buildings.Add(building3);
            if (buildings.Count < numBuildings)
                buildings.Add(building6);
            if (buildings.Count < numBuildings)
                buildings.Add(building2);
            if (buildings.Count < numBuildings)
                buildings.Add(building7);
            if (buildings.Count < numBuildings)
                buildings.Add(building1);
            if (buildings.Count < numBuildings)
                buildings.Add(building8);
        }

        private bool ValidInput()
        {
            bool result = true;
            int tester;
            if (numCitiesBox.Text.Length == 0 || !int.TryParse(numCitiesBox.Text, out tester) ||
                tester < 1 || tester > 8)
                result = false;
            else if (numMissBox.Text.Length != 0 && (!int.TryParse(numMissBox.Text, out tester) || tester < 0))
                result = false;
            else if (speedBox.SelectedIndex == -1)
                result = false;
            return result;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (gameInProgress)
            {
                Graphics g = e.Graphics;
                DrawArea(g);
                for (int i = missiles.Count - 1; i >= 0; i--)
                {
                    missiles[i].Move(g);
                    if (missiles[i].GetEndPoint().Y >= this.ClientSize.Height - 100)//missile hit ground
                        MissileLanded(missiles[i]);
                }

                for (int i = explosions.Count - 1; i >= 0; i--)
                {
                    explosions[i].Grow(g);
                    for (int j = missiles.Count - 1; j >= 0; j--)
                    {
                        if (explosions[i].Contains(missiles[j].GetEndPoint()))
                        {
                            missiles.RemoveAt(j);
                            UpdateScore();
                            missilesStopped++;
                        }
                    }
                    if (explosions[i].Done)
                        explosions.RemoveAt(i);
                }

                for(int i = buildings.Count - 1; i >= 0; i--)
                {
                    for(int j = missiles.Count - 1; j >= 0; j--)
                    {
                        if (i >= 0 && buildings[i].Bounds.Contains(missiles[j].GetEndPoint()))
                        {
                            MissileLanded(missiles[j]);
                            buildings[i].Visible = false;
                            buildings.RemoveAt(i);
                            i--;
                        }
                    }
                }
                if (!baseDestroyed)
                    foreach (MissileShape ms in missileBase)
                        ms.Draw(g);
                if (buildings.Count == 0)
                    GameOver(g);
                if (missilesMissed + missilesStopped == level * 10)
                    LevelComplete();
            }
            base.OnPaint(e);
        }

        private void MissileLanded(Missile m)
        {
            explosions.Add(new Explosion(new RectangleF(m.GetEndPoint().X - 7.5f,
                            m.GetEndPoint().Y - 7.5f, 15, 15)));
            if (m.GetEndPoint().X > 360 && m.GetEndPoint().X < 460)
            {
                baseDestroyed = true;
                playerMissiles = 0;
                if(!unlimitedMissiles)
                    missRemaining.Text = "0";
            }
            missiles.Remove(m);
            missilesMissed++;
        }

        private void DrawArea(Graphics g)
        {
            g.FillRectangle(Brushes.DarkOliveGreen, 0, ClientSize.Height - 100, ClientSize.Width, 100);
        }

        private void LevelComplete()
        {
            timer.Stop();
            int bonusPoints = 50 * level * playerMissiles + 100 * level * buildings.Count;
            level++;
            levelLabel.Text = "Level " + level;
            missiles.Clear();
            if(increasingSpeed)
                ticksBetweenMissiles -= 2;            
            MessageBox.Show("Enemy Missiles Stopped: " + missilesStopped + Environment.NewLine + 
                "Enemy Missiles Missed: " + missilesMissed + Environment.NewLine + "Player Missiles Remaining: " +
               missRemaining.Text + Environment.NewLine +
               "Cities Remaining: " + buildings.Count + Environment.NewLine +
               "Bonus Points Earned: " + bonusPoints, "Level Complete");
            missilesDropped = missilesMissed = missilesStopped = tickCount = 0;
            baseDestroyed = false;
            scoreLabel.Text = (int.Parse(scoreLabel.Text) + bonusPoints).ToString();
            if (!unlimitedMissiles)
            {
                playerMissiles = int.Parse(numMissBox.Text) * level * 10;
                missRemaining.Text = playerMissiles.ToString();
            }
            timer.Start();
        }

        private void UpdateScore()
        {
            scoreLabel.Text = (int.Parse(scoreLabel.Text) + 100 * level).ToString();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (gameInProgress && (playerMissiles > 0 || unlimitedMissiles))
            {
                explosions.Add(new Explosion(new RectangleF(e.X - 7.5f, e.Y - 7.5f, 15, 15)));
                if (!unlimitedMissiles)
                {
                    playerMissiles--;
                    missRemaining.Text = playerMissiles.ToString();
                }
            }
        }

        private void toolStripQuit_Click(object sender, EventArgs e)
        {
            GameOver(CreateGraphics());
        }

        private void GameOver(Graphics g)
        {
            timer.Stop();
            gameInProgress = false;
            Invalidate();
            foreach (PictureBox pb in buildings)
                pb.Visible = false;
            levelLabel.Visible = false;
            scoreLabel.Visible = false;
            missRemainingLabel.Visible = false;
            missRemaining.Visible = false;
            bool newHighScore = int.Parse(scoreLabel.Text) > int.Parse(highScore.Text);
            if (newHighScore)
            {
                WriteHighScore();
                highScore.Text = scoreLabel.Text;
            }
            MessageBox.Show("Final Score: " + scoreLabel.Text +
                (newHighScore ? " (NEW HIGH SCORE)" : ""), "Game Over");
            Reset();                   
            toolStripPause.Enabled = false;
            toolStripQuit.Enabled = false;
            toolStripRestart.Enabled = false;
            highScoreLabel.Visible = true;
            highScore.Visible = true;
            numCitiesBox.Visible = true;
            numCitiesLabel.Visible = true;
            numMissBox.Visible = true;
            numMissLabel.Visible = true;
            speedBox.Visible = true;
            speedLabel.Visible = true;
            startGame.Visible = true;
        }

        private void Reset()
        {
            scoreLabel.Text = "0";
            levelLabel.Text = "Level 1";
            baseDestroyed = false;
        }

        private void toolStripRestart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Reset();
            startGame_Click(null, null);
        }

        private void WriteHighScore()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("highscore.txt", false)) 
                {
                    sw.WriteLine(scoreLabel.Text);
                }
            }
            catch(FileNotFoundException e)
            {
                MessageBox.Show("High score file could not be found for overwrite");
            }
        }


        private void toolStripHowToPlay_Click(object sender, EventArgs e)
        {
            if (timer != null)
                timer.Stop();
            MessageBox.Show("Choose the desired settings for the game and press Start Game" + Environment.NewLine
                + "Aim with your mouse and click to fire a missile" + Environment.NewLine +
                "Fire your missiles in front of enemy missiles to destroy them" + Environment.NewLine +
                "Your goal is to protect your cities and missile base from enemy missiles" + Environment.NewLine
                + "If your missile base is hit, you will lose all remaining missiles for that level " +
                "(unless you've selected unlimited missiles)" + Environment.NewLine +
                "The game ends when all your cities have been destroyed" + Environment.NewLine +
                "Points are awarded during the level for destroying enemy missiles, and bonus points " +
                "are given at the end of each level according to how many unused missiles you have left and " +
                "how many cities are still standing", "How to Play");
            if (gameInProgress)
                timer.Start();
        }

        private void toolStripDocumentation_Click(object sender, EventArgs e)
        {
            if (timer != null)
                timer.Stop();
            MessageBox.Show("Developed by Andrew Robinson" + Environment.NewLine +
                "Target .NET Framework: 4.5.2" + Environment.NewLine +
                "Application version: 1.0.0", "Documentation");
            if (gameInProgress)
                timer.Start();
        }
    }
}
