using System;

namespace ex22
{
    class Car
    {
        private string manufacture { get; }
        private string model { get; }
        private string color { get; }
        private int doors { get; }
        private int maxspeed { get; }

        public Car(string s)
        {
            manufacture = s;
        }

        public Car(string m, string mo, string c, int d, int mx)
        {
            manufacture = m;
            model = mo;
            color = c;
            doors = d;
            maxspeed = mx;
        }

        public void speedUp()
        {
            return;
        }

        public void speedUp(int i)
        {
            Console.Beep();
            return;
        }

        public void speedDown()
        {
            return;
        }

        public void speedDown(int i)
        {
            Console.Beep();
            return;
        }
    }
}
