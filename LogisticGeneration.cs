using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGenerator
{
    class LogisticGeneration
    {
        //Logistic number generator
        //Xn+1 = r * Xn(1 - Xn)
        // Yn = (Xn - a)/(b-a)

        //(a,b) is the range of the generator
        //Yn is the ouput
        decimal r;
        decimal x;
        decimal a;
        decimal b;
        decimal Yn;

        public LogisticGeneration()
        {

        }

        public LogisticGeneration(decimal multiplyer, decimal seed, decimal min, decimal max)
    {
        //The varibles
        r = multiplyer;
            //Must be between 1 and 0
        x = seed;
        a = min;
        b = max;

    }

        public decimal nextNum()
        {
            decimal xn;

            xn = r * x * (1 - x);

            return (xn - a) / (b - a);

        }

    }
}
