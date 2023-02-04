using NetTopologySuite.Mathematics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFigures.Main
{
    public class Vector2D<T>
    {
        public const double Tolerance = 0.0001;

        public Vector2D(T x, T y)
        {
            X = x;
            Y = y;
        }

        public T X { get; }
        public T Y { get; }

        public static implicit operator Vector2D<T>(Vector2D v)
        {
            throw new NotImplementedException();
        }
    }
}
