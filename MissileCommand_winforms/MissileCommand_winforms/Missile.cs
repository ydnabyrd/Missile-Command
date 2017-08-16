/*
 * Andrew Robinson
 * This class defines a Missile. Instances of this class are used to represent and animate enemy
 * missiles in the missile command game.
 */
using System;
using System.Drawing;

namespace MissileCommand_winforms
{
    class Missile
    {
        private Point p1, p2;
        private int ySpeed, xSpeed;
        private bool exploded;
        public Missile(int width, int height, int maxSpeed, Random rand)
        {
            p2.X = p1.X = rand.Next(10, width - 9);
            p2.Y = p1.Y = 0;
            ySpeed = rand.Next(1, maxSpeed);
            int numTicks = height / ySpeed;
            xSpeed = rand.Next(p1.X / numTicks * -1, 1 + (width - p1.X) / numTicks);
        }

        public void Move(Graphics g)
        {
            if (!exploded)
            {
                p2.X += xSpeed;
                p2.Y += ySpeed;
                g.DrawLine(new Pen(Color.Goldenrod, 3), p1, p2);
            }
        }

        public Point GetEndPoint()
        {
            return p2;
        }

        public override string ToString()
        {
            return p1.X + ", " + p1.Y + " " + p2.X + ", " + p2.Y + " " + xSpeed + " " + ySpeed;
        }

        public bool Exploded
        {
            get { return exploded; }
            set { if (value) exploded = true; }
        }
    }
}
