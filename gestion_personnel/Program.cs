using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne personnel1 = new Personne("Paola", 25);
            Personne personnel2 = new Personne("Michelle", -6);

            //Appel de la methode afficherinfo dans le programme principale
            personnel1.AfficherInfo();
            personnel2.AfficherInfo();

            Console.Read();
        }
    }
}
