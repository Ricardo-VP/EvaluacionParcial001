using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluacionParcial001.clases
{
    class Ej1
        {
        public static double formula()
        {
            double s = 0;
            int i = 1;
            int j = 5;
            while (i <= 5)
            {
                while(j >= 1)
                {
                    s += Math.Pow(2, i) * factorial(j);
                    j--;
                    i++;
                }
            }
            return s;
        }

        static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return n;
            }
        }
    }

    

}
