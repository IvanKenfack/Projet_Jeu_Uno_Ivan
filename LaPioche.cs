using Projet_de_POO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class LaPioche
    {
        public List<Cartes> toutesLesCartes ;

        public LaPioche()
        {
            toutesLesCartes = new List<Cartes>();

        }

        public void CreerToutesLesCarte()
        {
            string[] couleurs = { "Rouge", "Bleu", "Vert", "Jaune" };
            int[] numeros = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] roles = { "PasseTonTour", "+2", "Inversion", "+4", "Joker" };
            foreach (string couleur in couleurs)
            {
                //Procedé de géneration des cartes numeroté: 0, (1 de chaque couleur)
                toutesLesCartes.Add(new CartesNumeroté(couleur, numeros[0]));

                // Procedé de géneration des cartes numeroté: de 1-9 (deux de chaque couleur)
                for (int i = 1; i < numeros.Length; i++) 
                {
                    toutesLesCartes.Add(new CartesNumeroté(couleur, numeros[i]));
                    toutesLesCartes.Add(new CartesNumeroté(couleur, numeros[i]));
                }

                //Procedé de géneration des cartes spéciaux

                toutesLesCartes.Add(new PasseTonTour(couleur, roles[0]));
                toutesLesCartes.Add(new PasseTonTour(couleur, roles[0]));


                toutesLesCartes.Add(new CartePlus2(couleur, roles[1]));
                toutesLesCartes.Add(new CartePlus2(couleur, roles[1]));

                toutesLesCartes.Add(new CarteInversion(couleur, roles[2]));
                toutesLesCartes.Add(new CarteInversion(couleur, roles[2]));

                toutesLesCartes.Add(new CartePlus4(couleur,roles[3]));
                toutesLesCartes.Add(new CarteJoker(couleur, roles[4]));


            }
        }

        public void MelangerCartes()
        {
            // Implementation de l'algorithme de Fisher-Yates pour mélanger les cartes de façon éfficace

            Random random = new Random();

            for (int i = 107; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (toutesLesCartes[i], toutesLesCartes[j]) = (toutesLesCartes[j], toutesLesCartes[i]); // Échange des cartes
            }
        }

        public void DistribuerCartes(List<Joueur> joueurs)
        {
            for (int i = 0; i < 7; i++) 
            {
                foreach (Joueur j in joueurs)
                {
                    if (toutesLesCartes.Count > 0)
                    {
                        j.PiocherCarte(toutesLesCartes[0]);
                        toutesLesCartes.RemoveAt(0);
                    }

                    else
                    {
                        Console.WriteLine("\nLa pioche est vide");
                        break;
                    }
                }
            }
        }


    }
}

