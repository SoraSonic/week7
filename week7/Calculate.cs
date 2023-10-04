using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    class Calculate
    {
        float a, b;

        public float B
        {
            get { return b; }
            set { b = value; }
        }

        public float A
        {
            get { return a; }
            set { a = value; }
        }

        public Calculate()
        {
            A = B = 0;
        }
        public Calculate(float a, float b)
        {
            A = a;
            B = b;
        }
        public float Plus()
        {
            return A + B;
        }
        public float Minus()
        {
            return A - B;
        }
        public float Multiply()
        {
            return A* B;
        }
        public float Divide()
        {
            return A / B;
        }
    }
}
