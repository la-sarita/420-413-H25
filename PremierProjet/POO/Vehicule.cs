using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_heritage
{
    internal class Vehicule
    {
        public string Marque { get; set; }
        public double Vitesse { get; set; }
        public double Acceleration { get; set; }

        public Vehicule(string marque, double vitesse, double acceleration) {
            Marque = marque;
            Vitesse = vitesse;
            Acceleration = acceleration;
        }

        public Vehicule() : this("", 0, 0)
        {      
        }

        public void SetVitesse(double tempsAcceleration)
        {
            this.Vitesse += Acceleration * tempsAcceleration;
        }

        public override string ToString()
        {
            return $"Marque : {Marque}\nVitesse : {Vitesse}\nAcceleration : {Acceleration}\n";
        }
    }
}
