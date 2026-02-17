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
            //Attributs de la clase CompteBancaire
            CompteBancaire compte = new CompteBancaire();
            //Attributs de la clase Etudiant
            Etudiant etudiant1 = new Etudiant("Alice", 20, 15);

            //Appel de la methode afficherinfo dans le programme principale
            personnel1.AfficherInfo();
            personnel2.AfficherInfo();
            //Appel des methode CalculerAire
            Console.WriteLine($"Aire : {rect1.CalculerAire()}");
            Console.WriteLine($"Périmetre : {rect1.CalculerPerimetre()}");

            //Opération sur la classe CompteBancaire
            compte.Deposer(500);
            compte.Retirer(200);
            compte.Retirer(400); // Solde insuffisant

            //Appel de la methode Afficherinfo
            etudiant1.AfficherInfos();

            // Test différents cas
            etudiant1.Moyenne = 18;   // OK
            etudiant1.AfficherInfos();

            etudiant1.Moyenne = 25;   // Erreur : trop élevé
            etudiant1.Moyenne = -3;   // Erreur : trop bas

            // Vérification finale
            etudiant1.AfficherInfos();


            Console.Read();
        }
    }
}    
   