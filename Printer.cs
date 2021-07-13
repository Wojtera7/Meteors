using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteors
{
    class Printer
    {

        public static void DrawField(string[,] Field)
        {

            for (int i = 0; i < Field.GetLength(0); i++)
            {

                for (int j = 0; j < Field.GetLength(1); j++)
                {

                    Console.Write(Field[j, i]);

                }

                Console.WriteLine("");
            }

            Console.ReadLine();


        }






    }
}
