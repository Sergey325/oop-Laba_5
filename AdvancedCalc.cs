using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface IAdvancedCalc
    {
        double Sqrt(double a);
    }
    class AdvancedCalc : OrdinaryCalc, IAdvancedCalc
    {
        public double Sqrt(double a) => Math.Sqrt(a);
    }
}
