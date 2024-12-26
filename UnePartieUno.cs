using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class UnePartieUno
    {
        private Joueur gagnant;
        private int nbrJoueurs;
        private List<Joueur> senseJeu;
        private Joueur premierJoueur;
        private Joueur joueurActuel;
        private int indexJoueurActuel;
        private Joueur joueurSuivant;
        private Cartes derniereCarteJouer;
        private Cartes pioche;
        private List<Cartes> tas;
        private List<Cartes> pioche;



        // Le constructeur
        public UnePartieUno(int nbrJoueurs, Cartes derniereCarteJouer)
        {
            gagnant = null;
            joueurs = new List<Joueur>();
            premierJoueur = null;
            joueurSuivant = null;
            senseHoraire = true;
            this.nbrJoueurs = nbrJoueurs;
            this.derniereCarteJouer = derniereCarteJouer;
            tas = new List<Cartes>();
        }

        // Les accesseurs des attributs qui seront modifier au cour du jeu

        public Joueur Gagnant 
        { 
            get 
            { 
                return gagnant; 
            }
            set
            {
                gagnant= value;
            }
        }

        public Joueur PremierJoueur
        {
            set
            {
                premierJoueur = value;
            }
        }

        public Joueur JoueurSuivant
        {
            set
            {
                joueurSuivant = value;
            }
        }

        public bool SenseJeu
        {
            set
            {
                senseHoraire = value;
            }
        }

        public List<Cartes> Tas
        {
            get
            {
                return tas;
            }
            set 
            {
                tas = value;
            }
        }

        // Definitions des methodes

        /*
        public void InitialisationPartie() 
        {

            senseHoraire=true;
        }*/

        public void DeterminerProchainJoueur()
        {
            if (derniereCarteJouer.GetType() is CarteInversion)
            {
                joueurSuivant = joueurs

            }
        }












    }
}
