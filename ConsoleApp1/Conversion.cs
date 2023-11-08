using System;

namespace Converter
{
    internal class Conversion
    {
        public int x;
        public int y;


        public Conversion(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Increment() { x++; y++; }

        public void Decrement() { x--; y--; }

        public int GetX() { return x; }
    }
}
