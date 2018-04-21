using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class ResolveBrasket
    {
        private string Resolve(int openindex, int closeindex, string text)
        {
            string answer = Calculate(text.Substring(openindex + 1, closeindex - openindex - 1));
            return answer;
        }

        private string Calculate(string text)
        {
            
                double final = first(text);
                return final.ToString();

            
        }

        private double first(string text)
        {
            double answer = Convert.ToDouble(text);
            return answer;
        }
    }
}
