using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Terrain : Bien
    {
        public int NbCotesClotures;
        public bool Riviere;

        public Terrain(string adresse, float superficie, int nbCotesClotures, bool riviere) : base(adresse, superficie)
        {
            NbCotesClotures = nbCotesClotures;
            Riviere = riviere;
        }

        public override string ToString()
        {
            string toString = String.Format("Présence d'une rivière = {0}\n", this.Riviere ? "Oui" : "Non");
            toString += String.Format("> Nombre de côtés clos = {0}$\n", this.NbCotesClotures);
            toString += String.Format("> Coût finition clôture = {0}$\n", this.CoutFinirCloture());
            toString += String.Format("=> VALEUR = {0}$\n", this.EvaluationValeur());
            return toString;
        }

        public new float EvaluationValeur()
        {
            int facteur = 3000;

            if (this.Riviere) { facteur += 600; }

            facteur += 100 * this.NbCotesClotures;

            if (Regex.IsMatch(this.Adresse, @"\bParis\b")) { facteur += 7000; }
            else if (Regex.IsMatch(this.Adresse, @"\bLyon\b")) { facteur += 2000; }

            return this.Superficie * facteur;
        }

        public int CoutFinirCloture()
        {
            int prixCloture = 1000;
            int coutTotal = this.NbCotesClotures * prixCloture;
            return coutTotal;
        }
    }
}
