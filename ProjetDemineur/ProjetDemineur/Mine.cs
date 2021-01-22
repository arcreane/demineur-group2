using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetDemineur
{
    public class Mine : ElementsGrille
    {

        public Mine(int p_X, int p_Y)
        {
            coordX = p_X;
            coordY = p_Y;
            apparenceCase = "O";
            //Console.WriteLine($"Mine x: {coordX} y: {coordY}");
        }

        public override void afficher()
        {
            Console.Write(apparenceCase);
        }
        public override void decouvreCase()
        {
            GameOver();
        }

        private void GameOver()
        {
            apparenceCase = "*";
            Console.WriteLine("perdu");
            
        }

        public override void Minedetecter()
        {
            base.Minedetecter();
        }
    }
}
