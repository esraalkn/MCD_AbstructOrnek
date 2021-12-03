using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_AbstructOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle R1 = new Rectangle(3f,5f);            
            R1.CalculateArea();
            R1.CalculatePerimeter();

            Circle C1 = new Circle(3f);
            C1.CalculateArea();
            C1.CalculatePerimeter();

            Square S1 = new Square(5f);
            S1.CalculateArea();
            S1.CalculatePerimeter();

            Console.ReadKey();
        }
    }
}
