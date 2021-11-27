using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== Calculator ===============");
            var cycle = true;
            var ordcalc = new OrdinaryCalc();
            var advcalsc = new AdvancedCalc();
            while (cycle)
            {
                switch (Input("1 - Ordinary calc\n2 - Advanced calc\nOhter to exit: "))
                {
                    case "1":
                        var action = Input("Choose the action (+,=,*,/)");
                        double a, b;
                        try
                        {
                            a = Convert.ToDouble(Input("Enter the first number"));
                            b = Convert.ToDouble(Input("Enter the second number"));
                        }
                        catch { Console.WriteLine("Numbers was entred incorrectly"); }
                        switch (action) 
                        {
                            case "+":
                                Console.WriteLine($"Asnwer: {ordcalc.Add(a, b)}");
                                break;
                            case "-":
                                Console.WriteLine($"Asnwer: {ordcalc.Sub(a, b)}");
                                break;
                            case "*":
                                Console.WriteLine($"Asnwer: {ordcalc.Mul(a, b)}");
                                break;
                            case "/":
                                Console.WriteLine($"Asnwer: {ordcalc.Div(a, b)}");
                                break;
                            default:
                                Console.WriteLine("The action was chosen incorrectly");
                                break;
                        }
                        break;
                    case "2":
                        break;
                    default:
                        cycle = false;
                        break;
                }
            }
        }
        static string Input(string str)
        {
            Console.Write(str + ": ");
            return Console.ReadLine();
        }
    }
}
