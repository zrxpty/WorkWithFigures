using NetTopologySuite.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithFigures.Main;

namespace WorkWithFigures.Figures
{
    public class Rect : Figure
    {
        public Vector2D positionA { get; }
        public Vector2D positionB { get; }
        public Rect(float x1, float y1, float x2, float y2) {
            positionA = new Vector2D(x1, y1);
            positionB = new Vector2D(x2, y2);
        }
        protected override string Draw()
        {
            Intersect();
            return $"rect at ({positionA.X}, {positionA.Y}), ({positionB.X}, {positionB.Y})";
        }

        protected override void Intersect()
        {
            Console.WriteLine($"it is rect");
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
