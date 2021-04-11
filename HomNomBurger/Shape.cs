using System;
using System.Collections.Generic;
using System.Text;

namespace HomNomBurger
{
    public abstract class Shape
    {
        public IShapeColor Color { get; set; }
        public abstract void Draw();
    }
}
