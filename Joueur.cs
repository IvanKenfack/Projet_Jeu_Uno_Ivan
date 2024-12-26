using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class Joueur
    {
        private string nom;
        private List<Cartes> mesCartes;

        public Joueur(string nom) 
        {
            this.nom = nom;
            mesCartes = new List<Cartes>();
        }

        /*
        public List<Cartes> MesCartes
        {
            set 
            {
                for(int i = 1; i<= mesCartes.Count; i++)
                {
                    mesCartes
                }
            }
        }*/

        public void AfficherMesCartes()
        {
            for (int i = 0; i < mesCartes.Count; i++)
            {
                Console.Write("...");
                Console.Write(mesCartes[i]);
            }
        }

        public void AjouterCarte(Cartes cartes)
        {
            mesCartes.Add(cartes);
        }

        public void PiocherCarte(Cartes c)
        {
           this.mesCartes.Add(c);
        }

        public void Jouer(Cartes cartes)
        {
            throw new NotImplementedException();
        }

        public void AnnoncerUno()
        {
            if (mesCartes.Count == 1)
            {
                Console.WriteLine($"{this.nom} annonce Uno");
            }
        }


    }
}
