using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{

    internal class Programnet
    {
        static void Main(string[] args)
        {

            int [] myArray = new int[]
            {
                1, 412, 4, 98, 76, 13, 14, 18, 32, 5
            };

            Array.Sort(myArray);

            int EvenNumber = 0;
            int OddNumber = 0;

            foreach (int i in myArray)
                if (i % 2 == 0)
                {
                    EvenNumber++;
                }
            else
                {
                    OddNumber++;  
                }

            int[] arrayEvenNumber = new int[EvenNumber];
            int[] arrayOddNumber = new int[OddNumber];
            int j = 0;
            int k = 0;

            foreach (var item in myArray)
            {
                if (item % 2 == 0)
                {
                    arrayEvenNumber[j] = item;
                    j++;
                }
                else
                {
                    arrayOddNumber[k] = item;
                    k++;
                }
            }
            Console.WriteLine(arrayEvenNumber);
            Console.WriteLine(arrayOddNumber);
        }


    }

}
