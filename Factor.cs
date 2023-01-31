using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_5
{
    public class Factor
    {
        public static void Factor1()
        {
            int n = 7;
            int result = 1;
            
            for(int i=1; i<=n; i++) 
            {
                result=result*i;
            }
            Console.WriteLine("The factor of "+ n + "is : ",result);
        }
    }
}
