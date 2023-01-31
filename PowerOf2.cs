using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_5
{
    public class PowerOf2
    {

        public static void isPowerOfTwo()
        {
            
            bool t=false;
            int n = 4, pow = 0;
            int temp=0;

            while(temp<n)
            {
                temp = (int)(Math.Pow(2, pow));
                pow++;

                if(temp==n)
                {
                    t = true;
                }
            }
            if(t)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }

        }
    }
}
