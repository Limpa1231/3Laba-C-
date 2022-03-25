using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab3f
{
    internal class Penta : Figure
    {
        public float Side { get; set; }

        public override double GetArea()
        {
            return (Side * Side) / 4 * Math.Sqrt(25 + 10 * Math.Sqrt(5));
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y));
        }
        public override void Draw(Graphics gr)
        {
            double angle = -Math.PI * 0.5;
            PointF point1 = new PointF(Position.X + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * 1 / 5) * Side), Position.Y + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * 1 / 5) * Side));
            PointF point2 = new PointF(Position.X + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * 2 / 5) * Side), Position.Y + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * 2 / 5) * Side));
            PointF point3 = new PointF(Position.X + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * 3 / 5) * Side), Position.Y + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * 3 / 5) * Side));
            PointF point4 = new PointF(Position.X + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * 4 / 5) * Side), Position.Y + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * 4 / 5) * Side));
            PointF point5 = new PointF(Position.X + (int)Math.Round(Math.Cos(angle + Math.PI * 2.0 * 5 / 5) * Side), Position.Y + (int)Math.Round(Math.Sin(angle + Math.PI * 2.0 * 5 / 5) * Side));

            PointF[] curvePoints =
            {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5
            };

            gr.DrawPolygon(new Pen(Color), curvePoints); //отвечает за рисование квадрата

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
