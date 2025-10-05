using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeProduits
{
    internal class Produit
    {
        private string _nom;
        private decimal _prix;
        private static int _compteur = 0;

        public Produit()
        {
            _nom = null;
            _prix = 0;
            _compteur++;
        }

        public Produit(string nom, decimal prix):this()
        {
            _nom = nom;
            _prix = prix;
        }

        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public decimal prix
        {
            get { return _prix; }
            set { _prix = value; }
        }

        public static int Compteur
        {
            get { return _compteur; }
        }

        public static void DecrementerCompteur()
        {
            if (_compteur > 0) { 
                _compteur--;
            }
        }

        public static void ReinitialiserCompteur()
        {
            _compteur = 0;
        }

        public override string ToString() {
            return _nom;
        }
    }
}
