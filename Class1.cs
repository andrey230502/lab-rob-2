using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_rob_2
{
    class Class1
    {
        public static string MyConvert(string t, int a)
        {
            List<char> tnew = new List<char>();
            int count = 0;
            //for (int i = t.Length - 1; i >= 0; i--)
            for (int i = 0; i < t.Length; i++)
            {

               
                if (i % a == 0 && i != 0)
                {
                    tnew.Insert(i + count, ' ');
                    count++;
                   
                }
                tnew.Add(t[t.Length - 1 - i]);
            }

            
            tnew.Reverse();
            string str = new string(tnew.ToArray());
            return new string(tnew.ToArray());
        }
    }
}
