using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle : Geometry
    {
        private int centre;
        private int S;

        public Triangle(int triangle, int plosh)
        {
            GoTo = triangle;
            S = plosh;
        }

        protected override int GoTo
        {
            get { return centre; }
            set { centre = value; }
        }

        public override void prient()
        { 
            Console.WriteLine("Треугольник с площадью " + S +" C точкой в " + centre);
        }
    }

    class Circle : Geometry
    {
        private int centre;
        private int S;

        public Circle(int circle, int plosh)
        {
            GoTo = circle;
            S = plosh;
        }

        protected override int GoTo
        {
            get { return centre; }
            set { centre = value; }
        }

        public override void prient()
        {
            Console.WriteLine("Кружок с площадью "+ S + " C точкой в " + centre);
        }
    }
}
