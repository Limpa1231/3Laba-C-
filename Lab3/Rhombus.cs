using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3f
{
    internal class Rhomb : Figure
    {
        public float Diagonalone { get; set; }
        public float Diagonaltwo { get; set; }

        public override double GetArea()
        {
            return (Diagonalone * Diagonaltwo) / 2;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X), (int)(Position.Y - Diagonaltwo / 2));
        }
        public override void Draw(Graphics gr)
        {
            PointF point1 = new PointF(Position.X, Position.Y);
            PointF point2 = new PointF(Position.X - Diagonalone / 2, Position.Y - Diagonaltwo / 2);
            PointF point3 = new PointF(Position.X, Position.Y - Diagonaltwo);
            PointF point4 = new PointF(Position.X + Diagonalone / 2, Position.Y - Diagonaltwo / 2);

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
