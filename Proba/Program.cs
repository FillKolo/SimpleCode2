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

            string myArray = Console.ReadLine();

            string[] words = myArray.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            myArray = myArray.Replace("Петух", "петух");

            string alexNazi =  "петух";

            int countWorld = myArray.IndexOf(alexNazi);

            if (countWorld >=0)
            {
                Console.WriteLine("Петух обнаружен");
            }
            else
            {
                Console.WriteLine("Петух деактивирован");
            }
            Console.ReadLine();

            }
        }


    }


