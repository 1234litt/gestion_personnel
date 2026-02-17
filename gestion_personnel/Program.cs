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
            Personne personnel2 = new Personne("Michelle", 26);
            //Attributs de la classe rectangle
            Rectangle rect1 = new Rectangle(5, 6);
            //Attributs de la clase compte
            CompteBancaire compte = new CompteBancaire();

            //Appel de la methode afficherinfo dans le programme principale
            personnel1.AfficherInfo();
            personnel2.AfficherInfo();
            //Appel des methode CalculerAire
            Console.WriteLine($"Aire : {rect1.CalculerAire()}");
            Console.WriteLine($"Aire : {rect1.CalculerPerimetre()}");

            
            compte.Deposer(500);
            compte.Retirer(200);
            compte.Retirer(400); // Solde insuffisant
            

            Console.Read();
        }
    }
}    
   