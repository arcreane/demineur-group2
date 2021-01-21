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

            }
        }

        public void genererMine()
        {
            
            Random rand = new Random();
            
            for (int i = 0; i < 6; i++)
            {
                int nbr1 = rand.Next(0, 6);
                int nbr2 = rand.Next(0, 6);
                tabElements[nbr1][nbr2] = new Mine();
                Console.WriteLine($"x: {nbr1} y: {nbr2}" );
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
