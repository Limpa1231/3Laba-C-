using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3f
{
    internal class Parallelogram : Figure
    {
        public float Side { get; set; }
        public float Height { get; set; }

        public override double GetArea()
        {
            return Side * Height;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side), (int)(Position.Y - Height / 2));
        }
        public override void Draw(Graphics gr)
        {
            PointF point1 = new PointF(Position.X, Position.Y);
            PointF point2 = new PointF(Position.X + Side, Position.Y - Height);
            PointF point3 = new PointF(Position.X + Side + Side, Position.Y - Height);
            PointF point4 = new PointF(Position.X + Side, Position.Y);

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
    }
}
