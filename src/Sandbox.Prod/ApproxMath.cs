using System;

namespace Sandbox.Prod 
{
    public static class ApproxMath 
    {
        public const double PREC = .000001;
        public static double approxSQRT(double s)
        {
            double g = 1;
            while((Math.Abs(s-(g*g)))> PREC)
            {
                g = improveGuess(g,s);
            }
            return g;
        }
        public static double improveGuess(double g, double s)
        {
            return ((g+(s/g))/2);
        }
    
    }

}

