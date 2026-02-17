using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class Voiture
    {
        private string marque;
        private int vitesse;
        int demarree = 0;

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public int Vitesse
        {
            get { return vitesse; }
            private set
            {
                if (value < 0) vitesse = 0;
                else vitesse = value;
            }
        }

        // Constructeur
        public Voiture(string marque)
        {
            Marque = marque;
            Vitesse = 0;
            demarree = 0;
        }

        public void Demarrer()
        {
            demarree = 1;
            Console.WriteLine("La voiture démarre");
        }

        // Méthode pour accélérer
        public void Accelerer(int increment)
        {
            if (demarree == 1)
            {
                Vitesse += increment;
                Console.WriteLine($"La voiture accélère de {increment} km/h. Vitesse actuelle : {Vitesse} km/h");
            }
            else
            {
                Console.WriteLine("Impossible d'accélérer : la voiture n'a pas démarré !");
            }
        }

        // Méthode pour freiner
        public void Freiner(int decrement)
        {
            Vitesse -= decrement;
            Console.WriteLine($"La voiture freine de {decrement} km/h. Vitesse actuelle : {Vitesse} km/h");
        }
    }

}

