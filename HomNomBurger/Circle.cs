using System;
using System.Collections.Generic;
using System.Text;

namespace HomNomBurger
{
    public class Circle : Shape
    {
        public string ColorValue { get; set; }
        public Circle(string colorValue)
        {
            this.ColorValue = colorValue;
        }
        public override void Draw()
        {
            this.Color.Paint($"Circle with {this.ColorValue} Color");
        }
    }
}
