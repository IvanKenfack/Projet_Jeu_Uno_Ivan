using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal class CartesNumeroté:Cartes
    {
        private int numero;

        public CartesNumeroté(string couleur, int numero)
            : base(couleur)
        {
            this.numero = numero;
        }


        public override void Afficher()
        {
            Console.WriteLine($"{numero}_{couleur}");
        }

    }
}
