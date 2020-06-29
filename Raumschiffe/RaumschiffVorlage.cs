using System;
using System.Collections.Generic;
using System.Text;

namespace Raumschiffe
{
   
        class RaumschiffVorlage
        {



            private string schiffName;
            public int geschwindigkeit = 5;


        public void setzeName(string name)
        {


            schiffName = name;


        }    



        public void zeigeStatus()
        {

              Console.WriteLine("Name: {0}, Geschwindigkeit: {1}", schiffName, geschwindigkeit);



        }







        }
}
