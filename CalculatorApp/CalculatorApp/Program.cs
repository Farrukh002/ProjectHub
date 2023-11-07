using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CalculatorApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("\t\t\t\t Calculator \r");
            Console.WriteLine("\t\t---------------------------------------------\r");
            while (true)
            {
                Typing();
                
                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Press any key to exit");
                    break;
                    
                }
                else
                {
                   
                        Typing();
     
                }
                
            }

            Console.ReadKey();
        }

        public static void Typing()
        {
 
            double firstNum;
            double secondNum;
            string ops;
            double result;
            while (true)
            {
                Console.WriteLine("Enter first number");
                if (double.TryParse(Console.ReadLine(), out firstNum))
                {
                    while (true)
                    {
                        Console.WriteLine("Chose the operator: (+, -, *, /, %)");
                        ops = Console.ReadLine();
                        
                        if (ops == "+" || ops == "-" || ops == "*" || ops == "/" || ops == "%")
                        {
                            Console.WriteLine("Enter second number");

                            while (true)
                            {
                                if (double.TryParse(Console.ReadLine(), out secondNum))
                                {
                                    if (ops == "+")
                                    {
                                        result = firstNum + secondNum;
                                        Console.WriteLine("Result: {0}", result);
                                    }
                                    if (ops == "-")
                                    {
                                        result = firstNum - secondNum;
                                        Console.WriteLine("Result: {0}", result);
                                    }
                                    if (ops == "*")
                                    {
                                        result = firstNum * secondNum;
                                        Console.WriteLine("Result: {0}", result);
                                    }
                                    if (ops == "/")
                                    {
                                        result = firstNum / secondNum;
                                        Console.WriteLine("Result: {0}", result);
                                    }
                                    if (ops == "%")
                                    {
                                        result = firstNum % secondNum;
                                        Console.WriteLine("Result: {0}", result);
                                    }
                                    goto LoopEnd;
                                    
                                }
                                else
                                {
                                    Console.WriteLine("Use only numbers");
                                }
                            }                            
                        }
                        else
                        {
                            Console.WriteLine("Use only above mentioned operators");
                        }                   
                    }    
                }
                else
                {
                    Console.WriteLine("Use only numbers please");
                }  
            }
            LoopEnd:
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Try again? (y/n)");
        }

        
    }
}
