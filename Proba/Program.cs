using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proba
{

    internal class Programnet
    {

        static void FoundFirstArray(int[] myArray)

        {
            //Создаем изначальный массив и заполняем его случайными элементами
            int[] myArrayInitial = new int[10];
            Random random = new Random();

            for (int i = 0; i < myArrayInitial.Length; i++)
            {
                myArrayInitial[i] = random.Next(-5, 5);
            }

            int firstElement = myArrayInitial.FirstOrDefault();
            Console.WriteLine(firstElement);
        }

        

        static void Write(string ABC)

        {
            int boolStrPersonWrite = 0;
            int result = 0;
            while (boolStrPersonWrite == 0)


            {
                string strPersonWrite2 = Console.ReadLine();
                bool strPersonWrite22 = int.TryParse(strPersonWrite2, out result);
                if (strPersonWrite22 == true)
                {
                    Console.WriteLine("Вы успешно ввели количество, теперь задайте символ");
                    boolStrPersonWrite++;
                }
                else
                {
                    Console.WriteLine("Введите корректное целочисленное значение");
                }

            }


            int boolCharPersonWrite = 0;
            char result2 = ' ';
            while (boolCharPersonWrite == 0)
            {
                string charPersonWrite22 = Console.ReadLine();
                bool boolCharPersonWrite222 = char.TryParse(charPersonWrite22, out result2);
                if (boolCharPersonWrite222 == true)
                {
                    Console.Write("Все введено корректно. Итог вашей строки ");
                    boolCharPersonWrite++;
                }

                else
                {
                    Console.WriteLine("Необходимо ввести один символ");
                }    

            }

            for (int i = 0; i < result; i++)
            {
                Console.Write(result2);
            }


        }


        static void Main(string[] args)
        {
            /*
            string ABC = "Введите количество символов";
            Console.WriteLine("Введите количество символов");


            Write(ABC);
            Console.WriteLine("Пятух");  */



            int[] myArrayInitial2 = new int[4];

            FoundFirstArray(myArrayInitial2);


            Console.ReadLine();





        }


    }

}
