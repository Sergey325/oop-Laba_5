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
            string action;
            double a = 0, b = 0;
            var ordcalc = new OrdinaryCalc();
            var advcalc = new AdvancedCalc();
            while (cycle)
            {
                switch (Input("1 - Ordinary calc\n2 - Advanced calc\nOther to exit"))
                {
                    case "1":
                        Console.WriteLine($"=== {ordcalc.Make} ===");
                        action = Input("Choose the action (+,-,*,/)");
                        try
                        {
                            a = Convert.ToDouble(Input("Enter the first number"));
                            b = Convert.ToDouble(Input("Enter the second number"));
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
                                    if (b != 0) Console.WriteLine($"Asnwer: {ordcalc.Div(a, b)}");
                                    else throw new Exception();
                                break;
                            default:
                                Console.WriteLine("The action was chosen incorrectly");
                                break;
                            }
                        }
                        catch 
                        { 
                            Console.WriteLine("Numbers was entred incorrectly");
                            break;
                        }
                        
                        break;
                    case "2":
                        Console.WriteLine($"=== {advcalc.Make} ===");
                        action = Input("Choose the action (+,-,*,/,sqrt)");
                        try
                        {
                            if(action == "sqrt") a = Convert.ToDouble(Input("Enter the number"));
                            else
                            {
                                a = Convert.ToDouble(Input("Enter the first number"));
                                b = Convert.ToDouble(Input("Enter the second number"));
                            }
                            switch (action)
                            {
                            case "+":
                                Console.WriteLine($"Asnwer: {advcalc.Add(a, b)}");
                                break;
                            case "-":
                                Console.WriteLine($"Asnwer: {advcalc.Sub(a, b)}");
                                break;
                            case "*":
                                Console.WriteLine($"Asnwer: {advcalc.Mul(a, b)}");
                                break;
                            case "/":
                                if (b != 0) Console.WriteLine($"Asnwer: {ordcalc.Div(a, b)}");
                                else throw new Exception();
                                break;
                            case "sqrt":
                                Console.WriteLine($"Asnwer: {advcalc.Sqrt(a)}");
                                break;
                            default:
                                Console.WriteLine("The action was chosen incorrectly");
                                break;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("Numbers was entred incorrectly");
                            break;
                        }
                        
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
