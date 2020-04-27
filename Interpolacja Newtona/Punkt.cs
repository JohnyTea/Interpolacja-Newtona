using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpolacja_Newtona
{
    public class Punkt
    {
        private float x;
        private float y;

        public float X
        {
            get { return x; }
            set { x = value; }
        }
        public float Y
        {
            get { return y; }
            set { y = value; }
        }

        public Punkt(float x, float y)
        {
            X = x;
            Y = y;
        }

    }
}