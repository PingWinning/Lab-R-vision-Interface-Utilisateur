using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeProduits
{
    public partial class Form1 : Form
    {
        private BindingList<Produit> listeProduits = new BindingList<Produit>();
        
        public Form1()
        {
            InitializeComponent();
            btnSupprimer.Enabled = false;
            btnEffacer.Enabled = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtBoxNom.Select();
            numPrix.DecimalPlaces = 2;
            numPrix.Maximum = decimal.MaxValue;
        }

        private void MettreAJourBoutons()
        {
            if (listBoxProduits.Items.Count > 0) 
            {
                btnSupprimer.Enabled = true;
                btnEffacer.Enabled = true;
            }
            else
            {
                btnSupprimer.Enabled = false;
                btnEffacer.Enabled = false;
            }
        }
        private void listBoxProduits_SelectedIndexChanged(object sender, EventArgs e)
        {
            MettreAJourBoutons();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string nomProd = txtBoxNom.Text;
            decimal prixProd = Math.Round(numPrix.Value, 2);

            Produit produit = new Produit(nomProd, prixProd);
            listBoxProduits.Items.Add(produit);
            numNbProduits.Value = Produit.Compteur;
            MettreAJourBoutons();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            listBoxProduits.Items.Clear();
            MettreAJourBoutons();
            Produit.ReinitialiserCompteur();
            numNbProduits.Value = Produit.Compteur;
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            listBoxProduits.Items.Remove(listBoxProduits.SelectedItem);
            Produit.DecrementerCompteur();
            numNbProduits.Value = Produit.Compteur;
            MettreAJourBoutons();
        }
    }
}
