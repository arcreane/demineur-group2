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
        private int nombreBonbeAdj = 0;

        public Case(int p_X, int p_Y)
        {
            coordX = p_X;
            coordY = p_Y;
            //Console.WriteLine($"Case x: {coordX} y: {coordY}");
        }

        public override void afficher()
        {
            if (nombreBonbeAdj !=0)
            {
                Console.Write(nombreBonbeAdj);
            }
            else
            {
                Console.Write(apparenceCase);
            }
            
        }
        public override void Minedetecter() 
        {
            nombreBonbeAdj += 1;
        }

    }
}
