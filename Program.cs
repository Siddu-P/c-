using System;

namespace simplecalc
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //take First number from the user
            Console.Write("Enter a num:");
            double a = Convert.ToDouble(Console.ReadLine());
            //take operator from user
            Console.Write("Enter a operator:");
            string op = Console.ReadLine();
            //take Second number from the user
            Console.Write("Enter a num:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (op=="+")
            {
                Console.WriteLine(a+b);
            }
            else if (op=="-")
            {
                Console.WriteLine(a - b);
            }
            else if (op == "*")
            {
                Console.WriteLine(a * b);
            }
            else if (op == "/")
            {
                Console.WriteLine(a / b);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
