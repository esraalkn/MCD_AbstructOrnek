using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructOrnek
{
    public class Circle : Shape
    {

        private float  _radius;

        public float  Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        
        public Circle(float radius)
        {
            _radius = radius;
            
           
        }





        public override void CalculateArea()
        {
           this.Area=(_radius*_radius)*3.14f;
            Console.WriteLine("Area of Circle: " + Area);
        }

        public override void CalculatePerimeter()
        {
            this.Perimeter=2*3.14f*_radius;
            Console.WriteLine("Perimeter of Circle: " + Perimeter);
        }
    }
}
