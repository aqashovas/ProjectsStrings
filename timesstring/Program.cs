using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timesstring
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            
            string sentence =Console.ReadLine();
            string str = Console.ReadLine();

           

            for (int i = 0; i <= sentence.Length; i++)
            {
                int index = sentence.IndexOf(str);
                string sn = sentence.Remove(index, str.Length);
                sentence = sn;
                count++;
                if (sentence.IndexOf(str) < 0)
                {
                    break;
                }
                
               
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
