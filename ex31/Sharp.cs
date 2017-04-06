using System;

namespace ex31
{
    abstract class Sharp
    {
        public abstract double area();
    }

    class Rectangle : Sharp
    {
        private double heigh;
        private double weight;

        public Rectangle(double h, double w)
        {
            heigh = h;
            weight = w;
        }

        public override double area()
        {
            return heigh * weight;
        }
    }

    class Circle : Sharp
    {
        private double r;

        public Circle(double radium)
        {
            r = radium;
        }

        public override double area()
        {
            return Math.PI * r * r;
        }
    }
}
