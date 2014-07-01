using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberGenerator
{
    class Modgeneration
    {
        //Modular Pseudo number generation
        //in the form Xn+1 = (k * Xn + c) mod m
        int k;
        int x;
        int c;
        int m;
        int[] numbers;
        int seed;

        public Modgeneration()
        {

        }

        //
        public Modgeneration(int seed)
        {
            /* Things needed for a full period
             * c and m are relatively prime
             * k - 1 is divisible by all prime factors of m,
             * k - 1 is a multiple of 4 if m is a multiple of 4.
             */
            //2^8 or an "8-bit" number generator.`
            m = 1024;
            k = (seed * 4) + 1;
            //Since prime factorization of modular is just 2 eight times, any odd number should do.
            c = (seed * 2) + 1;
            x = seed;
            

        }

        //Object Constructor. Creates sets varibles that this class will use.
        public Modgeneration(int seed, int offset, int multiplyer, int modular)
        {
            //The variables
            x = seed;
            c = offset;
            k = multiplyer;
            m = modular;

        }

       
        public int NextNum()
        {
            //x becomes Xn+1
            x = ((k * x) + c) % m;
            return x;
        }

        public void Reseed(int seed)
    {
            //New initial value. Generator still works the same
        x = seed;

    }
        //Should always return a number greater than or equal to 0 but less than 1.
        public decimal NextDecimal()
        {
            decimal d;
            //(k * Xn + c) mod m divided by m. 
            x = ((k * x) + c) % m;
            d = (decimal)x / (decimal)m;

            return d;

        }

         //Property blocks may not be needed for the moment
        public int CurrentVal
        {
            get { return x; }
            set { x = value; }
        }

        public int Offset
        {
            get { return c; }
            set { c = value; }
        }

        public int Multiplyer
        {
            get {return k;}
            set {k = value;}
        }

        public int Mod
        {
            get { return m; }
            set { m = value; }
        }
         

       


    }

}
