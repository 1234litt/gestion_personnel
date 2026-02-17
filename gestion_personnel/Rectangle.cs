using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class Rectangle
    {
        private double Largeur;
        private double Hauteur;

        public Rectangle(double largeur, double hauteur)
        {
            Largeur = largeur;
            Hauteur = hauteur;
        }

        //Methode publique
        public double CalculerAire()
        {
            return Largeur * Hauteur;
        }
        public double CalculerPerimetre()
        {
            return 2 * (Largeur + Hauteur);
        }
    }
}
    

        








