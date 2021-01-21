using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Mine : ElementsGrille
    {
        private char apparenceMine = 'O';

        public Mine()
        {
           
        }

        public override void afficher()
        {
            Console.Write(apparenceMine);
        }
    }
}
