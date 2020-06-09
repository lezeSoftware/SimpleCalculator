using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator // IF you use this source to make something of your own like this, please credit me
{
    class Program
    {
        private const string Title = "SimpleCalculator v1.1"; // i give 0 fucks about what this is

        static void Main(string[] args)
        {                 
            double val1 = 0, val2 = 0, res = 0;

            Console.WriteLine("Simple calculator written in C#. Made by nukiz.");
            Console.WriteLine("Initializing...");

            Console.Title = Title;

            Console.WriteLine("Succesfully Initialized! Press any key to continue.");
            Console.ReadLine();

            Console.Clear();

            int gamer = 69; // place own number if cared enough
            while (gamer <= 69) // place own number if cared enough
            {
                Console.Write("Specify the calculation with freespace between numbers and operation char:\n");
                string rawOperation = Console.ReadLine();
                string[] vals = rawOperation.Split(' ');
                //vals 1 = number 1
                //vals 2 = operator
                //vals 3 = number 2

                if(vals.Length>2)
                {
                    bool firstValIsValid = false;

                    try
                    {
                        val1 = Convert.ToDouble(vals[0]);
                        firstValIsValid = true;
                        val2 = Convert.ToDouble(vals[2]);
                    }
                    catch (FormatException)
                    {
                        if (firstValIsValid)
                        {
                            Console.Write("Check second given number!");
                        }
                        else
                        {
                            Console.Write("Check first given number!");
                        }
                    }

                    // Check if opChar is valid.
                    if (vals[1].Length == 1)
                    {
                        switch (vals[1])
                        {
                            case "+":
                                {
                                    res = val1 + val2;
                                    break;
                                }
                            case "-":
                                {
                                    res = val1 - val2;
                                    break;
                                }
                            case "*":
                                {
                                    res = val1 * val2;
                                    break;
                                }
                            case "/":
                                {
                                    res = val1 / val2;
                                    break;
                                }
                        }
                        Console.WriteLine("Result: " + res.ToString());
                    }
                }
                else
                {
                    Console.WriteLine("Check given input!");
                }
                
                /*

                Console.Write("Specify an number to calculate: "); // you can change the text
                double firstNum = Convert.ToDouble(Console.ReadLine());

                Console.Write("Specify an operator: "); // you can change the text
                string calculationOp = Console.ReadLine(); // variable (string) can be changed if fucks are given

                Console.Write("Specify the second number to calculate: "); // you can change text
                double secondNum = Convert.ToDouble(Console.ReadLine());

                if (calculationOp == "+")
                {
                    Console.WriteLine(firstNum + secondNum);
                }
                else if (calculationOp == "-")
                {
                    Console.WriteLine(firstNum - secondNum);
                }
                else if (calculationOp == "x")
                {
                    Console.WriteLine(firstNum * secondNum); // changing this shit doesn't do other than break the calculator.
                }
                else if (calculationOp == "d")
                {
                    Console.WriteLine(firstNum / secondNum);
                }
                else
                {
                    Console.WriteLine("Invalid Operator!");
                }

                Console.ReadLine();*/
            }

        }

    }    
}
