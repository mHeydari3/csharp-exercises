using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_exercises._04_CalculatorApp
{
    interface ICalculate
    {
        int Plus(int num1, int num2);
        int Minus(int num1, int num2);
        int Mutiple(int num1, int num2);
        int Divide(int num1, int num2);
    }
}
