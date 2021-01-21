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


        public Case()
        {
            
        }

        public override void afficher()
        {
            Console.Write(apparenceCase);
            
        }

    }
}
