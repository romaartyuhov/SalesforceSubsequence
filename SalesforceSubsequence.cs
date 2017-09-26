using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesforceTest
{
    class SalesforceSubsequence
    {

        static void Main()
        {
            int counter = 0, maxCounter = 0;

            StreamReader sr = new StreamReader("INPUT.TXT");
            String s = sr.ReadLine();
            sr.Close();
            for (int i = 0; i < s.Length; ++i)
            {
                if (s[i] == '1')
                {
                    ++counter;
                }
                else
                if (s[i] == '0')
                {
                    maxCounter = Math.Max(maxCounter, counter);
                    counter = 0;
                }
            }
            maxCounter = Math.Max(maxCounter, counter);


            StreamWriter sw = new StreamWriter("OUTPUT.TXT");
            sw.WriteLine(maxCounter);
            sw.Close();
        }
    }
}