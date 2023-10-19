using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoBataille
{
    class Bataille
    {
        private DateOnly dateB;
        private string lieu;
        private int duree;
        private string gagnant;
        private List<Personnage> lesDefenseurs;
        private List<Personnage> lesAttaquants;

        // accesseurs
        public DateOnly DateB { get => dateB; set => dateB = value; }
        public string Lieu { get => lieu; set => lieu = value; }
        public int Duree { get => duree; set => duree = value; }
        public string Gagnant { get => gagnant; set => gagnant = value; }
        public List<Personnage> LesDefenseurs { get => lesDefenseurs; set => lesDefenseurs = value; }
        public List<Personnage> LesAttaquants { get => lesAttaquants; set => lesAttaquants = value; }

        // constructeurs
        public Bataille(DateOnly date, string lieu, int duree)
        {
            dateB = date;
            this.lieu = lieu;
            this.duree = duree;
            gagnant = "";
            lesDefenseurs = new List<Personnage>();
            lesAttaquants = new List<Personnage>();
        }

        public Bataille(string lieu, DateOnly date)
        {
            this.lieu = lieu;
            dateB = date;
            duree = 0;
            gagnant = "";
            lesDefenseurs = new List<Personnage>();
            lesAttaquants = new List<Personnage>();
        }

        // méthode RetourneValeurEquipe
        public int RetourneValeurEquipe(List<Personnage> perso)
        {
            int valeur = 0;
            foreach (Personnage p in perso)
            {
                valeur += p.Valeur;
                if (p.EstChef == false)
                {
                    valeur -= p.UneArme.getCout();
                }
            }
            return valeur;
        }

        // méthode RetourneNbPerte
        public int RetourneNbPerte(List<Personnage> perso)
        {
            int perte = 0;
            foreach(Personnage p in perso)
            {
                if (p.DateDC != null)
                {
                    perte++;
                }
            }
            return perte;
        }

        // méthode AjoutPerso
        public void AjoutPerso(List<Personnage> perso, int cod, string nom)
        {
            Personnage P1 = new Personnage(cod, nom);
            perso.Add(P1);
        }

        //méthode AjoutPerso
        public void AjoutPerso(List<Personnage> perso, int cod, string nom, int val)
        {
            Personnage P1 = new Personnage(cod, nom);
            P1.Valeur = val;
            perso.Add(P1);
        }

        // méthode DefinirChef
        public void DefinirChef(List<Personnage> perso, int cod, string nom, Arme arme)
        {
            foreach(Personnage p in perso)
            {
                if (p.CodeP == cod && p.NomP == nom)
                {
                    p.UneArme = arme;
                    p.EstChef = true;
                }
            }
        }

        // méthode DefinirGagnant
        public void DefinirGagnant()
        {
            //string gagnant = "";
            int attaquant;
            int defenseur;

            attaquant = RetourneValeurEquipe(lesAttaquants) / RetourneNbPerte(LesAttaquants);
            defenseur = RetourneValeurEquipe(lesDefenseurs) / RetourneNbPerte(LesDefenseurs);
            if (attaquant < defenseur)
            {
                gagnant = defenseur.ToString();
            }
            else if (attaquant > defenseur)
            {
                gagnant = attaquant.ToString();
            }
            else if (attaquant == defenseur)
            {
                gagnant = null;
            }
        }
    }
}
