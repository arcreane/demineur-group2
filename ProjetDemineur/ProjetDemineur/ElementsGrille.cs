using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    public class ElementsGrille
    {

        protected int coordX;
        protected int coordY;
        public string apparenceCase { get; protected set; }

        public ElementsGrille()
        {

        }

        public virtual void afficher()
        {
            Console.Write(this);
        }

        public virtual void Minedetecter()
        {
        }

        public virtual void decouvreCase() 
        { 
        
        }
    }
}
