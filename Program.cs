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

                Calculator.Update(pew);

                pew.Add(new Pew(turns));

                turns++;

                Calculator.SetField(field, turns, pew);

                Printer.DrawField(field);





                if (turns >= 20)
                {
                    Lost = true;
                }

            }







        }
        



    }
}
