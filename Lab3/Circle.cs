using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3f
{
    internal class Circle : Figure
    {
        public int Raduis { get; set; }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(new Pen(Color), Position.X, Position.Y, Raduis, Raduis);
            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }

        public override double GetArea()
        {
            return 3.14 * Raduis * Raduis;
        }

        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Raduis / 2), (int)(Position.Y + Raduis / 2));
        }
    }
}
