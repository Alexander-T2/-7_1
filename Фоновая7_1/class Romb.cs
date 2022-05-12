using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая7_1
{
    class Romb : Figure
    {
        private int height;
        private double alfa;
        public Romb(int width, double alfa) : base(width)
        {
            this.alfa = alfa;
            height = (int)(width * Math.Sin(alfa * 3.14 / 180));
        }
        public Romb() : base()
        {
            this.alfa = 40;
            height = (int)(10 * Math.Sin(alfa * 3.14 / 180));
        }
        override public double Alfa
        {
            get { return alfa; }
            set
            {
                try
                {
                    if (value >= 180 || value <= 0) throw new Exception("imposiible angle");
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
                return height == width & (int)alfa == 90;
            }
        }
        override public double Area()
        {
            return height * width;
        }
        override public int Perimetr()
        {
            return width * 4;
        }
        public override double Diagonal()
        {
            return width * Math.Sqrt(2 + 2 * Math.Cos(alfa * 3.14 / 180));
        }
    }
}
