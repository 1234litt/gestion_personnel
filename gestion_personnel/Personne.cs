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
        string Nom;
        int Age;
        //Constructeur de la classe Personne
        public Personne(string nom, int age)
        {
            Nom = nom;
            Age = age;
        }
        // Méthode AfficherInfo
        public void AfficherInfo()
        {
            Console.WriteLine($"Nom:{Nom}, Age:{Age}");

        }
    }
}
