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
                Console.WriteLine("Entrer la coordonnée X :");
                X = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Entrer la coordonnée Y :");
                Y = Convert.ToInt32(Console.ReadLine());
                g.TestCase(X,Y);
            }



        }
    }
}
