using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructOrnek
{
    public class Square : Shape
    {

        private float _side;

        public float Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public Square(float Side)
        {
            _side = Side;
        }

        public override void CalculateArea()
        {
            this.Area = _side * _side;
            Console.WriteLine("Area of Square: " + Area);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 4 * _side;
            Console.WriteLine("Perimeter of Square: " + Perimeter);
        }
    }
}
