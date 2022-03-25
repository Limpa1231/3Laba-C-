using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3f
{
    internal class Trapeze : Figure
    {
        public int Top { get; set; }
        public int Bottom { get; set; }
        public int Height { get; set; }

        public override void Draw(Graphics gr)
        {
            PointF point1 = new PointF(Position.X, Position.Y);
            PointF point2 = new PointF(Position.X + ((Bottom - Top) / 2), Position.Y - Height);
            PointF point3 = new PointF(Position.X + Top + ((Bottom - Top) / 2), Position.Y - Height);
            PointF point4 = new PointF(Position.X + Bottom, Position.Y);

            PointF[] curvePoints =
            {
                 point1,
                 point2,
                 point3,
                 point4
            };

            gr.DrawPolygon(new Pen(Color), curvePoints); //отвечает за рисование квадрата

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override double GetArea()
        {
            return 0.5 * Top * Bottom;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Bottom / 2), (int)(Position.Y - Height / 2));
        }
    }
}
