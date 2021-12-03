using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructOrnek
{
    public class Rectangle : Shape
    {

        private float _height;

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private float _witdh ;

        public float Witdh 
        {
            get { return _witdh ; }
            set {  _witdh = value; }
        }

        public Rectangle(float height, float width)
        {
            _height = height;
            _witdh = width;
            var random = new Random();
            Console.BackgroundColor = (ConsoleColor)random.Next((int)ConsoleColor.Black, (int)ConsoleColor.Yellow);
        }

        public override void CalculateArea()
        {
            this.Area = _height*_witdh;
            Console.WriteLine("Area of Rectangle: " + Area);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter = 2*(_height+_witdh);
            Console.WriteLine("Perimeter of Rectangle: " + Perimeter);
        }
    }
}
