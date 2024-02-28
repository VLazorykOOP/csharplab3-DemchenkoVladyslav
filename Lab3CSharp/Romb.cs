using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3CSharp
{
    class Romb
    {
        protected int a;
        protected int d1;
        private int color;

        public Romb(int side, int diagonal, int color)
        {
            a = side;
            d1 = diagonal;
            this.color = color;
        }
        ~Romb()
        {
            Console.WriteLine("Видалено ромб");
        }
        public void DisplayLengths()
        {
            Console.WriteLine($"Сторона ромба: {a}, Діагональ ромба: {d1}");
        }

        public int CalculatePerimeter()
        {
            return 4 * a;
        }

        public double CalculateArea()
        {
            return 0.5 * a * d1;
        }

        public bool IsSquare()
        {
            return 2 * a * a == d1 * d1;
        }

        public int Side
        {
            get { return a; }
            set { a = value; }
        }

        public int Diagonal
        {
            get { return d1; }
            set { d1 = value; }
        }

        public int Color
        {
            get { return color; }
        }
    }
}
