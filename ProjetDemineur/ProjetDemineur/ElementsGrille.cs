using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    class ElementsGrille
    {

        protected int coordX;
        protected int coordY;

        public ElementsGrille()
        {

        }

        public virtual void afficher()
        {
            Console.Write(this);
        }

    }
}
