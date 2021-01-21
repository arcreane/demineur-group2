using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Case : ElementsGrille
    {

        private string apparenceCase = "O";
        private int nombreBonbeAdj = 0;

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

        public override void découvreCase()
        {
            if (nombreBonbeAdj !=0)
            {
                apparenceCase = Convert.ToString(nombreBonbeAdj);
            }
            else
            {
                apparenceCase = " ";
            }
        }


        public override void Minedetecter() 
        {
            nombreBonbeAdj += 1;
        }

    }
}
