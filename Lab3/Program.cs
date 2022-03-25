using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3f
{
    internal class Program
    {
        public static Figure[] figures =
        {
            new Rectangle()
            {
                Name = "Квадрат 1",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50, Height = 50
            },
            new Rectangle()
            {
                Name = "Квадрат 2",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(60, 100),
                Width = 100, Height = 100
            },
            new Rectangle()
            {
                Name = "Прямоугольник 1",
                Color = System.Drawing.Color.Blue,
                Position = new System.Drawing.Point(200, 200),
                Width = 100, Height = 50
            },
            new Circle()
            {
                Name = "Круг",
                Color = System.Drawing.Color.Violet,
                Position = new System.Drawing.Point(300, 300),
                Raduis = 150
            },
            new Triangle()
            {
                Name = "Треугольник",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(100, 200),
                Height = 100, Bottom = 200
            },
            new Trapeze()
            {
                Name = "Трапеция",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(175,130),
                Bottom = 150, Height = 25, Top = 100
            },
            new Square()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.Purple,
                Position = new System.Drawing.Point(100,50),
                Side = 200
            },
            new Rhomb()
            {
                Name = "Ромб",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(400,500),
                Diagonalone = 150, Diagonaltwo = 200
            },
            new Parallelogram()
            {
                Name = "Параллелограмм",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(550,200),
                Side = 100, Height= 50
            },
            new Penta()
            {
                Name = "Пятиугольник",
                Color = System.Drawing.Color.Red,
                Position = new System.Drawing.Point(600,400),
                Side = 100
            },
            new Deca()
            {
                Name = "Десятиугольник",
                Color = System.Drawing.Color.Green,
                Position = new System.Drawing.Point(600,300), 
                Side = 100
            }

        };
        static void Main(string[] args)
        {
            Console.WriteLine("Лаба №3");

            Figure f = new Rectangle()
            {
                Name = "Квадрат",
                Color = System.Drawing.Color.DarkRed,
                Position = new System.Drawing.Point(30, 30),
                Width = 50,
                Height = 50
            };

            Console.WriteLine("Фигура: " + f.Name);
            Console.WriteLine("S = " + f.GetArea());
            Console.WriteLine("Цвет: " + f.Color);
            Console.WriteLine("Положение фигуры: " + f.Position);
            Console.WriteLine("Координаты центра: " + f.GetCenter());

            Form frm = new Form()
            {
                Text = "Лаба 3",
                Size = new System.Drawing.Size(800, 600),
                StartPosition = FormStartPosition.CenterScreen
            };
            frm.Paint += Frm_Paint;
            Application.Run(frm);
        }
        private static void Frm_Paint(object sender, PaintEventArgs e)
        {
            foreach (Figure f in figures)
            {
                f.Draw(e.Graphics);
            }
        }
    }
}
