using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class CarteInversion:Cartes_Speciale
    {
        public CarteInversion(string couleur, string role)
      : base(couleur, role)
        {
        }

        public override void Afficher(UnePartieUno partie)
        {
            Console.WriteLine($"{role}_{couleur}");
        }

        public override void AppliquerEffet()
        {
            Console.WriteLine("Effet: Inversion du sens du jeu!");

            List<Joueur> joueursInverses = new List<Joueur>();


            for (int i = jeu.SensDuJeu.Count - 1; i >= 0; i--)
            {
                joueursInverses.Add(jeu.SensDuJeu[i]);
            }

            jeu.SensDuJeu = joueursInverses;

            Console.WriteLine("Le nouveau sens des joueurs est : ");
            foreach (var joueur in jeu.SensDuJeu)
            {
                Console.Write(joueur.nom + " ");
            }
            Console.WriteLine();
        }

    }
}
}
