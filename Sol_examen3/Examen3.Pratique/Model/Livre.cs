using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Pratique.Model
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public string Isbn { get; set; }
        public int Annee { get; set; }
        public bool EstDisponible { get; set; }
    }
}
