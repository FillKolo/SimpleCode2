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
            int[] myArray = new int[5] {5,4,3,1,2};
            Random random = new Random();
            int conutValueMax = 0;
            int conutValueMin = 0;

            foreach (int item in myArray)
            {
                if (item <= myArray.Last())
                {
                     conutValueMax++;
                }

                if (item <= myArray.First() & item < myArray.Last())
                {
                    conutValueMin++;
                }    
            }


            if (conutValueMax == myArray.Length)
            {
                Console.WriteLine("Массив задан упорядочно по возрастанию");
            }    

            if (conutValueMin == myArray.Length)
            {
                Console.WriteLine("Массив задан упорядочно по убыванию");
            }    

            if (myArray.Length > conutValueMax & myArray.Length > conutValueMin)
            { 
                Console.WriteLine("Массив задан хаотично");
            }



            Console.ReadLine();

            /*
for (int i = 0; i < myArray.Length; i++)
{
    myArray[i] = random.Next(5);
} */

            /*
            string words = Console.ReadLine();
 
            int counterVowel = 0;
            int value = 0;
          
            string [] words2 = words.Split('a', 'y', 'i', 'u', 'o', 'e');
            if (words2[words2.Length-1] == "")
            {
                counterVowel = words.Length - (words2.Length-1);
                
            }
            else
            {
                counterVowel = words.Length - words2.Length;
                
            }
            
            Console.WriteLine("Количество гласных " + counterVowel);
            Console.WriteLine("ПРоцент соотношения " + value);
            Console.ReadLine(); */


        }


    }

}
