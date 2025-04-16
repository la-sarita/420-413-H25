using System;
using System.Linq;

namespace examen3.theorique
{
    public class Auteur
    {
        public int Id { get; set; }
        public string Nom { get; set; }
    }

    public class Livre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Isbn { get; set; }
        public int Annee { get; set; }
        public Auteur Auteur { get; set; }
        public bool Disponible { get; set; }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var livres = new List<Livre>
            {
                new Livre { Titre = "Clean Code", Auteur = new Auteur (){ Nom="Camun" }, Isbn = "978-0132350884", Annee = 2008, Disponible = true },
                new Livre { Titre = "Clean Architecture", Auteur = new Auteur (){ Nom = "Robert C. Camun" }, Isbn = "978-0134494166", Annee = 2017, Disponible = false },
                new Livre { Titre = "The Pragmatic Programmer", Auteur = new Auteur (){ Nom = "Andrew Hunt" }, Isbn = "978-0135957059", Annee = 1999, Disponible = true },
                new Livre { Titre = "Eloquent JavaScript", Auteur = new Auteur (){ Nom = "Marijn Haverbeke" }, Isbn = "978-1593279509", Annee = 2018, Disponible = true },
                new Livre { Titre = "The Art of Computer Programming", Auteur = new Auteur (){ Nom = "Donald Knuth" }, Isbn = "978-0201896830", Annee = 1968, Disponible = false },
                new Livre { Titre = "C# in Depth", Auteur = new Auteur (){ Nom = "Jon Skeet" }, Isbn = "978-1617294532", Annee = 2019, Disponible = true },
                new Livre { Titre = "Design Patterns", Auteur = new Auteur (){ Nom = "Erich Gamma" }, Isbn = "978-0201633610",  Annee = 1994, Disponible = true },
                new Livre { Titre = "Refactoring", Auteur = new Auteur (){ Nom = "Camun" }, Isbn = "978-0201485677", Annee = 1999, Disponible = false },
                new Livre { Titre = "Introduction to Algorithms", Auteur = new Auteur (){ Nom = "Thomas H. Cormen" }, Isbn = "978-0262033848", Annee = 2009, Disponible = true },
                new Livre { Titre = "Domain-Driven Design", Auteur = new Auteur (){ Nom = "Eric Evans" }, Isbn = "978-0321125217", Annee = 2003, Disponible = true }
            };

            var livresCamun = livres.Where(Livre => Livre.Auteur.Nom.Equals("Camun")).ToList();
            Console.WriteLine(livresCamun.First().Auteur.Nom);

            var livresCamun2 = from livre in livres
                              where livre.Auteur.Nom.Equals("Camun")
                              select livre;
        }
    }

}


