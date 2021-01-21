using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class Mine : ElementsGrille
    {
        private char apparenceCase = '*';

        public Mine()
        {
            afficherMine();
        }

        public void afficherMine()
        {
            Console.Write(apparenceCase);
        }
    }
}
