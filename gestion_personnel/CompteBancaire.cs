using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_personnel
{
    class CompteBancaire
    {
        private decimal Solde;

        //Constructeur
        public CompteBancaire(decimal solde = 0)
        {
            Solde = solde;
        }

        public decimal solde
        {
            get { return Solde; }
            set
            {
                if (value >= 0) Solde = value;
                else Console.WriteLine("Erreur: Le solde doit être positif");
            }
        }
        //Methode publique
        public void Deposer (decimal montant)
        {
            if(montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif !");
                return;
            }

            Solde += montant;
            Console.WriteLine($"Dépôt : {montant} , Solde : {Solde} ");
        }

        //Methode publique
        public void Retirer(decimal montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant du retrait doit être positif !");
                return;
            }

            if (montant > Solde)
            {
                Console.WriteLine("Solde insuffisant !");
                return;
            }
            Solde -= montant;
            Console.WriteLine($"Retrait : {montant} , Solde : {Solde} ");
        }
    }
}
