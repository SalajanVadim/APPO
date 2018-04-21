using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class RemoveBrasket
    {
        public string RemoveBrackets(string text)
        {
            while (text.Contains('(') && text.Contains(')'))
            {
                int openindex = 0;
                int closeindex = 0;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == '(')
                    {
                        openindex = i;
                    }
                    if (text[i] == ')')
                    {
                        closeindex = i;
                        text = text.Remove(openindex, closeindex - openindex + 1).Insert(openindex, Resolve(openindex, closeindex, text));
                        break;
                    }
                }
            }return text;
            
        }

        private string Resolve(int openindex, int closeindex, string text)
        {
            throw new NotImplementedException();
        }
    }
}
