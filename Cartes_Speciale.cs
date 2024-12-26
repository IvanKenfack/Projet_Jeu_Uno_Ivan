using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_de_POO
{
    internal abstract class Cartes_Speciale : Cartes
    {
        protected string role;

        public Cartes_Speciale(string couleur,string role):
            base(couleur)
        {
            this.role = role;
        }

        public string Role
        {
            get
            {
                return this.role;
            }
        }
        public virtual void AppliquerEffet()
        {
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************************************************"
                );
        }
        
    }
}
