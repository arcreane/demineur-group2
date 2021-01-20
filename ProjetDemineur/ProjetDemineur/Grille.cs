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


        public Grille()
        {

            longueur = 6;
            largeur = 6;
            Console.WriteLine("la grille est de taille "+longueur+"*"+largeur+ " ");

        }

    }
}
