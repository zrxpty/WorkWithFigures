using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithFigures.Main;

namespace WorkWithFigures.Figures
{
    public class Point: Figure
    {
        public Vector2D<float> Position { get; }

        public Point(float x, float y)
        {
            Position = new Vector2D<float>(x, y);
            Validate();
        }

        protected override string Draw()
        {
            Intersect();
            return $"point at ({Position.X}, {Position.Y})";
        }
        protected override void Intersect()
        {
            Console.WriteLine("The point cannot intersect the circle");
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
