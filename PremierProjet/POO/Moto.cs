using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_heritage
{
    internal class Moto : Vehicule
    {
        public double longestWheele {  get; set; }

        public Moto(string marque, double vitesse, double acceleration, double longestWheele)
        : base(marque, vitesse, acceleration)
        {
            this.longestWheele = longestWheele;
        }

        public override string ToString()
        {
            return base.ToString() + $"longest Wheele : {longestWheele}\n";
        }
    }
}
