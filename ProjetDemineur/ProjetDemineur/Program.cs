using System;

namespace ProjetDemineur
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool JeuxEnCour = true;
            int X;
            int Y;
            Grille g = new Grille();

            while (JeuxEnCour == true)
            {
                do
                {
                    Console.WriteLine("Entrer la coordonnée X :");
                    X = Convert.ToInt32(Console.ReadLine());
                } while ((X > g.getLong()-1)||(X<0));
                do
                {
                    Console.WriteLine("Entrer la coordonnée Y :");
                    Y = Convert.ToInt32(Console.ReadLine());
                } while ((Y > g.getLarg()-1) || (Y < 0));
                g.TestCase(X, Y);
            }



        }
    }
}
