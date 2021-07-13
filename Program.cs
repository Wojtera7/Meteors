using System;
using System.Collections.Generic;

namespace Meteors
{
    class Program
    {
        static bool Lost = false;
        static int turns = 0;
        static List<Pew> pew = new List<Pew>();
        static string[,] field = new string[10, 10];


        static void Main(string[] args)
        {

            while (!Lost)
            {

                pew.Add(new Pew(turns));

                for (int k = 0; k < pew.Count; k++)
                {

                    pew[k].Update();

                }

                SetField();

                DrawField();

                Console.ReadLine();



                turns++;

                if (turns >= 20)
                {
                    Lost = true;
                }

            }







        }

        public static void SetField()
        {
            Console.Clear();

            for (int i = 0; i < field.GetLength(0); i++)
            {

                for (int j = 0; j < field.GetLength(1); j++)
                {

                    field[i, j] = " ";


                }


            }


            for (int l = 0; l < turns; l++)
            {

                field[pew[l].Xpos, pew[l].Ypos] = "#";


            }


        }

        public static void DrawField()
        {

            for (int i = 0; i < field.GetLength(0); i++)
            {

                for (int j = 0; j < field.GetLength(1); j++)
                {

                    Console.Write(field[j, i]);

                }

                Console.WriteLine("");
            }




        }






    }
}
