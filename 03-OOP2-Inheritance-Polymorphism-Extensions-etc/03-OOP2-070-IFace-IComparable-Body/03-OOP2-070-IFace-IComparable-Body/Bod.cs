using System;

namespace Interfaces {

    class Bod
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Bod(double x, double y) {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return string.Format("Bod [{0};{1}]", this.X, this.Y);
        }

        public double VzdalenostOdStredu() {
            return Math.Sqrt(this.X * this.X + this.Y * this.Y);
        }
    }
}