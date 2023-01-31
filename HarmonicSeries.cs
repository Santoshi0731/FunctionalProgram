using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_5
{
    public class HarmonicSeries
    {
        public static void HarmonicNo()
        {
            String symbol = "+";
            Console.WriteLine("Harmonic Series ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The series till " + n + "is :");

            for(int i=1; i<=n; i++) 
            {
                Console.Write("1/"+i+" ");
                Console.Write(symbol);
                if(i == n- 1) 
                {
                    symbol= "..";
                }

            }
        }
    }
}
