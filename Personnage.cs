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
        private DateOnly? dateDC;
        private bool enBataille;
        private int valeur;
        private Arme uneArme;
        private bool estChef;

        // Accesseurs
        public int CodeP { get => codeP; set => codeP = value; }
        public string NomP { get => nomP; set => nomP = value; }
        public string Peuple { get => peuple; set => peuple = value; }
        public DateOnly? DateDC { get => dateDC; set => dateDC = value; }
        public bool EnBataille { get => enBataille; set => enBataille = value; }
        public int Valeur { get => valeur; set { if (value > 0) { valeur = value; } } }
        public Arme UneArme { get => uneArme; set => uneArme = value; }
        public bool EstChef { get => estChef; set => estChef = value; }


        // Constructeur
        public Personnage (int c, string nom)
        {
            codeP = c;
            nomP = nom;
            peuple = "";
            enBataille = false;
            valeur = 0;
            uneArme = null;
            estChef = false;
        }

        // méthode meurt
        public void meurt(DateOnly dateFin)
        {
            dateDC = dateFin;
            enBataille = false;
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
