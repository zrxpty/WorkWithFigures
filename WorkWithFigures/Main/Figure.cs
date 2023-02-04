using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithFigures.Main
{
    public abstract class Figure
    {
        private readonly string _draw;

        protected Figure()
        {
            _draw = Draw();
        }

        protected abstract void Validate();
        protected abstract void Intersect();
        protected abstract string Draw();
    }
}
