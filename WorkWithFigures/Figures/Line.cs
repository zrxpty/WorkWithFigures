using NetTopologySuite.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkWithFigures.Main;

namespace WorkWithFigures.Figures
{
    public class Line : Figure
    {
        public Vector2D<float> Position { get; }
        Point _point1 { get; }
        Point _point2 { get; }

        public Line(float x, float y, float x1, float y1)
        {
            Point point = new Point(x,y);
            _point1= new Point(x, y);
            _point2= new Point(x1, y1);
            Position = new Vector2D();
        }
            
            

        protected override string Draw()
        {
            return $"line have point 1 {_point1} and point 2 {_point2}";
        }

        protected override void Intersect()
        {
            Console.WriteLine($"Line");
        }

        protected override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
