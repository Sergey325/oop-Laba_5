using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Calc
    {
        public abstract double Add(double a, double b);
        public abstract double Sub(double a, double b);
        public double Mul(double a, double b) { return a * b; }
        public double Div(double a, double b) { return a / b; }
    }
    class OrdinaryCalc
    {

    }
}
