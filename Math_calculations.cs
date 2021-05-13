using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Math_calculations
    {
        public double firsteq(double x)
        {
            if (x > 0&&x!=Math.PI/2)
            {
                return 100 * Math.Tan(x) * Math.Sqrt(x) / x;
            }
            throw new NotImplementedException();
        }
        public double secondeq(double x)
        {
            return 2*Math.Sin(x)-4;
           
            throw new NotImplementedException();
        }
    }
}
