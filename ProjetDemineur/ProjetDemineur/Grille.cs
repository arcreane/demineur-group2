using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Grille
    {

        private int longueur;
        private int largeur;
        
        private ElementsGrille[][] tabElements;


        public Grille()
        {

            longueur = 6;
            largeur = 6;
            Console.WriteLine("la grille est de taille "+longueur+"*"+largeur+ " ");
            genererGrille();
        }

        public void genererGrille()
        {
            tabElements = new ElementsGrille[longueur][];

            for (int i = 0; i < 6; i++)
            {
                tabElements[i] = new ElementsGrille[largeur];
                for(int j = 0; j<6;j++)
                {
                    //Case tabGrille[i][j] = tabElements[0];
                    tabElements[i][j] = new Case();
                }

                if (i != longueur)
                {
                    Console.Write("\n");
                }
            }
        }

    }
}
