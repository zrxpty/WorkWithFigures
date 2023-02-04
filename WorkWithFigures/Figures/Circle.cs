using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithFigures.Main;

namespace WorkWithFigures.Figures
{
    public class Circle : Figure
    {
        public Vector2D<float> Position { get; }
        public double Radius { get; }
        public Circle(float x, float y, double radius)
        {
            Position = new Vector2D<float>(x, y);
            Radius = radius;
            Validate();
        }

        protected override string Draw()
        {
            Intersect();
            return $"circle at {Position.X} {Position.Y}, radius = {Radius}";
        }

        protected override void Intersect()
        {
            Console.WriteLine($"The line and the circle have intersection at {Position.X}, {Radius}");
        }

        protected override void Validate()
        {
            if (Radius < 0)
            {
                throw new ArgumentException("Radius cannot be negative");
            }
        }
    }
}
