using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNA_harming_distance
{
    internal class Program
    {
       
       // function to calculate
        // Hamming distance
        static int Hammingdist(String str1,
                               String str2)
        {
            int i = 0, count = 0;
            while (i < str1.Length)
            {
                if (str1[i] != str2[i])
                    count++;
                i++;
            }
            return count;
        }

       
        public static void Main()
        {
            Console.WriteLine("din første string");
            String str1 = Console.ReadLine();
            Console.WriteLine("din anden string");
            String str2 = Console.ReadLine();
            
                

                Console.Write("der er ");
                Console.Write(Hammingdist(str1, str2));
                Console.Write(" harmin distance mellem de to DNA strings");
                Console.ReadKey();
            
            
        }
    }
}
