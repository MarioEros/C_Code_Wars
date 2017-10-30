using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas
{
    class Basic_Calculator
    {
        public static double Execute(double num1, char op, double num2)
        {
            List<char> simbolos = new List<char> { '+', '-', '*', '/' };
            if (simbolos.Contains(op))
            {
                if (op == '/' && num2 == 0) throw new ArgumentException();
                return (op == '+' ? num1 + num2 : op == '-' ? num1 - num2 : op == '*' ? num1 * num2 : num1 / num2);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
