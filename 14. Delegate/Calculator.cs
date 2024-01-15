using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._Delegate
{
    class Calculator
    {
        /* Calculator */

        double left;
        double right;
        Func<double, double, double> calc;

        public double Plus(double left, double right) { return left + right; }
        public double Minus(double left, double right) { return left - right; }
        public double Multi(double left, double right) { return left * right; }
        public double Divide(double left, double right) { return left / right; }
        public double Modify(double left, double right) { return left % right; }

        public void SetCommand(double left, char oper, double right)
        {
            this.left = left;
            this.right = right;

            switch (oper)
            {
                case '+':
                    this.calc = Plus;
                    break;
                case '-':
                    this.calc = Minus;
                    break;
                case '*':
                    this.calc = Multi;
                    break;
                case '/':
                    this.calc = Divide;
                    break;
            }
        }

        public double Equal()
        {
            return calc(left, right);
        }

        static void Main0()
        {
            Calculator cal = new Calculator();
            cal.SetCommand(2.5, '+', 3.2);
        }
    }
}
