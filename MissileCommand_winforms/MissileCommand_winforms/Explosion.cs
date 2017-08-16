/*
 * Andrew Robinson
 * This class defines an explosion. This class is instantiated when the user clicks on the form,
 * or when an enemy missile lands in the missile command game.
 */
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace MissileCommand_winforms
{
    class Explosion
    {
        private RectangleF rect;
        private bool done;
        public Explosion(RectangleF rect)
        {
            this.rect = rect;
            try
            {
                using (SoundPlayer sound = new SoundPlayer("explosion.wav"))
                    sound.Play();
            }
            catch(Exception e)
            {
                MessageBox.Show("Could not play sound");
            }
        }

        public void Grow(Graphics g)
        {
            if(!done)
            {
                rect.Height += 3.5f;
                rect.Width += 3.5f;
                rect.X -= 1.75f;
                rect.Y -= 1.75f;
                g.FillEllipse(new SolidBrush(Color.Red), rect);
                if (rect.Height >= 70)
                    done = true;
            }
        }

        public bool Done { get { return done; } }

        public bool Contains(Point p)
        {
            return rect.Contains(p);
        }
    }
}
