using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBataille
{
    public class Personnage
    {
        // propiétés
        private int codeP;
        private string nomP;
        private string peuple;
        private DateOnly dateDC;
        private Boolean enBataille;
        private int valeur;
        private Arme uneArme;

        // Accesseurs
        public int CodeP { get => codeP; set => codeP = value; }
        public string NomP { get => nomP; set => nomP = value; }
        public string Peuple { get => peuple; set => peuple = value; }
        public DateOnly DateDC { get => dateDC; set => dateDC = value; }
        public bool EnBataille { get => enBataille; set => enBataille = value; }
        public int Valeur { get => valeur; set { if (value > 0) { valeur = value; } } }


        // Constructeur
        public Personnage (int c, string nom)
        {
            codeP = c;
            nomP = nom;
            this.peuple = "";
            this.dateDC = new DateOnly();
            this.valeur = 0;
            Arme uneArme = null;
        }

        // méthode meurt
        public void meurt(DateOnly dateFin)
        {
            dateDC = dateFin;
            this.enBataille = false;
        }

        // méthode change pour nomPeuple
        public void change(string nouvNomPeuple)
        {
            peuple = nouvNomPeuple;
        }

        // méthode change pour valeur
        private void change(int nouvValeur)
        {
            valeur = nouvValeur;
        }
    }
}
