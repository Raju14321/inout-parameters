using System;

namespace inout_parameters.css
{
    class InOutparameters
    {
        public void Factorial(ref uint fact)
        {
            if (fact == 0 || fact == 1)
            {
                fact = 1;
            }
            else
            {
                uint result = 1;
                for (uint i = 2; i <= fact; i++)
                {
                    result = result * i;
                }
                fact = result;
            }
        }
        static void Main()
        {
            InOutparameters p = new InOutparameters();
            uint num = 5;
            Console.Write($"Factorial of {num} is: ");
            p.Factorial(ref num);
            Console.WriteLine(num);
            Console.ReadLine();
        }
    }
}
