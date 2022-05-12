using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая7_1
{
    class Rectangle : Figure
    {
        private int height;
        private double alfa = 90;
        public Rectangle(int height, int width) : base(width)
        {
            this.height = height;
        }
        public Rectangle() : base()
        {
            this.height = 10;
        }
        override public double Alfa
        {
            get { return alfa; }
            set
            {
                try
                {
                    if (value != 90) throw new Exception("only 90 degrees");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }
        }
        override public int Height
        {
            get { return height; }
            set
            {
                try
                {
                    if (value <= 0) throw new Exception("no 0 or lesser");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }
        }
        override public bool isQquare
        {
            get
            {
                return height == width;
            }
        }
        override public double Area()
        {
            return height * width;
        }
        override public int Perimetr()
        {
            return Height * 2 + Width * 2;
        }
        public override double Diagonal()
        {
            return Math.Sqrt(height * 2 + width * 2);
        }
    }
}
