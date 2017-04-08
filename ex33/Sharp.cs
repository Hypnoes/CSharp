using System;

namespace ex33
{
    interface ISharpArea
    {
        double area();
    }

    class Rectangle : ISharpArea
    {
        private double heigh;
        private double weight;

        public Rectangle(double h, double w)
        {
            heigh = h;
            weight = w;
        }

        public double area()
        {
            return heigh * weight;
        }
    }

    class Circle : ISharpArea
    {
        private double radium;

        public Circle(double r)
        {
            radium = r;
        }

        public double area()
        {
            return Math.PI * radium * radium;
        }
    }
}
