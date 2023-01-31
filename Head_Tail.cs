using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram_5
{
    public class Head_Tail
    {
        public static void HeadTail()
        {
            int count = 0;
            int tails = 0;
            int heads = 0;

            while (count < 10)
            {
                Random rnd = new Random();
                int result = rnd.Next(0, 2);
                if (result == 1)
                {
                    Console.WriteLine("Tails!");
                    tails = tails + 1;
                    count = count + 1;


                }
                else if (result == 0)
                {
                    Console.WriteLine("Heads!");
                    heads = heads + 1;
                    count = count + 1;



                }
            }
            Console.WriteLine("Heads = " + heads + "Tails = " + tails + " Counts = " + count);
            Console.ReadLine();
            
            double percentHeads = (heads /  10) * 100;
            double percentTails = (10 - tails) / 10 * 100;

            Console.WriteLine("The Persentage is : ", percentHeads);
            Console.WriteLine("The Persentage is : ", percentTails);
        }
    }
}
