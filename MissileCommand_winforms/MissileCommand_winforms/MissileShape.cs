/*
 * Andrew Robinson
 * This class defines a MissileShape. This class is used to animate the missile base for the 
 * missile command game.
 */
using System.Drawing;

namespace MissileCommand_winforms
{
    class MissileShape
    {
        private Point p;

        public MissileShape(Point p)
        {
            this.p = p;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.LightSlateGray, 3);
            g.DrawLine(pen, p.X, p.Y, p.X, p.Y + 10);
            g.DrawLine(pen, p.X - 1.5f, p.Y + 7, p.X - 1.5f, p.Y + 13);
            g.DrawLine(pen, p.X + 1.5f, p.Y + 7, p.X + 1.5f, p.Y + 13);
        }
    }
}
