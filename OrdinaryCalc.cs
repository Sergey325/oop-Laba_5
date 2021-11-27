using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Calc
    {
        public string Make { get => GetType().Name; }
        public abstract double Add(double a, double b);
        public abstract double Sub(double a, double b);
        public abstract double Mul(double a, double b);
        public abstract double Div(double a, double b);

        //public double Add(double a, double b) => a + b;
        //public double Sub(double a, double b) => a - b;
        //public double Mul(double a, double b) => a * b;
        //public double Div(double a, double b) => a / b;
    }
    class OrdinaryCalc : Calc
    {
        public override double Add(double a, double b) => a + b;
        public override double Sub(double a, double b) => a - b;
        public override double Mul(double a, double b) => a + b;
        public override double Div(double a, double b) => a - b;
    }
}
