using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class Etudiant
    {
        private string nom;
        private int age;
        private float moyenne;

        //Propriétés publiques de l'attribut nom
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        //Propriétés publiques de l'attribut age
        public int Age
        {
            get { return age; }
            set 
            { if (value > 0) age = value; 
              else throw new ArgumentException("L'âge doit être positif !"); 
            }
        }
        //Propriétés publiques de l'attribut moyenne
        public float Moyenne
        {
            get { return moyenne; }
            set
            {
                if (value >= 0 && value <= 20)
                    moyenne = value;
                else
                    Console.WriteLine("Erreur : la moyenne doit être comprise entre 0 et 20 !");
            }   
        }
        //constructeur
        public Etudiant(string nom, int age, float moyenne)
        {
            Nom = nom;
            Age = age;
            Moyenne = moyenne;
        }

        public void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom}, Age : {Age}, Moyenne : {Moyenne}");
        }

    }
}
