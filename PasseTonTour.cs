using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class PasseTonTour:Cartes_Speciale
    {
        public PasseTonTour(string couleur, string role)
        :base(couleur,role)
        {
        }

        public override void Afficher()
        {
            Console.WriteLine($"{role}_{couleur}");
        }

        public override void AppliquerEffet()
        {
            throw new NotImplementedException();
        }

    }
}
