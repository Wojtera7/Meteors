using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meteors
{
    class Calculator
    {


        public static void SetField(string[,] field, int turns, List<Pew> pew)
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


        public static void Update(List<Pew> pew)
        {


            for (int k = 0; k < pew.Count; k++)
            {

                pew[k].Update();

            }

        }




    }
}
