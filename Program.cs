using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        private const string Title = "SimpleCalculator v1";

        static void Main(string[] args)
        {
            Console.WriteLine("Simple calculator written in C#. Made by nukiz.");
            Console.WriteLine("Initializing...")

            ; Console.Title = Title;

            Console.WriteLine("Succesfully Initialized! Starting...");




            Console.Clear();

            Console.Write("Specify an number to calculate: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Specify an operator: ");
            string calculationOp = Console.ReadLine();

            Console.Write("Specify the second number to calculate: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            if (calculationOp == "+)
            {
                Console.WriteLine(firstNum + secondNum);
            } else if (calculationOp == "-") {
                Console.WriteLine(firstNum - secondNum);
            }
            else if (calculationOp == "x")
            {
                Console.WriteLine(firstNum * secondNum);
            }
            else if (calculationOp == "d")
            {
                Console.WriteLine(firstNum / secondNum);
            }
            else 
            {
                Console.WriteLine("Invalid Operator!");
            }

            Console.ReadLine();



        }


        

        

        
    }    
}
