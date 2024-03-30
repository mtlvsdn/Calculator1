using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1.Entities
{
    internal class Computation
    {
        private double result;

        public Computation()
        {
            this.result = 0;
        }

        public void add(double v1, double v2)
        {
            this.result = v1 + v2;
        }
        public void diff(double v1, double v2)
        {
            this.result = v1 - v2;
        }
        public void multiply(double v1, double v2)
        {
            this.result = v1 * v2;
        }
        public void divide(double v1, double v2)
        {
            this.result = v1 / v2;
        }
        public double getResult() { return this.result; }
    }
}
