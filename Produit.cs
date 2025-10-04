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

        public Produit()
        {
            _nom = null;
            _prix = 0;
        }

        public Produit(string nom, decimal prix)
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

        public override string ToString() {
            return _nom + " - "+ _prix + "$";
        }
    }
}
