using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal abstract class Cartes
    {
        protected string couleur;


        public Cartes(string couleur) 
        {
            this.couleur = couleur;
        }

        public abstract void Afficher();


    }
}
