using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Фоновая7_1
{
    abstract class Figure
    {
        protected string name;
        protected int width;
        public Figure()
        {
            width = 10;
        }
        public Figure(int width)
        {
            this.width = width;
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                try
                {
                    if (value <= 0) throw new Exception("can't be 0 or lesser");
                    width = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e}");
                }
            }
        }
        abstract public int Height
        {
            get;
            set;
        }
        abstract public double Alfa
        {
            get;
            set;
        }
        abstract public bool isQquare
        {
            get;
        }
        abstract public double Area();
        abstract public int Perimetr();
        abstract public double Diagonal();
    }
}
