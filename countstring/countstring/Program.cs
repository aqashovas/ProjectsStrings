using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countstring
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string str = Console.ReadLine();

          
               str= str.TrimStart(' ');
            str = str.TrimEnd(' ');

            char[] strarray = new char[500];
            int count = 0;
            int len = str.Length;
            str.CopyTo(0, strarray, 0, len);
            for (int i = 0;  i < str.Length;  i++)
            {
                
                if (strarray[i] == ' ')
                {
count++;
                }
                if(strarray[i]==' ' && strarray[i + 1] == ' ')
                {
                    count--;
                }
                
                    
              
            }
           
            Console.WriteLine(count+1);
            Console.ReadLine();

           
            
        }
    }
}
