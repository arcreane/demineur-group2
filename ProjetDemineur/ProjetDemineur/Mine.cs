using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Mine : ElementsGrille
    {
        private char apparenceMineDepart = 'O';

        public Mine(int p_X, int p_Y)
        {
            coordX = p_X;
            coordY = p_Y;
            //Console.WriteLine($"Mine x: {coordX} y: {coordY}");
        }

        public override void afficher()
        {
            Console.Write(apparenceMineDepart);
        }
    }
}
