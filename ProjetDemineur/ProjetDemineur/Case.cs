using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Case : ElementsGrille
    {

        private char apparenceCase = 'O';


        public Case(int p_X, int p_Y)
        {
            coordX = p_X;
            coordY = p_Y;
            //Console.WriteLine($"Case x: {coordX} y: {coordY}");
        }

        public override void afficher()
        {
            Console.Write(apparenceCase);
        }

    }
}
