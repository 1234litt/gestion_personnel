using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class Personne
    {
        //Attributs de la classe personne
        private string nom;
        private int age;

        //getter et setter
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int Age
        {
            get { return Age; }
            set
            {
                if (value >= 0) age = value;
                else Console.WriteLine("Erreur: L'âge doit être positif");
                
            }
        }
        //Constructeur de la classe Personne
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }
        // Méthode AfficherInfo
        public void AfficherInfo()
        {
            Console.WriteLine($"Nom:{nom}, Age:{age}");

        }
    }
}
