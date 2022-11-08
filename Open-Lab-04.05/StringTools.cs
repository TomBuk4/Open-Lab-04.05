using System;
using System.Drawing;
using System.Text;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {

            string nChars = string.Empty;
            foreach(char i in orig)
            {
                for(int j = 0; j < n; j++)
                {
                    nChars += i;
                }
                
            }
            return nChars;
        }
    }
}
