using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Grille
    {
        private int nombreBombe = 6;
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

            for (int i = 0; i < longueur; i++)
            {
                tabElements[i] = new ElementsGrille[largeur];
                for(int j = 0; j< largeur; j++)
                {
                    tabElements[i][j] = new Case(i,j);
                }

            }
        }

        public void genererMine()
        {
            
            Random rand = new Random();
            
            for (int i = 0; i < nombreBombe; i++)
            {
                int nbr1 = rand.Next(0, longueur);
                int nbr2 = rand.Next(0, largeur);
                tabElements[nbr1][nbr2] = new Mine(nbr1,nbr2);
                for (int j = nbr1-1; j <= nbr1+1; j++)
                {
                    if (j>=0 && j< longueur)
                    {
                        if (j != nbr1)
                        {
                            tabElements[j][nbr2].Minedetecter();
                        }
                        if (nbr2 >0)
                        {
                            tabElements[j][nbr2 - 1].Minedetecter();
                        }
                        if (nbr2 < largeur - 1)
                        {
                            tabElements[j][nbr2 + 1].Minedetecter();
                        }
                    }
                 
                        
                        
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

        public void afficherContenu()
        {

        }

    }
}
