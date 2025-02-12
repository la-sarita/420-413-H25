using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_heritage
{
    internal class Voiture : Vehicule
    {

        public int NbrPortes { get; set; }

        public Voiture(string marque, double vitesse, double acceleration, int nbrPortes)
            : base(marque, vitesse, acceleration)
        {
            this.NbrPortes = nbrPortes;
        }

        public override string ToString()
        {
            return base.ToString() + $"Nombre de portes : {NbrPortes}\n";
        }
    }
}
