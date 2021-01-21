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
            genererCase();
            genererMine();
            afficherGrille();
        }

        public void genererCase()
        {
            tabElements = new ElementsGrille[longueur][];

            for (int i = 0; i < 6; i++)
            {
                tabElements[i] = new ElementsGrille[largeur];
                for(int j = 0; j<6;j++)
                {
                    tabElements[i][j] = new Case();
                }

                if (i != longueur)
                {
                    Console.Write("\n");
                }
            }
        }

        public void genererMine()
        {
            tabElements = new ElementsGrille[longueur][];

            for (int i = 0; i < 6; i++)
            {
                tabElements[i] = new ElementsGrille[largeur];
                for (int j = 0; j < 6; j++)
                {
                    tabElements[i][j] = new Mine();
                }

                if (i != longueur)
                {
                    Console.Write("\n");
                }
            }
        }

        public void afficherGrille()
        {

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    tabElements[i][j].afficher();
                }

                if (i != longueur)
                {
                    Console.Write("\n");
                }
            }
        }

    }
}
