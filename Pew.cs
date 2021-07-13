using System;
using System.Collections.Generic;
using System.Text;

namespace Meteors
{
    class Pew
    {

        public int Xpos { get; set; }
        public int Ypos { get; set; }
        public int ID { get; set; }

        public Random rand = new Random();


        public Pew(int id)
        {
            ID = id;
            Xpos = rand.Next(9);
            Ypos = 0;


        }


        public void Update()
        {

            Ypos++;
            if (Ypos == 10)
            {
                Ypos = 0;
            }

        }



    }
}
