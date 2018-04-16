using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Resistor2Calculate
{
    class Calculation
    {
        private bool paraSer;
        private double res1;
        private double res2;

        public Calculation()
        {
            paraSer = true;
            res1 = 100;
            res2 = 100;
        }
        public void setParaSer(bool parallelOderSeriell)
        {
            this.paraSer = parallelOderSeriell;
        }
        public void setRes1(int resistor1)
        {
            this.res1 = resistor1;
        }
        public void setRes2(int resistor2)
        {
            this.res2 = resistor2;
        }

        public double getResistance()
        {
            double resistor;
            if (paraSer)
                resistor = res1 * res2 / (res1 + res2);
            else
                resistor = res1 + res2;
            return (resistor);
        }

    }
}
