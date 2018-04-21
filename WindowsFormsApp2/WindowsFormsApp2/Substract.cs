using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Substract
    {
        public double substract(string expression)
        {
            double result = 0;


            string[] expressions = expression.Split('+');
            if (expressions.Length > 1)
            {
                result = 0;
                foreach (string expr in expressions)
                    result += substract(expr);
                return result;
            }
            expressions = expression.Split('-');
            if (expressions.Length > 1)
            {
                result = substract(expressions[0]);
                for (int i = 1; i < expressions.Length; i++)
                    result -= Convert.ToDouble(substract(expressions[i]));
                return result;
            }
            expressions = expression.Split('*');
            if (expressions.Length > 1)
            {
                result = 1;
                foreach (string expr in expressions)
                    result *= substract(expr);
                return result;
            }
            expressions = expression.Split('/');
            if (expressions.Length > 1)
            {
                result = substract(expressions[0]);
                for (int i = 1; i < expressions.Length; i++)
                    result /= substract(expressions[i]);
                return result;
            }

            if (!double.TryParse(expression, out result))
                throw new ArgumentException("Expression was not nummeric", "expression");


            return result;
        }
    }
}
