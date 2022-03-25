using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3f
{
    internal class Square : Figure
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return Side * Side;
        }
        public override Point GetCenter()
        {
            return new Point((int)(Position.X + Side / 2), (int)(Position.Y + Side / 2));
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Position.X, Position.Y, (int)Side, (int)Side); //отвечает за рисование квадрата

            gr.DrawString(GetCenter().ToString(), new Font("Arial", 9), Brushes.Black, GetCenter());
        }
    }
}
